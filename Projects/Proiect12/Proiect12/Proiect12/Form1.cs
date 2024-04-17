using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proiect12
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        private Random rnd;

        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;

            timer =  new System.Windows.Forms.Timer();
            timer.Interval = 200; 
            timer.Tick += Timer_Tick;
            timer.Start();

            rnd = new Random();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        //am modificat, adauga 10 cercuri cu raza random, dupa un timp se sterg, si se adauga altele

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                int radius = rnd.Next(50) + 50;
                int x = rnd.Next(ClientSize.Width - radius);
                int y = rnd.Next(ClientSize.Height - radius);
                Color color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

                using (Pen pen = new Pen(color, 2))
                {
                    e.Graphics.DrawEllipse(pen, x, y, radius, radius);
                }
            }

            for (int i = 0; i < 10; i++)
            {
                int frequency = 300 + rnd.Next(1000);
                int duration = 150;

                Console.Beep(frequency, duration);
            }
        }
    }
}

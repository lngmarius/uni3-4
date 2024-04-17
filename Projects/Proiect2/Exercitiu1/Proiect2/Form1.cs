using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proiect2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                if (clickedButton.BackColor == Color.IndianRed)
                {
                    clickedButton.BackColor = Color.Yellow;
                }
                else
                {
                    clickedButton.BackColor = Color.IndianRed;
                }
            }
        }

   

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox1.Text = "";

            if (button1.BackColor == Color.Yellow)
                textBox1.Text += 'A';
            if (button2.BackColor == Color.Yellow)
                textBox1.Text += 'B';
            if (button3.BackColor == Color.Yellow)
                textBox1.Text += 'C';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

    }
}

using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Proiect6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contruieste_lista_Click(object sender, EventArgs e)
        {
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            imageList1.ImageSize = new System.Drawing.Size(60, 60);
            imageList1.Images.Clear();
            string[] gif_uri = Directory.GetFiles("C:\\Users\\lunge\\source\\repos\\lab6\\Proiect6\\Proiect6", "*.gif");

            foreach (string fisier_gif in gif_uri)
            {
                Bitmap desen = new Bitmap(fisier_gif);
                imageList1.Images.Add(desen);
                pictureBox1.Image = desen;
            }
            Graphics g = this.CreateGraphics();
            for (int i = 0; i < imageList1.Images.Count; i++)
                imageList1.Draw(g, 60 + i * 60, 60, i);
            g.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contruieste_lista_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayImages(); 
        }

        private int currentImageIndex = 0;

        private void DisplayImages()
        {
            if (imageList1.Images.Count == 0)
            {
                MessageBox.Show("Nu au fost gasite imagini.");
                return;
            }

            string[] gif_uri = Directory.GetFiles("C:\\Users\\lunge\\source\\repos\\lab6\\Proiect6\\Proiect6", "*.gif");

            foreach (string fisier_gif in gif_uri)
            {
                var result = MessageBox.Show("Urmatorul? " + (currentImageIndex + 1) + "/" + imageList1.Images.Count, "Image Viewer", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    currentImageIndex++;
                    if (currentImageIndex >= imageList1.Images.Count)
                        currentImageIndex = 0;

                    Bitmap desen = new Bitmap(fisier_gif);

                    pictureBox1.Image = desen;
                }
                if (result == DialogResult.No)
                {
                    this.Close();
                }

            }
        }
    }
}

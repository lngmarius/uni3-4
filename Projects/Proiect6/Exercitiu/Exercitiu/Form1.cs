using System;
using System.IO;
using System.Windows.Forms;

namespace Exercitiu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(Environment.CurrentDirectory);

            foreach (string file in files)
            {
                if (IsImageFile(file))
                {
                    //un panou va contine imaginea si numele lui
                    Panel panel = new Panel();
                    panel.Width = 100;
                    panel.Height = 140;

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = new System.Drawing.Bitmap(file);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Dock = DockStyle.Top;
                    pictureBox.Height = 100;
                    panel.Controls.Add(pictureBox);

                    Label fileNameLabel = new Label();
                    fileNameLabel.Text = Path.GetFileName(file);
                    fileNameLabel.TextAlign = ContentAlignment.MiddleCenter;
                    fileNameLabel.Dock = DockStyle.Bottom;
                    panel.Controls.Add(fileNameLabel);

                    flowLayoutPanel1.Controls.Add(panel);
                }
            }
        }



        // Funcție pentru a verifica dacă un fișier este o imagine
        private bool IsImageFile(string path)
        {
            string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
            string extension = Path.GetExtension(path).ToLower();
            return Array.Exists(imageExtensions, ext => ext == extension);
        }
    }
}

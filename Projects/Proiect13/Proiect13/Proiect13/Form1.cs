using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proiect13
{
    public partial class Form1 : Form
    {
        Image thumbnail;
        ErrorProvider myErrorProvider;

        public Form1()
        {
            InitializeComponent();
            myErrorProvider = new ErrorProvider();

            this.Load += Thumbnails_Load;
            this.Paint += Form1_Paint;
            this.textBox1.KeyDown += textBox1_KeyUp;
            this.button1.Click += btnValidate_Click;
            this.textBox1.Leave += txtName_Leave;
        }

        private void Thumbnails_Load(object sender, EventArgs e)
        {
            try
            {
                Image img = Image.FromFile("C:\\Users\\lunge\\source\\repos\\lab13\\Proiect13\\Proiect13\\imagine.png");
                int latime = 100, inaltime = 100;
                thumbnail = img.GetThumbnailImage(latime, inaltime, null, IntPtr.Zero);
                this.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Thumbnails_Paint(sender, e);
        }

        private void Thumbnails_Paint(object sender, PaintEventArgs e)
        {
            if (thumbnail != null)
            {
                e.Graphics.DrawImage(thumbnail, 10, 10);
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Alt)
                MessageBox.Show("Tasta Alt e apasata");
            if (char.IsDigit((char)e.KeyCode))
                MessageBox.Show("Ati apasat o cifra");
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox && string.IsNullOrEmpty(ctrl.Text))
                {
                    myErrorProvider.SetError(ctrl, "Acest camp este obligatoriu!");
                    ctrl.Focus();
                    return;
                }
                else
                {
                    myErrorProvider.SetError(ctrl, "");
                }
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Contains(" "))
            {
                myErrorProvider.SetError(textBox, "Numele nu trebuie sa contina spatii!");
            }
            else
            {
                myErrorProvider.SetError(textBox, "");
            }
        }
    }
}
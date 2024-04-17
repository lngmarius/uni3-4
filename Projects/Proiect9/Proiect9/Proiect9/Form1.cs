using System.Windows.Forms;

namespace Proiect9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void ApplyFont(object sender, EventArgs e)
        {

        }

        private bool am_apasat = false;
        private Point forma_deplasata;

        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            am_apasat = true;
            forma_deplasata = new Point(e.X, e.Y);
            toolStrip1.Capture = true;
        }

        private void toolStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            am_apasat = false;
            toolStrip1.Capture = false;
        }

        private void toolStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (am_apasat)
            {
                if (toolStrip1.Dock == DockStyle.Top || toolStrip1.Dock == DockStyle.Left)
                {
                    if (forma_deplasata.X < (e.X - 20) || forma_deplasata.Y < (e.Y - 20))
                    {
                        am_apasat = false;
                        toolStrip1.Dock = DockStyle.None;
                        toolStrip1.Location = new Point(10, 10);
                        toolStrip1.Size = new Size(200, 45);
                    }
                }
                else if (toolStrip1.Dock == DockStyle.None)
                {
                    toolStrip1.Left = e.X + toolStrip1.Left - forma_deplasata.X;
                    toolStrip1.Top = e.Y + toolStrip1.Top - forma_deplasata.Y;
                    if (toolStrip1.Top < 5 || toolStrip1.Top > this.ClientSize.Height - 20)
                    {
                        am_apasat = false;
                        toolStrip1.Dock = DockStyle.Top;
                    }
                    else if (toolStrip1.Left < 5 || toolStrip1.Left > this.ClientSize.Width - 20)
                    {
                        am_apasat = false;
                        toolStrip1.Dock = DockStyle.Left;
                    }
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowColor = true;
            fd.Color = Color.IndianRed;
            fd.ShowApply = true;
            fd.Apply += new EventHandler(ApplyFont);
            if (fd.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                this.richTextBox1.Font = fd.Font;
                this.richTextBox1.ForeColor = fd.Color;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = true;
            cd.Color = Color.DarkBlue;
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                this.richTextBox1.ForeColor = cd.Color;
        }
    }
}

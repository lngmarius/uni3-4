using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace Proiect11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void asdToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void asdToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Text Files (*.txt)|*.txt";
            of.Title = "Fisiere Text";
            if (of.ShowDialog() == DialogResult.Cancel) return;
            richTextBox1.Text = ""; richTextBox1.Visible = true;
            FileStream strm;
            try
            {
                strm = new FileStream(of.FileName, FileMode.Open, FileAccess.Read);
                StreamReader rdr = new StreamReader(strm);
                while (rdr.Peek() >= 0)
                {
                    string str = rdr.ReadLine();
                    richTextBox1.Text = richTextBox1.Text + " " + str;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error opening file", "File Error",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void asdToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog.Color;
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font defaultFont = SystemFonts.DefaultFont;
            Color defaultForeColor = SystemColors.WindowText;
            richTextBox1.ForeColor = defaultForeColor;
            richTextBox1.Font = defaultFont;

        }

        private void dinamicHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "http://msdn2.microsoft.com/en-us/default.aspx",
                UseShellExecute = true
            });
        }

        private void aboutPVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox1.Text = "informatii foarte interesante si detaliate";

        }
    }
}

using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;




//am adaugat save (odata ce e salvat, nu mai cere calea),
//save as (mai multe extensii) si se schimba numele formularului in functie de ce fisier deschid/salvez




namespace Proiect11
{
    public partial class Form1 : Form
    {
        private string currentFilePath = "";

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
            of.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
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
                currentFilePath = of.FileName; 
                UpdateFormTitle();
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare la deschiderea fisierului", "File Error",
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


        private void SaveFile(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(richTextBox1.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la salvarea fisierului: {ex.Message}", "File Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveAs()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Text Files (*.txt)|*.txt|Python Files (*.py)|*.py|" +
                                    "C# Files (*.cs)|*.cs|" +
                                    "JavaScript Files (*.js)|*.js|" +
                                    "HTML Files (*.html;*.htm)|*.html;*.htm|" +
                                    "Java Files (*.java)|*.java|" +
                                    "All Files (*.*)|*.*";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                SaveFile(saveDialog.FileName);
                currentFilePath = saveDialog.FileName;
                UpdateFormTitle();
            }
        }

        private void UpdateFormTitle()
        {
            string fileName = currentFilePath != "" ? Path.GetFileName(currentFilePath) : "Untitled";
            this.Text = $"{fileName} - Text Editor";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                SaveAs();
            }
            else
            {
                SaveFile(currentFilePath);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }
    }
}

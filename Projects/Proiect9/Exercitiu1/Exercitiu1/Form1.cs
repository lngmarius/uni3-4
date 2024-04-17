using System;
using System.Windows.Forms;

namespace Exercitiu1
{
    public partial class Form1 : Form
    {
        private RichTextBox richTextBox;
        private ToolStrip toolStrip;

        public Form1()
        {
            Text = "Text Editor";
            Size = new System.Drawing.Size(600, 400);
            InitializeTextEditor();
            InitializeToolStrip();
        }

        private void InitializeTextEditor()
        {
            richTextBox = new RichTextBox();
            richTextBox.Dock = DockStyle.Fill;
            Controls.Add(richTextBox);
        }

        private void InitializeToolStrip()
        {
            toolStrip = new ToolStrip();
            toolStrip.Dock = DockStyle.Top;

            toolStrip.Items.Add(new ToolStripButton("Deschide", null, OpenFile));
            toolStrip.Items.Add(new ToolStripButton("Salveaza", null, SaveFile));
            toolStrip.Items.Add(new ToolStripSeparator());
            toolStrip.Items.Add(new ToolStripButton("Copiaza", null, CopyText));
            toolStrip.Items.Add(new ToolStripButton("Lipeste", null, PasteText));
            toolStrip.Items.Add(new ToolStripSeparator());

            toolStrip.Items.Add(new ToolStripButton("Selectare Font", null, SelectFont));

            Controls.Add(toolStrip);
        }

        private void SelectFont(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowColor = true;
            fd.Color = Color.IndianRed;
            fd.ShowApply = true;
            fd.Apply += new EventHandler(ApplyFont);

            if (fd.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox.SelectionFont = fd.Font;
                richTextBox.SelectionColor = fd.Color;
            }

            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = true;
            cd.Color = Color.DarkBlue;

            if (cd.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SelectionColor = cd.Color;
            }
        }

        private void ApplyFont(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = ((FontDialog)sender).Font;
        }


        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void SaveFile(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void CopyText(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox.SelectedText))
                Clipboard.SetText(richTextBox.SelectedText);
        }

        private void PasteText(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

     
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Exercitiu
{
    public partial class Form1 : Form
    {
        private string selectedFolderPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();

                if (checkedListBox2.SelectedIndex != -1)
                {
                    string selectedExtension = checkedListBox2.SelectedItem.ToString();
                    string[] files = Directory.GetFiles(selectedFolderPath);
                    foreach (string file in files)
                    {
                        if (Path.GetExtension(file).Equals(selectedExtension, StringComparison.OrdinalIgnoreCase))
                        {
                            listBox1.Items.Add(Path.GetFileName(file));
                        }
                    }

                    if (listBox1.Items.Count == 0)
                    {
                        MessageBox.Show($"N-au fost gasite fisiere cu extensia {selectedExtension} in director", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Alege o extensie din lista.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayFiles(string folderPath)
        {
            try
            {
                checkedListBox2.Items.Clear();
                HashSet<string> extensions = new HashSet<string>();
                string[] files = Directory.GetFiles(folderPath);
                selectedFolderPath = folderPath;
                foreach (string file in files)
                {
                    string extension = Path.GetExtension(file);
                    extensions.Add(extension);
                }

                foreach (string extension in extensions)
                {
                    checkedListBox2.Items.Add(extension);
                }

                if (checkedListBox2.Items.Count == 0)
                {
                    MessageBox.Show("Nu exista fisiere in director.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    checkedListBox2.Text = folderDialog.SelectedPath;
                    DisplayFiles(folderDialog.SelectedPath);
                }
            }
        }

        
    }
}

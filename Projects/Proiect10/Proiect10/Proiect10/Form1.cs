using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proiect10
{
    public partial class Form1 : Form
    {
        private ColorDialog selectedColorDialog;
        private string colorName;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            colorDialog.Color = Color.DarkBlue;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                selectedColorDialog = colorDialog;
                string colorName = GetColorName(selectedColorDialog.Color);
                MessageBox.Show(colorName);
            }
        }

        private string GetColorName(Color color)
        {
            KnownColor knownColor = color.ToKnownColor();
            if (knownColor != 0 && Enum.IsDefined(typeof(KnownColor), knownColor))
            {
                return knownColor.ToString();
            }
            else
            {
                string htmlColor = ColorTranslator.ToHtml(color);
                return htmlColor;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(varstaTextBox.Text) ||
                string.IsNullOrWhiteSpace(numeTextBox.Text) ||
                string.IsNullOrWhiteSpace(prenumeTextBox.Text) ||
                string.IsNullOrWhiteSpace(adresaTextBox.Text))
            {
                MessageBox.Show("Toate campurile trebuie completate.", "Eroare de validare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (selectedColorDialog == null)
            {
                MessageBox.Show("Selectati o culoare.", "Eroare de validare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (categorieComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Selectati un produs din lista.", "Eroare de validare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (!int.TryParse(varstaTextBox.Text, out int age) || age < 0 || age > 18)
            {
                MessageBox.Show("Varsta trebuie sa fie un numar intre 0 si 18.", "Eroare de validare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            string colorName = GetColorName(selectedColorDialog.Color);

            rezultatLabel.AutoSize = true;
            rezultatLabel.MaximumSize = new Size(groupBox1.Width - 20, 0); 

            rezultatLabel.Text = "Comanda: " + categorieComboBox.Text + " de culoare " +
                colorName + " pentru un copil de " + age +
                " va fi trimisa pe adresa " + numeTextBox.Text + " " + prenumeTextBox.Text +
                " " + adresaTextBox.Text;
        }

    }
}

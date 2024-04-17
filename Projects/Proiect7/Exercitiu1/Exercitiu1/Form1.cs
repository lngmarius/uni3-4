using System.Windows.Forms;

namespace Exercitiu1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c > '0' || c < '9')
                    return true;
            }
            return false;
        }

        bool IsLettersOnly(string str)
        {
            foreach (char c in str)
            {
                if (c > 'a' || c < 'Z')
                    return true;
            }
            return false;
        }

        private bool checkInfo() {
            if (textBox5.Text.Length == 10 && IsDigitsOnly(textBox5.Text) && IsLettersOnly(textBox4.Text) && textBox4.Text.Length > 8 && IsLettersOnly(textBox3.Text) && textBox3.Text.Length > 8 && textBox2.Text.Length>8)
                return true;
            else return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkInfo())
            {
                MessageBox.Show("Email generat: \n" +
                    "Nume: " + textBox3.Text + "\n" +
                    "Prenume: " + textBox4.Text + "\n" +
                    "Email: " + textBox1.Text + "\n" +
                    "Telefon: " + textBox5.Text + "\n" +
                    "Data nasterii: " + monthCalendar1.SelectionRange.Start.ToShortDateString() + "\n" +
                    "Nationalitate: " + comboBox1.Text + "\n");
            }
            else MessageBox.Show("Introdu toate valorile");
        }
    }
}

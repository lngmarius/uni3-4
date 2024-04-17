using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Proiect14
{

    public class Intrebare
    {
        public string Enunt { get; set; } 
        public string RaspunsCorect { get; set; } 
        public List<string> Distractori { get; set; } 
        public int Punctaj { get; set; } 
        public string Imagine { get; set; } 

        public Intrebare(string enunt, string raspunsCorect, List<string> distractori, int punctaj, string imagine)
        {
            Enunt = enunt;
            RaspunsCorect = raspunsCorect;
            Distractori = distractori;
            Punctaj = punctaj;
            Imagine = imagine;
        }
    }

    public partial class Form1 : Form
    {
        private List<Intrebare> intrebari;
        private int indexIntrebare = 0;
        private int totalPunctaj = 0;
        private List<string> raspunsuriDate = new List<string>();
        System.Windows.Forms.GroupBox groupBox1 = new System.Windows.Forms.GroupBox();
        private System.Windows.Forms.GroupBox groupBox2; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string fisierIntrebari = "intrebari.txt";
            intrebari = CitesteIntrebari(fisierIntrebari);
            DisplayIntrebare();
        }

        private List<Intrebare> CitesteIntrebari(string fisier)
        {
            List<Intrebare> intrebari = new List<Intrebare>();

            try
            {
                using (StreamReader sr = new StreamReader(fisier))
                {
                    while (!sr.EndOfStream)
                    {
                        string enunt = sr.ReadLine();
                        string raspunsCorect = sr.ReadLine();
                        int punctaj = int.Parse(sr.ReadLine());
                        string imagine = sr.ReadLine();
                        List<string> distractori = new List<string>();

                        string line;
                        while ((line = sr.ReadLine()) != "-----")
                        {
                            distractori.Add(line);
                        }

                        Intrebare intrebare = new Intrebare(enunt, raspunsCorect, distractori, punctaj, imagine);
                        intrebari.Add(intrebare);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la citirea întrebărilor: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return intrebari;
        }

        private void DisplayIntrebare()
        {
            PictureBox pictureBox = null;
            int groupBoxHeight = 0;

            if (indexIntrebare < intrebari.Count)
            {
                Intrebare intrebare = intrebari[indexIntrebare];

                // intrebarea
                Label labelIntrebare = new Label();
                labelIntrebare.Text = intrebare.Enunt;
                labelIntrebare.Location = new Point(20, 20);
                labelIntrebare.AutoSize = true;
                Controls.Add(labelIntrebare);
                ClearPreviousQuestion();

                // imaginea
                if (!string.IsNullOrEmpty(intrebare.Imagine))
                {
                    pictureBox = new PictureBox();
                    pictureBox.Image = Image.FromFile(intrebare.Imagine);
                    pictureBox.Location = new Point(20, labelIntrebare.Bottom + 10);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Width = 200;
                    pictureBox.Height = 150;
                    Controls.Add(pictureBox);
                }


                //groupBox pentru raspunsuri
                groupBox2 = new System.Windows.Forms.GroupBox();
                groupBox2.Location = new Point(20, (pictureBox != null) ? pictureBox.Bottom + 10 : labelIntrebare.Bottom + 10);
                groupBox2.Width = ClientSize.Width - 40;
                groupBox2.Height = 150;
                Controls.Add(groupBox2);

                int yOffset = 20;
                for (int i = 0; i < intrebare.Distractori.Count; i++)
                {
                    System.Windows.Forms.RadioButton radioButton = new System.Windows.Forms.RadioButton();
                    radioButton.Text = intrebare.Distractori[i];
                    radioButton.Location = new Point(20, yOffset);
                    radioButton.Width = groupBox2.Width - 40; 
                    groupBox2.Controls.Add(radioButton);

                    yOffset += radioButton.Height + 5;
                }

                groupBoxHeight = yOffset + 10;

               
                Button buttonNext = new Button();
                buttonNext.Text = "Următoarea întrebare";
                Size buttonSize = TextRenderer.MeasureText(buttonNext.Text, buttonNext.Font);
                buttonNext.Width = buttonSize.Width + 20; 
                buttonNext.Click += buttonNext_Click;
                buttonNext.Location = new Point(20, groupBox2.Bottom + 10);
                Controls.Add(buttonNext);


                int requiredHeight = buttonNext.Bottom + 10;
                if (requiredHeight > Height)
                    Height = requiredHeight;
            }
            else
            {
                groupBox1.Visible = false;

                MessageBox.Show($"Rezultat test:\nTotal punctaj obținut: {totalPunctaj}", "Rezultat test", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string summary = "Statistica răspunsurilor:\n";
                for (int i = 0; i < intrebari.Count; i++)
                {
                    summary += $"Întrebarea {i + 1}: Răspuns dat: {raspunsuriDate[i]}, Răspuns corect: {intrebari[i].RaspunsCorect}\n";
                }
                MessageBox.Show(summary, "Statistica răspunsurilor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }



        private void buttonNext_Click(object sender, EventArgs e)
        {
            // daca este selectat un buton
            var selectedRadioButton = groupBox2.Controls.OfType<System.Windows.Forms.RadioButton>().FirstOrDefault(r => r.Checked);
            if (selectedRadioButton != null)
            {
                raspunsuriDate.Add(selectedRadioButton.Text);

                // daca cel selectat este cel corect
                if (selectedRadioButton.Text == intrebari[indexIntrebare].RaspunsCorect)
                {
                    totalPunctaj += intrebari[indexIntrebare].Punctaj;
                }
                else
                {
                    MessageBox.Show("Răspuns greșit! Răspunsul corect este: " + intrebari[indexIntrebare].RaspunsCorect, "Incorect", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                indexIntrebare++;
                ClearPreviousQuestion();
                DisplayIntrebare();
            }
            else
            {
                MessageBox.Show("Selectați un răspuns înainte de a trece la următoarea întrebare.", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void ClearPreviousQuestion()
        {
            foreach (Control control in Controls)
            {
                if (control is PictureBox || control is Label || control is System.Windows.Forms.GroupBox || control.Text == "Următoarea întrebare")
                {
                    Controls.Remove(control);
                }
            }
        }


    }
}

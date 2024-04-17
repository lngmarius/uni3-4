namespace Exercitiu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int scor = 0;
            if (checkBox1.CheckState == CheckState.Checked
                && checkBox2.CheckState != CheckState.Checked
                && checkBox3.CheckState == CheckState.Checked
                && checkBox4.CheckState == CheckState.Checked
                )
            {
                scor += 2;
                checkBox1.ForeColor = System.Drawing.Color.Green;
                checkBox2.ForeColor = System.Drawing.Color.Red;
                checkBox3.ForeColor = System.Drawing.Color.Green;
                checkBox4.ForeColor = System.Drawing.Color.Green;

            }

            if (
            checkBox5.CheckState == CheckState.Checked
            && checkBox6.CheckState == CheckState.Checked
            && checkBox7.CheckState != CheckState.Checked
            && checkBox8.CheckState == CheckState.Checked
            )
            {
                scor += 2;
                checkBox5.ForeColor = System.Drawing.Color.Green;
                checkBox6.ForeColor = System.Drawing.Color.Green;
                checkBox7.ForeColor = System.Drawing.Color.Red;
                checkBox8.ForeColor = System.Drawing.Color.Green;

            }

            if (
           checkBox13.CheckState != CheckState.Checked
           && checkBox14.CheckState != CheckState.Checked
           && checkBox15.CheckState == CheckState.Checked
           && checkBox16.CheckState != CheckState.Checked
           )
            {
                scor += 2;

                checkBox13.ForeColor = System.Drawing.Color.Red;
                checkBox14.ForeColor = System.Drawing.Color.Red;
                checkBox15.ForeColor = System.Drawing.Color.Green;
                checkBox16.ForeColor = System.Drawing.Color.Red;
            }
            if (
           checkBox17.CheckState != CheckState.Checked
           && checkBox18.CheckState != CheckState.Checked
           && checkBox19.CheckState == CheckState.Checked
           && checkBox20.CheckState != CheckState.Checked
           )
            {
                scor += 2;
                checkBox17.ForeColor = System.Drawing.Color.Red;
                checkBox18.ForeColor = System.Drawing.Color.Red;
                checkBox19.ForeColor = System.Drawing.Color.Green;
                checkBox20.ForeColor = System.Drawing.Color.Red;

            }
            if (
           checkBox9.CheckState == CheckState.Checked
           && checkBox10.CheckState != CheckState.Checked
           && checkBox11.CheckState == CheckState.Checked
           && checkBox12.CheckState != CheckState.Checked
           )
            {
                scor += 2;
                checkBox9.ForeColor = System.Drawing.Color.Green;
                checkBox10.ForeColor = System.Drawing.Color.Red;
                checkBox11.ForeColor = System.Drawing.Color.Green;
                checkBox12.ForeColor = System.Drawing.Color.Red;

            }

            label6.Text = "Scor: " + scor;
            MessageBox.Show("1: Marte, Venus, Jupiter \n 2: Albastru, Verde, Galben \n 3: Lupta importiva infectiilor \n 4: Oxigen \n 5:Mar, Capsuna");
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }
    }
}

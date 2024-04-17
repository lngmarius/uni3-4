namespace Proiect2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (button1.BackColor == Color.IndianRed)
                    button1.BackColor = Color.Yellow;
                else
                    button1.BackColor = Color.IndianRed;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.IndianRed)
                button2.BackColor = Color.Yellow;
            else
                button2.BackColor = Color.IndianRed;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.IndianRed)
                button3.BackColor = Color.Yellow;
            else
                button3.BackColor = Color.IndianRed;
        }

        private void button4_MouseEnter(object sender, System.EventArgs e)
        {
            button4.BackColor = Color.YellowGreen;
            button4.Text = "Butoane apasate";
        }
        private void button4_MouseLeave(object sender, System.EventArgs e)
        {
            textBox1.Visible = false; button4.Text = "Starea butoanelor";
            button4.BackColor = Color.Orange;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true; textBox1.Text = "";
            if (button1.BackColor == Color.Yellow)
                textBox1.Text = textBox1.Text + 'A';
            if (button2.BackColor == Color.Yellow)
                textBox1.Text = textBox1.Text + 'B';
            if (button3.BackColor == Color.Yellow)
                textBox1.Text = textBox1.Text + 'C';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
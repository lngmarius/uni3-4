namespace Proiect1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        { MessageBox.Show(textBox1.Text); }


        private void button2_Click_1(object sender, EventArgs e)
        {
            { Form1.ActiveForm.Dispose(); }

        }
    }
}
namespace Proiect5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s = "Am selectat si am adaugat itemii: ";
            listBox1.Items.Clear();
            foreach (object c in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(c);
                s = s + c.ToString(); s = s + " ";
            }
            label1.Text = s;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

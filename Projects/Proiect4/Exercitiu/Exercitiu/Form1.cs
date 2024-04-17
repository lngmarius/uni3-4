namespace Exercitiu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("C:\\Program Files\\Mozilla Firefox\\firefox.exe",
            "https://edu.csed.ugal.ro/pluginfile.php/60756/mod_resource/content/9/Curs1.pdf");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("C:\\Program Files\\Mozilla Firefox\\firefox.exe",
            "https://edu.csed.ugal.ro/pluginfile.php/60759/mod_resource/content/8/Curs2.pdf");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel3.LinkVisited = true;
            System.Diagnostics.Process.Start("C:\\Program Files\\Mozilla Firefox\\firefox.exe",
            "https://edu.csed.ugal.ro/pluginfile.php/60762/mod_resource/content/5/Curs3.pdf");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel4.LinkVisited = true;
            System.Diagnostics.Process.Start("C:\\Program Files\\Mozilla Firefox\\firefox.exe",
            "https://edu.csed.ugal.ro/pluginfile.php/60765/mod_resource/content/5/Curs4.pdf");
        }
    }
}

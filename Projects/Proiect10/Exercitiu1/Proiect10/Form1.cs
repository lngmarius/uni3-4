using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing;

namespace Proiect10
{
    public partial class Form1 : Form
    {
        private List<Product> products = new List<Product>();
        private List<Product> shoppingCart = new List<Product>();

        public Form1()
        {
            InitializeComponent();
            InitProducts();
            DisplayProducts();
        }

        private void InitProducts()
        {
            string directory = @"C:\Users\lunge\source\repos\lab10\Exercitiu1\Proiect10\Properties\";

            Random rand = new Random();

            for (int i = 1; i <= 9; i++)
            {
                string imagePath = Path.Combine(directory, $"model{i}.png");
                Image image = Image.FromFile(imagePath);

                int price = rand.Next(1, 101);

                products.Add(new Product($"Covor emoticon {i}", $"Pret: {price} Lei", image));
            }
        }


        private void DisplayProducts()
        {
            foreach (Product product in products)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = product.Image;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Width = 100;
                pictureBox.Height = 100;
                pictureBox.Margin = new Padding(10);

                CheckBox checkBox = new CheckBox();
                checkBox.AutoSize = true;

                Label nameLabel = new Label();
                nameLabel.Text = product.Name;
                nameLabel.AutoSize = true;

                Label descriptionLabel = new Label();
                descriptionLabel.Text = product.Description;
                descriptionLabel.AutoSize = true;

                pictureBox.Click += (sender, e) =>
                {
                    shoppingCart.Add(product);
                    DisplayShoppingCart();
                };

                tabPage1.Controls.Add(pictureBox);
                tabPage1.Controls.Add(checkBox);
                tabPage1.Controls.Add(nameLabel);
                tabPage1.Controls.Add(descriptionLabel);

                int index = products.IndexOf(product);
                int x = (index % 3) * 250 + 20;
                int y = (index / 3) * 150 + 20;
                pictureBox.Location = new Point(x, y);
                checkBox.Location = new Point(x + 100, y + 100);
                nameLabel.Location = new Point(x, y + 120);
                descriptionLabel.Location = new Point(x, y + 140);

                checkBox.CheckedChanged += (sender, e) =>
                {
                    if (checkBox.Checked)
                    {
                        shoppingCart.Add(product);
                    }
                    else
                    {
                        shoppingCart.Remove(product);
                    }
                    DisplayShoppingCart();
                };
            }
        }


        private void DisplayShoppingCart()
        {
            tabPage3.Controls.Clear();

            int yPos = 10;
            foreach (Product product in shoppingCart)
            {
                Label labelProduct = new Label();
                labelProduct.Text = product.Name + ": " + product.Description;
                labelProduct.AutoSize = true;
                labelProduct.Margin = new Padding(0, 5, 0, 0);
                labelProduct.Location = new Point(10, yPos);
                tabPage3.Controls.Add(labelProduct);

                yPos += labelProduct.Height + 5;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string nume = numeTextBox.Text.Trim();
            string prenume = prenumeTextBox.Text.Trim();
            string adresa = adresaTextBox.Text.Trim();

            if (string.IsNullOrEmpty(nume) || string.IsNullOrEmpty(prenume) || string.IsNullOrEmpty(adresa))
            {
                MessageBox.Show("Introduceti informatiile personale.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (shoppingCart.Count == 0)
            {
                MessageBox.Show("Selectati cel putin un produs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            label1.AutoSize = true;
            label1.Text = $"Cumparaturi facute de: {nume} {prenume} la adresa: {adresa}\n";

            double pretTotal = 0.0; 

            foreach (Product product in shoppingCart)
            {
                label1.Text += $"{product.Name}: {product.Description}\n";
                string[] parts = product.Description.Split(':');
                if (parts.Length >= 2)
                {
                    string priceString = parts[1].Trim().Split(' ')[0]; 
                    if (double.TryParse(priceString, out double price))
                    {
                        pretTotal += price; 
                    }
                    else
                    {
                        MessageBox.Show($"Formatul descrierii pentru produsul '{product.Name}' nu este valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show($"Formatul descrierii pentru produsul '{product.Name}' nu este valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            label1.Text += $"\nPret total: {pretTotal} Lei";
        }






    }

    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Image Image { get; set; }

        public Product(string name, string description, Image image)
        {
            Name = name;
            Description = description;
            Image = image;
        }
    }
}

namespace Proiect10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            categorieComboBox = new ComboBox();
            label6 = new Label();
            tabPage2 = new TabPage();
            culoareButton = new Button();
            tabPage3 = new TabPage();
            varstaTextBox = new TextBox();
            label5 = new Label();
            tabPage4 = new TabPage();
            ComandaButton = new Button();
            adresaTextBox = new TextBox();
            prenumeTextBox = new TextBox();
            numeTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            rezultatLabel = new Label();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Controls.Add(rezultatLabel);
            groupBox1.Controls.Add(panel1);
            groupBox1.Location = new Point(53, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(688, 323);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Comanda";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(191, 26);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(421, 212);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(categorieComboBox);
            tabPage1.Controls.Add(label6);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(413, 179);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Categorie";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // categorieComboBox
            // 
            categorieComboBox.FormattingEnabled = true;
            categorieComboBox.Items.AddRange(new object[] { "Seturi Lego", "Costume tradiționale românești ", "Jucării din lemn", "Cărți cu povești românești", "Păpuși handmade", "Instrumente muzicale tradiționale ", "Jocuri de societate", "Fluier din alamă", "Materiale de artă", "Puzzle-uri educaționale", "Cărți și jocuri pentru învățarea limbii române", "Jucării tricotate", "Steagul României", "Cărți de colorat cu obiective turistice din România", "Seturi de bucătărie pentru copii", "Animale din fetru handmade", "Dulciuri tradiționale românești (ex: cozonac, turta dulce)", "Bicicletă", "Cărți de istorie românească pentru copii", "Seturi de bricolaj pentru copii", "Aplicații educaționale în limba română pentru copii", "Seturi de grădinărit pentru juniori", "Costume tradiționale de dans popular pentru copii", "Ghiduri de faună și floră românească pentru copii", "Echipament de aventură în aer liber " });
            categorieComboBox.Location = new Point(25, 69);
            categorieComboBox.Name = "categorieComboBox";
            categorieComboBox.Size = new Size(368, 28);
            categorieComboBox.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 40);
            label6.Name = "label6";
            label6.Size = new Size(133, 20);
            label6.TabIndex = 0;
            label6.Text = "Selecteaza produs:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(culoareButton);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(413, 179);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Culoare";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // culoareButton
            // 
            culoareButton.Location = new Point(114, 68);
            culoareButton.Name = "culoareButton";
            culoareButton.Size = new Size(120, 29);
            culoareButton.TabIndex = 0;
            culoareButton.Text = "Alege culoarea";
            culoareButton.UseVisualStyleBackColor = true;
            culoareButton.Click += button2_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(varstaTextBox);
            tabPage3.Controls.Add(label5);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(413, 179);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Varsta Copilului";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // varstaTextBox
            // 
            varstaTextBox.Location = new Point(97, 51);
            varstaTextBox.Name = "varstaTextBox";
            varstaTextBox.Size = new Size(125, 27);
            varstaTextBox.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 54);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 0;
            label5.Text = "Varsta:";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(ComandaButton);
            tabPage4.Controls.Add(adresaTextBox);
            tabPage4.Controls.Add(prenumeTextBox);
            tabPage4.Controls.Add(numeTextBox);
            tabPage4.Controls.Add(label4);
            tabPage4.Controls.Add(label3);
            tabPage4.Controls.Add(label2);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(413, 179);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Contact";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // ComandaButton
            // 
            ComandaButton.Location = new Point(305, 138);
            ComandaButton.Name = "ComandaButton";
            ComandaButton.Size = new Size(94, 29);
            ComandaButton.TabIndex = 6;
            ComandaButton.Text = "Comanda";
            ComandaButton.UseVisualStyleBackColor = true;
            ComandaButton.Click += button1_Click;
            // 
            // adresaTextBox
            // 
            adresaTextBox.Location = new Point(109, 100);
            adresaTextBox.Name = "adresaTextBox";
            adresaTextBox.Size = new Size(125, 27);
            adresaTextBox.TabIndex = 5;
            // 
            // prenumeTextBox
            // 
            prenumeTextBox.Location = new Point(109, 64);
            prenumeTextBox.Name = "prenumeTextBox";
            prenumeTextBox.Size = new Size(125, 27);
            prenumeTextBox.TabIndex = 4;
            // 
            // numeTextBox
            // 
            numeTextBox.Location = new Point(109, 31);
            numeTextBox.Name = "numeTextBox";
            numeTextBox.Size = new Size(125, 27);
            numeTextBox.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 100);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 2;
            label4.Text = "Adresa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 67);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 1;
            label3.Text = "Prenume:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 34);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 0;
            label2.Text = "Nume:";
            // 
            // rezultatLabel
            // 
            rezultatLabel.AutoSize = true;
            rezultatLabel.Location = new Point(28, 237);
            rezultatLabel.Name = "rezultatLabel";
            rezultatLabel.Size = new Size(0, 20);
            rezultatLabel.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Location = new Point(28, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(109, 126);
            panel1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button ComandaButton;
        private TextBox adresaTextBox;
        private TextBox prenumeTextBox;
        private TextBox numeTextBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label rezultatLabel;
        private Panel panel1;
        private TextBox varstaTextBox;
        private Label label5;
        private Button culoareButton;
        private ComboBox categorieComboBox;
        private Label label6;
    }
}

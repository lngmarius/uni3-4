namespace Exercitiu1
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
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            monthCalendar1 = new MonthCalendar();
            button1 = new Button();
            label2 = new Label();
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 19);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 0;
            label1.Text = "Inregistrati un email.";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(47, 56);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(132, 24);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Bussiness Email";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(185, 56);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(126, 24);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Personal Email";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(47, 98);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "email";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(47, 131);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "parola";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            textBox2.UseSystemPasswordChar = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(47, 164);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "nume";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(178, 164);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "prenume";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(48, 197);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "telefon";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 7;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(48, 236);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(47, 522);
            button1.Name = "button1";
            button1.Size = new Size(125, 40);
            button1.TabIndex = 11;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 101);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 12;
            label2.Text = "@email.com";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(47, 488);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(277, 24);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Esti de acord cu termenii si serviciile?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Afghan", "  Albanian", "  Algerian", "  American", "  Andorran", "  Angolan", "  Anguillan", "  Citizen of Antigua and Barbuda", "  Argentine", "  Armenian", "  Australian", "  Austrian", "  Azerbaijani", "  Bahamian", "  Bahraini", "  Bangladeshi", "  Barbadian", "  Belarusian", "  Belgian", "  Belizean", "  Beninese", "  Bermudian", "  Bhutanese", "  Bolivian", "  Citizen of Bosnia and Herzegovina", "  Botswanan", "  Brazilian", "  British", "  British Virgin Islander", "  Bruneian", "  Bulgarian", "  Burkinan", "  Burmese", "  Burundian", "  Cambodian", "  Cameroonian", "  Canadian", "  Cape Verdean", "  Cayman Islander", "  Central African", "  Chadian", "  Chilean", "  Chinese", "  Colombian", "  Comoran", "  Congolese (Congo)", "  Congolese (DRC)", "  Cook Islander", "  Costa Rican", "  Croatian", "  Cuban", "  Cymraes", "  Cymro", "  Cypriot", "  Czech", "  Danish", "  Djiboutian", "  Dominican", "  Citizen of the Dominican Republic", "  Dutch", "  East Timorese", "  Ecuadorean", "  Egyptian", "  Emirati", "  English", "  Equatorial Guinean", "  Eritrean", "  Estonian", "  Ethiopian", "  Faroese", "  Fijian", "  Filipino", "  Finnish", "  French", "  Gabonese", "  Gambian", "  Georgian", "  German", "  Ghanaian", "  Gibraltarian", "  Greek", "  Greenlandic", "  Grenadian", "  Guamanian", "  Guatemalan", "  Citizen of Guinea-Bissau", "  Guinean", "  Guyanese", "  Haitian", "  Honduran", "  Hong Konger", "  Hungarian", "  Icelandic", "  Indian", "  Indonesian", "  Iranian", "  Iraqi", "  Irish", "  Israeli", "  Italian", "  Ivorian", "  Jamaican", "  Japanese", "  Jordanian", "  Kazakh", "  Kenyan", "  Kittitian", "  Citizen of Kiribati", "  Kosovan", "  Kuwaiti", "  Kyrgyz", "  Lao", "  Latvian", "  Lebanese", "  Liberian", "  Libyan", "  Liechtenstein citizen", "  Lithuanian", "  Luxembourger", "  Macanese", "  Macedonian", "  Malagasy", "  Malawian", "  Malaysian", "  Maldivian", "  Malian", "  Maltese", "  Marshallese", "  Martiniquais", "  Mauritanian", "  Mauritian", "  Mexican", "  Micronesian", "  Moldovan", "  Monegasque", "  Mongolian", "  Montenegrin", "  Montserratian", "  Moroccan", "  Mosotho", "  Mozambican", "  Namibian", "  Nauruan", "  Nepalese", "  New Zealander", "  Nicaraguan", "  Nigerian", "  Nigerien", "  Niuean", "  North Korean", "  Northern Irish", "  Norwegian", "  Omani", "  Pakistani", "  Palauan", "  Palestinian", "  Panamanian", "  Papua New Guinean", "  Paraguayan", "  Peruvian", "  Pitcairn Islander", "  Polish", "  Portuguese", "  Prydeinig", "  Puerto Rican", "  Qatari", "  Romanian", "  Russian", "  Rwandan", "  Salvadorean", "  Sammarinese", "  Samoan", "  Sao Tomean", "  Saudi Arabian", "  Scottish", "  Senegalese", "  Serbian", "  Citizen of Seychelles", "  Sierra Leonean", "  Singaporean", "  Slovak", "  Slovenian", "  Solomon Islander", "  Somali", "  South African", "  South Korean", "  South Sudanese", "  Spanish", "  Sri Lankan", "  St Helenian", "  St Lucian", "  Stateless", "  Sudanese", "  Surinamese", "  Swazi", "  Swedish", "  Swiss", "  Syrian", "  Taiwanese", "  Tajik", "  Tanzanian", "  Thai", "  Togolese", "  Tongan", "  Trinidadian", "  Tristanian", "  Tunisian", "  Turkish", "  Turkmen", "  Turks and Caicos Islander", "  Tuvaluan", "  Ugandan", "  Ukrainian", "  Uruguayan", "  Uzbek", "  Vatican citizen", "  Citizen of Vanuatu", "  Venezuelan", "  Vietnamese", "  Vincentian", "  Wallisian", "  Welsh", "  Yemeni", "  Zambian", "  Zimbabwean" });
            comboBox1.Location = new Point(47, 455);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(413, 583);
            Controls.Add(comboBox1);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(monthCalendar1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private MonthCalendar monthCalendar1;
        private Button button1;
        private Label label2;
        private CheckBox checkBox1;
        private ComboBox comboBox1;
    }
}

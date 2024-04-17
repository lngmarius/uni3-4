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
            groupBox1 = new GroupBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            label1 = new Label();
            ComandaButton = new Button();
            adresaTextBox = new TextBox();
            prenumeTextBox = new TextBox();
            numeTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            rezultatLabel = new Label();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Controls.Add(rezultatLabel);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(853, 565);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Comanda";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(6, 26);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(847, 539);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(839, 506);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Categorie";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(839, 506);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Cos de cumparaturi";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label1);
            tabPage4.Controls.Add(ComandaButton);
            tabPage4.Controls.Add(adresaTextBox);
            tabPage4.Controls.Add(prenumeTextBox);
            tabPage4.Controls.Add(numeTextBox);
            tabPage4.Controls.Add(label4);
            tabPage4.Controls.Add(label3);
            tabPage4.Controls.Add(label2);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(839, 506);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Contact";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 272);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 7;
            // 
            // ComandaButton
            // 
            ComandaButton.Location = new Point(140, 133);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 589);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
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
        private Label label1;
    }
}

namespace Exercitiu
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
            button1 = new Button();
            checkedListBox2 = new CheckedListBox();
            button2 = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(59, 234);
            button1.Name = "button1";
            button1.Size = new Size(150, 29);
            button1.TabIndex = 1;
            button1.Text = "Cauta fisiere";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkedListBox2
            // 
            checkedListBox2.CheckOnClick = true;
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Location = new Point(59, 103);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(150, 114);
            checkedListBox2.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(58, 63);
            button2.Name = "button2";
            button2.Size = new Size(151, 29);
            button2.TabIndex = 3;
            button2.Text = "Selecteaza folder";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(59, 282);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 124);
            listBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 103);
            label1.Name = "label1";
            label1.Size = new Size(384, 100);
            label1.TabIndex = 5;
            label1.Text = resources.GetString("label1.Text");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 450);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(checkedListBox2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private CheckedListBox checkedListBox2;
        private Button button2;
        private ListBox listBox1;
        private Label label1;
    }
}

namespace Proiect11
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
            menuStrip1 = new MenuStrip();
            asdToolStripMenuItem = new ToolStripMenuItem();
            asdToolStripMenuItem1 = new ToolStripMenuItem();
            asdToolStripMenuItem2 = new ToolStripMenuItem();
            asdToolStripMenuItem3 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            asdToolStripMenuItem4 = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            asdToolStripMenuItem5 = new ToolStripMenuItem();
            dinamicHelpToolStripMenuItem = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            aboutPVToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { asdToolStripMenuItem, asdToolStripMenuItem4, asdToolStripMenuItem5 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // asdToolStripMenuItem
            // 
            asdToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { asdToolStripMenuItem1, asdToolStripMenuItem2, asdToolStripMenuItem3, exitToolStripMenuItem });
            asdToolStripMenuItem.Name = "asdToolStripMenuItem";
            asdToolStripMenuItem.Size = new Size(46, 24);
            asdToolStripMenuItem.Text = "File";
            // 
            // asdToolStripMenuItem1
            // 
            asdToolStripMenuItem1.Name = "asdToolStripMenuItem1";
            asdToolStripMenuItem1.Size = new Size(128, 26);
            asdToolStripMenuItem1.Text = "New";
            asdToolStripMenuItem1.Click += asdToolStripMenuItem1_Click;
            // 
            // asdToolStripMenuItem2
            // 
            asdToolStripMenuItem2.Name = "asdToolStripMenuItem2";
            asdToolStripMenuItem2.Size = new Size(128, 26);
            asdToolStripMenuItem2.Text = "Open";
            asdToolStripMenuItem2.Click += asdToolStripMenuItem2_Click;
            // 
            // asdToolStripMenuItem3
            // 
            asdToolStripMenuItem3.Name = "asdToolStripMenuItem3";
            asdToolStripMenuItem3.Size = new Size(128, 26);
            asdToolStripMenuItem3.Text = "Close";
            asdToolStripMenuItem3.Click += asdToolStripMenuItem3_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(128, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // asdToolStripMenuItem4
            // 
            asdToolStripMenuItem4.DropDownItems.AddRange(new ToolStripItem[] { fontToolStripMenuItem, colorToolStripMenuItem, resetToolStripMenuItem });
            asdToolStripMenuItem4.Name = "asdToolStripMenuItem4";
            asdToolStripMenuItem4.Size = new Size(78, 24);
            asdToolStripMenuItem4.Text = "Window";
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(128, 26);
            fontToolStripMenuItem.Text = "Font";
            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(128, 26);
            colorToolStripMenuItem.Text = "Color";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Size = new Size(128, 26);
            resetToolStripMenuItem.Text = "Reset";
            resetToolStripMenuItem.Click += resetToolStripMenuItem_Click;
            // 
            // asdToolStripMenuItem5
            // 
            asdToolStripMenuItem5.DropDownItems.AddRange(new ToolStripItem[] { dinamicHelpToolStripMenuItem, aboutPVToolStripMenuItem });
            asdToolStripMenuItem5.Name = "asdToolStripMenuItem5";
            asdToolStripMenuItem5.Size = new Size(55, 24);
            asdToolStripMenuItem5.Text = "Help";
            // 
            // dinamicHelpToolStripMenuItem
            // 
            dinamicHelpToolStripMenuItem.Name = "dinamicHelpToolStripMenuItem";
            dinamicHelpToolStripMenuItem.Size = new Size(224, 26);
            dinamicHelpToolStripMenuItem.Text = "DinamicHelp";
            dinamicHelpToolStripMenuItem.Click += dinamicHelpToolStripMenuItem_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(244, 135);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(475, 235);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // aboutPVToolStripMenuItem
            // 
            aboutPVToolStripMenuItem.Name = "aboutPVToolStripMenuItem";
            aboutPVToolStripMenuItem.Size = new Size(224, 26);
            aboutPVToolStripMenuItem.Text = "About PV";
            aboutPVToolStripMenuItem.Click += aboutPVToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem asdToolStripMenuItem;
        private ToolStripMenuItem asdToolStripMenuItem1;
        private ToolStripMenuItem asdToolStripMenuItem2;
        private ToolStripMenuItem asdToolStripMenuItem3;
        private ToolStripMenuItem asdToolStripMenuItem4;
        private ToolStripMenuItem asdToolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private RichTextBox richTextBox1;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
        private ToolStripMenuItem dinamicHelpToolStripMenuItem;
        private ToolStripMenuItem aboutPVToolStripMenuItem;
    }
}

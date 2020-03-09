namespace FinalProjectTest
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.aboutus = new System.Windows.Forms.Label();
            this.emailSubmit = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.email = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.itemsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.itemsToolStripMenuItem.Text = "Items";
            this.itemsToolStripMenuItem.Click += new System.EventHandler(this.itemsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(300, 301);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 1;
            // 
            // aboutus
            // 
            this.aboutus.AutoSize = true;
            this.aboutus.Location = new System.Drawing.Point(367, 105);
            this.aboutus.Name = "aboutus";
            this.aboutus.Size = new System.Drawing.Size(51, 13);
            this.aboutus.TabIndex = 2;
            this.aboutus.Text = "About Us";
            // 
            // emailSubmit
            // 
            this.emailSubmit.Location = new System.Drawing.Point(361, 429);
            this.emailSubmit.Name = "emailSubmit";
            this.emailSubmit.Size = new System.Drawing.Size(75, 23);
            this.emailSubmit.TabIndex = 3;
            this.emailSubmit.Text = "Submit";
            this.emailSubmit.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(300, 194);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(194, 84);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "If you have any issues or questions please fill in your email address and your qu" +
    "estion and someone will get back to you as soon as they can. ";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(232, 304);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(32, 13);
            this.email.TabIndex = 5;
            this.email.Text = "Email";
            // 
            // emailText
            // 
            this.emailText.AutoSize = true;
            this.emailText.Location = new System.Drawing.Point(232, 355);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(54, 13);
            this.emailText.TabIndex = 6;
            this.emailText.Text = "Questions";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(300, 327);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(194, 96);
            this.richTextBox2.TabIndex = 7;
            this.richTextBox2.Text = "";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 490);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.email);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.emailSubmit);
            this.Controls.Add(this.aboutus);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "About";
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label aboutus;
        private System.Windows.Forms.Button emailSubmit;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label emailText;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAgainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(798, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemsToolStripMenuItem1});
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.itemsToolStripMenuItem.Text = "Items";
            // 
            // itemsToolStripMenuItem1
            // 
            this.itemsToolStripMenuItem1.Name = "itemsToolStripMenuItem1";
            this.itemsToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.itemsToolStripMenuItem1.Text = "Items";
            this.itemsToolStripMenuItem1.Click += new System.EventHandler(this.itemsToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutAgainToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutAgainToolStripMenuItem
            // 
            this.aboutAgainToolStripMenuItem.Name = "aboutAgainToolStripMenuItem";
            this.aboutAgainToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.aboutAgainToolStripMenuItem.Text = "About Again";
            this.aboutAgainToolStripMenuItem.Click += new System.EventHandler(this.aboutAgainToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(300, 301);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "abc@yourdomain.com";
            // 
            // aboutus
            // 
            this.aboutus.AutoSize = true;
            this.aboutus.BackColor = System.Drawing.SystemColors.Control;
            this.aboutus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aboutus.Location = new System.Drawing.Point(361, 96);
            this.aboutus.Name = "aboutus";
            this.aboutus.Size = new System.Drawing.Size(53, 15);
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
            this.emailSubmit.Click += new System.EventHandler(this.emailSubmit_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(300, 180);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(194, 88);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "We are in the business of helping you track your items. If you have any issues or" +
    " questions please fill in your email address and your question and someone will " +
    "get back to you as soon as they can. ";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(166, 304);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(120, 13);
            this.email.TabIndex = 5;
            this.email.Text = "Please enter your Email:";
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
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 490);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.email);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.emailSubmit);
            this.Controls.Add(this.aboutus);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutAgainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}
namespace FinalProjectTest
{
    partial class RegisterForm
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
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.Uname = new System.Windows.Forms.Label();
            this.Pword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(287, 130);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(165, 20);
            this.usernameTextbox.TabIndex = 0;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(287, 189);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(165, 20);
            this.passwordTextbox.TabIndex = 1;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(325, 236);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 2;
            this.registerButton.Text = "Register";
            this.registerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Uname
            // 
            this.Uname.AutoSize = true;
            this.Uname.Location = new System.Drawing.Point(284, 114);
            this.Uname.Name = "Uname";
            this.Uname.Size = new System.Drawing.Size(55, 13);
            this.Uname.TabIndex = 3;
            this.Uname.Text = "Username";
            // 
            // Pword
            // 
            this.Pword.AutoSize = true;
            this.Pword.Location = new System.Drawing.Point(284, 173);
            this.Pword.Name = "Pword";
            this.Pword.Size = new System.Drawing.Size(53, 13);
            this.Pword.TabIndex = 4;
            this.Pword.Text = "Password";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(726, 385);
            this.Controls.Add(this.Pword);
            this.Controls.Add(this.Uname);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usernameTextbox);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label Uname;
        private System.Windows.Forms.Label Pword;
    }
}
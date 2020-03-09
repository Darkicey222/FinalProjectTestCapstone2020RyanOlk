using NSubstitute.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Security;



namespace FinalProjectTest
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm register = new RegisterForm();
            register.ShowDialog();
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked == true)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "")
            {
                MessageBox.Show("Please enter user name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTextBox.Focus();
                return;
            }
            if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTextBox.Focus();
                return;
            }
            try
            {
                SqlConnection con = new SqlConnection("Server=tcp:finalproject123.database.windows.net,1433;Initial Catalog=TrackingItems;Persist Security Info=False;User ID=rolk;Password=Darkpooh!234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                SqlCommand cmd = new SqlCommand("Select Username, Password from Users where Username = @Username and Password = @Password", con);
                SqlParameter uname = new SqlParameter("@Username", SqlDbType.VarChar);
                SqlParameter pword = new SqlParameter("@Password", SqlDbType.VarChar);

                uname.Value = usernameTextBox.Text;
                pword.Value = passwordTextBox.Text;

                cmd.Parameters.Add(uname);
                cmd.Parameters.Add(pword);

                cmd.Connection.Open();

                   
                SqlDataReader myReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                if (myReader.Read() == true)
                {
                    MessageBox.Show("You have logged in successfully " + usernameTextBox.Text);
                    this.Hide();
                    Items register = new Items();
                    register.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login Failed...Try again or please click link below to register!", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernameTextBox.Clear();
                    passwordTextBox.Clear();
                    usernameTextBox.Focus();

                }
                if (con.State == ConnectionState.Open)
                {
                    con.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

       
    }
}
    


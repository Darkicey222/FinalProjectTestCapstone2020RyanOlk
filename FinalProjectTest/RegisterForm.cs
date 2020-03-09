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


namespace FinalProjectTest
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String uname = usernameTextbox.Text.ToString();
            String pword = passwordTextbox.Text.ToString();

            SqlConnection con = new SqlConnection("Server=tcp:finalproject123.database.windows.net,1433;Initial Catalog=TrackingItems;Persist Security Info=False;User ID=rolk;Password=Darkpooh!234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            con.Open();

            String query = "INSERT INTO Users VALUES ('" + uname.ToString() + "','" + pword.ToString() + "' );";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Congrats you have registered your account");
            this.Hide();

            LoginForm register = new LoginForm();
            register.ShowDialog();




        }
    }
    
}

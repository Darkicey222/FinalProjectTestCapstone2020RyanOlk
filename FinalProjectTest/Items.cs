using IdentityModel.Client;
using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalProjectTest
{
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
        }
         private void itemsButton_Click(object sender, EventArgs e)
        {

            if (itemDesc.Text == "")
            {
                MessageBox.Show("Please enter Item Description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                itemDesc.Focus();
                return;
            }
            if (itemPrice.Text == "")
            {
                MessageBox.Show("Please enter Item Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                itemPrice.Focus();
                return;
            }
            try
            {
                SqlConnection con = new SqlConnection("Server=tcp:finalproject123.database.windows.net,1433;Initial Catalog=TrackingItems;Persist Security Info=False;User ID=rolk;Password=Darkpooh!234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                SqlCommand cmd = new SqlCommand("Insert Into TrackedItem Values (@ItemDescription, @ItemPrice)", con);
                SqlParameter itemD = new SqlParameter("@ItemDescription", SqlDbType.VarChar);
                SqlParameter itemP = new SqlParameter("@ItemPrice", SqlDbType.VarChar);

                itemD.Value = itemDesc.Text;
                itemP.Value = itemPrice.Text;

                cmd.Parameters.Add(itemD);
                cmd.Parameters.Add(itemP);

                cmd.Connection.Open();

                SqlDataReader myReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);               

                if (myReader.Read() == true)
                {
                    MessageBox.Show("You have entered item! " + itemDesc.Text);
                    
                    
                }
                else
                {
                    MessageBox.Show("Enter Item Failed", "Please Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    itemDesc.Clear();
                    itemPrice.Clear();
                    itemDesc.Focus();

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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About frm = new About();
            if (frm == null)
            {
                frm.Parent = this;
            }
            frm.Show();
            this.Hide();
            

        }
    }

        
    }

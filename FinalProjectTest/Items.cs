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
using FinalProjectTest;
using System.Globalization;
using System.Configuration;
using System.Web.Security;


namespace FinalProjectTest
{
    public partial class Items : Form
    {
        SqlConnection con = new SqlConnection("Server=tcp:finalproject123.database.windows.net,1433;Initial Catalog=TrackingItems;Persist Security Info=False;User ID=rolk;Password=Darkpooh!234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public Items()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
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
                SqlCommand cmd = new SqlCommand("Insert Into TrackedItem(ItemDescription, ItemPrice) Values (@ItemDescription, @ItemPrice)", con);
                SqlParameter itemD = new SqlParameter("@ItemDescription", SqlDbType.VarChar);
                SqlParameter itemP = new SqlParameter("@ItemPrice", SqlDbType.VarChar);
                

                itemD.Value = itemDesc.Text;
                itemP.Value = itemPrice.Text;
                

                cmd.Parameters.Add(itemD);
                cmd.Parameters.Add(itemP);

                cmd.Connection.Open();

                SqlDataAdapter sda = new SqlDataAdapter("Select * from TrackedItem", con);
                DataTable Data = new DataTable();
                sda.Fill(Data);
                dataGridView1.DataSource = Data;

                SqlDataReader myReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);


                if (myReader.Read() == true)
                {
                    MessageBox.Show("Item did not enter");


                }
                else
                {
                    MessageBox.Show("Item Entered", "'"+ itemDesc, MessageBoxButtons.OK, MessageBoxIcon.Error);
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



        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            About f2 = new About();
            f2.ShowDialog();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f1 = new LoginForm();
            f1.ShowDialog();
            this.Close();
        }

        private void itemsAgainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Items f3 = new Items();
            f3.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from TrackedItem", con);
            DataTable Data = new DataTable();
            sda.Fill(Data);
            dataGridView1.DataSource = Data;
            con.Close();
        }
    }

        
}

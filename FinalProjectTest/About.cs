using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace FinalProjectTest
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            
        }

        private void itemsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Items f1 = new Items();
            f1.ShowDialog();
            this.Close();
        }

        private void aboutAgainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            About f2 = new About();
            f2.ShowDialog();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f3 = new LoginForm();
            f3.ShowDialog();
            this.Close();
        }

        private void emailSubmit_Click(object sender, EventArgs e)
        {

            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 25)
                {
                    EnableSsl = true,
                    Timeout = 10000,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("olktree222@gmail.com", "RickandMorty!222")
                };

                MailMessage msg = new MailMessage();
                msg.From = new MailAddress(textBox1.Text, "Enquiry");
                msg.To.Add("olktree222@gmail.com");
                msg.Subject = textBox1.Text;
                msg.Body = richTextBox2.Text;
                client.Send(msg);
                MessageBox.Show("Successfully Sent Message.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

               
        }
        
    }
}

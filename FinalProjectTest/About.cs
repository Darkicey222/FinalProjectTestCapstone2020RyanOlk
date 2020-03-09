using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            LoginForm register = new LoginForm();
            register.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            About register = new About();
            register.ShowDialog();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Items register = new Items();
            register.ShowDialog();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            home register = new home();
            register.ShowDialog();
        }
    }
}

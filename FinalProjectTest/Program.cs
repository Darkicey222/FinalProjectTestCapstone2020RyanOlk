﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text;

namespace FinalProjectTest
{
   static class Program
    {
        /// <summary>   
        ///The main entry point for the application.
        ///</summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm()); //Startup Form
        }
    }
}
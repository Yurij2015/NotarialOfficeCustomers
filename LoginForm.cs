using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Configuration;

namespace NotarialOfficeCustomers
{
    public partial class LoginForm : Telerik.WinControls.UI.RadForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radButtonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radButtonTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["DBNotarialOfficeConnectionString"].ToString();


            ElectronicQueueForm electronicQueueForm = new ElectronicQueueForm();
            electronicQueueForm.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace NotarialOfficeCustomers
{
    public partial class PanelFormNoAdmin : Telerik.WinControls.UI.RadForm
    {
        public PanelFormNoAdmin()
        {
            InitializeComponent();
            radButton2.Enabled = false;
            radButton3.Enabled = false;
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            ElectronicQueueForm electronicQueueForm = new ElectronicQueueForm();
            electronicQueueForm.Show();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer();
            formCustomer.Show();
        }

        private void radButton6_Click(object sender, EventArgs e)
        {
            FormService formServie = new FormService();
            formServie.Show();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {

        }

        private void radButton3_Click(object sender, EventArgs e)
        {

        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

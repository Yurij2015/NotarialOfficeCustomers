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
    public partial class PanelForm : Telerik.WinControls.UI.RadForm
    {
        public PanelForm()
        {
            InitializeComponent();
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

        private void radButton2_Click(object sender, EventArgs e)
        {
            FormEmployee formEmployee = new FormEmployee();
            formEmployee.Show();
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            FormPosition formPosition = new FormPosition();
            formPosition.Show();
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelForm_Load(object sender, EventArgs e)
        {

        }
    }
}

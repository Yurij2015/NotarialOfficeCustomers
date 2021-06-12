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
    public partial class FormCustomer : Telerik.WinControls.UI.RadForm
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'notarialOfficeCustemersDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.notarialOfficeCustemersDataSet.customer);

        }

        private void commandBarButton8_Click(object sender, EventArgs e)
        {
            customerTableAdapter.Update(notarialOfficeCustemersDataSet.customer);
        }

        private void radBindingNavigator2_Click(object sender, EventArgs e)
        {

        }
    }
}

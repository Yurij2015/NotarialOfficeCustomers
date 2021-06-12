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
    public partial class FormEmployee : Telerik.WinControls.UI.RadForm
    {
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void commandBarButton2_Click(object sender, EventArgs e)
        {
            employeeTableAdapter.Update(notarialOfficeCustemersDataSet.employee);

        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'notarialOfficeCustemersDataSet.positon' table. You can move, or remove it, as needed.
            this.positonTableAdapter.Fill(this.notarialOfficeCustemersDataSet.positon);
            // TODO: This line of code loads data into the 'notarialOfficeCustemersDataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.notarialOfficeCustemersDataSet.employee);

        }
    }
}

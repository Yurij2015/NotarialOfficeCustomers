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
    public partial class FormPosition : Telerik.WinControls.UI.RadForm
    {
        public FormPosition()
        {
            InitializeComponent();
        }

        private void FormPosition_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'notarialOfficeCustemersDataSet2.positon' table. You can move, or remove it, as needed.
            this.positonTableAdapter2.Fill(this.notarialOfficeCustemersDataSet2.positon);

        }

        private void commandBarButton2_Click(object sender, EventArgs e)
        {
            positonTableAdapter.Update(notarialOfficeCustemersDataSet.positon);
        }
    }
}

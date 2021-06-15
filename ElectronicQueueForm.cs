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
    public partial class ElectronicQueueForm : Telerik.WinControls.UI.RadForm
    {
        public ElectronicQueueForm()
        {
            InitializeComponent();
        }

        private void ElectronicQueueForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'notarialOfficeCustemersDataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.notarialOfficeCustemersDataSet.employee);
            // TODO: This line of code loads data into the 'notarialOfficeCustemersDataSet.service' table. You can move, or remove it, as needed.
            this.serviceTableAdapter.Fill(this.notarialOfficeCustemersDataSet.service);
            // TODO: This line of code loads data into the 'notarialOfficeCustemersDataSet1.recording' table. You can move, or remove it, as needed.
            this.recordingTableAdapter.Fill(this.notarialOfficeCustemersDataSet1.recording);
            // TODO: This line of code loads data into the 'notarialOfficeCustemersDataSet.recording' table. You can move, or remove it, as needed.
            this.recordingTableAdapter.Fill(this.notarialOfficeCustemersDataSet.recording);
            // TODO: This line of code loads data into the 'notarialOfficeCustemersDataSet.recording' table. You can move, or remove it, as needed.

        }

        private void nDataNavigator1_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void radBindingNavigator1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            recordingTableAdapter.Update(notarialOfficeCustemersDataSet.recording);
        }

        private void radGridView1_Click(object sender, EventArgs e)
        {

        }

        private void radBindingNavigator1DeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void commandBarButton2_Click(object sender, EventArgs e)
        {
            recordingTableAdapter.Update(notarialOfficeCustemersDataSet.recording);
        }

        private void recordingBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}

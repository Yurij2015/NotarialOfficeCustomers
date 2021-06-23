using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;

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
            // TODO: This line of code loads data into the 'notarialOfficeCustemersDataSetQueue.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.notarialOfficeCustemersDataSetQueue.employee);
            // TODO: This line of code loads data into the 'notarialOfficeCustemersDataSetQueue.timetorecording' table. You can move, or remove it, as needed.
            this.timetorecordingTableAdapter.Fill(this.notarialOfficeCustemersDataSetQueue.timetorecording);
            // TODO: This line of code loads data into the 'notarialOfficeCustemersDataSetQueue.service' table. You can move, or remove it, as needed.
            this.serviceTableAdapter1.Fill(this.notarialOfficeCustemersDataSetQueue.service);
            // TODO: This line of code loads data into the 'notarialOfficeCustemersDataSetQueue.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter1.Fill(this.notarialOfficeCustemersDataSetQueue.customer);
            // TODO: This line of code loads data into the 'notarialOfficeCustemersDataSet4.recording' table. You can move, or remove it, as needed.
            this.recordingTableAdapterQueue.Fill(this.notarialOfficeCustemersDataSetQueue.recording);


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
        }

        private void radGridView1_Click(object sender, EventArgs e)
        {

        }

        private void radBindingNavigator1DeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void commandBarButton2_Click(object sender, EventArgs e)
        {
        }

        private void recordingBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void radBindingNavigator1AddNewItem_Click(object sender, EventArgs e)
        {
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                recordingTableAdapterQueue.Update(notarialOfficeCustemersDataSetQueue.recording);
            }
            catch
            {
                MessageBox.Show("Запись не может быть добавлена! Выберите другое время");
            }
        }
    }
}

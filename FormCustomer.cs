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
            // TODO: This line of code loads data into the 'notarialOfficeCustemersDataSet11.gender' table. You can move, or remove it, as needed.
            this.genderTableAdapter.Fill(this.notarialOfficeCustemersDataSet11.gender);
            // TODO: This line of code loads data into the 'notarialOfficeCustemersDataSet11.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter2.Fill(this.notarialOfficeCustemersDataSet11.customer);
            // TODO: This line of code loads data into the 'notarialOfficeCustemersDataSet11.customer' table. You can move, or remove it, as needed.


        }

        private void commandBarButton8_Click(object sender, EventArgs e)
        {
            customerTableAdapter1.Update(notarialOfficeCustemersDataSet1.customer);
        }

        private void radBindingNavigator2_Click(object sender, EventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {

        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            try
            {
                customerTableAdapter2.Update(notarialOfficeCustemersDataSet11.customer);

            }
            catch
            {
                MessageBox.Show("Запись не может быть удалена! Есть связанные записи!");
                // TODO: This line of code loads data into the 'notarialOfficeCustemersDataSet2.gender' table. You can move, or remove it, as needed.
                this.genderTableAdapter.Fill(this.notarialOfficeCustemersDataSet11.gender);
                // TODO: This line of code loads data into the 'notarialOfficeCustemersDataSet2.customer' table. You can move, or remove it, as needed.
                this.customerTableAdapter2.Fill(this.notarialOfficeCustemersDataSet11.customer);
            }

        }
    }
}

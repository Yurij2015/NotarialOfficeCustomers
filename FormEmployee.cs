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
            try
            {
                employeeTableAdapter.Update(notarialOfficeCustemersDataSet11.employee);
            }
            catch
            {
                MessageBox.Show("Ошибка обработки данных!");
                this.specializationTableAdapter.Fill(this.notarialOfficeCustemersDataSet11.specialization);
                this.positonTableAdapter.Fill(this.notarialOfficeCustemersDataSet11.positon);
                this.employeeTableAdapter.Fill(this.notarialOfficeCustemersDataSet11.employee);

            }
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'notarialOfficeCustemersDataSet11.specialization' table. You can move, or remove it, as needed.
            this.specializationTableAdapter.Fill(this.notarialOfficeCustemersDataSet11.specialization);
            // TODO: This line of code loads data into the 'notarialOfficeCustemersDataSet11.positon' table. You can move, or remove it, as needed.
            this.positonTableAdapter.Fill(this.notarialOfficeCustemersDataSet11.positon);
            // TODO: This line of code loads data into the 'notarialOfficeCustemersDataSet11.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.notarialOfficeCustemersDataSet11.employee);


        }

        private void radGridView1_Click(object sender, EventArgs e)
        {

        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            try
            {
                employeeTableAdapter.Update(notarialOfficeCustemersDataSet11.employee);
            }
            catch
            {
                MessageBox.Show("Запись не может быть удалена! Есть связанные записи!");

                this.specializationTableAdapter.Fill(this.notarialOfficeCustemersDataSet11.specialization);
                this.positonTableAdapter.Fill(this.notarialOfficeCustemersDataSet11.positon);
                this.employeeTableAdapter.Fill(this.notarialOfficeCustemersDataSet11.employee);

            }
        }

        private void radBindingNavigator1DeleteItem_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotarialOfficeCustomers
{
    public partial class FormService : Form
    {
        public FormService()
        {
            InitializeComponent();
        }

        private void FormService_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'notarialOfficeCustemersDataSet.service' table. You can move, or remove it, as needed.
            this.serviceTableAdapter.Fill(this.notarialOfficeCustemersDataSet.service);

        }

        private void commandBarButton2_Click(object sender, EventArgs e)
        {
            serviceTableAdapter.Update(notarialOfficeCustemersDataSet.service);
        }
    }
}

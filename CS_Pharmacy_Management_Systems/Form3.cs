using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Pharmacy_Management_Systems
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void gP_AppointmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gP_AppointmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.GP_Appointment' table. You can move, or remove it, as needed.
            this.gP_AppointmentTableAdapter.Fill(this.pharmacyDataSet.GP_Appointment);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if You Want to Exit GP page", "Pharmacy Management System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)

            {
                this.Hide();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.gP_AppointmentBindingSource.AddNew();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gP_AppointmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.gP_AppointmentBindingSource.RemoveCurrent();
        }
    }
}

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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void paymentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.pharmacyDataSet.Payment);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if You Want to Exit Payment page", "Pharmacy Management System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)

            {
                this.Hide();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.paymentBindingSource.AddNew();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.paymentBindingSource.RemoveCurrent();
        }
    }
}

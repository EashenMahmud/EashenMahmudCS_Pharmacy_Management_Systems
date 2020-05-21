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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void pharmacyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pharmacyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.Pharmacy' table. You can move, or remove it, as needed.
            this.pharmacyTableAdapter.Fill(this.pharmacyDataSet.Pharmacy);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if You Want to Exit Pharmacy page", "Pharmacy Management System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)

            {
                this.Hide();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.pharmacyBindingSource.AddNew();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pharmacyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.pharmacyBindingSource.RemoveCurrent();
        }
    }
}

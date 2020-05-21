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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.Pharmacy_Office' table. You can move, or remove it, as needed.
            this.pharmacy_OfficeTableAdapter.Fill(this.pharmacyDataSet.Pharmacy_Office);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if You Want to Exit Office page", "Pharmacy Management System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)

            {
                this.Hide();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.pharmacy_OfficeBindingSource.AddNew();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pharmacy_OfficeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.pharmacy_OfficeBindingSource.RemoveCurrent();
        }
    }
}

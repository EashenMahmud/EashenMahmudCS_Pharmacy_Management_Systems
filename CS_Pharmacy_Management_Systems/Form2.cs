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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void doctorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doctorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.pharmacyDataSet.Doctor);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if You Want to Exit Doctor page", "Pharmacy Management System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)

            {
                this.Hide();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.doctorBindingSource.AddNew();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doctorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.doctorBindingSource.RemoveCurrent();
        }
    }
}

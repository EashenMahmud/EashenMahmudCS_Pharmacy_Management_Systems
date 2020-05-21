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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            Form2 Doctor = new Form2();
            Doctor.Show();
        }

        private void btnGP_Click(object sender, EventArgs e)
        {
            Form3 GP = new Form3();
            GP.Show();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            Form4 Patient = new Form4();
            Patient.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Form5 Payment = new Form5();
            Payment.Show();
        }

        private void btnPharmacy_Click(object sender, EventArgs e)
        {
            Form6 Pharmacy = new Form6();
            Pharmacy.Show();
        }

        private void btnPharmacy_Office_Click(object sender, EventArgs e)
        {
            Form7 Pharmacy_Office = new Form7();
            Pharmacy_Office.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if You Want to Exit", "Pharmacy Management System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)

            {
                Application.Exit();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPasswod.Clear();
            txtUsername.Focus();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text =="dream1" && txtPasswod.Text =="dream2")

            {
                btnGP.Enabled = true;
                btnPatient.Enabled = true;
                btnPayment.Enabled = true;
                btnDoctor.Enabled = true;
                btnPharmacy.Enabled = true;
                btnPharmacy_Office.Enabled = true;
            }
            else 
            {
                MessageBox.Show("please enter the correct login details", "Pharmacy Management System");
                txtUsername.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnGP.Enabled = false;
            btnPatient.Enabled = false;
            btnPayment.Enabled = false;
            btnDoctor.Enabled = false;
            btnPharmacy.Enabled = false;
            btnPharmacy_Office.Enabled = false;
        }
    }
}

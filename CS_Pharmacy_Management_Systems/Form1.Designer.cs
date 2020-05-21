namespace CS_Pharmacy_Management_Systems
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDoctor = new System.Windows.Forms.Button();
            this.btnGP = new System.Windows.Forms.Button();
            this.btnPatient = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnPharmacy = new System.Windows.Forms.Button();
            this.btnPharmacy_Office = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPasswod = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDoctor
            // 
            this.btnDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctor.Location = new System.Drawing.Point(143, 164);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(140, 37);
            this.btnDoctor.TabIndex = 0;
            this.btnDoctor.Text = "Doctor";
            this.btnDoctor.UseVisualStyleBackColor = true;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // btnGP
            // 
            this.btnGP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGP.Location = new System.Drawing.Point(143, 233);
            this.btnGP.Name = "btnGP";
            this.btnGP.Size = new System.Drawing.Size(140, 46);
            this.btnGP.TabIndex = 0;
            this.btnGP.Text = "GP Appointment";
            this.btnGP.UseVisualStyleBackColor = true;
            this.btnGP.Click += new System.EventHandler(this.btnGP_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatient.Location = new System.Drawing.Point(143, 303);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(140, 40);
            this.btnPatient.TabIndex = 0;
            this.btnPatient.Text = "Patient";
            this.btnPatient.UseVisualStyleBackColor = true;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(1003, 164);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(140, 36);
            this.btnPayment.TabIndex = 0;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnPharmacy
            // 
            this.btnPharmacy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPharmacy.Location = new System.Drawing.Point(1003, 234);
            this.btnPharmacy.Name = "btnPharmacy";
            this.btnPharmacy.Size = new System.Drawing.Size(140, 45);
            this.btnPharmacy.TabIndex = 0;
            this.btnPharmacy.Text = "Pharmacy";
            this.btnPharmacy.UseVisualStyleBackColor = true;
            this.btnPharmacy.Click += new System.EventHandler(this.btnPharmacy_Click);
            // 
            // btnPharmacy_Office
            // 
            this.btnPharmacy_Office.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPharmacy_Office.Location = new System.Drawing.Point(1003, 302);
            this.btnPharmacy_Office.Name = "btnPharmacy_Office";
            this.btnPharmacy_Office.Size = new System.Drawing.Size(140, 41);
            this.btnPharmacy_Office.TabIndex = 0;
            this.btnPharmacy_Office.Text = "Pharmacy Office";
            this.btnPharmacy_Office.UseVisualStyleBackColor = true;
            this.btnPharmacy_Office.Click += new System.EventHandler(this.btnPharmacy_Office_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(636, 408);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 29);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPasswod);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Location = new System.Drawing.Point(411, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 234);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(380, 175);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 34);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(42, 175);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 34);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // txtPasswod
            // 
            this.txtPasswod.Location = new System.Drawing.Point(331, 84);
            this.txtPasswod.Multiline = true;
            this.txtPasswod.Name = "txtPasswod";
            this.txtPasswod.PasswordChar = '*';
            this.txtPasswod.Size = new System.Drawing.Size(144, 36);
            this.txtPasswod.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(331, 33);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(144, 34);
            this.txtUsername.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(114, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1058, 100);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1048, 90);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pharmacy Management System";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPharmacy_Office);
            this.Controls.Add(this.btnPharmacy);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnPatient);
            this.Controls.Add(this.btnGP);
            this.Controls.Add(this.btnDoctor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDoctor;
        private System.Windows.Forms.Button btnGP;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnPharmacy;
        private System.Windows.Forms.Button btnPharmacy_Office;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPasswod;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}


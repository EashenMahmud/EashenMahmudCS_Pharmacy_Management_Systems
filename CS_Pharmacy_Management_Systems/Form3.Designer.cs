namespace CS_Pharmacy_Management_Systems
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label gP_Appointment_RefLabel;
            System.Windows.Forms.Label patient_NHS_NumberLabel;
            System.Windows.Forms.Label eMIS_NumberLabel;
            System.Windows.Forms.Label gP_AppointmentLabel;
            System.Windows.Forms.Label patient_Full_NameLabel;
            System.Windows.Forms.Label patient_IDLabel;
            System.Windows.Forms.Label medical_Centre_NameLabel;
            System.Windows.Forms.Label doctor_s_NHS_NoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pharmacyDataSet = new CS_Pharmacy_Management_Systems.PharmacyDataSet();
            this.gP_AppointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gP_AppointmentTableAdapter = new CS_Pharmacy_Management_Systems.PharmacyDataSetTableAdapters.GP_AppointmentTableAdapter();
            this.tableAdapterManager = new CS_Pharmacy_Management_Systems.PharmacyDataSetTableAdapters.TableAdapterManager();
            this.gP_AppointmentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gP_AppointmentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.gP_Appointment_RefTextBox = new System.Windows.Forms.TextBox();
            this.patient_NHS_NumberTextBox = new System.Windows.Forms.TextBox();
            this.eMIS_NumberTextBox = new System.Windows.Forms.TextBox();
            this.gP_AppointmentTextBox = new System.Windows.Forms.TextBox();
            this.patient_Full_NameTextBox = new System.Windows.Forms.TextBox();
            this.patient_IDTextBox = new System.Windows.Forms.TextBox();
            this.medical_Centre_NameTextBox = new System.Windows.Forms.TextBox();
            this.doctor_s_NHS_NoTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gP_AppointmentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            gP_Appointment_RefLabel = new System.Windows.Forms.Label();
            patient_NHS_NumberLabel = new System.Windows.Forms.Label();
            eMIS_NumberLabel = new System.Windows.Forms.Label();
            gP_AppointmentLabel = new System.Windows.Forms.Label();
            patient_Full_NameLabel = new System.Windows.Forms.Label();
            patient_IDLabel = new System.Windows.Forms.Label();
            medical_Centre_NameLabel = new System.Windows.Forms.Label();
            doctor_s_NHS_NoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gP_AppointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gP_AppointmentBindingNavigator)).BeginInit();
            this.gP_AppointmentBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gP_AppointmentDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gP_Appointment_RefLabel
            // 
            gP_Appointment_RefLabel.AutoSize = true;
            gP_Appointment_RefLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gP_Appointment_RefLabel.Location = new System.Drawing.Point(114, 35);
            gP_Appointment_RefLabel.Name = "gP_Appointment_RefLabel";
            gP_Appointment_RefLabel.Size = new System.Drawing.Size(151, 16);
            gP_Appointment_RefLabel.TabIndex = 1;
            gP_Appointment_RefLabel.Text = "GP Appointment Ref:";
            // 
            // patient_NHS_NumberLabel
            // 
            patient_NHS_NumberLabel.AutoSize = true;
            patient_NHS_NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patient_NHS_NumberLabel.Location = new System.Drawing.Point(114, 61);
            patient_NHS_NumberLabel.Name = "patient_NHS_NumberLabel";
            patient_NHS_NumberLabel.Size = new System.Drawing.Size(154, 16);
            patient_NHS_NumberLabel.TabIndex = 3;
            patient_NHS_NumberLabel.Text = "Patient NHS Number:";
            // 
            // eMIS_NumberLabel
            // 
            eMIS_NumberLabel.AutoSize = true;
            eMIS_NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eMIS_NumberLabel.Location = new System.Drawing.Point(114, 87);
            eMIS_NumberLabel.Name = "eMIS_NumberLabel";
            eMIS_NumberLabel.Size = new System.Drawing.Size(106, 16);
            eMIS_NumberLabel.TabIndex = 5;
            eMIS_NumberLabel.Text = "EMIS Number:";
            // 
            // gP_AppointmentLabel
            // 
            gP_AppointmentLabel.AutoSize = true;
            gP_AppointmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gP_AppointmentLabel.Location = new System.Drawing.Point(114, 113);
            gP_AppointmentLabel.Name = "gP_AppointmentLabel";
            gP_AppointmentLabel.Size = new System.Drawing.Size(123, 16);
            gP_AppointmentLabel.TabIndex = 7;
            gP_AppointmentLabel.Text = "GP Appointment:";
            // 
            // patient_Full_NameLabel
            // 
            patient_Full_NameLabel.AutoSize = true;
            patient_Full_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patient_Full_NameLabel.Location = new System.Drawing.Point(565, 28);
            patient_Full_NameLabel.Name = "patient_Full_NameLabel";
            patient_Full_NameLabel.Size = new System.Drawing.Size(134, 16);
            patient_Full_NameLabel.TabIndex = 9;
            patient_Full_NameLabel.Text = "Patient Full Name:";
            // 
            // patient_IDLabel
            // 
            patient_IDLabel.AutoSize = true;
            patient_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patient_IDLabel.Location = new System.Drawing.Point(565, 54);
            patient_IDLabel.Name = "patient_IDLabel";
            patient_IDLabel.Size = new System.Drawing.Size(79, 16);
            patient_IDLabel.TabIndex = 11;
            patient_IDLabel.Text = "Patient ID:";
            // 
            // medical_Centre_NameLabel
            // 
            medical_Centre_NameLabel.AutoSize = true;
            medical_Centre_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            medical_Centre_NameLabel.Location = new System.Drawing.Point(565, 80);
            medical_Centre_NameLabel.Name = "medical_Centre_NameLabel";
            medical_Centre_NameLabel.Size = new System.Drawing.Size(161, 16);
            medical_Centre_NameLabel.TabIndex = 13;
            medical_Centre_NameLabel.Text = "Medical Centre Name:";
            // 
            // doctor_s_NHS_NoLabel
            // 
            doctor_s_NHS_NoLabel.AutoSize = true;
            doctor_s_NHS_NoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doctor_s_NHS_NoLabel.Location = new System.Drawing.Point(565, 106);
            doctor_s_NHS_NoLabel.Name = "doctor_s_NHS_NoLabel";
            doctor_s_NHS_NoLabel.Size = new System.Drawing.Size(130, 16);
            doctor_s_NHS_NoLabel.TabIndex = 15;
            doctor_s_NHS_NoLabel.Text = "Doctor\'s NHS No:";
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gP_AppointmentBindingSource
            // 
            this.gP_AppointmentBindingSource.DataMember = "GP Appointment";
            this.gP_AppointmentBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // gP_AppointmentTableAdapter
            // 
            this.gP_AppointmentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.GP_AppointmentTableAdapter = this.gP_AppointmentTableAdapter;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.PharmacyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CS_Pharmacy_Management_Systems.PharmacyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gP_AppointmentBindingNavigator
            // 
            this.gP_AppointmentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.gP_AppointmentBindingNavigator.BindingSource = this.gP_AppointmentBindingSource;
            this.gP_AppointmentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.gP_AppointmentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.gP_AppointmentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.gP_AppointmentBindingNavigatorSaveItem});
            this.gP_AppointmentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.gP_AppointmentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.gP_AppointmentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.gP_AppointmentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.gP_AppointmentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.gP_AppointmentBindingNavigator.Name = "gP_AppointmentBindingNavigator";
            this.gP_AppointmentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.gP_AppointmentBindingNavigator.Size = new System.Drawing.Size(1081, 25);
            this.gP_AppointmentBindingNavigator.TabIndex = 0;
            this.gP_AppointmentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // gP_AppointmentBindingNavigatorSaveItem
            // 
            this.gP_AppointmentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gP_AppointmentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("gP_AppointmentBindingNavigatorSaveItem.Image")));
            this.gP_AppointmentBindingNavigatorSaveItem.Name = "gP_AppointmentBindingNavigatorSaveItem";
            this.gP_AppointmentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.gP_AppointmentBindingNavigatorSaveItem.Text = "Save Data";
            this.gP_AppointmentBindingNavigatorSaveItem.Click += new System.EventHandler(this.gP_AppointmentBindingNavigatorSaveItem_Click);
            // 
            // gP_Appointment_RefTextBox
            // 
            this.gP_Appointment_RefTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gP_AppointmentBindingSource, "GP Appointment Ref", true));
            this.gP_Appointment_RefTextBox.Location = new System.Drawing.Point(271, 35);
            this.gP_Appointment_RefTextBox.Name = "gP_Appointment_RefTextBox";
            this.gP_Appointment_RefTextBox.Size = new System.Drawing.Size(100, 20);
            this.gP_Appointment_RefTextBox.TabIndex = 2;
            // 
            // patient_NHS_NumberTextBox
            // 
            this.patient_NHS_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gP_AppointmentBindingSource, "Patient NHS Number", true));
            this.patient_NHS_NumberTextBox.Location = new System.Drawing.Point(271, 61);
            this.patient_NHS_NumberTextBox.Name = "patient_NHS_NumberTextBox";
            this.patient_NHS_NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.patient_NHS_NumberTextBox.TabIndex = 4;
            // 
            // eMIS_NumberTextBox
            // 
            this.eMIS_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gP_AppointmentBindingSource, "EMIS Number", true));
            this.eMIS_NumberTextBox.Location = new System.Drawing.Point(271, 87);
            this.eMIS_NumberTextBox.Name = "eMIS_NumberTextBox";
            this.eMIS_NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.eMIS_NumberTextBox.TabIndex = 6;
            // 
            // gP_AppointmentTextBox
            // 
            this.gP_AppointmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gP_AppointmentBindingSource, "GP Appointment", true));
            this.gP_AppointmentTextBox.Location = new System.Drawing.Point(271, 113);
            this.gP_AppointmentTextBox.Name = "gP_AppointmentTextBox";
            this.gP_AppointmentTextBox.Size = new System.Drawing.Size(100, 20);
            this.gP_AppointmentTextBox.TabIndex = 8;
            // 
            // patient_Full_NameTextBox
            // 
            this.patient_Full_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gP_AppointmentBindingSource, "Patient Full Name", true));
            this.patient_Full_NameTextBox.Location = new System.Drawing.Point(725, 28);
            this.patient_Full_NameTextBox.Name = "patient_Full_NameTextBox";
            this.patient_Full_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.patient_Full_NameTextBox.TabIndex = 10;
            // 
            // patient_IDTextBox
            // 
            this.patient_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gP_AppointmentBindingSource, "Patient ID", true));
            this.patient_IDTextBox.Location = new System.Drawing.Point(725, 54);
            this.patient_IDTextBox.Name = "patient_IDTextBox";
            this.patient_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.patient_IDTextBox.TabIndex = 12;
            // 
            // medical_Centre_NameTextBox
            // 
            this.medical_Centre_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gP_AppointmentBindingSource, "Medical Centre Name", true));
            this.medical_Centre_NameTextBox.Location = new System.Drawing.Point(725, 80);
            this.medical_Centre_NameTextBox.Name = "medical_Centre_NameTextBox";
            this.medical_Centre_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.medical_Centre_NameTextBox.TabIndex = 14;
            // 
            // doctor_s_NHS_NoTextBox
            // 
            this.doctor_s_NHS_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gP_AppointmentBindingSource, "Doctor\'s NHS No", true));
            this.doctor_s_NHS_NoTextBox.Location = new System.Drawing.Point(725, 106);
            this.doctor_s_NHS_NoTextBox.Name = "doctor_s_NHS_NoTextBox";
            this.doctor_s_NHS_NoTextBox.Size = new System.Drawing.Size(100, 20);
            this.doctor_s_NHS_NoTextBox.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.gP_AppointmentDataGridView);
            this.panel1.Location = new System.Drawing.Point(139, 285);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 263);
            this.panel1.TabIndex = 17;
            // 
            // gP_AppointmentDataGridView
            // 
            this.gP_AppointmentDataGridView.AutoGenerateColumns = false;
            this.gP_AppointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gP_AppointmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.gP_AppointmentDataGridView.DataSource = this.gP_AppointmentBindingSource;
            this.gP_AppointmentDataGridView.Location = new System.Drawing.Point(35, 19);
            this.gP_AppointmentDataGridView.Name = "gP_AppointmentDataGridView";
            this.gP_AppointmentDataGridView.Size = new System.Drawing.Size(860, 220);
            this.gP_AppointmentDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "GP Appointment Ref";
            this.dataGridViewTextBoxColumn1.HeaderText = "GP Appointment Ref";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Patient NHS Number";
            this.dataGridViewTextBoxColumn2.HeaderText = "Patient NHS Number";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EMIS Number";
            this.dataGridViewTextBoxColumn3.HeaderText = "EMIS Number";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GP Appointment";
            this.dataGridViewTextBoxColumn4.HeaderText = "GP Appointment";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Patient Full Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Patient Full Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Patient ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "Patient ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Medical Centre Name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Medical Centre Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Doctor\'s NHS No";
            this.dataGridViewTextBoxColumn8.HeaderText = "Doctor\'s NHS No";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(514, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 55);
            this.panel2.TabIndex = 18;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(447, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 41);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(308, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 41);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(161, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 41);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(18, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 41);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 560);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(gP_Appointment_RefLabel);
            this.Controls.Add(this.gP_Appointment_RefTextBox);
            this.Controls.Add(patient_NHS_NumberLabel);
            this.Controls.Add(this.patient_NHS_NumberTextBox);
            this.Controls.Add(eMIS_NumberLabel);
            this.Controls.Add(this.eMIS_NumberTextBox);
            this.Controls.Add(gP_AppointmentLabel);
            this.Controls.Add(this.gP_AppointmentTextBox);
            this.Controls.Add(patient_Full_NameLabel);
            this.Controls.Add(this.patient_Full_NameTextBox);
            this.Controls.Add(patient_IDLabel);
            this.Controls.Add(this.patient_IDTextBox);
            this.Controls.Add(medical_Centre_NameLabel);
            this.Controls.Add(this.medical_Centre_NameTextBox);
            this.Controls.Add(doctor_s_NHS_NoLabel);
            this.Controls.Add(this.doctor_s_NHS_NoTextBox);
            this.Controls.Add(this.gP_AppointmentBindingNavigator);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gP_AppointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gP_AppointmentBindingNavigator)).EndInit();
            this.gP_AppointmentBindingNavigator.ResumeLayout(false);
            this.gP_AppointmentBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gP_AppointmentDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource gP_AppointmentBindingSource;
        private PharmacyDataSetTableAdapters.GP_AppointmentTableAdapter gP_AppointmentTableAdapter;
        private PharmacyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator gP_AppointmentBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton gP_AppointmentBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox gP_Appointment_RefTextBox;
        private System.Windows.Forms.TextBox patient_NHS_NumberTextBox;
        private System.Windows.Forms.TextBox eMIS_NumberTextBox;
        private System.Windows.Forms.TextBox gP_AppointmentTextBox;
        private System.Windows.Forms.TextBox patient_Full_NameTextBox;
        private System.Windows.Forms.TextBox patient_IDTextBox;
        private System.Windows.Forms.TextBox medical_Centre_NameTextBox;
        private System.Windows.Forms.TextBox doctor_s_NHS_NoTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gP_AppointmentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
    }
}
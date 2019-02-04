namespace ProjectTeam08HospitalWFA
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.dataGridViewPrescriptions = new System.Windows.Forms.DataGridView();
            this.dataGridViewMedicine = new System.Windows.Forms.DataGridView();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.buttonAddNewPatient = new System.Windows.Forms.Button();
            this.buttonAddNewMedicine = new System.Windows.Forms.Button();
            this.labelPatientList = new System.Windows.Forms.Label();
            this.labelMedicineList = new System.Windows.Forms.Label();
            this.labelPrescriptionsList = new System.Windows.Forms.Label();
            this.buttonAdminExit = new System.Windows.Forms.Button();
            this.buttonAddNewPrescription = new System.Windows.Forms.Button();
            this.labelFilterBy = new System.Windows.Forms.Label();
            this.labelFiltPatient = new System.Windows.Forms.Label();
            this.textBoxFilterPatientID = new System.Windows.Forms.TextBox();
            this.labelDocIDfilt = new System.Windows.Forms.Label();
            this.textBoxFilterDocID = new System.Windows.Forms.TextBox();
            this.labelMedIDFilt = new System.Windows.Forms.Label();
            this.textBoxFilterMedID = new System.Windows.Forms.TextBox();
            this.labelBackground = new System.Windows.Forms.Label();
            this.buttonFilterPrescriptions = new System.Windows.Forms.Button();
            this.buttonSwitchToUserView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrescriptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPrescriptions
            // 
            this.dataGridViewPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrescriptions.Location = new System.Drawing.Point(22, 42);
            this.dataGridViewPrescriptions.Name = "dataGridViewPrescriptions";
            this.dataGridViewPrescriptions.Size = new System.Drawing.Size(395, 207);
            this.dataGridViewPrescriptions.TabIndex = 0;
            // 
            // dataGridViewMedicine
            // 
            this.dataGridViewMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedicine.Location = new System.Drawing.Point(590, 42);
            this.dataGridViewMedicine.Name = "dataGridViewMedicine";
            this.dataGridViewMedicine.Size = new System.Drawing.Size(294, 207);
            this.dataGridViewMedicine.TabIndex = 1;
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Location = new System.Drawing.Point(22, 324);
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.Size = new System.Drawing.Size(757, 234);
            this.dataGridViewPatients.TabIndex = 2;
            // 
            // buttonAddNewPatient
            // 
            this.buttonAddNewPatient.AutoSize = true;
            this.buttonAddNewPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewPatient.Location = new System.Drawing.Point(423, 100);
            this.buttonAddNewPatient.Name = "buttonAddNewPatient";
            this.buttonAddNewPatient.Size = new System.Drawing.Size(135, 27);
            this.buttonAddNewPatient.TabIndex = 3;
            this.buttonAddNewPatient.Text = "Add A New Patient";
            this.buttonAddNewPatient.UseVisualStyleBackColor = true;
            this.buttonAddNewPatient.Click += new System.EventHandler(this.buttonAddNewPatient_Click);
            // 
            // buttonAddNewMedicine
            // 
            this.buttonAddNewMedicine.AutoSize = true;
            this.buttonAddNewMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewMedicine.Location = new System.Drawing.Point(423, 161);
            this.buttonAddNewMedicine.Name = "buttonAddNewMedicine";
            this.buttonAddNewMedicine.Size = new System.Drawing.Size(147, 27);
            this.buttonAddNewMedicine.TabIndex = 4;
            this.buttonAddNewMedicine.Text = "Add A New Medicine";
            this.buttonAddNewMedicine.UseVisualStyleBackColor = true;
            this.buttonAddNewMedicine.Click += new System.EventHandler(this.buttonAddNewMedicine_Click);
            // 
            // labelPatientList
            // 
            this.labelPatientList.AutoSize = true;
            this.labelPatientList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelPatientList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPatientList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientList.Location = new System.Drawing.Point(22, 302);
            this.labelPatientList.Name = "labelPatientList";
            this.labelPatientList.Size = new System.Drawing.Size(80, 19);
            this.labelPatientList.TabIndex = 6;
            this.labelPatientList.Text = "Patient List";
            // 
            // labelMedicineList
            // 
            this.labelMedicineList.AutoSize = true;
            this.labelMedicineList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelMedicineList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMedicineList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedicineList.Location = new System.Drawing.Point(590, 9);
            this.labelMedicineList.Name = "labelMedicineList";
            this.labelMedicineList.Size = new System.Drawing.Size(92, 19);
            this.labelMedicineList.TabIndex = 7;
            this.labelMedicineList.Text = "Medicine List";
            // 
            // labelPrescriptionsList
            // 
            this.labelPrescriptionsList.AutoSize = true;
            this.labelPrescriptionsList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelPrescriptionsList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPrescriptionsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrescriptionsList.Location = new System.Drawing.Point(22, 9);
            this.labelPrescriptionsList.Name = "labelPrescriptionsList";
            this.labelPrescriptionsList.Size = new System.Drawing.Size(118, 19);
            this.labelPrescriptionsList.TabIndex = 8;
            this.labelPrescriptionsList.Text = "Prescriptions List";
            // 
            // buttonAdminExit
            // 
            this.buttonAdminExit.AutoSize = true;
            this.buttonAdminExit.BackColor = System.Drawing.Color.Red;
            this.buttonAdminExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdminExit.Location = new System.Drawing.Point(809, 519);
            this.buttonAdminExit.Name = "buttonAdminExit";
            this.buttonAdminExit.Size = new System.Drawing.Size(75, 27);
            this.buttonAdminExit.TabIndex = 9;
            this.buttonAdminExit.Text = "Exit";
            this.buttonAdminExit.UseVisualStyleBackColor = false;
            this.buttonAdminExit.Click += new System.EventHandler(this.buttonAdminExit_Click);
            // 
            // buttonAddNewPrescription
            // 
            this.buttonAddNewPrescription.AutoSize = true;
            this.buttonAddNewPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewPrescription.Location = new System.Drawing.Point(423, 219);
            this.buttonAddNewPrescription.Name = "buttonAddNewPrescription";
            this.buttonAddNewPrescription.Size = new System.Drawing.Size(166, 27);
            this.buttonAddNewPrescription.TabIndex = 10;
            this.buttonAddNewPrescription.Text = "Add A New Prescription";
            this.buttonAddNewPrescription.UseVisualStyleBackColor = true;
            this.buttonAddNewPrescription.Click += new System.EventHandler(this.buttonAddNewPrescription_Click);
            // 
            // labelFilterBy
            // 
            this.labelFilterBy.AutoSize = true;
            this.labelFilterBy.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelFilterBy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilterBy.Location = new System.Drawing.Point(22, 265);
            this.labelFilterBy.Name = "labelFilterBy";
            this.labelFilterBy.Size = new System.Drawing.Size(65, 19);
            this.labelFilterBy.TabIndex = 11;
            this.labelFilterBy.Text = "Filter By:";
            // 
            // labelFiltPatient
            // 
            this.labelFiltPatient.AutoSize = true;
            this.labelFiltPatient.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelFiltPatient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFiltPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltPatient.Location = new System.Drawing.Point(93, 265);
            this.labelFiltPatient.Name = "labelFiltPatient";
            this.labelFiltPatient.Size = new System.Drawing.Size(75, 19);
            this.labelFiltPatient.TabIndex = 12;
            this.labelFiltPatient.Text = "Patient ID:";
            // 
            // textBoxFilterPatientID
            // 
            this.textBoxFilterPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFilterPatientID.Location = new System.Drawing.Point(171, 263);
            this.textBoxFilterPatientID.Name = "textBoxFilterPatientID";
            this.textBoxFilterPatientID.Size = new System.Drawing.Size(100, 23);
            this.textBoxFilterPatientID.TabIndex = 13;
            // 
            // labelDocIDfilt
            // 
            this.labelDocIDfilt.AutoSize = true;
            this.labelDocIDfilt.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelDocIDfilt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDocIDfilt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDocIDfilt.Location = new System.Drawing.Point(277, 264);
            this.labelDocIDfilt.Name = "labelDocIDfilt";
            this.labelDocIDfilt.Size = new System.Drawing.Size(73, 19);
            this.labelDocIDfilt.TabIndex = 14;
            this.labelDocIDfilt.Text = "Doctor ID:";
            // 
            // textBoxFilterDocID
            // 
            this.textBoxFilterDocID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFilterDocID.Location = new System.Drawing.Point(353, 262);
            this.textBoxFilterDocID.Name = "textBoxFilterDocID";
            this.textBoxFilterDocID.Size = new System.Drawing.Size(100, 23);
            this.textBoxFilterDocID.TabIndex = 15;
            // 
            // labelMedIDFilt
            // 
            this.labelMedIDFilt.AutoSize = true;
            this.labelMedIDFilt.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelMedIDFilt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMedIDFilt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedIDFilt.Location = new System.Drawing.Point(459, 264);
            this.labelMedIDFilt.Name = "labelMedIDFilt";
            this.labelMedIDFilt.Size = new System.Drawing.Size(87, 19);
            this.labelMedIDFilt.TabIndex = 16;
            this.labelMedIDFilt.Text = "Medicine ID:";
            // 
            // textBoxFilterMedID
            // 
            this.textBoxFilterMedID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFilterMedID.Location = new System.Drawing.Point(552, 262);
            this.textBoxFilterMedID.Name = "textBoxFilterMedID";
            this.textBoxFilterMedID.Size = new System.Drawing.Size(100, 23);
            this.textBoxFilterMedID.TabIndex = 17;
            // 
            // labelBackground
            // 
            this.labelBackground.BackColor = System.Drawing.SystemColors.MenuBar;
            this.labelBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBackground.Location = new System.Drawing.Point(13, 259);
            this.labelBackground.Name = "labelBackground";
            this.labelBackground.Size = new System.Drawing.Size(654, 30);
            this.labelBackground.TabIndex = 18;
            // 
            // buttonFilterPrescriptions
            // 
            this.buttonFilterPrescriptions.AutoSize = true;
            this.buttonFilterPrescriptions.BackColor = System.Drawing.SystemColors.Control;
            this.buttonFilterPrescriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilterPrescriptions.Location = new System.Drawing.Point(692, 260);
            this.buttonFilterPrescriptions.Name = "buttonFilterPrescriptions";
            this.buttonFilterPrescriptions.Size = new System.Drawing.Size(135, 27);
            this.buttonFilterPrescriptions.TabIndex = 19;
            this.buttonFilterPrescriptions.Text = "Filter Prescriptions";
            this.buttonFilterPrescriptions.UseVisualStyleBackColor = false;
            this.buttonFilterPrescriptions.Click += new System.EventHandler(this.buttonFilterPrescriptions_Click);
            // 
            // buttonSwitchToUserView
            // 
            this.buttonSwitchToUserView.AutoSize = true;
            this.buttonSwitchToUserView.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSwitchToUserView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSwitchToUserView.Location = new System.Drawing.Point(424, 42);
            this.buttonSwitchToUserView.Name = "buttonSwitchToUserView";
            this.buttonSwitchToUserView.Size = new System.Drawing.Size(146, 27);
            this.buttonSwitchToUserView.TabIndex = 20;
            this.buttonSwitchToUserView.Text = "Switch To User View";
            this.buttonSwitchToUserView.UseVisualStyleBackColor = false;
            this.buttonSwitchToUserView.Click += new System.EventHandler(this.buttonSwitchToUserView_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(898, 570);
            this.Controls.Add(this.buttonSwitchToUserView);
            this.Controls.Add(this.buttonFilterPrescriptions);
            this.Controls.Add(this.textBoxFilterMedID);
            this.Controls.Add(this.labelMedIDFilt);
            this.Controls.Add(this.textBoxFilterDocID);
            this.Controls.Add(this.labelDocIDfilt);
            this.Controls.Add(this.textBoxFilterPatientID);
            this.Controls.Add(this.labelFiltPatient);
            this.Controls.Add(this.labelFilterBy);
            this.Controls.Add(this.buttonAddNewPrescription);
            this.Controls.Add(this.buttonAdminExit);
            this.Controls.Add(this.labelPrescriptionsList);
            this.Controls.Add(this.labelMedicineList);
            this.Controls.Add(this.labelPatientList);
            this.Controls.Add(this.buttonAddNewMedicine);
            this.Controls.Add(this.buttonAddNewPatient);
            this.Controls.Add(this.dataGridViewPatients);
            this.Controls.Add(this.dataGridViewMedicine);
            this.Controls.Add(this.dataGridViewPrescriptions);
            this.Controls.Add(this.labelBackground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrescriptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPrescriptions;
        private System.Windows.Forms.DataGridView dataGridViewMedicine;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.Button buttonAddNewPatient;
        private System.Windows.Forms.Button buttonAddNewMedicine;
        private System.Windows.Forms.Label labelPatientList;
        private System.Windows.Forms.Label labelMedicineList;
        private System.Windows.Forms.Label labelPrescriptionsList;
        private System.Windows.Forms.Button buttonAdminExit;
        private System.Windows.Forms.Button buttonAddNewPrescription;
        private System.Windows.Forms.Label labelFilterBy;
        private System.Windows.Forms.Label labelFiltPatient;
        private System.Windows.Forms.TextBox textBoxFilterPatientID;
        private System.Windows.Forms.Label labelDocIDfilt;
        private System.Windows.Forms.TextBox textBoxFilterDocID;
        private System.Windows.Forms.Label labelMedIDFilt;
        private System.Windows.Forms.TextBox textBoxFilterMedID;
        private System.Windows.Forms.Label labelBackground;
        private System.Windows.Forms.Button buttonFilterPrescriptions;
        private System.Windows.Forms.Button buttonSwitchToUserView;
    }
}
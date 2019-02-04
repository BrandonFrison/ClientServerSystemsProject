namespace ProjectTeam08HospitalWFA
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.dataGridViewDoctors = new System.Windows.Forms.DataGridView();
            this.dataGridViewPrescriptions = new System.Windows.Forms.DataGridView();
            this.labelDoctorList = new System.Windows.Forms.Label();
            this.labelPrescriptionList = new System.Windows.Forms.Label();
            this.buttonFillGridViews = new System.Windows.Forms.Button();
            this.textBoxPatientIdInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUserExit = new System.Windows.Forms.Button();
            this.labelMedlist = new System.Windows.Forms.Label();
            this.dataGridViewMedicineList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrescriptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicineList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDoctors
            // 
            this.dataGridViewDoctors.AllowUserToAddRows = false;
            this.dataGridViewDoctors.AllowUserToDeleteRows = false;
            this.dataGridViewDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctors.Location = new System.Drawing.Point(12, 43);
            this.dataGridViewDoctors.Name = "dataGridViewDoctors";
            this.dataGridViewDoctors.ReadOnly = true;
            this.dataGridViewDoctors.Size = new System.Drawing.Size(431, 137);
            this.dataGridViewDoctors.TabIndex = 0;
            // 
            // dataGridViewPrescriptions
            // 
            this.dataGridViewPrescriptions.AllowUserToAddRows = false;
            this.dataGridViewPrescriptions.AllowUserToDeleteRows = false;
            this.dataGridViewPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrescriptions.Location = new System.Drawing.Point(464, 43);
            this.dataGridViewPrescriptions.Name = "dataGridViewPrescriptions";
            this.dataGridViewPrescriptions.ReadOnly = true;
            this.dataGridViewPrescriptions.Size = new System.Drawing.Size(414, 252);
            this.dataGridViewPrescriptions.TabIndex = 1;
            // 
            // labelDoctorList
            // 
            this.labelDoctorList.AutoSize = true;
            this.labelDoctorList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelDoctorList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDoctorList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDoctorList.Location = new System.Drawing.Point(12, 13);
            this.labelDoctorList.Name = "labelDoctorList";
            this.labelDoctorList.Size = new System.Drawing.Size(78, 19);
            this.labelDoctorList.TabIndex = 2;
            this.labelDoctorList.Text = "Doctor List";
            // 
            // labelPrescriptionList
            // 
            this.labelPrescriptionList.AutoSize = true;
            this.labelPrescriptionList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelPrescriptionList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPrescriptionList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrescriptionList.Location = new System.Drawing.Point(464, 13);
            this.labelPrescriptionList.Name = "labelPrescriptionList";
            this.labelPrescriptionList.Size = new System.Drawing.Size(111, 19);
            this.labelPrescriptionList.TabIndex = 3;
            this.labelPrescriptionList.Text = "Prescription List";
            // 
            // buttonFillGridViews
            // 
            this.buttonFillGridViews.AutoSize = true;
            this.buttonFillGridViews.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFillGridViews.Location = new System.Drawing.Point(338, 480);
            this.buttonFillGridViews.Name = "buttonFillGridViews";
            this.buttonFillGridViews.Size = new System.Drawing.Size(217, 27);
            this.buttonFillGridViews.TabIndex = 4;
            this.buttonFillGridViews.Text = "Check Doctor and Prescriptions";
            this.buttonFillGridViews.UseVisualStyleBackColor = true;
            this.buttonFillGridViews.Click += new System.EventHandler(this.buttonFillGridViews_Click);
            // 
            // textBoxPatientIdInput
            // 
            this.textBoxPatientIdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPatientIdInput.Location = new System.Drawing.Point(348, 447);
            this.textBoxPatientIdInput.Name = "textBoxPatientIdInput";
            this.textBoxPatientIdInput.Size = new System.Drawing.Size(190, 23);
            this.textBoxPatientIdInput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Your Patient ID Here:";
            // 
            // buttonUserExit
            // 
            this.buttonUserExit.AutoSize = true;
            this.buttonUserExit.BackColor = System.Drawing.Color.Red;
            this.buttonUserExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUserExit.Location = new System.Drawing.Point(803, 542);
            this.buttonUserExit.Name = "buttonUserExit";
            this.buttonUserExit.Size = new System.Drawing.Size(75, 27);
            this.buttonUserExit.TabIndex = 7;
            this.buttonUserExit.Text = "Exit";
            this.buttonUserExit.UseVisualStyleBackColor = false;
            this.buttonUserExit.Click += new System.EventHandler(this.buttonUserExit_Click);
            // 
            // labelMedlist
            // 
            this.labelMedlist.AutoSize = true;
            this.labelMedlist.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelMedlist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMedlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedlist.Location = new System.Drawing.Point(12, 187);
            this.labelMedlist.Name = "labelMedlist";
            this.labelMedlist.Size = new System.Drawing.Size(92, 19);
            this.labelMedlist.TabIndex = 8;
            this.labelMedlist.Text = "Medicine List";
            // 
            // dataGridViewMedicineList
            // 
            this.dataGridViewMedicineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedicineList.Location = new System.Drawing.Point(12, 215);
            this.dataGridViewMedicineList.Name = "dataGridViewMedicineList";
            this.dataGridViewMedicineList.Size = new System.Drawing.Size(431, 144);
            this.dataGridViewMedicineList.TabIndex = 9;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(890, 577);
            this.Controls.Add(this.dataGridViewMedicineList);
            this.Controls.Add(this.labelMedlist);
            this.Controls.Add(this.buttonUserExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPatientIdInput);
            this.Controls.Add(this.buttonFillGridViews);
            this.Controls.Add(this.labelPrescriptionList);
            this.Controls.Add(this.labelDoctorList);
            this.Controls.Add(this.dataGridViewPrescriptions);
            this.Controls.Add(this.dataGridViewDoctors);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "User";
            this.Text = "User";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrescriptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicineList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDoctors;
        private System.Windows.Forms.DataGridView dataGridViewPrescriptions;
        private System.Windows.Forms.Label labelDoctorList;
        private System.Windows.Forms.Label labelPrescriptionList;
        private System.Windows.Forms.Button buttonFillGridViews;
        private System.Windows.Forms.TextBox textBoxPatientIdInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUserExit;
        private System.Windows.Forms.Label labelMedlist;
        private System.Windows.Forms.DataGridView dataGridViewMedicineList;
    }
}
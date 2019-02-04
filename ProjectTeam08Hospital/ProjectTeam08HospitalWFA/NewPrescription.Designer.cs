namespace ProjectTeam08HospitalWFA
{
    partial class NewPrescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPrescription));
            this.buttonInsertNewPrescription = new System.Windows.Forms.Button();
            this.labelEnterDocID = new System.Windows.Forms.Label();
            this.textBoxDoctorID = new System.Windows.Forms.TextBox();
            this.labelMedicineID = new System.Windows.Forms.Label();
            this.textBoxMedicineID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPatientID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonInsertNewPrescription
            // 
            this.buttonInsertNewPrescription.AutoSize = true;
            this.buttonInsertNewPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertNewPrescription.Location = new System.Drawing.Point(137, 216);
            this.buttonInsertNewPrescription.Name = "buttonInsertNewPrescription";
            this.buttonInsertNewPrescription.Size = new System.Drawing.Size(163, 27);
            this.buttonInsertNewPrescription.TabIndex = 0;
            this.buttonInsertNewPrescription.Text = "Insert New Prescription";
            this.buttonInsertNewPrescription.UseVisualStyleBackColor = true;
            this.buttonInsertNewPrescription.Click += new System.EventHandler(this.buttonInsertNewPrescription_Click);
            // 
            // labelEnterDocID
            // 
            this.labelEnterDocID.AutoSize = true;
            this.labelEnterDocID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelEnterDocID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterDocID.Location = new System.Drawing.Point(13, 13);
            this.labelEnterDocID.Name = "labelEnterDocID";
            this.labelEnterDocID.Size = new System.Drawing.Size(111, 19);
            this.labelEnterDocID.TabIndex = 1;
            this.labelEnterDocID.Text = "Enter Doctor ID:";
            // 
            // textBoxDoctorID
            // 
            this.textBoxDoctorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDoctorID.Location = new System.Drawing.Point(187, 11);
            this.textBoxDoctorID.Name = "textBoxDoctorID";
            this.textBoxDoctorID.Size = new System.Drawing.Size(245, 23);
            this.textBoxDoctorID.TabIndex = 2;
            // 
            // labelMedicineID
            // 
            this.labelMedicineID.AutoSize = true;
            this.labelMedicineID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMedicineID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedicineID.Location = new System.Drawing.Point(13, 64);
            this.labelMedicineID.Name = "labelMedicineID";
            this.labelMedicineID.Size = new System.Drawing.Size(129, 19);
            this.labelMedicineID.TabIndex = 5;
            this.labelMedicineID.Text = "Enter Medicine ID: ";
            // 
            // textBoxMedicineID
            // 
            this.textBoxMedicineID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMedicineID.Location = new System.Drawing.Point(187, 62);
            this.textBoxMedicineID.Name = "textBoxMedicineID";
            this.textBoxMedicineID.Size = new System.Drawing.Size(245, 23);
            this.textBoxMedicineID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Patient ID: ";
            // 
            // textBoxPatientID
            // 
            this.textBoxPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPatientID.Location = new System.Drawing.Point(187, 117);
            this.textBoxPatientID.Name = "textBoxPatientID";
            this.textBoxPatientID.Size = new System.Drawing.Size(245, 23);
            this.textBoxPatientID.TabIndex = 4;
            // 
            // NewPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(444, 286);
            this.Controls.Add(this.textBoxPatientID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMedicineID);
            this.Controls.Add(this.labelMedicineID);
            this.Controls.Add(this.textBoxDoctorID);
            this.Controls.Add(this.labelEnterDocID);
            this.Controls.Add(this.buttonInsertNewPrescription);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewPrescription";
            this.Text = "NewPrescription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInsertNewPrescription;
        private System.Windows.Forms.Label labelEnterDocID;
        private System.Windows.Forms.TextBox textBoxDoctorID;
        private System.Windows.Forms.Label labelMedicineID;
        private System.Windows.Forms.TextBox textBoxMedicineID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPatientID;
    }
}
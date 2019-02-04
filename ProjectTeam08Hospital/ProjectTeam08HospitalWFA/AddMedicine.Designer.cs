namespace ProjectTeam08HospitalWFA
{
    partial class AddMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMedicine));
            this.labelMedicineName = new System.Windows.Forms.Label();
            this.textBoxMedicineName = new System.Windows.Forms.TextBox();
            this.labelAmountInStock = new System.Windows.Forms.Label();
            this.textBoxAmountInStock = new System.Windows.Forms.TextBox();
            this.buttonInsertMedicine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMedicineName
            // 
            this.labelMedicineName.AutoSize = true;
            this.labelMedicineName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMedicineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedicineName.Location = new System.Drawing.Point(13, 13);
            this.labelMedicineName.Name = "labelMedicineName";
            this.labelMedicineName.Size = new System.Drawing.Size(153, 19);
            this.labelMedicineName.TabIndex = 0;
            this.labelMedicineName.Text = "Enter Medicine Name: ";
            // 
            // textBoxMedicineName
            // 
            this.textBoxMedicineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMedicineName.Location = new System.Drawing.Point(195, 11);
            this.textBoxMedicineName.Name = "textBoxMedicineName";
            this.textBoxMedicineName.Size = new System.Drawing.Size(181, 23);
            this.textBoxMedicineName.TabIndex = 1;
            // 
            // labelAmountInStock
            // 
            this.labelAmountInStock.AutoSize = true;
            this.labelAmountInStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAmountInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmountInStock.Location = new System.Drawing.Point(13, 55);
            this.labelAmountInStock.Name = "labelAmountInStock";
            this.labelAmountInStock.Size = new System.Drawing.Size(158, 19);
            this.labelAmountInStock.TabIndex = 3;
            this.labelAmountInStock.Text = "Enter Amount in Stock: ";
            // 
            // textBoxAmountInStock
            // 
            this.textBoxAmountInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAmountInStock.Location = new System.Drawing.Point(195, 53);
            this.textBoxAmountInStock.Name = "textBoxAmountInStock";
            this.textBoxAmountInStock.Size = new System.Drawing.Size(181, 23);
            this.textBoxAmountInStock.TabIndex = 2;
            // 
            // buttonInsertMedicine
            // 
            this.buttonInsertMedicine.AutoSize = true;
            this.buttonInsertMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertMedicine.Location = new System.Drawing.Point(121, 146);
            this.buttonInsertMedicine.Name = "buttonInsertMedicine";
            this.buttonInsertMedicine.Size = new System.Drawing.Size(144, 27);
            this.buttonInsertMedicine.TabIndex = 4;
            this.buttonInsertMedicine.Text = "Insert New Medicine";
            this.buttonInsertMedicine.UseVisualStyleBackColor = true;
            this.buttonInsertMedicine.Click += new System.EventHandler(this.buttonInsertMedicine_Click);
            // 
            // AddMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(401, 236);
            this.Controls.Add(this.buttonInsertMedicine);
            this.Controls.Add(this.textBoxAmountInStock);
            this.Controls.Add(this.labelAmountInStock);
            this.Controls.Add(this.textBoxMedicineName);
            this.Controls.Add(this.labelMedicineName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddMedicine";
            this.Text = "AddMedicine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMedicineName;
        private System.Windows.Forms.TextBox textBoxMedicineName;
        private System.Windows.Forms.Label labelAmountInStock;
        private System.Windows.Forms.TextBox textBoxAmountInStock;
        private System.Windows.Forms.Button buttonInsertMedicine;
    }
}
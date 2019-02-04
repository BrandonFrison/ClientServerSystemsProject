namespace AS1ProjectTeam08
{
    partial class FormHousePurchase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonGetListings = new System.Windows.Forms.Button();
            this.dataGridViewAllListings = new System.Windows.Forms.DataGridView();
            this.ColumnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNeighborhood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBRs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelListings = new System.Windows.Forms.Label();
            this.labelListingsCount = new System.Windows.Forms.Label();
            this.labelListingsCountNum = new System.Windows.Forms.Label();
            this.labelListingsAveragePrice = new System.Windows.Forms.Label();
            this.labelListingsAverageNum = new System.Windows.Forms.Label();
            this.labelDesiredAttributes = new System.Windows.Forms.Label();
            this.groupBoxHousingType = new System.Windows.Forms.GroupBox();
            this.radioButtonHouse = new System.Windows.Forms.RadioButton();
            this.radioButtonTownHouse = new System.Windows.Forms.RadioButton();
            this.radioButtonCondo = new System.Windows.Forms.RadioButton();
            this.labelMaximumPrice = new System.Windows.Forms.Label();
            this.textBoxMaxPrice = new System.Windows.Forms.TextBox();
            this.labelBedrooms = new System.Windows.Forms.Label();
            this.textBoxBedrooms = new System.Windows.Forms.TextBox();
            this.labelSuitableHomes = new System.Windows.Forms.Label();
            this.buttonFindHouses = new System.Windows.Forms.Button();
            this.dataGridViewFiltered = new System.Windows.Forms.DataGridView();
            this.Column2Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2Neighborhood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2BRs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelFilteredCount = new System.Windows.Forms.Label();
            this.labelFilteredAverage = new System.Windows.Forms.Label();
            this.labelFilteredAverageNum = new System.Windows.Forms.Label();
            this.labelFilteredCountNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllListings)).BeginInit();
            this.groupBoxHousingType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiltered)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGetListings
            // 
            this.buttonGetListings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetListings.Location = new System.Drawing.Point(51, 87);
            this.buttonGetListings.Name = "buttonGetListings";
            this.buttonGetListings.Size = new System.Drawing.Size(103, 49);
            this.buttonGetListings.TabIndex = 0;
            this.buttonGetListings.Text = "Get Listings";
            this.buttonGetListings.UseVisualStyleBackColor = true;
            this.buttonGetListings.Click += new System.EventHandler(this.buttonGetListings_Click);
            // 
            // dataGridViewAllListings
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewAllListings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAllListings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAllListings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllListings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCode,
            this.ColumnType,
            this.ColumnNeighborhood,
            this.ColumnPrice,
            this.ColumnBRs});
            this.dataGridViewAllListings.Location = new System.Drawing.Point(189, 59);
            this.dataGridViewAllListings.Name = "dataGridViewAllListings";
            this.dataGridViewAllListings.ReadOnly = true;
            this.dataGridViewAllListings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewAllListings.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewAllListings.Size = new System.Drawing.Size(667, 205);
            this.dataGridViewAllListings.TabIndex = 1;
            // 
            // ColumnCode
            // 
            this.ColumnCode.HeaderText = "Code";
            this.ColumnCode.Name = "ColumnCode";
            this.ColumnCode.ReadOnly = true;
            // 
            // ColumnType
            // 
            this.ColumnType.HeaderText = "Type";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            // 
            // ColumnNeighborhood
            // 
            this.ColumnNeighborhood.HeaderText = "Neighborhood";
            this.ColumnNeighborhood.Name = "ColumnNeighborhood";
            this.ColumnNeighborhood.ReadOnly = true;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.HeaderText = "Price";
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            // 
            // ColumnBRs
            // 
            this.ColumnBRs.HeaderText = "BRs";
            this.ColumnBRs.Name = "ColumnBRs";
            this.ColumnBRs.ReadOnly = true;
            // 
            // labelListings
            // 
            this.labelListings.AutoSize = true;
            this.labelListings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListings.Location = new System.Drawing.Point(463, 9);
            this.labelListings.Name = "labelListings";
            this.labelListings.Size = new System.Drawing.Size(71, 20);
            this.labelListings.TabIndex = 2;
            this.labelListings.Text = "Listings";
            // 
            // labelListingsCount
            // 
            this.labelListingsCount.AutoSize = true;
            this.labelListingsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListingsCount.Location = new System.Drawing.Point(329, 290);
            this.labelListingsCount.Name = "labelListingsCount";
            this.labelListingsCount.Size = new System.Drawing.Size(39, 15);
            this.labelListingsCount.TabIndex = 3;
            this.labelListingsCount.Text = "Count";
            // 
            // labelListingsCountNum
            // 
            this.labelListingsCountNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelListingsCountNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListingsCountNum.Location = new System.Drawing.Point(390, 291);
            this.labelListingsCountNum.Name = "labelListingsCountNum";
            this.labelListingsCountNum.Size = new System.Drawing.Size(83, 22);
            this.labelListingsCountNum.TabIndex = 4;
            this.labelListingsCountNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelListingsAveragePrice
            // 
            this.labelListingsAveragePrice.AutoSize = true;
            this.labelListingsAveragePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListingsAveragePrice.Location = new System.Drawing.Point(544, 292);
            this.labelListingsAveragePrice.Name = "labelListingsAveragePrice";
            this.labelListingsAveragePrice.Size = new System.Drawing.Size(82, 15);
            this.labelListingsAveragePrice.TabIndex = 5;
            this.labelListingsAveragePrice.Text = "Average Price";
            // 
            // labelListingsAverageNum
            // 
            this.labelListingsAverageNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelListingsAverageNum.Location = new System.Drawing.Point(665, 292);
            this.labelListingsAverageNum.Name = "labelListingsAverageNum";
            this.labelListingsAverageNum.Size = new System.Drawing.Size(142, 23);
            this.labelListingsAverageNum.TabIndex = 6;
            this.labelListingsAverageNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDesiredAttributes
            // 
            this.labelDesiredAttributes.AutoSize = true;
            this.labelDesiredAttributes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesiredAttributes.Location = new System.Drawing.Point(354, 340);
            this.labelDesiredAttributes.Name = "labelDesiredAttributes";
            this.labelDesiredAttributes.Size = new System.Drawing.Size(155, 20);
            this.labelDesiredAttributes.TabIndex = 7;
            this.labelDesiredAttributes.Text = "Desired Attributes";
            // 
            // groupBoxHousingType
            // 
            this.groupBoxHousingType.Controls.Add(this.radioButtonHouse);
            this.groupBoxHousingType.Controls.Add(this.radioButtonTownHouse);
            this.groupBoxHousingType.Controls.Add(this.radioButtonCondo);
            this.groupBoxHousingType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxHousingType.Location = new System.Drawing.Point(51, 368);
            this.groupBoxHousingType.Name = "groupBoxHousingType";
            this.groupBoxHousingType.Size = new System.Drawing.Size(290, 54);
            this.groupBoxHousingType.TabIndex = 8;
            this.groupBoxHousingType.TabStop = false;
            this.groupBoxHousingType.Text = "Housing Type";
            // 
            // radioButtonHouse
            // 
            this.radioButtonHouse.AutoSize = true;
            this.radioButtonHouse.Location = new System.Drawing.Point(173, 22);
            this.radioButtonHouse.Name = "radioButtonHouse";
            this.radioButtonHouse.Size = new System.Drawing.Size(61, 19);
            this.radioButtonHouse.TabIndex = 2;
            this.radioButtonHouse.TabStop = true;
            this.radioButtonHouse.Text = "House";
            this.radioButtonHouse.UseVisualStyleBackColor = true;
            // 
            // radioButtonTownHouse
            // 
            this.radioButtonTownHouse.AutoSize = true;
            this.radioButtonTownHouse.Location = new System.Drawing.Point(75, 21);
            this.radioButtonTownHouse.Name = "radioButtonTownHouse";
            this.radioButtonTownHouse.Size = new System.Drawing.Size(91, 19);
            this.radioButtonTownHouse.TabIndex = 1;
            this.radioButtonTownHouse.TabStop = true;
            this.radioButtonTownHouse.Text = "TownHouse";
            this.radioButtonTownHouse.UseVisualStyleBackColor = true;
            // 
            // radioButtonCondo
            // 
            this.radioButtonCondo.AutoSize = true;
            this.radioButtonCondo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCondo.Location = new System.Drawing.Point(7, 20);
            this.radioButtonCondo.Name = "radioButtonCondo";
            this.radioButtonCondo.Size = new System.Drawing.Size(61, 19);
            this.radioButtonCondo.TabIndex = 0;
            this.radioButtonCondo.TabStop = true;
            this.radioButtonCondo.Text = "Condo";
            this.radioButtonCondo.UseVisualStyleBackColor = true;
            // 
            // labelMaximumPrice
            // 
            this.labelMaximumPrice.AutoSize = true;
            this.labelMaximumPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaximumPrice.Location = new System.Drawing.Point(355, 388);
            this.labelMaximumPrice.Name = "labelMaximumPrice";
            this.labelMaximumPrice.Size = new System.Drawing.Size(94, 15);
            this.labelMaximumPrice.TabIndex = 9;
            this.labelMaximumPrice.Text = "Maximum Price";
            // 
            // textBoxMaxPrice
            // 
            this.textBoxMaxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaxPrice.Location = new System.Drawing.Point(455, 388);
            this.textBoxMaxPrice.Name = "textBoxMaxPrice";
            this.textBoxMaxPrice.Size = new System.Drawing.Size(100, 21);
            this.textBoxMaxPrice.TabIndex = 10;
            // 
            // labelBedrooms
            // 
            this.labelBedrooms.AutoSize = true;
            this.labelBedrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBedrooms.Location = new System.Drawing.Point(595, 388);
            this.labelBedrooms.Name = "labelBedrooms";
            this.labelBedrooms.Size = new System.Drawing.Size(64, 15);
            this.labelBedrooms.TabIndex = 11;
            this.labelBedrooms.Text = "Bedrooms";
            // 
            // textBoxBedrooms
            // 
            this.textBoxBedrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBedrooms.Location = new System.Drawing.Point(680, 386);
            this.textBoxBedrooms.Name = "textBoxBedrooms";
            this.textBoxBedrooms.Size = new System.Drawing.Size(57, 21);
            this.textBoxBedrooms.TabIndex = 12;
            // 
            // labelSuitableHomes
            // 
            this.labelSuitableHomes.AutoSize = true;
            this.labelSuitableHomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuitableHomes.Location = new System.Drawing.Point(413, 447);
            this.labelSuitableHomes.Name = "labelSuitableHomes";
            this.labelSuitableHomes.Size = new System.Drawing.Size(136, 20);
            this.labelSuitableHomes.TabIndex = 13;
            this.labelSuitableHomes.Text = "Suitable Homes";
            // 
            // buttonFindHouses
            // 
            this.buttonFindHouses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindHouses.Location = new System.Drawing.Point(51, 563);
            this.buttonFindHouses.Name = "buttonFindHouses";
            this.buttonFindHouses.Size = new System.Drawing.Size(103, 50);
            this.buttonFindHouses.TabIndex = 14;
            this.buttonFindHouses.Text = "Find Houses";
            this.buttonFindHouses.UseVisualStyleBackColor = true;
            this.buttonFindHouses.Click += new System.EventHandler(this.buttonFindHouses_Click);
            // 
            // dataGridViewFiltered
            // 
            this.dataGridViewFiltered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiltered.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2Code,
            this.Column2Type,
            this.Column2Neighborhood,
            this.Column2Price,
            this.Column2BRs});
            this.dataGridViewFiltered.Location = new System.Drawing.Point(189, 498);
            this.dataGridViewFiltered.Name = "dataGridViewFiltered";
            this.dataGridViewFiltered.ReadOnly = true;
            this.dataGridViewFiltered.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewFiltered.Size = new System.Drawing.Size(667, 205);
            this.dataGridViewFiltered.TabIndex = 15;
            // 
            // Column2Code
            // 
            this.Column2Code.HeaderText = "Code";
            this.Column2Code.Name = "Column2Code";
            this.Column2Code.ReadOnly = true;
            // 
            // Column2Type
            // 
            this.Column2Type.HeaderText = "Type";
            this.Column2Type.Name = "Column2Type";
            this.Column2Type.ReadOnly = true;
            // 
            // Column2Neighborhood
            // 
            this.Column2Neighborhood.HeaderText = "Neighborhood";
            this.Column2Neighborhood.Name = "Column2Neighborhood";
            this.Column2Neighborhood.ReadOnly = true;
            // 
            // Column2Price
            // 
            this.Column2Price.HeaderText = "Price";
            this.Column2Price.Name = "Column2Price";
            this.Column2Price.ReadOnly = true;
            // 
            // Column2BRs
            // 
            this.Column2BRs.HeaderText = "BRs";
            this.Column2BRs.Name = "Column2BRs";
            this.Column2BRs.ReadOnly = true;
            // 
            // labelFilteredCount
            // 
            this.labelFilteredCount.AutoSize = true;
            this.labelFilteredCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilteredCount.Location = new System.Drawing.Point(332, 737);
            this.labelFilteredCount.Name = "labelFilteredCount";
            this.labelFilteredCount.Size = new System.Drawing.Size(39, 15);
            this.labelFilteredCount.TabIndex = 16;
            this.labelFilteredCount.Text = "Count";
            // 
            // labelFilteredAverage
            // 
            this.labelFilteredAverage.AutoSize = true;
            this.labelFilteredAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilteredAverage.Location = new System.Drawing.Point(547, 737);
            this.labelFilteredAverage.Name = "labelFilteredAverage";
            this.labelFilteredAverage.Size = new System.Drawing.Size(82, 15);
            this.labelFilteredAverage.TabIndex = 17;
            this.labelFilteredAverage.Text = "Average Price";
            // 
            // labelFilteredAverageNum
            // 
            this.labelFilteredAverageNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFilteredAverageNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilteredAverageNum.Location = new System.Drawing.Point(665, 737);
            this.labelFilteredAverageNum.Name = "labelFilteredAverageNum";
            this.labelFilteredAverageNum.Size = new System.Drawing.Size(142, 23);
            this.labelFilteredAverageNum.TabIndex = 18;
            this.labelFilteredAverageNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFilteredCountNum
            // 
            this.labelFilteredCountNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFilteredCountNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilteredCountNum.Location = new System.Drawing.Point(390, 737);
            this.labelFilteredCountNum.Name = "labelFilteredCountNum";
            this.labelFilteredCountNum.Size = new System.Drawing.Size(83, 23);
            this.labelFilteredCountNum.TabIndex = 19;
            this.labelFilteredCountNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormHousePurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 804);
            this.Controls.Add(this.labelFilteredCountNum);
            this.Controls.Add(this.labelFilteredAverageNum);
            this.Controls.Add(this.labelFilteredAverage);
            this.Controls.Add(this.labelFilteredCount);
            this.Controls.Add(this.dataGridViewFiltered);
            this.Controls.Add(this.buttonFindHouses);
            this.Controls.Add(this.labelSuitableHomes);
            this.Controls.Add(this.textBoxBedrooms);
            this.Controls.Add(this.labelBedrooms);
            this.Controls.Add(this.textBoxMaxPrice);
            this.Controls.Add(this.labelMaximumPrice);
            this.Controls.Add(this.groupBoxHousingType);
            this.Controls.Add(this.labelDesiredAttributes);
            this.Controls.Add(this.labelListingsAverageNum);
            this.Controls.Add(this.labelListingsAveragePrice);
            this.Controls.Add(this.labelListingsCountNum);
            this.Controls.Add(this.labelListingsCount);
            this.Controls.Add(this.labelListings);
            this.Controls.Add(this.dataGridViewAllListings);
            this.Controls.Add(this.buttonGetListings);
            this.Name = "FormHousePurchase";
            this.Text = "House Purchase";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllListings)).EndInit();
            this.groupBoxHousingType.ResumeLayout(false);
            this.groupBoxHousingType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiltered)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetListings;
        private System.Windows.Forms.DataGridView dataGridViewAllListings;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNeighborhood;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBRs;
        private System.Windows.Forms.Label labelListings;
        private System.Windows.Forms.Label labelListingsCount;
        private System.Windows.Forms.Label labelListingsCountNum;
        private System.Windows.Forms.Label labelListingsAveragePrice;
        private System.Windows.Forms.Label labelListingsAverageNum;
        private System.Windows.Forms.Label labelDesiredAttributes;
        private System.Windows.Forms.GroupBox groupBoxHousingType;
        private System.Windows.Forms.RadioButton radioButtonHouse;
        private System.Windows.Forms.RadioButton radioButtonTownHouse;
        private System.Windows.Forms.RadioButton radioButtonCondo;
        private System.Windows.Forms.Label labelMaximumPrice;
        private System.Windows.Forms.TextBox textBoxMaxPrice;
        private System.Windows.Forms.Label labelBedrooms;
        private System.Windows.Forms.TextBox textBoxBedrooms;
        private System.Windows.Forms.Label labelSuitableHomes;
        private System.Windows.Forms.Button buttonFindHouses;
        private System.Windows.Forms.DataGridView dataGridViewFiltered;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2Neighborhood;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2BRs;
        private System.Windows.Forms.Label labelFilteredCount;
        private System.Windows.Forms.Label labelFilteredAverage;
        private System.Windows.Forms.Label labelFilteredAverageNum;
        private System.Windows.Forms.Label labelFilteredCountNum;
    }
}


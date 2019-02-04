namespace ProjectTeam08HospitalWFA
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUserNameInput = new System.Windows.Forms.TextBox();
            this.textBoxPasswordInput = new System.Windows.Forms.TextBox();
            this.buttonSignInAsUser = new System.Windows.Forms.Button();
            this.buttonSignInAsAdmin = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelOr = new System.Windows.Forms.Label();
            this.buttonLoadDatabase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelUserName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(202, 127);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(89, 19);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "User Name: ";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(202, 193);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(79, 19);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password: ";
            // 
            // textBoxUserNameInput
            // 
            this.textBoxUserNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserNameInput.Location = new System.Drawing.Point(327, 125);
            this.textBoxUserNameInput.Name = "textBoxUserNameInput";
            this.textBoxUserNameInput.Size = new System.Drawing.Size(197, 23);
            this.textBoxUserNameInput.TabIndex = 2;
            // 
            // textBoxPasswordInput
            // 
            this.textBoxPasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordInput.Location = new System.Drawing.Point(327, 192);
            this.textBoxPasswordInput.Name = "textBoxPasswordInput";
            this.textBoxPasswordInput.PasswordChar = '*';
            this.textBoxPasswordInput.Size = new System.Drawing.Size(197, 23);
            this.textBoxPasswordInput.TabIndex = 3;
            // 
            // buttonSignInAsUser
            // 
            this.buttonSignInAsUser.AutoSize = true;
            this.buttonSignInAsUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignInAsUser.Location = new System.Drawing.Point(326, 388);
            this.buttonSignInAsUser.Name = "buttonSignInAsUser";
            this.buttonSignInAsUser.Size = new System.Drawing.Size(129, 27);
            this.buttonSignInAsUser.TabIndex = 4;
            this.buttonSignInAsUser.Text = "Sign In As Patient";
            this.buttonSignInAsUser.UseVisualStyleBackColor = true;
            this.buttonSignInAsUser.Click += new System.EventHandler(this.buttonSignInAsUser_Click);
            // 
            // buttonSignInAsAdmin
            // 
            this.buttonSignInAsAdmin.AutoSize = true;
            this.buttonSignInAsAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignInAsAdmin.Location = new System.Drawing.Point(326, 249);
            this.buttonSignInAsAdmin.Name = "buttonSignInAsAdmin";
            this.buttonSignInAsAdmin.Size = new System.Drawing.Size(127, 27);
            this.buttonSignInAsAdmin.TabIndex = 5;
            this.buttonSignInAsAdmin.Text = "Sign In As Doctor";
            this.buttonSignInAsAdmin.UseVisualStyleBackColor = true;
            this.buttonSignInAsAdmin.Click += new System.EventHandler(this.buttonSignInAsAdmin_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(219, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(377, 33);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Hospital Management System";
            // 
            // labelOr
            // 
            this.labelOr.AutoSize = true;
            this.labelOr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOr.Location = new System.Drawing.Point(374, 327);
            this.labelOr.Name = "labelOr";
            this.labelOr.Size = new System.Drawing.Size(29, 17);
            this.labelOr.TabIndex = 7;
            this.labelOr.Text = "OR";
            // 
            // buttonLoadDatabase
            // 
            this.buttonLoadDatabase.AutoSize = true;
            this.buttonLoadDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadDatabase.Location = new System.Drawing.Point(326, 71);
            this.buttonLoadDatabase.Name = "buttonLoadDatabase";
            this.buttonLoadDatabase.Size = new System.Drawing.Size(145, 27);
            this.buttonLoadDatabase.TabIndex = 8;
            this.buttonLoadDatabase.Text = "Populate Seed Data";
            this.buttonLoadDatabase.UseVisualStyleBackColor = true;
            this.buttonLoadDatabase.Click += new System.EventHandler(this.buttonLoadDatabase_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(805, 578);
            this.Controls.Add(this.buttonLoadDatabase);
            this.Controls.Add(this.labelOr);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonSignInAsAdmin);
            this.Controls.Add(this.buttonSignInAsUser);
            this.Controls.Add(this.textBoxPasswordInput);
            this.Controls.Add(this.textBoxUserNameInput);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUserNameInput;
        private System.Windows.Forms.TextBox textBoxPasswordInput;
        private System.Windows.Forms.Button buttonSignInAsUser;
        private System.Windows.Forms.Button buttonSignInAsAdmin;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelOr;
        private System.Windows.Forms.Button buttonLoadDatabase;
    }
}
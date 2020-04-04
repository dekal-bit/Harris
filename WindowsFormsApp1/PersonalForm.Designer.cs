namespace WindowsFormsApp1
{
    partial class PersonalForm
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
            this.DGBpersonal = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveSelected = new System.Windows.Forms.Button();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPostcode = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbCompany = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContactTel = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbConTel = new System.Windows.Forms.TextBox();
            this.tbHomeTel = new System.Windows.Forms.TextBox();
            this.lblHomeTelephone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGBpersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // DGBpersonal
            // 
            this.DGBpersonal.AllowUserToResizeColumns = false;
            this.DGBpersonal.AllowUserToResizeRows = false;
            this.DGBpersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGBpersonal.Location = new System.Drawing.Point(12, 212);
            this.DGBpersonal.Name = "DGBpersonal";
            this.DGBpersonal.ReadOnly = true;
            this.DGBpersonal.Size = new System.Drawing.Size(700, 233);
            this.DGBpersonal.TabIndex = 0;
            this.DGBpersonal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DGBpersonal_CellClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(474, 39);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(474, 68);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Enabled = false;
            this.btnSaveNew.Location = new System.Drawing.Point(474, 97);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNew.TabIndex = 3;
            this.btnSaveNew.Text = "Save New";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(474, 128);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update Selected";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(474, 157);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveSelected
            // 
            this.btnSaveSelected.Enabled = false;
            this.btnSaveSelected.Location = new System.Drawing.Point(462, 8);
            this.btnSaveSelected.Name = "btnSaveSelected";
            this.btnSaveSelected.Size = new System.Drawing.Size(97, 23);
            this.btnSaveSelected.TabIndex = 6;
            this.btnSaveSelected.Text = "Save Selected";
            this.btnSaveSelected.UseVisualStyleBackColor = true;
            this.btnSaveSelected.Click += new System.EventHandler(this.btnSaveSelected_Click);
            // 
            // tbFname
            // 
            this.tbFname.Enabled = false;
            this.tbFname.Location = new System.Drawing.Point(83, 10);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(100, 20);
            this.tbFname.TabIndex = 7;
            // 
            // tbLname
            // 
            this.tbLname.Enabled = false;
            this.tbLname.Location = new System.Drawing.Point(83, 42);
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(100, 20);
            this.tbLname.TabIndex = 8;
            // 
            // tbAddress
            // 
            this.tbAddress.Enabled = false;
            this.tbAddress.Location = new System.Drawing.Point(83, 71);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(100, 20);
            this.tbAddress.TabIndex = 9;
            // 
            // tbPostcode
            // 
            this.tbPostcode.Enabled = false;
            this.tbPostcode.Location = new System.Drawing.Point(83, 100);
            this.tbPostcode.Name = "tbPostcode";
            this.tbPostcode.Size = new System.Drawing.Size(100, 20);
            this.tbPostcode.TabIndex = 10;
            // 
            // tbCity
            // 
            this.tbCity.Enabled = false;
            this.tbCity.Location = new System.Drawing.Point(83, 126);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(100, 20);
            this.tbCity.TabIndex = 11;
            // 
            // tbCompany
            // 
            this.tbCompany.Enabled = false;
            this.tbCompany.Location = new System.Drawing.Point(83, 157);
            this.tbCompany.Name = "tbCompany";
            this.tbCompany.Size = new System.Drawing.Size(100, 20);
            this.tbCompany.TabIndex = 12;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(20, 10);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 13;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(20, 39);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 14;
            this.lblLastName.Text = "Last Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(20, 68);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 15;
            this.lblAddress.Text = "Address";
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Location = new System.Drawing.Point(20, 97);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(56, 13);
            this.lblPostCode.TabIndex = 16;
            this.lblPostCode.Text = "Post Code";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(20, 128);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 17;
            this.lblCity.Text = "City";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(20, 157);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(51, 13);
            this.lblCompany.TabIndex = 18;
            this.lblCompany.Text = "Company";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(278, 17);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email";
            // 
            // lblContactTel
            // 
            this.lblContactTel.AutoSize = true;
            this.lblContactTel.Location = new System.Drawing.Point(255, 51);
            this.lblContactTel.Name = "lblContactTel";
            this.lblContactTel.Size = new System.Drawing.Size(84, 13);
            this.lblContactTel.TabIndex = 20;
            this.lblContactTel.Text = "Contact Number";
            // 
            // tbEmail
            // 
            this.tbEmail.Enabled = false;
            this.tbEmail.Location = new System.Drawing.Point(345, 10);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 21;
            // 
            // tbConTel
            // 
            this.tbConTel.Enabled = false;
            this.tbConTel.Location = new System.Drawing.Point(345, 48);
            this.tbConTel.Name = "tbConTel";
            this.tbConTel.Size = new System.Drawing.Size(100, 20);
            this.tbConTel.TabIndex = 22;
            // 
            // tbHomeTel
            // 
            this.tbHomeTel.Enabled = false;
            this.tbHomeTel.Location = new System.Drawing.Point(345, 90);
            this.tbHomeTel.Name = "tbHomeTel";
            this.tbHomeTel.Size = new System.Drawing.Size(100, 20);
            this.tbHomeTel.TabIndex = 23;
            // 
            // lblHomeTelephone
            // 
            this.lblHomeTelephone.AutoSize = true;
            this.lblHomeTelephone.Location = new System.Drawing.Point(250, 90);
            this.lblHomeTelephone.Name = "lblHomeTelephone";
            this.lblHomeTelephone.Size = new System.Drawing.Size(89, 13);
            this.lblHomeTelephone.TabIndex = 24;
            this.lblHomeTelephone.Text = "Home Telephone";
            // 
            // PersonalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 448);
            this.Controls.Add(this.lblHomeTelephone);
            this.Controls.Add(this.tbHomeTel);
            this.Controls.Add(this.tbConTel);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblContactTel);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblPostCode);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.tbCompany);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbPostcode);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbLname);
            this.Controls.Add(this.tbFname);
            this.Controls.Add(this.btnSaveSelected);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.DGBpersonal);
            this.Name = "PersonalForm";
            this.Text = "PersonalForm";
            this.Load += new System.EventHandler(this.PersonalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGBpersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGBpersonal;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveSelected;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.TextBox tbLname;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbPostcode;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbCompany;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContactTel;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbConTel;
        private System.Windows.Forms.TextBox tbHomeTel;
        private System.Windows.Forms.Label lblHomeTelephone;
    }
}
namespace WindowsFormsApp1
{
    partial class BusinessForm
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
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.btnSaveSelected = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.TbBusinessName = new System.Windows.Forms.TextBox();
            this.TbOrder = new System.Windows.Forms.TextBox();
            this.TbAddress = new System.Windows.Forms.TextBox();
            this.TbPostcode = new System.Windows.Forms.TextBox();
            this.TbCity = new System.Windows.Forms.TextBox();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.TbBusinessTel = new System.Windows.Forms.TextBox();
            this.lblBusinessName = new System.Windows.Forms.Label();
            this.lblBusinessOrder = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBusinessTel = new System.Windows.Forms.Label();
            this.DBGbusiness = new System.Windows.Forms.DataGridView();
            this.btnMain = new System.Windows.Forms.Button();
            this.TbHomeTel = new System.Windows.Forms.TextBox();
            this.lblHomeTel = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.DBGbusiness)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Enabled = false;
            this.btnSaveNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSaveNew.Location = new System.Drawing.Point(694, 14);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNew.TabIndex = 0;
            this.btnSaveNew.Text = "Save Selected";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // btnSaveSelected
            // 
            this.btnSaveSelected.Enabled = false;
            this.btnSaveSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSaveSelected.Location = new System.Drawing.Point(694, 43);
            this.btnSaveSelected.Name = "btnSaveSelected";
            this.btnSaveSelected.Size = new System.Drawing.Size(96, 23);
            this.btnSaveSelected.TabIndex = 1;
            this.btnSaveSelected.Text = "Save Selected";
            this.btnSaveSelected.UseVisualStyleBackColor = true;
            this.btnSaveSelected.Click += new System.EventHandler(this.btnSaveSelected_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(613, 14);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnRefresh.Location = new System.Drawing.Point(694, 73);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnUpdate.Location = new System.Drawing.Point(613, 43);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnDelete.Location = new System.Drawing.Point(613, 73);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // TbBusinessName
            // 
            this.TbBusinessName.Enabled = false;
            this.TbBusinessName.Location = new System.Drawing.Point(148, 20);
            this.TbBusinessName.Name = "TbBusinessName";
            this.TbBusinessName.Size = new System.Drawing.Size(100, 20);
            this.TbBusinessName.TabIndex = 6;
            // 
            // TbOrder
            // 
            this.TbOrder.Enabled = false;
            this.TbOrder.Location = new System.Drawing.Point(148, 57);
            this.TbOrder.Name = "TbOrder";
            this.TbOrder.Size = new System.Drawing.Size(100, 20);
            this.TbOrder.TabIndex = 7;
            // 
            // TbAddress
            // 
            this.TbAddress.Enabled = false;
            this.TbAddress.Location = new System.Drawing.Point(148, 86);
            this.TbAddress.Name = "TbAddress";
            this.TbAddress.Size = new System.Drawing.Size(100, 20);
            this.TbAddress.TabIndex = 8;
            // 
            // TbPostcode
            // 
            this.TbPostcode.Enabled = false;
            this.TbPostcode.Location = new System.Drawing.Point(148, 113);
            this.TbPostcode.Name = "TbPostcode";
            this.TbPostcode.Size = new System.Drawing.Size(100, 20);
            this.TbPostcode.TabIndex = 9;
            // 
            // TbCity
            // 
            this.TbCity.Enabled = false;
            this.TbCity.Location = new System.Drawing.Point(148, 139);
            this.TbCity.Name = "TbCity";
            this.TbCity.Size = new System.Drawing.Size(100, 20);
            this.TbCity.TabIndex = 10;
            // 
            // TbEmail
            // 
            this.TbEmail.Enabled = false;
            this.TbEmail.Location = new System.Drawing.Point(148, 175);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(100, 20);
            this.TbEmail.TabIndex = 11;
            this.TbEmail.TextChanged += new System.EventHandler(this.TbEmail_TextChanged);
            // 
            // TbBusinessTel
            // 
            this.TbBusinessTel.Enabled = false;
            this.TbBusinessTel.Location = new System.Drawing.Point(423, 16);
            this.TbBusinessTel.Name = "TbBusinessTel";
            this.TbBusinessTel.Size = new System.Drawing.Size(100, 20);
            this.TbBusinessTel.TabIndex = 12;
            // 
            // lblBusinessName
            // 
            this.lblBusinessName.AutoSize = true;
            this.lblBusinessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusinessName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBusinessName.Location = new System.Drawing.Point(12, 24);
            this.lblBusinessName.Name = "lblBusinessName";
            this.lblBusinessName.Size = new System.Drawing.Size(116, 16);
            this.lblBusinessName.TabIndex = 14;
            this.lblBusinessName.Text = "Business Name";
            // 
            // lblBusinessOrder
            // 
            this.lblBusinessOrder.AutoSize = true;
            this.lblBusinessOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblBusinessOrder.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBusinessOrder.Location = new System.Drawing.Point(12, 61);
            this.lblBusinessOrder.Name = "lblBusinessOrder";
            this.lblBusinessOrder.Size = new System.Drawing.Size(47, 16);
            this.lblBusinessOrder.TabIndex = 15;
            this.lblBusinessOrder.Text = "Order";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAddress.Location = new System.Drawing.Point(12, 90);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(66, 16);
            this.lblAddress.TabIndex = 16;
            this.lblAddress.Text = "Address";
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPostcode.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPostcode.Location = new System.Drawing.Point(12, 117);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(74, 16);
            this.lblPostcode.TabIndex = 17;
            this.lblPostcode.Text = "Postcode";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblCity.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCity.Location = new System.Drawing.Point(12, 143);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(34, 16);
            this.lblCity.TabIndex = 18;
            this.lblCity.Text = "City";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblEmail.Location = new System.Drawing.Point(12, 179);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 16);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblBusinessTel
            // 
            this.lblBusinessTel.AutoSize = true;
            this.lblBusinessTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblBusinessTel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBusinessTel.Location = new System.Drawing.Point(267, 20);
            this.lblBusinessTel.Name = "lblBusinessTel";
            this.lblBusinessTel.Size = new System.Drawing.Size(150, 16);
            this.lblBusinessTel.TabIndex = 20;
            this.lblBusinessTel.Text = "Business Telephone";
            // 
            // DBGbusiness
            // 
            this.DBGbusiness.AllowUserToResizeColumns = false;
            this.DBGbusiness.AllowUserToResizeRows = false;
            this.DBGbusiness.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DBGbusiness.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGbusiness.Location = new System.Drawing.Point(11, 260);
            this.DBGbusiness.Name = "DBGbusiness";
            this.DBGbusiness.ReadOnly = true;
            this.DBGbusiness.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DBGbusiness.Size = new System.Drawing.Size(1033, 215);
            this.DBGbusiness.TabIndex = 22;
            this.DBGbusiness.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGbusiness_CellClick);
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnMain.Location = new System.Drawing.Point(839, 18);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(95, 23);
            this.btnMain.TabIndex = 23;
            this.btnMain.Text = "Main Menu";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // TbHomeTel
            // 
            this.TbHomeTel.Enabled = false;
            this.TbHomeTel.Location = new System.Drawing.Point(464, 49);
            this.TbHomeTel.Name = "TbHomeTel";
            this.TbHomeTel.Size = new System.Drawing.Size(100, 20);
            this.TbHomeTel.TabIndex = 13;
            // 
            // lblHomeTel
            // 
            this.lblHomeTel.AutoSize = true;
            this.lblHomeTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblHomeTel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblHomeTel.Location = new System.Drawing.Point(263, 49);
            this.lblHomeTel.Name = "lblHomeTel";
            this.lblHomeTel.Size = new System.Drawing.Size(195, 16);
            this.lblHomeTel.TabIndex = 21;
            this.lblHomeTel.Text = "Business Home Telephone";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.monthCalendar1.Location = new System.Drawing.Point(270, 90);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 24;
            // 
            // BusinessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(946, 485);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.DBGbusiness);
            this.Controls.Add(this.lblHomeTel);
            this.Controls.Add(this.lblBusinessTel);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblPostcode);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblBusinessOrder);
            this.Controls.Add(this.lblBusinessName);
            this.Controls.Add(this.TbHomeTel);
            this.Controls.Add(this.TbBusinessTel);
            this.Controls.Add(this.TbEmail);
            this.Controls.Add(this.TbCity);
            this.Controls.Add(this.TbPostcode);
            this.Controls.Add(this.TbAddress);
            this.Controls.Add(this.TbOrder);
            this.Controls.Add(this.TbBusinessName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnSaveSelected);
            this.Controls.Add(this.btnSaveNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "BusinessForm";
            this.Text = "BusinessForm";
            this.Load += new System.EventHandler(this.BusinessForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBGbusiness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Button btnSaveSelected;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox TbBusinessName;
        private System.Windows.Forms.TextBox TbOrder;
        private System.Windows.Forms.TextBox TbAddress;
        private System.Windows.Forms.TextBox TbPostcode;
        private System.Windows.Forms.TextBox TbCity;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.TextBox TbBusinessTel;
        private System.Windows.Forms.Label lblBusinessName;
        private System.Windows.Forms.Label lblBusinessOrder;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBusinessTel;
        private System.Windows.Forms.DataGridView DBGbusiness;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.TextBox TbHomeTel;
        private System.Windows.Forms.Label lblHomeTel;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}
namespace WindowsFormsApp1
{
    partial class WelcomeForm
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
            this.btnPersonal = new System.Windows.Forms.Button();
            this.btnBusiness = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPersonal
            // 
            this.btnPersonal.Location = new System.Drawing.Point(61, 89);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(117, 30);
            this.btnPersonal.TabIndex = 0;
            this.btnPersonal.Text = "Personal Contact";
            this.btnPersonal.UseVisualStyleBackColor = true;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnBusiness
            // 
            this.btnBusiness.Location = new System.Drawing.Point(272, 89);
            this.btnBusiness.Name = "btnBusiness";
            this.btnBusiness.Size = new System.Drawing.Size(108, 30);
            this.btnBusiness.TabIndex = 1;
            this.btnBusiness.Text = "Business Details";
            this.btnBusiness.UseVisualStyleBackColor = true;
            this.btnBusiness.Click += new System.EventHandler(this.btnBusiness_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 203);
            this.Controls.Add(this.btnBusiness);
            this.Controls.Add(this.btnPersonal);
            this.Name = "WelcomeForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Button btnBusiness;
    }
}


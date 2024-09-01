
namespace ESGARD_STORE
{
    partial class Manager_Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnMaintainEmployee = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(31, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 90);
            this.panel1.TabIndex = 11;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(919, 54);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(69, 30);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ESGARD_STORE.Properties.Resources.ESGARD_LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(39, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(31, 298);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(389, 53);
            this.btnReports.TabIndex = 15;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnMaintainEmployee
            // 
            this.btnMaintainEmployee.Location = new System.Drawing.Point(31, 197);
            this.btnMaintainEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMaintainEmployee.Name = "btnMaintainEmployee";
            this.btnMaintainEmployee.Size = new System.Drawing.Size(389, 54);
            this.btnMaintainEmployee.TabIndex = 14;
            this.btnMaintainEmployee.Text = "Maintain Employees";
            this.btnMaintainEmployee.UseVisualStyleBackColor = true;
            this.btnMaintainEmployee.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ESGARD_STORE.Properties.Resources.this_is_Esgard__1_;
            this.pictureBox2.Location = new System.Drawing.Point(533, 140);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(504, 382);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // Manager_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnMaintainEmployee);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Manager_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager_Dashboard";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnMaintainEmployee;
    }
}
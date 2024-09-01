
namespace ESGARD_STORE
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.btnMClient = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnPurchaseD = new System.Windows.Forms.Button();
            this.btnMReturns = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMClient
            // 
            this.btnMClient.Location = new System.Drawing.Point(58, 234);
            this.btnMClient.Name = "btnMClient";
            this.btnMClient.Size = new System.Drawing.Size(292, 43);
            this.btnMClient.TabIndex = 5;
            this.btnMClient.Text = "Maintain Clients Details";
            this.toolTip1.SetToolTip(this.btnMClient, "Open client editor page");
            this.btnMClient.UseVisualStyleBackColor = true;
            this.btnMClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(58, 284);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(292, 46);
            this.btnInventory.TabIndex = 1;
            this.btnInventory.Text = "Maintain Inventory";
            this.toolTip1.SetToolTip(this.btnInventory, "Open inventory page");
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPurchaseD
            // 
            this.btnPurchaseD.Location = new System.Drawing.Point(58, 136);
            this.btnPurchaseD.Name = "btnPurchaseD";
            this.btnPurchaseD.Size = new System.Drawing.Size(292, 43);
            this.btnPurchaseD.TabIndex = 2;
            this.btnPurchaseD.Text = "Purchase";
            this.toolTip1.SetToolTip(this.btnPurchaseD, "Open the purchase page");
            this.btnPurchaseD.UseVisualStyleBackColor = true;
            this.btnPurchaseD.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMReturns
            // 
            this.btnMReturns.Location = new System.Drawing.Point(58, 336);
            this.btnMReturns.Name = "btnMReturns";
            this.btnMReturns.Size = new System.Drawing.Size(292, 44);
            this.btnMReturns.TabIndex = 3;
            this.btnMReturns.Text = "Make Returns";
            this.toolTip1.SetToolTip(this.btnMReturns, "Open returns page");
            this.btnMReturns.UseVisualStyleBackColor = true;
            this.btnMReturns.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(689, 44);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(52, 24);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.toolTip1.SetToolTip(this.btnLogout, "Log out of the system");
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(58, 185);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(292, 43);
            this.button7.TabIndex = 10;
            this.button7.Text = "Maintain Payment Type";
            this.toolTip1.SetToolTip(this.button7, "Open payment type page");
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 73);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ESGARD_STORE.Properties.Resources.ESGARD_LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(29, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(117, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "@2024 Esgard, inc, All rights reserved";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(371, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tel. 0726168472 email. whatisit@gmail.com";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ESGARD_STORE.Properties.Resources.this_is_Esgard__1_;
            this.pictureBox2.Location = new System.Drawing.Point(389, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(378, 310);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Location = new System.Drawing.Point(343, 437);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(29, 13);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Help";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 526);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnMReturns);
            this.Controls.Add(this.btnPurchaseD);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnMClient);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMClient;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnPurchaseD;
        private System.Windows.Forms.Button btnMReturns;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
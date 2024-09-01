
namespace ESGARD_STORE
{
    partial class Reports
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoDes = new System.Windows.Forms.RadioButton();
            this.rdoAsc = new System.Windows.Forms.RadioButton();
            this.lblEsgard = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGenerateCS = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.lstClient = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-5, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(812, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.dateTimePicker2);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.BtnGenerate);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.lblEsgard);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(804, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Top Ten Selling Items";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(586, 375);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 37);
            this.btnClear.TabIndex = 47;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(511, 118);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 46;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(511, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 45;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(781, 209);
            this.dataGridView1.TabIndex = 44;
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(693, 375);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(101, 37);
            this.BtnGenerate.TabIndex = 43;
            this.BtnGenerate.Text = "Generate";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "End Between";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Start Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoDes);
            this.groupBox1.Controls.Add(this.rdoAsc);
            this.groupBox1.Location = new System.Drawing.Point(24, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 110);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorted by:";
            // 
            // rdoDes
            // 
            this.rdoDes.AutoSize = true;
            this.rdoDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDes.Location = new System.Drawing.Point(6, 59);
            this.rdoDes.Name = "rdoDes";
            this.rdoDes.Size = new System.Drawing.Size(152, 20);
            this.rdoDes.TabIndex = 2;
            this.rdoDes.TabStop = true;
            this.rdoDes.Text = "Price Descending";
            this.rdoDes.UseVisualStyleBackColor = true;
            // 
            // rdoAsc
            // 
            this.rdoAsc.AutoSize = true;
            this.rdoAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAsc.Location = new System.Drawing.Point(6, 34);
            this.rdoAsc.Name = "rdoAsc";
            this.rdoAsc.Size = new System.Drawing.Size(142, 20);
            this.rdoAsc.TabIndex = 1;
            this.rdoAsc.TabStop = true;
            this.rdoAsc.Text = "Price Ascending";
            this.rdoAsc.UseVisualStyleBackColor = true;
            // 
            // lblEsgard
            // 
            this.lblEsgard.AutoSize = true;
            this.lblEsgard.Location = new System.Drawing.Point(27, 18);
            this.lblEsgard.Name = "lblEsgard";
            this.lblEsgard.Size = new System.Drawing.Size(93, 13);
            this.lblEsgard.TabIndex = 30;
            this.lblEsgard.Text = "Esgard Apparel";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lstClient);
            this.tabPage2.Controls.Add(this.txtClientName);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btnGenerateCS);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(804, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Client Statements";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(560, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "client Name:";
            // 
            // btnGenerateCS
            // 
            this.btnGenerateCS.Location = new System.Drawing.Point(669, 343);
            this.btnGenerateCS.Name = "btnGenerateCS";
            this.btnGenerateCS.Size = new System.Drawing.Size(87, 29);
            this.btnGenerateCS.TabIndex = 1;
            this.btnGenerateCS.Text = "Generate";
            this.btnGenerateCS.UseVisualStyleBackColor = true;
            this.btnGenerateCS.Click += new System.EventHandler(this.btnGenerateCS_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label15.Location = new System.Drawing.Point(147, 516);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(233, 16);
            this.label15.TabIndex = 29;
            this.label15.Text = "@2024 Esgard, inc, All rights reserved";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label14.Location = new System.Drawing.Point(403, 516);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(265, 16);
            this.label14.TabIndex = 28;
            this.label14.Text = "Tel. 0726168472 email. whatisit@gmail.com";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalAmount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(30, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 42);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Amount:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(128, 15);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(45, 16);
            this.lblTotalAmount.TabIndex = 1;
            this.lblTotalAmount.Text = "label3";
            this.lblTotalAmount.Visible = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(12, 465);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(101, 37);
            this.btnDashboard.TabIndex = 30;
            this.btnDashboard.Text = "Back to dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(644, 66);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(134, 20);
            this.txtClientName.TabIndex = 8;
            // 
            // lstClient
            // 
            this.lstClient.FormattingEnabled = true;
            this.lstClient.Location = new System.Drawing.Point(30, 119);
            this.lstClient.Name = "lstClient";
            this.lstClient.Size = new System.Drawing.Size(748, 186);
            this.lstClient.TabIndex = 9;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 541);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tabControl1);
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoDes;
        private System.Windows.Forms.RadioButton rdoAsc;
        private System.Windows.Forms.Label lblEsgard;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGenerateCS;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.ListBox lstClient;
    }
}

namespace ESGARD_STORE
{
    partial class Purchase_Form
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnProceed = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.txtQtyPF = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDescrPF = new System.Windows.Forms.TextBox();
            this.txtColorPF = new System.Windows.Forms.TextBox();
            this.txtSizePF = new System.Windows.Forms.TextBox();
            this.txtPricePF = new System.Windows.Forms.TextBox();
            this.txtBarPF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBTD = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblPurchaseN = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtClientID_PF = new System.Windows.Forms.TextBox();
            this.txtEmpID_PF = new System.Windows.Forms.TextBox();
            this.cboPayType_PF = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(13, 222);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(492, 324);
            this.listBox1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(325, 280);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(897, 569);
            this.btnProceed.Margin = new System.Windows.Forms.Padding(4);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(137, 51);
            this.btnProceed.TabIndex = 17;
            this.btnProceed.Text = "PROCEED";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(572, 569);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(137, 51);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 510);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(492, 36);
            this.label7.TabIndex = 19;
            this.label7.Text = "Total Amount:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddCart);
            this.panel1.Controls.Add(this.txtQtyPF);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtDescrPF);
            this.panel1.Controls.Add(this.txtColorPF);
            this.panel1.Controls.Add(this.txtSizePF);
            this.panel1.Controls.Add(this.txtPricePF);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtBarPF);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(572, 217);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 329);
            this.panel1.TabIndex = 20;
            // 
            // btnAddCart
            // 
            this.btnAddCart.Location = new System.Drawing.Point(190, 280);
            this.btnAddCart.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(100, 28);
            this.btnAddCart.TabIndex = 30;
            this.btnAddCart.Text = "Add to Cart";
            this.btnAddCart.UseVisualStyleBackColor = true;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // txtQtyPF
            // 
            this.txtQtyPF.Location = new System.Drawing.Point(190, 251);
            this.txtQtyPF.Name = "txtQtyPF";
            this.txtQtyPF.Size = new System.Drawing.Size(235, 22);
            this.txtQtyPF.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 254);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 17);
            this.label15.TabIndex = 28;
            this.label15.Text = "Quantity";
            // 
            // txtDescrPF
            // 
            this.txtDescrPF.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescrPF.Location = new System.Drawing.Point(188, 60);
            this.txtDescrPF.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescrPF.Name = "txtDescrPF";
            this.txtDescrPF.ReadOnly = true;
            this.txtDescrPF.Size = new System.Drawing.Size(237, 22);
            this.txtDescrPF.TabIndex = 23;
            // 
            // txtColorPF
            // 
            this.txtColorPF.BackColor = System.Drawing.SystemColors.Window;
            this.txtColorPF.Location = new System.Drawing.Point(188, 106);
            this.txtColorPF.Margin = new System.Windows.Forms.Padding(4);
            this.txtColorPF.Name = "txtColorPF";
            this.txtColorPF.ReadOnly = true;
            this.txtColorPF.Size = new System.Drawing.Size(237, 22);
            this.txtColorPF.TabIndex = 22;
            // 
            // txtSizePF
            // 
            this.txtSizePF.BackColor = System.Drawing.SystemColors.Window;
            this.txtSizePF.Location = new System.Drawing.Point(188, 156);
            this.txtSizePF.Margin = new System.Windows.Forms.Padding(4);
            this.txtSizePF.Name = "txtSizePF";
            this.txtSizePF.ReadOnly = true;
            this.txtSizePF.Size = new System.Drawing.Size(237, 22);
            this.txtSizePF.TabIndex = 21;
            // 
            // txtPricePF
            // 
            this.txtPricePF.BackColor = System.Drawing.SystemColors.Window;
            this.txtPricePF.Location = new System.Drawing.Point(188, 198);
            this.txtPricePF.Margin = new System.Windows.Forms.Padding(4);
            this.txtPricePF.Name = "txtPricePF";
            this.txtPricePF.ReadOnly = true;
            this.txtPricePF.Size = new System.Drawing.Size(237, 22);
            this.txtPricePF.TabIndex = 20;
            // 
            // txtBarPF
            // 
            this.txtBarPF.Location = new System.Drawing.Point(188, 15);
            this.txtBarPF.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarPF.Name = "txtBarPF";
            this.txtBarPF.Size = new System.Drawing.Size(237, 22);
            this.txtBarPF.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Serial Number";
            // 
            // btnBTD
            // 
            this.btnBTD.Location = new System.Drawing.Point(13, 569);
            this.btnBTD.Margin = new System.Windows.Forms.Padding(4);
            this.btnBTD.Name = "btnBTD";
            this.btnBTD.Size = new System.Drawing.Size(137, 51);
            this.btnBTD.TabIndex = 21;
            this.btnBTD.Text = "Back To Dashboard";
            this.btnBTD.UseVisualStyleBackColor = true;
            this.btnBTD.Click += new System.EventHandler(this.button5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(503, 628);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(335, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tel. 0726168472 email. whatisit@gmail.com";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(140, 628);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(296, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "@2024 Esgard, inc, All rights reserved";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ESGARD_STORE.Properties.Resources.ESGARD_LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(31, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Date:";
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDate.Location = new System.Drawing.Point(305, 66);
            this.lblCurrentDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(62, 20);
            this.lblCurrentDate.TabIndex = 26;
            this.lblCurrentDate.Text = "label10";
            this.lblCurrentDate.Visible = false;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(222, 523);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(54, 17);
            this.lblTotalAmount.TabIndex = 27;
            this.lblTotalAmount.Text = "label12";
            // 
            // lblPurchaseN
            // 
            this.lblPurchaseN.AutoSize = true;
            this.lblPurchaseN.Location = new System.Drawing.Point(382, 523);
            this.lblPurchaseN.Name = "lblPurchaseN";
            this.lblPurchaseN.Size = new System.Drawing.Size(54, 17);
            this.lblPurchaseN.TabIndex = 28;
            this.lblPurchaseN.Text = "label13";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(601, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "Client ID: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(601, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 17);
            this.label13.TabIndex = 30;
            this.label13.Text = "Employee ID:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(601, 166);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 17);
            this.label14.TabIndex = 31;
            this.label14.Text = "Payment Type:";
            // 
            // txtClientID_PF
            // 
            this.txtClientID_PF.Location = new System.Drawing.Point(762, 50);
            this.txtClientID_PF.Name = "txtClientID_PF";
            this.txtClientID_PF.Size = new System.Drawing.Size(237, 22);
            this.txtClientID_PF.TabIndex = 32;
            // 
            // txtEmpID_PF
            // 
            this.txtEmpID_PF.Location = new System.Drawing.Point(760, 107);
            this.txtEmpID_PF.Name = "txtEmpID_PF";
            this.txtEmpID_PF.Size = new System.Drawing.Size(237, 22);
            this.txtEmpID_PF.TabIndex = 33;
            // 
            // cboPayType_PF
            // 
            this.cboPayType_PF.FormattingEnabled = true;
            this.cboPayType_PF.Location = new System.Drawing.Point(762, 163);
            this.cboPayType_PF.Name = "cboPayType_PF";
            this.cboPayType_PF.Size = new System.Drawing.Size(235, 24);
            this.cboPayType_PF.TabIndex = 34;
            // 
            // Purchase_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 655);
            this.Controls.Add(this.cboPayType_PF);
            this.Controls.Add(this.txtEmpID_PF);
            this.Controls.Add(this.txtClientID_PF);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblPurchaseN);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblCurrentDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBTD);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Purchase_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "l";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDescrPF;
        private System.Windows.Forms.TextBox txtColorPF;
        private System.Windows.Forms.TextBox txtSizePF;
        private System.Windows.Forms.TextBox txtPricePF;
        private System.Windows.Forms.TextBox txtBarPF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBTD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblPurchaseN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.TextBox txtQtyPF;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtClientID_PF;
        private System.Windows.Forms.TextBox txtEmpID_PF;
        private System.Windows.Forms.ComboBox cboPayType_PF;
    }
}
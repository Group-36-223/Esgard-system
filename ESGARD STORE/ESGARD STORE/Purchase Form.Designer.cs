
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnATCartP = new System.Windows.Forms.Button();
            this.btnProceed = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDescrP = new System.Windows.Forms.TextBox();
            this.txtColorP = new System.Windows.Forms.TextBox();
            this.txtSizeP = new System.Windows.Forms.TextBox();
            this.txtPriceP = new System.Windows.Forms.TextBox();
            this.txtBarP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBTD = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 117);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(410, 264);
            this.listBox1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(347, 387);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnATCartP
            // 
            this.btnATCartP.Location = new System.Drawing.Point(245, 220);
            this.btnATCartP.Name = "btnATCartP";
            this.btnATCartP.Size = new System.Drawing.Size(75, 23);
            this.btnATCartP.TabIndex = 16;
            this.btnATCartP.Text = "Add To Cart";
            this.btnATCartP.UseVisualStyleBackColor = true;
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(650, 436);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(138, 36);
            this.btnProceed.TabIndex = 17;
            this.btnProceed.Text = "PROCEED";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(266, 387);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(443, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(345, 46);
            this.label7.TabIndex = 19;
            this.label7.Text = "Total Amount:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDescrP);
            this.panel1.Controls.Add(this.txtColorP);
            this.panel1.Controls.Add(this.txtSizeP);
            this.panel1.Controls.Add(this.txtPriceP);
            this.panel1.Controls.Add(this.btnATCartP);
            this.panel1.Controls.Add(this.txtBarP);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(443, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 264);
            this.panel1.TabIndex = 20;
            // 
            // txtDescrP
            // 
            this.txtDescrP.Location = new System.Drawing.Point(141, 81);
            this.txtDescrP.Name = "txtDescrP";
            this.txtDescrP.ReadOnly = true;
            this.txtDescrP.Size = new System.Drawing.Size(179, 20);
            this.txtDescrP.TabIndex = 23;
            // 
            // txtColorP
            // 
            this.txtColorP.Location = new System.Drawing.Point(141, 119);
            this.txtColorP.Name = "txtColorP";
            this.txtColorP.ReadOnly = true;
            this.txtColorP.Size = new System.Drawing.Size(179, 20);
            this.txtColorP.TabIndex = 22;
            // 
            // txtSizeP
            // 
            this.txtSizeP.Location = new System.Drawing.Point(141, 160);
            this.txtSizeP.Name = "txtSizeP";
            this.txtSizeP.ReadOnly = true;
            this.txtSizeP.Size = new System.Drawing.Size(179, 20);
            this.txtSizeP.TabIndex = 21;
            // 
            // txtPriceP
            // 
            this.txtPriceP.Location = new System.Drawing.Point(141, 194);
            this.txtPriceP.Name = "txtPriceP";
            this.txtPriceP.ReadOnly = true;
            this.txtPriceP.Size = new System.Drawing.Size(179, 20);
            this.txtPriceP.TabIndex = 20;
            // 
            // txtBarP
            // 
            this.txtBarP.Location = new System.Drawing.Point(141, 38);
            this.txtBarP.Name = "txtBarP";
            this.txtBarP.Size = new System.Drawing.Size(179, 20);
            this.txtBarP.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Bar Code";
            // 
            // btnBTD
            // 
            this.btnBTD.Location = new System.Drawing.Point(12, 436);
            this.btnBTD.Name = "btnBTD";
            this.btnBTD.Size = new System.Drawing.Size(111, 23);
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
            this.label8.Location = new System.Drawing.Point(369, 493);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(265, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tel. 0726168472 email. whatisit@gmail.com";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(97, 493);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(233, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "@2024 Esgard, inc, All rights reserved";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ESGARD_STORE.Properties.Resources.ESGARD_LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Purchase_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBTD);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.listBox1);
            this.Name = "Purchase_Form";
            this.Text = "Purchase_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnATCartP;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDescrP;
        private System.Windows.Forms.TextBox txtColorP;
        private System.Windows.Forms.TextBox txtSizeP;
        private System.Windows.Forms.TextBox txtPriceP;
        private System.Windows.Forms.TextBox txtBarP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBTD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
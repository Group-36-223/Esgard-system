
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
            this.cBSPayType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(406, 127);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(370, 264);
            this.listBox1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(537, 420);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnATCartP
            // 
            this.btnATCartP.Location = new System.Drawing.Point(245, 187);
            this.btnATCartP.Name = "btnATCartP";
            this.btnATCartP.Size = new System.Drawing.Size(75, 23);
            this.btnATCartP.TabIndex = 16;
            this.btnATCartP.Text = "Search";
            this.btnATCartP.UseVisualStyleBackColor = true;
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(673, 420);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(103, 23);
            this.btnProceed.TabIndex = 17;
            this.btnProceed.Text = "PROCEED";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(406, 420);
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
            this.label7.Location = new System.Drawing.Point(23, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(345, 30);
            this.label7.TabIndex = 19;
            this.label7.Text = "Total Amount:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cBSPayType);
            this.panel1.Controls.Add(this.label11);
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
            this.panel1.Location = new System.Drawing.Point(28, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 267);
            this.panel1.TabIndex = 20;
            // 
            // cBSPayType
            // 
            this.cBSPayType.FormattingEnabled = true;
            this.cBSPayType.Items.AddRange(new object[] {
            "Cash",
            "Debit/Credit Card",
            "Apple Pay"});
            this.cBSPayType.Location = new System.Drawing.Point(141, 217);
            this.cBSPayType.Name = "cBSPayType";
            this.cBSPayType.Size = new System.Drawing.Size(179, 21);
            this.cBSPayType.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Select Payment Type:";
            // 
            // txtDescrP
            // 
            this.txtDescrP.Location = new System.Drawing.Point(141, 49);
            this.txtDescrP.Name = "txtDescrP";
            this.txtDescrP.ReadOnly = true;
            this.txtDescrP.Size = new System.Drawing.Size(179, 20);
            this.txtDescrP.TabIndex = 23;
            // 
            // txtColorP
            // 
            this.txtColorP.Location = new System.Drawing.Point(141, 86);
            this.txtColorP.Name = "txtColorP";
            this.txtColorP.ReadOnly = true;
            this.txtColorP.Size = new System.Drawing.Size(179, 20);
            this.txtColorP.TabIndex = 22;
            // 
            // txtSizeP
            // 
            this.txtSizeP.Location = new System.Drawing.Point(141, 127);
            this.txtSizeP.Name = "txtSizeP";
            this.txtSizeP.ReadOnly = true;
            this.txtSizeP.Size = new System.Drawing.Size(179, 20);
            this.txtSizeP.TabIndex = 21;
            // 
            // txtPriceP
            // 
            this.txtPriceP.Location = new System.Drawing.Point(141, 161);
            this.txtPriceP.Name = "txtPriceP";
            this.txtPriceP.ReadOnly = true;
            this.txtPriceP.Size = new System.Drawing.Size(179, 20);
            this.txtPriceP.TabIndex = 20;
            // 
            // txtBarP
            // 
            this.txtBarP.Location = new System.Drawing.Point(141, 12);
            this.txtBarP.Name = "txtBarP";
            this.txtBarP.Size = new System.Drawing.Size(179, 20);
            this.txtBarP.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Bar Code";
            // 
            // btnBTD
            // 
            this.btnBTD.Location = new System.Drawing.Point(28, 462);
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
            this.label8.Location = new System.Drawing.Point(377, 510);
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
            this.label9.Location = new System.Drawing.Point(105, 510);
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Date of purchase:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(403, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "label10";
            this.label10.Visible = false;
            // 
            // Purchase_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cBSPayType;
    }
}
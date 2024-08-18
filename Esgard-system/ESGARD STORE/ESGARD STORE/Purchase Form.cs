using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESGARD_STORE
{
    public partial class Purchase_Form : Form
    {
        public Purchase_Form()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            ds.ShowDialog();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
            //listBox1.Items.Add("Description\]\tQuantity\\tPrice");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Dashboard ds = new Dashboard();
            //ds.ShowDialog();

            
            Dashboard ds = Application.OpenForms["Dashboard"] as Dashboard;

            
            if (ds == null)
            {
                ds = new Dashboard();
                ds.Show();
            }
            else
            {
                ds.BringToFront();
            }

            
            this.Close();
        }
    }
    
}

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
    public partial class Payment_Type : Form
    {
        public Payment_Type()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Purchase_Form pf = new Purchase_Form();
            pf.ShowDialog();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your payment Type is unsupported!");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            ds.ShowDialog();
        }
    }
}

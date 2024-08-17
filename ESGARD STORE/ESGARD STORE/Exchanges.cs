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
    public partial class Exchanges : Form
    {
        public Exchanges()
        {
            InitializeComponent();
        }

        private void Exchanges_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            ds.ShowDialog();
        }
    }
}

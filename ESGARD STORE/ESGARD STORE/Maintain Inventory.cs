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
    public partial class Maintain_Inventory : Form
    {
        public Maintain_Inventory()
        {
            InitializeComponent();
        }

        private void Maintain_Inventory_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            ds.ShowDialog();
            this.Hide(); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            ds.ShowDialog();
        }
    }
}

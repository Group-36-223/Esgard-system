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
    public partial class Maintain_Employees : Form
    {
        public Maintain_Employees()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Manager_Dashboard mds = Application.OpenForms["Manager Dashboard"] as Manager_Dashboard;


            if (mds == null)
            {
                mds = new Manager_Dashboard();
                mds.Show();
            }
            else
            {
                mds.BringToFront();
            }

            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Dashboard ds = new Dashboard();
            //ds.ShowDialog();

            Manager_Dashboard mds = Application.OpenForms["Manager Dashboard"] as Manager_Dashboard;


            if (mds == null)
            {
                mds = new Manager_Dashboard();
                mds.Show();
            }
            else
            {
                mds.BringToFront();
            }

            this.Close();
        }

        private void btnAddME_Click(object sender, EventArgs e)
        {
          
        }
    }
}

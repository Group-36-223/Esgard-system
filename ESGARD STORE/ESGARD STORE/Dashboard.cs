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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Maintain_Clients mc = new Maintain_Clients();
            mc.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Purchase_Form pf = new Purchase_Form();
            pf.ShowDialog();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            //this.Close();
            Login login = Application.OpenForms["Login"] as Login;


            if (login == null)
            {
                login = new Login();
                login.Show();
            }
            else
            {
                login.BringToFront();
            }


            this.Close();
        }
      private void button7_Click(object sender, EventArgs e)
        {
            MaintainPType mp = new MaintainPType();
            mp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Maintain_Inventory mi = new Maintain_Inventory();
            mi.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Returns r = new Returns();
            r.ShowDialog();
        }
    }
}

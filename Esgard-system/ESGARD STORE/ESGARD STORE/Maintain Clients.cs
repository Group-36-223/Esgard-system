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
    public partial class Maintain_Clients : Form
    {
        public Maintain_Clients()
        {
            InitializeComponent();
        }

        private void Maintain_Clients_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

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

        private void btnAddMC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New Client has been added");
            this.Close();
        }

        private void btnUpdateMC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Client details has been updated");
            this.Close();
        }

        private void btnDeleteMC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Client details has been successfully deleted!");
            this.Close();
        }
    }
}

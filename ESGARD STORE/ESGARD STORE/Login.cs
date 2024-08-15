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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtUser.Text;
            string Password = txtPass.Text;

            if (Password == "12345" && name == "thato")
            {

                Manager_Dashboard mds = new Manager_Dashboard();
                mds.ShowDialog();
            }
            else
            {
                Dashboard ds = new Dashboard();
                ds.ShowDialog();
            }
            
        }

        private void lLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Maintain_Employees ms = new Maintain_Employees();
            ms.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

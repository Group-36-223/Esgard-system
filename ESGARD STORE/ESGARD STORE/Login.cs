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
          /*  string name = txtUser.Text;
            string Password = txtPass.Text;

              if (Password == "12345" && name == "thato")
              {*/

                  Manager_Dashboard mds = new Manager_Dashboard();
                  mds.ShowDialog();
             /* }
              else if(Password == "123456" && name == "tshepo") 
              {
                   Dashboard ds = new Dashboard();
                   ds.ShowDialog();    
               }

              else
              {
                lblName.Text = "Does not exist!!!!!";
                lblPassword.Text = "does not exist";
              }

              if (string.IsNullOrWhiteSpace(name))
              {
                   lblName.Text = "Please fill in a name!!";
                   lblName.Show();
              }               

              if (string.IsNullOrWhiteSpace(Password))
              {
                  lblPassword.Text = "Invalid password!!";
                  lblPassword.Show();
              }*/

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

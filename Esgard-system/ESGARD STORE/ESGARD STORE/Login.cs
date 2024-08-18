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
            name.ToLower();
            string Password = txtPass.Text;

            Dashboard ds = new Dashboard();
            ds.ShowDialog();
            //this.Hide();
            //this.Close();
            /*  if (Password == "12345" && name == "thato")
              {

                  Manager_Dashboard mds = new Manager_Dashboard();
                  mds.ShowDialog();
              }
              else if(Password == "123456" && name == "tshepo") 
              {
                  Dashboard ds = new Dashboard();
                  ds.ShowDialog();
              }

              else
              {
                  lblName.Text = "Does not exist!!!!!";
              }


              if (string.IsNullOrWhiteSpace(name))
              {
                  lblName.Text = "Please fill in a name!!";
                  lblName.Show();
              }
              /*
               * else if(!validNames.contains(name))
               * {
               *      lblName.text = "Person doesn't exist!!";
               * }
               * 
               */

            /*  if (string.IsNullOrWhiteSpace(Password))
              {
                  lblPassword.Text = "Invalid password!!";
                  lblPassword.Show();
              }*/

        }

        private void lLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Maintain_Employees ms = new Maintain_Employees();
            ms.ShowDialog();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

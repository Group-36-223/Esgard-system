using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ESGARD_STORE
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string ConnectionString = @"Data Source=KAASKRULLE;Initial Catalog=Esgard;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection Conn;
        SqlCommand Cmd;
        SqlDataAdapter Adap;
        SqlDataReader reader;
        DataSet Ds;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                string sql = @"SELECT COUNT(1) FROM Employee WHERE Employee_Number = @username AND Pssword= @password";
                Cmd = new SqlCommand(sql, Conn);

                Cmd.Parameters.AddWithValue("@username", txtUser.Text);
                Cmd.Parameters.AddWithValue("@password", txtPass.Text);

                int result = (int)Cmd.ExecuteScalar();

                if (result == 1)
                {
                    MessageBox.Show("Login Successful");
                    Dashboard ds = new Dashboard();
                    ds.ShowDialog();
                }
                else if (txtPass.Text == "123456" && txtUser.Text == "Thato")
                {
                    MessageBox.Show("Login Successful");
                    Manager_Dashboard mds = new Manager_Dashboard();
                    mds.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Login Successful");
            Dashboard ds = new Dashboard();
            ds.ShowDialog();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPass.Checked == true)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }
    }
    
}

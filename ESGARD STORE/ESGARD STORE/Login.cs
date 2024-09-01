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

//Group 36
//Seisa Satekge 32395620
//Sithembiso Masoka 39069656
//Adrian Steenbok 37557025
//Thando Kunyuza 48124095
//Naledi Methula 37828118
//Bongiwe Mncube 36149829
//MC Meyer 35163984

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
        SqlDataReader reader;


        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                // Adjust the SQL query to retrieve the employee's name and admin status
                string sql = @"SELECT First_Name, Is_Admin FROM Employee WHERE First_Name = @username AND Pssword = @pssword";
                Cmd = new SqlCommand(sql, Conn);

                Cmd.Parameters.AddWithValue("@username", txtUser.Text);
                Cmd.Parameters.AddWithValue("@pssword", txtPass.Text);

                reader = Cmd.ExecuteReader();

                if (reader.Read()) // Read once since we expect one record
                {
                    string employeeName = reader["First_Name"].ToString();
                    bool isAdmin = (bool)reader["Is_Admin"];

                    if (isAdmin)
                    {
                        //MessageBox.Show("Login Successful - Manager");
                        Manager_Dashboard mds = new Manager_Dashboard();
                        mds.ShowDialog();
                    }
                    else
                    {
                        //MessageBox.Show("Login Successful - Employee");
                        Dashboard ds = new Dashboard(); // Pass employee name to the dashboard
                        ds.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }

                reader.Close();
                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void Login_Load(object sender, EventArgs e)
        {
           // Dashboard ds = new Dashboard(); // Pass employee name to the dashboard
            //ds.ShowDialog();
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

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
    
}

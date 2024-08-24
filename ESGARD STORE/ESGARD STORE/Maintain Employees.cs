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
    public partial class Maintain_Employees : Form
    {
        String ConnectionString = @"Data Source=KAASKRULLE;Initial Catalog=Esgard;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection Conn;
        SqlCommand Cmd;
        SqlDataAdapter Adap;
        SqlDataReader reader;
        DataSet Ds;

        public Maintain_Employees()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Manager_Dashboard mds = new Manager_Dashboard();
            mds.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Dashboard ds = new Dashboard();
            //ds.ShowDialog();

            Dashboard db = Application.OpenForms["Dashboard"] as Dashboard;


            if (db == null)
            {
                db = new Dashboard();
                db.Show();
            }
            else
            {
                db.BringToFront();
            }
        }
        private Boolean employeeNumberFound(long employeeNumberSearch)
        {
            if("a" =="a")
            {
                
           try
           {
               Conn = new SqlConnection(ConnectionString);
               Conn.Open();

               Adap = new SqlDataAdapter();

               string sql = "SELECT * FROM Employee WHERE User_ID_No = employeeNumberSearch";
               Cmd = new SqlCommand(sql, Conn);


              // Ds = new DataSet();

               Adap.SelectCommand = Cmd;
               Adap.Fill(Ds, "Employee");

               dgv_Employee.DataSource = Ds;
               dgv_Employee.DataMember = "Employee";

               Cmd.Dispose();
               Conn.Close();
           }
           catch(Exception Ex)
           {
               MessageBox.Show(Ex.Message);
           }
                return true;
            }
            else
            {
                return false;
            }
                        
        }
        private void btnSearchME_Click(object sender, EventArgs e)
        {
            long employeeNumberSearch;
            if (long.TryParse(txtENumberMe.Text, out employeeNumberSearch))
            {
                if(employeeNumberFound(employeeNumberSearch))
                { 

                }
                else
                {
                    MessageBox.Show("Employee number not found!");
                }

            }
            else
            {
                MessageBox.Show("Invalid input!");
            }
            
            
           
        }
    }
}

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
        String ConnectionString = @"Data Source=LAPTOP-EM1DCRUG;Initial Catalog=Esgard;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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
        private Boolean employeeNumberFound(int employeeNumberSearch)
        {
            txtFNameME.Text = "";
            txtLNameME.Text = "";
            txtCellphoneME.Text = "";
            txtEmailME.Text = "";
            txtENumber.Text = "";
            txtPasswordME.Text = "";
            txtINumberMe.Text = "";
            Boolean didItThrewAnException = false;

            
            
                
               try
               {
                   Conn = new SqlConnection(ConnectionString);
                   Conn.Open();

                   Adap = new SqlDataAdapter();

                   string sql = @"SELECT F_Name, L_Name FROM Employee WHERE User_ID_No = "+ employeeNumberSearch;
                   Cmd = new SqlCommand(sql, Conn);

                    Cmd.Parameters.AddWithValue("User_ID_No", employeeNumberSearch);

                    SqlDataReader reader = Cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtFNameME.Text = reader["F_Name"].ToString();
                        txtLNameME.Text = reader["L_Name"].ToString();
                    }
                    reader.Close();
                    /* Ds = new DataSet();

                     Adap.SelectCommand = Cmd;
                     Adap.Fill(Ds, "Employee");

                     dgv_Employee.DataSource = Ds;
                     dgv_Employee.DataMember = "Employee";*/

                    Cmd.Dispose();
                   Conn.Close();
                    
                }
               catch(Exception Ex)
               {
                   MessageBox.Show(Ex.Message);
                    didItThrewAnException = true;
                    
               }
                
            if (!didItThrewAnException && !(txtFNameME.Text == "") )
            {
                return true;
            }
            else
            {
                return false;
            }
                        
        }
        private void btnSearchME_Click(object sender, EventArgs e)
        {

            int employeeNumberSearch;
            if (int.TryParse(txtENumberMe.Text, out employeeNumberSearch))
            {
                if(employeeNumberFound(employeeNumberSearch))
                {
                    MessageBox.Show("Employee successfully found!");
                }
                else
                {
                    MessageBox.Show("Employee does not exist!");
                }

            }
            else
            {
                MessageBox.Show("Invalid input!");
            }
            


        }

        private void Maintain_Employees_Load(object sender, EventArgs e)
        {
           
        }
    }
}

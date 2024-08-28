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
        string ConnectionString = @"Data Source=HIMALAYANTOP;Initial Catalog=Esgard;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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

            loadAll();
        }
        private Boolean employeeNumberFound(int employeeNumberSearch)
        {

            clearTextBoxes();
            Boolean didItThrewAnException = false;

            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                //Adap = new SqlDataAdapter();

                string sql = @"SELECT F_Name, L_Name, User_ID_No, cell_No, Email_Address, Employee_Number, Password FROM Employee WHERE Employee_Number= " + employeeNumberSearch;
                Cmd = new SqlCommand(sql, Conn);

                Cmd.Parameters.AddWithValue("Employee_Number", employeeNumberSearch);

                SqlDataReader reader = Cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtFNameME.Text = reader["F_Name"].ToString();
                    txtLNameME.Text = reader["L_Name"].ToString();
                    txtINumberMe.Text = reader["User_ID_No"].ToString();
                    txtEmailME.Text = reader["Email_Address"].ToString();
                    txtCellphoneME.Text = reader["cell_No"].ToString();
                    txtENumber.Text = reader["Employee_Number"].ToString();
                    txtPasswordME.Text = reader["Password"].ToString();
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
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                didItThrewAnException = true;

            }

            if (!didItThrewAnException && !(txtFNameME.Text == ""))
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
                if (employeeNumberFound(employeeNumberSearch))
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

            loadAll();

        }

        private void Maintain_Employees_Load(object sender, EventArgs e)
        {

        }

        private Boolean addEmployee(String firstName, string lastName, long idNumber, int cellphoneNumber, string email, int EmployeeNumber, int Password)
        {
            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                Adap = new SqlDataAdapter();

                string sql = @"INSERT INTO Employee (F_Name, L_Name, User_ID_No, cell_No, Email_Address, Employee_Number, Password) VALUES ('" + firstName + "','" + lastName + "','" + idNumber + "','" + cellphoneNumber + "','" + email + "', '" + EmployeeNumber + "', '" + Password + "')";
                Cmd = new SqlCommand(sql, Conn);



                Adap.InsertCommand = Cmd;
                Adap.InsertCommand.ExecuteNonQuery();


                Cmd.Dispose();
                Conn.Close();


            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return false;

            }

            return true;

            
        }

        private void clearTextBoxes()
        {
            txtFNameME.Text = "";
            txtLNameME.Text = "";
            txtCellphoneME.Text = "";
            txtEmailME.Text = "";
            txtENumber.Text = "";
            txtPasswordME.Text = "";
            txtINumberMe.Text = "";

            loadAll();
        }
        private void btnAddME_Click(object sender, EventArgs e)
        {
            string firstName = txtFNameME.Text;
            string lastName = txtLNameME.Text;
            long idNumber;
            int cellphoneNumber;
            string email = txtEmailME.Text;

            Random rand = new Random();
            int Password = rand.Next(1000, 9999);

            txtPasswordME.Text = Password.ToString();

            Random rnd = new Random();
            int EmployeeNumber = rnd.Next(10000000, 99999999);

            txtENumber.Text = EmployeeNumber.ToString();

            if (!(firstName == ""))
            {
                if (!(lastName == ""))
                {
                    if (long.TryParse(txtINumberMe.Text, out idNumber) && txtINumberMe.Text.Length == 13)
                    {
                        if (!(email == ""))
                        {
                            if (int.TryParse(txtCellphoneME.Text, out cellphoneNumber))
                            {
                                if (addEmployee(firstName, lastName, idNumber, cellphoneNumber, email, EmployeeNumber, Password ))    
                                {
                                    MessageBox.Show("Employee successfully added!");
                                }
                                else
                                {
                                    MessageBox.Show("Error while adding new employee details!\nPlease try again!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please enter valid cellphone number!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid email!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid ID number!");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid last name!");
                }

            }
            else
            {
                MessageBox.Show("Please enter valid first name!");
            }

            clearTextBoxes();

            loadAll();
        }

        private void btnDeleteME_Click(object sender, EventArgs e)
        {
            Conn.Open();
            string sql = "DELETE FROM Employee WHERE Employee_Number = @num";
            Cmd = new SqlCommand(sql, Conn);
            Cmd.Parameters.AddWithValue("@num", txtENumber.Text);
            Cmd.ExecuteNonQuery();

            Conn.Close();

            MessageBox.Show("Deleted Successfully");

            loadAll();
            clearTextBoxes();
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                MessageBox.Show("Connected Successfully");

                Conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            loadAll();
        }

        private void loadAll()
        {
            try
            {
                Conn.Open();
                string sql = "SELECT * FROM Employee";
                Cmd = new SqlCommand(sql, Conn);
                Adap = new SqlDataAdapter();
                Ds = new DataSet();

                Adap.SelectCommand = Cmd;
                Adap.Fill(Ds, "Employee");

                dgv_Employee.DataSource = Ds;
                dgv_Employee.DataMember = "Employee";

                Conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            loadAll();
        }
        
        private void txtINumberMe_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void groupbox1_Enter(object sender, EventArgs e)
        {
          
        }

        private Boolean UpdateEmployee(long Employee_Number, String firstname, string lastname, long idNumber, int cellphoneNumber, string email)
        {
            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                Adap = new SqlDataAdapter();

                string sql = @"UPDATE Employee SET F_Name= '" + firstname + "', L_Name = '" + lastname + "', ID_Number= '" + idNumber + "', cell_No= '" + cellphoneNumber + "', Email_Address= '" + email + "' WHERE Employee_Number= '" + Employee_Number + "'";
                Cmd = new SqlCommand(sql, Conn);

                Adap.UpdateCommand = Cmd;
                Adap.UpdateCommand.ExecuteNonQuery();

                Cmd.Dispose();
                Conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            loadAll();
            return true;
           
        }

        private void btnUpdateME_Click(object sender, EventArgs e)
        {
            string firstName = txtFNameME.Text;
            string lastName = txtLNameME.Text;
            long idNumber;
            int cellphoneNumber;
            string email = txtEmailME.Text;

            if (!(firstName == ""))
            {
                if (!(lastName == ""))
                {
                    if (long.TryParse(txtINumberMe.Text, out idNumber) && txtINumberMe.Text.Length == 13)
                    {
                        if (!(email == ""))
                        {
                            if (int.TryParse(txtCellphoneME.Text, out cellphoneNumber))
                            {
                                if (UpdateEmployee(long.Parse(txtENumberMe.Text), firstName, lastName, idNumber, cellphoneNumber, email))
                                {
                                    MessageBox.Show("Employee successfully updated!");
                                }
                                else
                                {
                                    MessageBox.Show("Error while updating employee details!\nPlease try again!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please enter valid cellphone number!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid email!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid ID number!");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid last name!");
                }

                loadAll();
            }

        }

        private void txtINumberMe_TextChanged_1(object sender, EventArgs e)
        {
            if (txtINumberMe.Text.Length == 13)
            {
                btnAddME.Enabled = true;
                btnUpdateME.Enabled = true;
            }
            else
            {
                btnAddME.Enabled = false;
                btnUpdateME.Enabled = false;
            }
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {
            txtINumberMe.TextChanged += txtINumberMe_TextChanged;
            btnAddME.Enabled = false;
            btnUpdateME.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
        }
    }
}

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
        string ConnectionString = @"Data Source=KAASKRULLE;Initial Catalog=Esgard;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection Conn;
        SqlCommand Cmd;
        SqlDataAdapter Adap;
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
        private Boolean employeeNameFound(string employeeNameSearch)
        {

            clearTextBoxes();
            Boolean didItThrewAnException = false;

            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                //Adap = new SqlDataAdapter();

                string sql = @"SELECT First_Name, Last_Name, ID_Number, cell_No, Email_Address, Employee_Number, Pssword FROM Employee WHERE First_Name LIKE @employeeName";
               
                Cmd = new SqlCommand(sql, Conn);

                Cmd.Parameters.AddWithValue("@employeeName","%"+ employeeNameSearch + "%");

                SqlDataReader reader = Cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtFNameME.Text = reader["First_Name"].ToString();
                    txtLNameME.Text = reader["Last_Name"].ToString();
                    txtINumberMe.Text = reader["ID_Number"].ToString();
                    txtEmailME.Text = reader["Email_Address"].ToString();
                    txtCellphoneME.Text = reader["cell_No"].ToString();
                    txtENumber.Text = reader["Employee_Number"].ToString();
                    txtPasswordME.Text = reader["Pssword"].ToString();
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

            string employeeNameSearch = txtENumberMe.Text;
            if (!(employeeNameSearch == ""))
            {
                if (employeeNameFound(employeeNameSearch))
                {
                    MessageBox.Show("Employee successfully found!");
                    txtENumberMe.Text = "";
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
            loadAll();
        }



        private Boolean addEmployee(String firstName, string lastName, long idNumber, int cellphoneNumber, string email, int EmployeeNumber, int Password)
        {
            bool isAdmin = false;
            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                Adap = new SqlDataAdapter();

                string sql = @"INSERT INTO Employee (First_Name, Last_Name, ID_Number, cell_No, Email_Address, Employee_Number, Pssword,Is_Admin) VALUES ('" + firstName + "','" + lastName + "','" + idNumber + "','" + cellphoneNumber + "','" + email + "', '" + EmployeeNumber + "', '" + Password+ "','"+ isAdmin +"')";
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
            txtENumberMe.Text = "";
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
            int EmployeeNumber = rnd.Next(10000, 99999);

            txtENumber.Text = EmployeeNumber.ToString();
           // bool Is_Admin = false;

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
            /*Conn.Open();
            string sql = "DELETE FROM Employee WHERE First_Name = @name";
            Cmd = new SqlCommand(sql, Conn);
            Cmd.Parameters.AddWithValue("@name", txtENumberMe.Text);
            Cmd.ExecuteNonQuery();

            Conn.Close();

            MessageBox.Show("Deleted Successfully");

            loadAll();
            clearTextBoxes();
            */
            int Empe_No;
            if (int.TryParse(txtENumber.Text, out Empe_No))
            {
                if (DeleteEmployee(Empe_No))
                {
                    MessageBox.Show("Employee successfully deleted!");
                    clearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Deleting employee unsuccessfull!\n Please try again!");
                }

            }
            else
            {
                MessageBox.Show("Invalid input!");
            }
            loadAll();
        }
        private Boolean DeleteEmployee(int Emp_No)
        {

            try
            {
                //String delete_sql 
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                Adap = new SqlDataAdapter();
                String delete_sql = "DELETE FROM Employee WHERE Employee_Number = " + Emp_No;
                Cmd = new SqlCommand(delete_sql, Conn);
                Cmd.ExecuteNonQuery();
                Adap.DeleteCommand = Cmd;
                Adap.DeleteCommand.ExecuteNonQuery();

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
                Conn = new SqlConnection(ConnectionString);
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

        private Boolean UpdateEmployee(long Employee_No, string firstName, string lastName, long cellphoneNumber, string email, long idNumber)
        {
            /* try
             {
                 Conn = new SqlConnection(ConnectionString);
                 Conn.Open();

                 Adap = new SqlDataAdapter();

                 string sql = @"UPDATE Employee SET First_Name= '" + firstname + "', Last_Name = '" + lastname + "', ID_Number= '" + idNumber + "', cell_No= '" + cellphoneNumber + "', Email_Address= '" + email + "' WHERE First_Name= '" + firstname + "'";
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
            */
            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                Adap = new SqlDataAdapter();

                string sql = @"UPDATE Employee SET First_Name= '" + firstName + "',Last_Name= '" + lastName + "', cell_No= '" + cellphoneNumber + "', Email_Address= '" + email + "', ID_Number= '" + idNumber + "' WHERE Employee_Number= '" + Employee_No + "'";
                Cmd = new SqlCommand(sql, Conn);



                Adap.UpdateCommand = Cmd;
                Adap.UpdateCommand.ExecuteNonQuery();


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



        private void btnUpdateME_Click(object sender, EventArgs e)
        {
            string firstName = txtFNameME.Text;
            string lastName = txtLNameME.Text;
            long idNumber;
            long cellphoneNumber;
            string email = txtEmailME.Text;
            long Employee_No = long.Parse(txtENumber.Text);

            if (!(firstName == ""))
            {
                if (!(lastName == ""))
                {
                    if (long.TryParse(txtINumberMe.Text, out idNumber) && txtINumberMe.Text.Length == 13)
                    {
                        if (!(email == ""))
                        {
                            if (long.TryParse(txtCellphoneME.Text, out cellphoneNumber))
                            {
                                if (UpdateEmployee(Employee_No, firstName, lastName, cellphoneNumber, email, idNumber))
                                {
                                    MessageBox.Show("Employee successfully updated!");
                                    clearTextBoxes();
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

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
        }
    }
}

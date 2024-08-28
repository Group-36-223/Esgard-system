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
        String ConnectionString = @"Data Source=LAPTOP-2IBBG9V4;Initial Catalog=Esgard;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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
        private Boolean employeeNumberFound(long employeeNumberSearch)
        {

            //clearTextBoxes();
            txtFNameME.Text = "";
            txtLNameME.Text = "";
            txtCellphoneME.Text = "";
            txtEmailME.Text = "";
            txtENumber.Text = "";
            txtPasswordME.Text = "";
            txtINumberMe.Text = "";
            //txtENumberMe.Text = "";
            Boolean didItThrewAnException = false;

            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                //Adap = new SqlDataAdapter();

                string sql = @"SELECT F_Name, L_Name, cell_No, Email_Address, ID_Number FROM Employee WHERE Employee_Number = " + employeeNumberSearch;
                Cmd = new SqlCommand(sql, Conn);

                Cmd.Parameters.AddWithValue("User_ID_No", employeeNumberSearch);

                SqlDataReader reader = Cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtFNameME.Text = reader["F_Name"].ToString();
                    txtLNameME.Text = reader["L_Name"].ToString();
                    txtINumberMe.Text = reader["ID_Number"].ToString();
                    txtEmailME.Text = reader["Email_Address"].ToString();
                    txtCellphoneME.Text = reader["cell_No"].ToString();
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

            long employeeNumberSearch;
            if (long.TryParse(txtENumberMe.Text, out employeeNumberSearch))
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



        }

        private void Maintain_Employees_Load(object sender, EventArgs e)
        {

        }

        private Boolean addEmployee(String firstName, string lastName, int cellphoneNumber, string email, long idNumber, int Password, int Employee_Number)
        {
            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                Adap = new SqlDataAdapter();

                string sql = @"INSERT INTO Employee (F_Name, L_Name, cell_No, Email_Address, ID_Number, Pssword, Employee_Number) VALUES ('" + firstName + "','" + lastName + "','" + cellphoneNumber + "','" + email + "','" + idNumber + "', '" + Password + "', '" + Employee_Number + "')";
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
        }
        private void btnAddME_Click(object sender, EventArgs e)
        {
            string firstName = txtFNameME.Text;
            string lastName = txtLNameME.Text;
            long idNumber;
            int cellphoneNumber;
            string email = txtEmailME.Text;
            int Password;
            int Employee_Number;

            Random rnd = new Random();
            int rndPassword = rnd.Next(10000000, 99999999);
            txtPasswordME.Text = rndPassword.ToString();
            Password = rndPassword;

            //Random rnd = new Random();
            int rndEmployeeNum = rnd.Next(10000, 99999);
            txtENumber.Text = rndEmployeeNum.ToString();
            Employee_Number = rndEmployeeNum;

            if (!(firstName == ""))
            {
                if (!(lastName == ""))
                {
                    if (long.TryParse(txtINumberMe.Text, out idNumber) && txtINumberMe.Text.Length == 13)
                    {
                        if (!(email == ""))
                        {
                            if (int.TryParse(txtCellphoneME.Text, out cellphoneNumber) && txtCellphoneME.Text.Length == 10)
                            {
                                if (addEmployee(firstName, lastName, cellphoneNumber, email, idNumber, Password, Employee_Number))
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
                        MessageBox.Show("Please enter valid ID number with 13 digits!");
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

            loadAll();
            //ValidEmail();
            bool isValid = ValidEmail(email);
            //clearTextBoxes();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
        }
        private Boolean DeleteEmployee(int Emp_No)
        {

            try
            {
                //String delete_sql 
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                Adap = new SqlDataAdapter();
                String delete_sql = "DELETE Employee WHERE Employee_Number = " + Emp_No;
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
        private void btnDeleteME_Click(object sender, EventArgs e)
        {
            int Empe_No;
            if (int.TryParse(txtENumberMe.Text, out Empe_No))
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
        }

        private Boolean UpdateEmployee(int Employee_No, string firstName, string lastName, long cellphoneNumber, string email, long idNumber, int Password)
        {

            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                Adap = new SqlDataAdapter();

                string sql = @"UPDATE Employee SET F_Name= '" + firstName + "',L_Name= '" + lastName + "', cell_No= '" + cellphoneNumber + "', Email_Address= '" + email + "', ID_Number= '" + idNumber + "', Pssword= '" + Password + "' WHERE Employee_Number= '" + Employee_No + "'";
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
            int Password;
            string email = txtEmailME.Text;

            Random rnd = new Random();
            int rndPassword = rnd.Next(10000000, 99999999);
            txtPasswordME.Text = rndPassword.ToString();
            Password = rndPassword;

            //Random rnd = new Random();
            //int rndEmployeeNum = rnd.Next(10000, 99999);
            //txtENumber.Text = rndEmployeeNum.ToString();
            //Employee_Number = rndEmployeeNum;

            if (!(firstName == ""))
            {
                if (!(lastName == ""))
                {
                    if (long.TryParse(txtINumberMe.Text, out idNumber) && txtINumberMe.Text.Length == 13)
                    {
                        if (!(email == ""))
                        {
                            if (long.TryParse(txtCellphoneME.Text, out cellphoneNumber) && txtCellphoneME.Text.Length == 10)
                            {
                                if (UpdateEmployee(int.Parse(txtENumberMe.Text), firstName, lastName, cellphoneNumber, email, idNumber, Password))
                                {
                                    MessageBox.Show("Employee successfully updated!");
                                }
                                else
                                {
                                    MessageBox.Show("Error while updating new employee details!\nPlease try again!");
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
                        MessageBox.Show("Please enter valid ID number with 13 digits!");
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

            //clearTextBoxes();
            txtFNameME.Text = "";
            txtLNameME.Text = "";
            txtCellphoneME.Text = "";
            txtEmailME.Text = "";
            txtENumber.Text = "";
            txtPasswordME.Text = "";
            txtINumberMe.Text = "";
            //txtENumberMe.Text = "";


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
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void btnDisplayME_Click(object sender, EventArgs e)
        {
            loadAll();
        }

        private void txtINumberMe_TextChanged(object sender, EventArgs e)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            txtINumberMe.TextChanged += txtINumberMe_TextChanged;
            txtCellphoneME.TextChanged += txtCellphoneME_TextChanged;
            btnAddME.Enabled = false;
            btnUpdateME.Enabled = false;
        }

        private void txtCellphoneME_TextChanged(object sender, EventArgs e)
        {
            if (txtCellphoneME.Text.Length == 10)
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

        private bool ValidEmail(string email)
        {
            bool output = false;
            try
            {

                var emailValidator = new System.Net.Mail.MailAddress(email);
                output = (email.LastIndexOf(".") > email.LastIndexOf("@"));
            }
            catch
            {
                output = false;
            }
            return output;

        }

        private void txtEmailME_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
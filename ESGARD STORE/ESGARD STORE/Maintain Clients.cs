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
    public partial class Maintain_Clients : Form
    {
        public Maintain_Clients()
        {
            InitializeComponent();
        }

        string ConnectionString = @"Data Source=HIMALAYANTOP;Initial Catalog=Esgard;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection Conn;
        SqlCommand Cmd;
        SqlDataAdapter Adap;
        SqlDataReader reader;
        DataSet Ds;

        private void Maintain_Clients_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Dashboard ds = new Dashboard();
            //ds.ShowDialog();

            Dashboard ds = Application.OpenForms["Dashboard"] as Dashboard;


            if (ds == null)
            {
                ds = new Dashboard();
                ds.Show();
            }
            else
            {
                ds.BringToFront();
            }


            this.Close();
        }

        private Boolean clientNumberFound(int clientNumberSearch)
        {

            clearTextBoxes();
            Boolean didItThrewAnException = false;

            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                //Adap = new SqlDataAdapter();

                string sql = @"SELECT F_Name, L_Name, Cell_No, Email_Address, ID_Number, Client_Number FROM Client WHERE Client_Number = " + clientNumberSearch;
                Cmd = new SqlCommand(sql, Conn);

                Cmd.Parameters.AddWithValue("Client_Number", clientNumberSearch);

                SqlDataReader reader = Cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtFNameMC.Text = reader["F_Name"].ToString();
                    txtLNameMC.Text = reader["L_Name"].ToString();
                    txtCellphoneMC.Text = reader["Cell_No"].ToString();
                    txtEmailMC.Text = reader["Email_Address"].ToString();
                    txtINumberMC.Text = reader["ID_Number"].ToString();
                    txtClientNumber.Text = reader["Client_Number"].ToString();
                }
                reader.Close();            

                Cmd.Dispose();
                Conn.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                didItThrewAnException = true;

            }

            if (!didItThrewAnException && !(txtFNameMC.Text == ""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

            private Boolean addEmployee(String firstName, string lastName, int cellphoneNumber , string Email , long idNumber, int clientNumber)
        {
            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                Adap = new SqlDataAdapter();

                string sql = @"INSERT INTO Client (F_Name, L_Name, Cell_No, Email_Address, ID_Number, Client_Number) VALUES ('" + firstName + "','" + lastName + "','" + cellphoneNumber + "','" + Email + "','" + idNumber + "', '" + clientNumber + "')";
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

        private void btnAddMC_Click(object sender, EventArgs e)
        {
            string firstName = txtFNameMC.Text;
            string lastName = txtLNameMC.Text;
            long idNumber;
            int cellphoneNumber;
            string Email = txtEmailMC.Text;

            Random rand = new Random();
            int randClientNumber = rand.Next(10000, 99999);
            txtClientNumber.Text = randClientNumber.ToString();

            if (!(firstName == ""))
            {
                if (!(lastName == ""))
                {
                    if (long.TryParse(txtINumberMC.Text, out idNumber) && txtINumberMC.Text.Length == 13)
                    {
                        if (!(Email == ""))
                        {
                            if (int.TryParse(txtCellphoneMC.Text, out cellphoneNumber))
                            {
                                if (addEmployee(firstName, lastName, cellphoneNumber, Email, idNumber, randClientNumber))
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
        }

         private Boolean updateClient(long clientNumber, String firstname, string lastname, int cellphoneNumber, string email, long idNumber)
        {
            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                Adap = new SqlDataAdapter();

                string sql = @"UPDATE Client SET F_Name= '" + firstname + "', L_Name = '" + lastname + "', Cell_No= '" + cellphoneNumber + "', Email_Address= '" + email + "', ID_Number= '" + idNumber + "' WHERE Client_Number= '" + clientNumber + "'";
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

            return true;
        }

        private void btnUpdateMC_Click(object sender, EventArgs e)
        {
            try
            {
                 string firstName = txtFNameMC.Text;
            string lastName = txtLNameMC.Text;
            long idNumber;
            int cellphoneNumber;
            string email = txtEmailMC.Text;
            

            if (!(firstName == ""))
            {
                if (!(lastName == ""))
                {
                    if (long.TryParse(txtINumberMC.Text, out idNumber) && txtINumberMC.Text.Length == 13)
                    {
                        if (!(email == ""))
                        {
                            if (int.TryParse(txtCellphoneMC.Text, out cellphoneNumber))
                            {
                                if (updateClient(long.Parse(txtClientMC.Text), firstName, lastName, cellphoneNumber, email, idNumber))
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
                clearTextBoxes();
               
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnConnect_Click(object sender, EventArgs e)
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
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            loadAll();
        }

        private void loadAll()
        {
            try
            {
                Conn.Open();
                string sql = "SELECT * FROM Client";
                Cmd = new SqlCommand(sql, Conn);
                Adap = new SqlDataAdapter();
                Ds = new DataSet();

                Adap.SelectCommand = Cmd;
                Adap.Fill(Ds, "Client");

                dgvClients.DataSource = Ds;
                dgvClients.DataMember = "Client";

                Conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void clearTextBoxes()
        {
            txtINumberMC.Text = "";
            txtClientMC.Text = "";
            txtClientNumber.Text = "";
            txtEmailMC.Text = "";
            txtFNameMC.Text = "";
            txtCellphoneMC.Text = "";
            txtLNameMC.Text = "";

            loadAll();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
        }

        private void btnDeleteMC_Click(object sender, EventArgs e)
        {
            Conn.Open();
            string sql = "DELETE FROM Client WHERE Client_Number = @num";
            Cmd = new SqlCommand(sql, Conn);
            Cmd.Parameters.AddWithValue("@num", txtClientNumber.Text);
            Cmd.ExecuteNonQuery();

            Conn.Close();

            MessageBox.Show("Deleted Successfully");

            loadAll();
        }

        private void btnSearchMC_Click(object sender, EventArgs e)
        {
            int clientNumberSearch;
            if (int.TryParse(txtClientMC.Text, out clientNumberSearch))
            {
                if (clientNumberFound(clientNumberSearch))
                {
                    MessageBox.Show("Client successfully found!");
                }
                else
                {
                    MessageBox.Show("Client does not exist!");
                }

            }
            else
            {
                MessageBox.Show("Invalid input!");
            }

            loadAll();
        }
    }
}

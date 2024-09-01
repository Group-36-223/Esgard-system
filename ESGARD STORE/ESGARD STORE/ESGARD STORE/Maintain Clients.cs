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

        string ConnectionString = @"Data Source=KAASKRULLE;Initial Catalog=Esgard;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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

                string sql = @"SELECT First_Name, Last_Name, Cell_No, Email_Address, Client_Number FROM Client WHERE Client_Number = " + clientNumberSearch;
                Cmd = new SqlCommand(sql, Conn);

                Cmd.Parameters.AddWithValue("Client_Number", clientNumberSearch);

                SqlDataReader reader = Cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtFNameMC.Text = reader["First_Name"].ToString();
                    txtLNameMC.Text = reader["Last_Name"].ToString();
                    txtCellphoneMC.Text = reader["Cell_No"].ToString();
                    txtEmailMC.Text = reader["Email_Address"].ToString();
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

            private Boolean addClient(String firstName, string lastName, int cellphoneNumber , string Email , int clientNumber)
        {
            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                Adap = new SqlDataAdapter();

                string sql = @"INSERT INTO Client (First_Name, Last_Name, Cell_No, Email_Address, Client_Number) VALUES ('" + firstName + "','" + lastName + "','" + cellphoneNumber + "','" + Email + "', '" + clientNumber + "')";
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
            int cellphoneNumber;
            string Email = txtEmailMC.Text;

            Random rand = new Random();
            int randClientNumber = rand.Next(10000, 99999);
            txtClientNumber.Text = randClientNumber.ToString();

            if (!(firstName == ""))
            {
                if (!(lastName == ""))
                {
                    if (!(Email == ""))
                    {
                        if (int.TryParse(txtCellphoneMC.Text, out cellphoneNumber))
                        {
                            if (addClient(firstName, lastName, cellphoneNumber, Email, randClientNumber))
                            {
                                MessageBox.Show("Client successfully added!");
                            }
                            else
                            {
                                MessageBox.Show("Error while adding new client details!\nPlease try again!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid cellphone number!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid Email!");
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
        }
       

         private Boolean updateClient(int clientNumber, String firstname, string lastname, long cellphoneNumber, string email)
        {
            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                Adap = new SqlDataAdapter();

                string sql = @"UPDATE Client SET First_Name= '" + firstname + "', Last_Name = '" + lastname + "', Cell_No= '" + cellphoneNumber + "', Email_Address= '" + email + "' WHERE Client_Number= '" + clientNumber + "'";
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
            
                string firstName = txtFNameMC.Text;
                string lastName = txtLNameMC.Text;
                long cellphoneNumber;
                string email = txtEmailMC.Text;
                int clientNumber;

                if (!(firstName == ""))
                {
                    if (!(lastName == ""))
                    {
                        if (!(email == ""))
                        {
                            if (long.TryParse(txtCellphoneMC.Text, out cellphoneNumber))
                            {
                            if (int.TryParse(txtClientNumber.Text, out clientNumber))
                             {
                                        if (updateClient(clientNumber, firstName, lastName, cellphoneNumber, email))
                                        {
                                            MessageBox.Show("Employee successfully updated!");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Error while updating Client details!\nPlease try again!");
                                        }
                             }
                            else
                            {
                                MessageBox.Show("Please enter a valid client number!");
                            }
                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid cellphone number!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid email!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid last name!");
                    }
                }
                else
                {
                     MessageBox.Show("Please enter a valid first name!");
                }

                loadAll();
                clearTextBoxes();
           
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

        private void txtEmailMC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

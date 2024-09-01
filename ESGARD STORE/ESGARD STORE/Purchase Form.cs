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
    public partial class Purchase_Form : Form
    {
        String ConnectionString = @"Data Source=HIMALAYANTOP;Initial Catalog=Esgard;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection Conn;
        SqlCommand Cmd;
        SqlDataAdapter Adap;
        SqlDataReader reader;
        DataSet Ds;
        private DateTime startTime;
        private Timer timer;
        public Purchase_Form()
        {
            InitializeComponent();
            startTime = DateTime.Now;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - startTime;
            lblCurrentDate.Text = DateTime.Now.ToString("MM, dd, yyyy HH:mm:ss");
            lblCurrentDate.Visible = true;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Dashboard ds = new Dashboard();
            //ds.ShowDialog();
            this.Close();
        }


        private void clearTextBoxes()
        {
            txtBarPF.Text = "";
            txtColorPF.Text = "";
            txtDescrPF.Text = "";
            txtPricePF.Text = "";
            txtSizePF.Text = "";
            txtQtyPF.Text = "";
            txtClientID_PF.Text = "";
            txtEmpID_PF.Text = "";
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



        private bool ValidateForeignKeys(string ClientName, string EmployeeName)
        {
            SqlConnection Conn = null;
            SqlCommand clientCmd = null;
            SqlCommand employeeCmd = null;
            SqlCommand paymentTypeCmd = null;
            SqlDataReader reader = null;

            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();
                //check Client_ID
                string checkClientSql = "SELECT First_Name FROM Client WHERE First_Name  ='" + ClientName + "'";
                clientCmd = new SqlCommand(checkClientSql, Conn);
                clientCmd.Parameters.AddWithValue("Client_ID", ClientName);
                reader = clientCmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    MessageBox.Show("Client Name does not exist.");
                    return false;
                }
                reader.Close();

                //check Employee_ID
                string checkEmployeeSql = "SELECT First_Name FROM Employee WHERE First_Name  ='" + EmployeeName + "'";
                employeeCmd = new SqlCommand(checkEmployeeSql, Conn);
                employeeCmd.Parameters.AddWithValue("Employee_ID", EmployeeName);
                reader = employeeCmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    MessageBox.Show("Employee Name does not exist");
                    return false;
                }
                reader.Close();

                //check Payment_Type_ID
                /*  string checkPaymentSql = "SELECT Payment_Type_ID FROM Payment_Type WHERE Payment_Type_ID = '" + Payment_Type_ID + "'";
                  paymentTypeCmd = new SqlCommand(checkPaymentSql, Conn);
                  paymentTypeCmd.Parameters.AddWithValue("Payment_Type_ID", Payment_Type_ID);
                  reader = paymentTypeCmd.ExecuteReader();

                  if (!reader.HasRows)
                  {
                      MessageBox.Show("Payment ID does not exist");
                      return false;
                  }**/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured: " + ex.Message);
                return false;
            }

            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    reader.Dispose();
                }

                if (clientCmd != null)
                {
                    clientCmd.Dispose();
                }
                if (employeeCmd != null)
                {
                    employeeCmd.Dispose();
                }
                if (paymentTypeCmd != null)
                {
                    paymentTypeCmd.Dispose();
                }

                if (Conn != null)
                {
                    Conn.Close();
                    Conn.Dispose();
                }
            }

            return true;
        }


        public int GetEmployeeIdByName(string employeeName)
        {
            int employeeId = -1;  // Default value if employee not found


            string query = "SELECT Employee_ID FROM Employee WHERE First_Name = @EmployeeName"; // Adjust column and table names as needed

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmployeeName", employeeName);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        employeeId = Convert.ToInt32(reader["Employee_ID"]);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Handle exceptions (e.g., log the error)
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return employeeId;
        }
        public int GetClientIdByName(string clientName)
        {
            int clientId = -1;  // Default value if employee not found


            string query = "SELECT Client_ID FROM Client WHERE First_Name = @ClientName"; // Adjust column and table names as needed

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ClientName", clientName);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        clientId = Convert.ToInt32(reader["Client_ID"]);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Handle exceptions (e.g., log the error)
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return clientId;
        }
        public int GetPaymentTypeByName(string PaymentOption)
        {
            int paymentTypeID = -1;  // Default value if employee not found


            string query = "SELECT Payment_Type_ID FROM Payment_Type WHERE Payment_Option = @paymentOption"; // Adjust column and table names as needed

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@paymentOption", PaymentOption);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        paymentTypeID = Convert.ToInt32(reader["Payment_Type_ID"]);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Handle exceptions (e.g., log the error)
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return paymentTypeID;
        }

        private Boolean addPurchase(DateTime Purchase_Date_Time, decimal total_cost, bool Is_paid, char Purchase_number, int Client_ID, int Employee_ID, int Payment_Type_ID)
        {
            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                Adap = new SqlDataAdapter();

                string sql = @"INSERT INTO Purchases (Client_ID, Employee_ID, Payment_Type_ID, Purchase_Date_Time, total_cost, Is_paid, Purchase_number) VALUES ('" + Client_ID + "', '" + Employee_ID + "', '" + Payment_Type_ID + "', '" + Purchase_Date_Time + "', '" + total_cost + "', '" + Is_paid + "', '" + Purchase_number + "')";
                // string sql = @"INSERT INTO Purchases (Client_ID, Employee_ID, Payment_Type_ID, Purchase_Date_Time, total_cost, Is_paid, Purchase_number) VALUES ('" + Purchase_Date_Time + "', '" + total_cost + "', '" + Is_paid + "', '" + Purchase_number + "', '" + Client_ID + "', '" + Employee_ID + "', '" + Payment_Type_ID + "')";

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

        private decimal totalPrice = 0;
        private void btnAddCart_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtBarPF.Text) && !string.IsNullOrEmpty(txtDescrPF.Text) && !String.IsNullOrEmpty(txtQtyPF.Text) && !string.IsNullOrEmpty(txtPricePF.Text))
            {
                string descriptionT = txtDescrPF.Text;
                string priceT = txtPricePF.Text;
                string quantityT = txtQtyPF.Text;
                char Purchase_Number;

                if (decimal.TryParse(priceT, out decimal price) && int.TryParse(quantityT, out int quantity))
                {
                    Random rnd = new Random();
                    char rndChar = (char)('0' + rnd.Next(0, 10));
                    Purchase_Number = rndChar;
                    decimal itemTotalPrice = price * quantity;
                    totalPrice += itemTotalPrice;

                    string itemDetails = $"{descriptionT,-20} {priceT,10:C} {quantityT,10} {itemTotalPrice,15:C}";
                    listBox1.Items.Add(itemDetails);
                    lblTotalAmount.Text = $"{totalPrice:C}";
                    lblPurchaseN.Text = $"{rndChar:C}";
                    lblTotalAmount.Visible = true;
                    // lblPurchaseN.Visible = true;
                    clearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Please enter valid numbers for price and quantity.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }
        }

        private Boolean SerialNumberFound(string serialNumberSearch)
        {

            clearTextBoxes();
            Boolean didItThrewAnException = false;

            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                string sql = @"SELECT Descri, Color, Category, Serial_No, Unit_Price, Size FROM Inventory WHERE Serial_No = '" + serialNumberSearch + "'";
                Cmd = new SqlCommand(sql, Conn);
                Cmd.Parameters.AddWithValue("Serial_No", serialNumberSearch);
                SqlDataReader reader = Cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtBarPF.Text = reader["Serial_No"].ToString();
                    txtColorPF.Text = reader["Color"].ToString();
                    txtDescrPF.Text = reader["Descri"].ToString();
                    txtPricePF.Text = reader["Unit_Price"].ToString();
                    txtSizePF.Text = reader["Size"].ToString();

                }
                reader.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                didItThrewAnException = true;
            }

            return !didItThrewAnException && !string.IsNullOrEmpty(txtBarPF.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string serialNumberSearch = txtBarPF.Text.Trim();

            if (string.IsNullOrEmpty(serialNumberSearch))
            {
                MessageBox.Show("Please enter a number.");
                return;
            }
            /* if (SerialNumberFound(serialNumberSearch))
             {
                 MessageBox.Show("Item successfully found!");
             }*/
            if (!(SerialNumberFound(serialNumberSearch)))
            {
                MessageBox.Show("Item does not exist!");
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            clearTextBoxes();
            listBox1.Items.Clear();
            lblTotalAmount.Text = "";
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            DateTime Purchase_Date_Time = DateTime.Now;
            decimal total_cost = totalPrice;
            bool Is_paid = true;
            char Purchase_number;

            Random rnd = new Random();
            char rndChar = (char)('0' + rnd.Next(0, 10));
            Purchase_number = rndChar;
            string ClientName = txtClientID_PF.Text;
            string EmployeeName = txtEmpID_PF.Text;
            string Payment_Type = cboPayType_PF.SelectedItem.ToString();

            if (!(ClientName == "") && !(EmployeeName == ""))
            {
                if (ValidateForeignKeys(ClientName, EmployeeName))
                {
                    if (addPurchase(Purchase_Date_Time, total_cost, Is_paid, Purchase_number, GetClientIdByName(ClientName), GetEmployeeIdByName(EmployeeName), GetPaymentTypeByName(Payment_Type)))
                    {
                        MessageBox.Show("Payment Recieved and Purchase Recorded!");
                    }
                    else
                    {
                        MessageBox.Show("Cannot record purchase. Please try again.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid. Please enter a valid Client ID");
            }
            this.Close();
        }

        private void Purchase_Form_Load(object sender, EventArgs e)
        {


            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                //Adap = new SqlDataAdapter();

                string sql = @"SELECT Payment_Option FROM Payment_Type";
                Cmd = new SqlCommand(sql, Conn);

                SqlDataReader reader = Cmd.ExecuteReader();

                // SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    cboPayType_PF.Items.Add(reader["Payment_Option"].ToString());
                }
                reader.Close();

                Cmd.Dispose();
                Conn.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
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
        String ConnectionString = @"Data Source=KAASKRULLE;Initial Catalog=Esgard;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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

        

        private bool ValidateForeignKeys(int Client_ID, int Employee_ID, string Payment_Type_ID)
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
                string checkClientSql = "SELECT Client_ID FROM Client WHERE Client_ID = " + Client_ID;
                clientCmd = new SqlCommand(checkClientSql, Conn);
                clientCmd.Parameters.AddWithValue("Client_ID", Client_ID);
                reader = clientCmd.ExecuteReader();
                
                if(!reader.HasRows)
                {
                    MessageBox.Show("Client ID does not exist.");
                    return false;
                }
                reader.Close();

                //check Employee_ID
                string checkEmployeeSql = "SELECT Employee_ID FROM Employee WHERE Employee_ID = " + Employee_ID;
                employeeCmd = new SqlCommand(checkEmployeeSql, Conn);
                employeeCmd.Parameters.AddWithValue("Employee_ID", Employee_ID);
                reader = employeeCmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    MessageBox.Show("Employee ID does not exist");
                    return false;
                }
                reader.Close();

                //check Payment_Type_ID
                string checkPaymentSql = "SELECT Payment_Type_ID FROM Payment_Type WHERE Payment_Type_ID = '" + Payment_Type_ID + "'";
                paymentTypeCmd = new SqlCommand(checkPaymentSql, Conn);
                paymentTypeCmd.Parameters.AddWithValue("Payment_Type_ID", Payment_Type_ID);
                reader = paymentTypeCmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    MessageBox.Show("Payment ID does not exist");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured: " + ex.Message);
                return false;
            }

            finally
            {
                if(reader != null)
                {
                    reader.Close();
                    reader.Dispose();
                }

                if(clientCmd != null)
                {
                    clientCmd.Dispose();
                }
                if(employeeCmd != null)
                {
                    employeeCmd.Dispose();
                }
                if(paymentTypeCmd != null)
                {
                    paymentTypeCmd.Dispose();
                }

                if(Conn != null)
                {
                    Conn.Close();
                    Conn.Dispose();
                }
            }
            
            return true;
        }

        private Boolean addPurchase(DateTime Purchase_Date_Time, decimal total_cost, bool Is_paid, char Purchase_number, int Client_ID, int Employee_ID, string Payment_Type_ID)
        {
            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                Adap = new SqlDataAdapter();

                string sql = @"INSERT INTO Purchases (Purchase_Date_Time, total_cost, Is_paid, Purchase_number, Client_ID, Employee_ID, Payment_Type_ID ) VALUES ('" +Purchase_Date_Time+ "', '" +total_cost+ "', '" +Is_paid+ "', '"+Purchase_number+ "', '" +Client_ID+ "', '" +Employee_ID+ "', '" +Payment_Type_ID+ "')";
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
                    lblPurchaseN.Visible = true;
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
            if (SerialNumberFound(serialNumberSearch))
            {
                MessageBox.Show("Item successfully found!");
            }
            else
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
            int Client_ID;
            int Employee_ID;
            string Payment_Type_ID = cboPayType_PF.Text;

            if (int.TryParse(txtClientID_PF.Text, out Client_ID) && int.TryParse(txtEmpID_PF.Text, out Employee_ID))
            {
                if (ValidateForeignKeys(Client_ID, Employee_ID, Payment_Type_ID))
                {
                    if (addPurchase(Purchase_Date_Time, total_cost, Is_paid, Purchase_number, Client_ID, Employee_ID, Payment_Type_ID))
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
    }
 }
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

        private decimal totalPrice = 0;


        private Boolean addPurchase(DateTime Purchase_Date_Time, decimal total_cost, bool Is_paid, char Purchase_number, int Client_ID, int Employee_ID, int Payment_ID)
        {
            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                Adap = new SqlDataAdapter();

                string sql = @"INSERT INTO Purchases (Purchase_Date_Time, total_cost, Is_paid, Purchase_number, Client_ID, Employee_ID, Payment_ID ) VALUES ('" +Purchase_Date_Time+ "', '" +total_cost+ "', '" +Is_paid+ "', '"+Purchase_number+ "', '" +Employee_ID+ "', '" +Payment_ID+ "')";
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
                using (Conn = new SqlConnection(ConnectionString))
                {
                    Conn.Open();
                    string sql = @"SELECT Descri, Color, Category, Serial_No, Unit_Price FROM Inventory WHERE Serial_No = " + serialNumberSearch;

                    using (Cmd = new SqlCommand(sql, Conn))
                    {
                        Cmd.Parameters.Add(new SqlParameter("@Serial_No", SqlDbType.Char)
                        {
                            Value = serialNumberSearch
                        });

                        using (reader = Cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtBarPF.Text = reader["Serial_No"].ToString();
                                txtColorPF.Text = reader["Color"].ToString();
                                txtDescrPF.Text = reader["Category"].ToString();
                                txtPricePF.Text = reader["Unit_Price"].ToString();
                                txtSizePF.Text = reader["Inventory_ID"].ToString();

                            }
                            reader.Close();
                        }
                    }

                }
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
            int Payment_ID;
            if (int.TryParse(txtClientID_PF.Text, out Client_ID))
            {
                if (addPurchase(Purchase_Date_Time, total_cost, Is_paid, Purchase_number, Client_ID, Employee_ID, Payment_ID))
                {
                    MessageBox.Show("Payment Recieved and Purchase Recorded!");
                }
                else
                {
                    MessageBox.Show("Cannot record purchase. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Invalid Client ID. Please enter a valid Client ID");
            }
            this.Close();
        }
    }
 }
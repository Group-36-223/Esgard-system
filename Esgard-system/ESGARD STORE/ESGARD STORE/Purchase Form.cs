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
        String ConnectionString = @"Data Source=LAPTOP-2IBBG9V4;Initial Catalog=Esgard;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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
            lblDate.Text = DateTime.Now.ToString("MM, dd, yyyy HH:mm:ss");
            lblDate.Visible = true;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if(timer != null)
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
        private Boolean SerialNumberFound(string serialNumberSearch)
        {

            clearTextBoxes();
            Boolean didItThrewAnException = false;

            try
            {
                using (Conn = new SqlConnection(ConnectionString))
                {
                    Conn.Open();
                    string sql = @"SELECT Inventory_ID, Descri, Color, Category, Serial_No, Unit_Price FROM Inventory WHERE Serial_No = @Serial_No";

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
                                txtBarP.Text = reader["Serial_No"].ToString();
                                txtColorP.Text = reader["Color"].ToString();
                                txtDescrP.Text = reader["Category"].ToString();
                                txtPriceP.Text = reader["Unit_Price"].ToString();
                                txtSizeP.Text = reader["Inventory_ID"].ToString();
                                
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
            return !didItThrewAnException && !string.IsNullOrEmpty(txtBarP.Text);
        }

        private void clearTextBoxes()
        {
            txtBarP.Text = "";
            txtColorP.Text = "";
            txtDescrP.Text = "";
            txtPriceP.Text = "";
            txtSizeP.Text = "";
            txtQuantity.Text = "";
            txtClientN.Text = "";
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private Boolean addPurchase(DateTime Purchase_Date_Time, decimal total_cost, bool Is_paid, char Purchase_number, int Client_ID)
        {
            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                Adap = new SqlDataAdapter();

                string sql = @"INSERT INTO Purchases (Purchase_Date_Time, total_cost, Is_paid, Purchase_number, Client_ID ) VALUES (@PurchaseDateTime, @TotalCost, @IsPaid, @PurchaseNumber, @ClientID)";
                Cmd = new SqlCommand(sql, Conn);
                Cmd.Parameters.AddWithValue("@PurchaseDateTime", Purchase_Date_Time);
                Cmd.Parameters.AddWithValue("@TotalCost", total_cost);
                Cmd.Parameters.AddWithValue("@IsPaid", Is_paid);
                Cmd.Parameters.AddWithValue("@PurchaseNumber", Purchase_number.ToString());
                Cmd.Parameters.AddWithValue("@ClientID", Client_ID);
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

        private void btnProceed_Click_1(object sender, EventArgs e)
        {
            DateTime Purchase_Date_Time = DateTime.Now;
            decimal total_cost = totalPrice;
            bool Is_paid = true;
            char Purchase_number;
            
            Random rnd = new Random();
            char rndChar = (char)('0' + rnd.Next(0, 10));
            Purchase_number = rndChar;
            int Client_ID;
            if(int.TryParse(txtClientN.Text, out Client_ID))
            {
                if (addPurchase(Purchase_Date_Time, total_cost, Is_paid, Purchase_number, Client_ID))
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

        private void btnATCartP_Click(object sender, EventArgs e)
        {
            string serialNumberSearch = txtBarP.Text.Trim();
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

        private decimal totalPrice = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtBarP.Text) && !string.IsNullOrEmpty(txtDescrP.Text) && !String.IsNullOrEmpty(txtQuantity.Text) && !string.IsNullOrEmpty(txtPriceP.Text))
            {
                string descriptionT = txtDescrP.Text;
                string priceT = txtPriceP.Text;
                string quantityT = txtQuantity.Text;
                char Purchase_Number;

                if(decimal.TryParse(priceT, out decimal price) && int.TryParse(quantityT, out int quantity))
                {
                    Random rnd = new Random();
                    char rndChar = (char)('0' + rnd.Next(0, 10));
                    Purchase_Number = rndChar;
                    decimal itemTotalPrice = price * quantity;
                    totalPrice += itemTotalPrice;

                    string itemDetails = $"{descriptionT,-20} {priceT,10:C} {quantityT,10} {itemTotalPrice,15:C}";
                    listBox1.Items.Add(itemDetails);
                    lblTotalPrice.Text = $"{totalPrice:C}";
                    lblPurchaseN.Text = $"{rndChar:C}";
                    lblTotalPrice.Visible = true;
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


        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
            listBox1.Items.Clear();
            lblTotalPrice.Text = "";
        }
    }
}

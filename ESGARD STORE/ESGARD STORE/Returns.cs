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
    public partial class Returns : Form
    {
        String ConnectionString = @"Data Source=KAASKRULLE;Initial Catalog=Esgard;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection Conn;
        SqlCommand Cmd;
        SqlDataAdapter Adap;
        SqlDataReader reader;
        DataSet Ds;

        public Returns()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to process this return?", "Confirm Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int purchaseID;
                if (int.TryParse(txtPurchaseID.Text, out purchaseID))
                {
                    if (ProcessReturn(purchaseID))
                    {
                        MessageBox.Show("Return processed successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to process return. Please try again.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid Purchase ID.");
                }
            }
        }

        private bool ProcessReturn(int purchaseID)
        {
            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                // 1. Retrieve Inventory_ID and Quantity from Purchase_Detail table
                string queryDetail = "SELECT Inventory_ID, Qty_Sold FROM Purchase_Details WHERE Purchases_ID = @PurchaseID";
                Cmd = new SqlCommand(queryDetail, Conn);
                Cmd.Parameters.AddWithValue("@PurchaseID", purchaseID);

                // Start reading the data
                SqlDataReader readerProcess = Cmd.ExecuteReader();

                if (!readerProcess.HasRows)
                {
                    MessageBox.Show("No purchase details found for this Purchase ID.");
                    readerProcess.Close(); // Ensure reader is closed
                    return false;
                }

                List<int> inventoryIDs = new List<int>();
                List<int> quantities = new List<int>();

                while (readerProcess.Read())
                {
                    int inventoryID = (int)readerProcess["Inventory_ID"];
                    int quantityBought = (int)readerProcess["Qty_Sold"];

                    inventoryIDs.Add(inventoryID);
                    quantities.Add(quantityBought);
                }

                readerProcess.Close(); // Close the reader before executing further commands

                // 2. Update the Quantity_on_Hand in the Inventory table
                for (int i = 0; i < inventoryIDs.Count; i++)
                {
                    UpdateInventoryQuantity(inventoryIDs[i], quantities[i]);
                }

                // 3. Update the Is_Paid status in the Purchases table
                UpdatePurchaseStatus(purchaseID);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
                return false;
            }
            finally
            {
                if (Conn != null)
                {
                    Conn.Close();
                }
            }
        }


        private void UpdateInventoryQuantity(int inventoryID, int quantityBought)
        {
            string updateInventory = "UPDATE Inventory SET Quantity_On_Hand = Quantity_On_Hand + @QuantityBought WHERE Inventory_ID = @InventoryID";
            SqlCommand cmdUpdate = new SqlCommand(updateInventory, Conn);
            cmdUpdate.Parameters.AddWithValue("@QuantityBought", quantityBought);
            cmdUpdate.Parameters.AddWithValue("@InventoryID", inventoryID);
            cmdUpdate.ExecuteNonQuery();
        }

        private void UpdatePurchaseStatus(int purchaseID)
        {
            string updatePurchase = "UPDATE Purchases SET Is_paid = 0 WHERE Purchases_ID = @PurchaseID";
            SqlCommand cmdUpdate = new SqlCommand(updatePurchase, Conn);
            cmdUpdate.Parameters.AddWithValue("@PurchaseID", purchaseID);
            cmdUpdate.ExecuteNonQuery();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string clientID = txtSClientN.Text.Trim();
            string firstName = txtFirstName.Text.Trim();

            if (string.IsNullOrEmpty(clientID) && string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("Please enter a Client ID or First Name to search.");
                return;
            }

            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                // Create SQL query
                string sqlQuery = @"SELECT 
                                Purchases.Purchases_ID,
                                Purchases.Client_ID,
                                Purchases.Employee_ID,
                                Purchases.Payment_Type_ID,
                                Purchases.Purchase_Date_Time,
                                Purchases.total_cost,
                                Purchases.Is_paid,
                                Purchases.Purchase_number
                            FROM 
                                Purchases 
                            JOIN 
                                Client ON Purchases.Client_ID = Client.Client_ID
                            WHERE 
                                Purchases.Is_paid = 1 AND
                                ((@ClientID IS NULL OR Client.Client_ID = @ClientID) 
                                OR (@FirstName IS NULL OR Client.First_Name = @FirstName));";

                Cmd = new SqlCommand(sqlQuery, Conn);

                if (!string.IsNullOrEmpty(clientID))
                {
                    Cmd.Parameters.AddWithValue("@ClientID", clientID);
                }
                else
                {
                    Cmd.Parameters.AddWithValue("@ClientID", DBNull.Value);
                }

                if (!string.IsNullOrEmpty(firstName))
                {
                    Cmd.Parameters.AddWithValue("@FirstName", firstName);
                }
                else
                {
                    Cmd.Parameters.AddWithValue("@FirstName", DBNull.Value);
                }

                reader = Cmd.ExecuteReader();

                lbInfo.Items.Clear(); // Clear previous search results

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string purchaseInfo = $"Purchase ID: {reader["Purchases_ID"]}, " +
                                              $"Client ID: {reader["Client_ID"]}, " +
                                              $"Employee ID: {reader["Employee_ID"]}, " +
                                              $"Payment Type ID: {reader["Payment_Type_ID"]}, " +
                                              $"Date/Time: {reader["Purchase_Date_Time"]}, " +
                                              $"Total Cost: {reader["total_cost"]}, " +
                                              $"Is Paid: {reader["Is_paid"]}, " +
                                              $"Purchase Number: {reader["Purchase_number"]}";

                        lbInfo.Items.Add(purchaseInfo);
                    }
                }
                else
                {
                    lbInfo.Items.Add("No purchases found for the given client.");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
            finally
            {
                if (Conn != null)
                {
                    Conn.Close();
                }
            }
        }
    }
}

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
    public partial class Reports : Form
    {
        String ConnectionString = @"Data Source=LAPTOP-2IBBG9V4;Initial Catalog=Esgard;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection Conn;
        SqlCommand Cmd;
        SqlDataAdapter Adap;
        SqlDataReader reader;
        DataSet Ds;

        public Reports()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            /*GenerateTopSellingItemsReportForTab2();
            PopulateDateComboBox();
            PopulateClientComboBox();
            FilterReport();*/
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
       /* private void GenerateTopSellingItemsReportForTab2()
        {
            try
            {
                using (SqlConnection Conn = new SqlConnection(ConnectionString))
                {
                    Conn.Open();

                    // Build the client filter condition
                    string clientFilter = comboBoxClient.SelectedValue != null ? $"p.Client_ID = {comboBoxClient.SelectedValue}" : "1 = 1";

                    // Build the date filter condition
                    string dateFilter = comboBoxDate.SelectedValue != null ? $"p.Purchase_Date_Time = '{comboBoxDate.SelectedValue}'" : "1 = 1";

                    // SQL query with dynamic filters, removed Is_paid check
                    string sqlQuery = $@"
                    SELECT TOP 10 
                        i.Descri AS Item_Description,
                        SUM(pd.Qty_Sold) AS Total_Quantity_Sold,
                        MAX(p.Purchase_Date_Time) AS Most_Recent_Purchase_Date
                    FROM 
                        Purchase_Details pd
                    JOIN 
                        Inventory i ON pd.Inventory_ID = i.Inventory_ID
                    JOIN 
                        Purchases p ON pd.Purchases_ID = p.Purchases_ID
                    JOIN 
                        Client c ON p.Client_ID = c.Client_ID
                    WHERE 
                        {clientFilter} AND {dateFilter}
                    GROUP BY 
                        i.Descri
                    ORDER BY 
                        Total_Quantity_Sold DESC;";

                    SqlDataAdapter da = new SqlDataAdapter(sqlQuery, Conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    lstClient.Items.Clear();

                    // Add headings
                    lstClient.Items.Add("============================================");
                    lstClient.Items.Add("Item Description\t\tQuantity Sold\tMost Recent Purchase Date");
                    lstClient.Items.Add("============================================");

                    // Populate the ListBox with the results
                    foreach (DataRow row in dt.Rows)
                    {
                        string itemDescription = row["Item_Description"].ToString();
                        string totalQuantitySold = row["Total_Quantity_Sold"].ToString();
                        string mostRecentPurchaseDate = row["Most_Recent_Purchase_Date"].ToString();

                        // Format the display string with tab spacing for alignment
                        string displayText = $"{itemDescription,-30}\t{totalQuantitySold,5}\t{mostRecentPurchaseDate}";

                        // Add item to ListBox
                        lstClient.Items.Add(displayText);
                    }

                    // Add a footer line
                    lstClient.Items.Add("============================================");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }*/

        /*private void PopulateDateComboBox()
        {
            try
            {
                using (SqlConnection Conn = new SqlConnection(ConnectionString))
                {
                    Conn.Open();

                    string sqlQuery = @"
                    SELECT DISTINCT 
                        p.Purchase_Date_Time
                    FROM 
                        Purchases p";

                    SqlDataAdapter da = new SqlDataAdapter(sqlQuery, Conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboBoxDate.DisplayMember = "Purchase_Date_Time";
                    comboBoxDate.ValueMember = "Purchase_Date_Time";
                    comboBoxDate.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }*/

        /*private void PopulateClientComboBox()
        {
            try
            {
                using (SqlConnection Conn = new SqlConnection(ConnectionString))
                {
                    Conn.Open();

                    string sqlQuery = @"
                    SELECT DISTINCT 
                        c.Client_ID,
                        CONCAT(c.First_Name, ' ', c.Last_Name) AS FullName
                    FROM 
                        Purchases p
                    JOIN 
                        Client c ON p.Client_ID = c.Client_ID";

                    SqlDataAdapter da = new SqlDataAdapter(sqlQuery, Conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboBoxClient.DisplayMember = "FullName";
                    comboBoxClient.ValueMember = "Client_ID";
                    comboBoxClient.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }*/

        /*private void FilterReport()
        {
            try
            {
                //GenerateTopSellingItemsReportForTab2();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }*/

        /*private void comboBoxDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            //FilterReport();
        }*/

        /*private void comboBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            //FilterReport();
        }*/

        /*private void button1_Click(object sender, EventArgs e)
        {
            //GenerateTopSellingItemsReportForTab2();
        }*/

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-2IBBG9V4;Initial Catalog=Esgard;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"; // Update with your actual connection string
            string query = @"
            SELECT TOP 10 
                pd.ItemID, 
                i.ItemName, 
                SUM(pd.Quantity) AS TotalQuantitySold, 
                p.Price
            FROM 
                PurchaseDetail pd
            INNER JOIN 
                Purchase p ON pd.PurchaseID = p.PurchaseID
            INNER JOIN 
                Item i ON pd.ItemID = i.ItemID
            GROUP BY 
                pd.ItemID, i.ItemName, p.Price
            ORDER BY 
                TotalQuantitySold DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
    }
}
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
            //GenerateTopSellingItemsReportForTab2();
            //PopulateDateComboBox();
            //PopulateClientComboBox();
            //FilterReport();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-2IBBG9V4;Initial Catalog=Esgard;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"; 
            DateTime startDate = dateTimePicker1.Value.Date;
            DateTime endDate = dateTimePicker2.Value.Date.AddDays(1).AddSeconds(-1); // Include the entire end date

            // Determine the order by clause based on the selected radio button
            string orderByClause = rdoAsc.Checked ? "ORDER BY TotalQuantitySold ASC" : "ORDER BY TotalQuantitySold DESC";

            string query = $@"
            SELECT TOP 10 
                pd.Inventory_ID, 
                i.Unit_Price, 
                SUM(pd.Qty_Sold) AS TotalQuantitySold, 
                SUM(p.total_cost) AS TotalCost
            FROM 
                Purchase_Details pd
            INNER JOIN 
                Purchases p ON pd.Purchases_ID = p.Purchases_ID
            INNER JOIN 
                Inventory i ON pd.Inventory_ID = i.Inventory_ID
            WHERE 
                p.Purchase_Date_Time BETWEEN @StartDate AND @EndDate
            GROUP BY 
                pd.Inventory_ID, i.Serial_No, i.Unit_Price
            {orderByClause}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@StartDate", startDate);
                adapter.SelectCommand.Parameters.AddWithValue("@EndDate", endDate);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all TextBox controls
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }
                // Reset ComboBox selections
                else if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).SelectedIndex = -1;
                }
                // Reset CheckBox selections
                else if (ctrl is CheckBox)
                {
                    ((CheckBox)ctrl).Checked = false;
                }
                // Reset RadioButton selections
                else if (ctrl is RadioButton)
                {
                    ((RadioButton)ctrl).Checked = false;
                }
                // Reset DateTimePickers to current date
                else if (ctrl is DateTimePicker)
                {
                    ((DateTimePicker)ctrl).Value = DateTime.Now;
                }
            }

            // Clear the DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear(); 
        }
        private void ReportsForm_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-2IBBG9V4;Initial Catalog=Esgard;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"; // Update with your actual connection string

            string query = "SELECT F_Name FROM Client";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Populate ListBox or DataGridView
                    lstClient.DataSource = dataTable;
                    lstClient.DisplayMember = "F_Name";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private void lstClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update TextBox with the selected client's name
            if (lstClient.SelectedItem != null)
            {
                DataRowView selectedRow = lstClient.SelectedItem as DataRowView;
                txtClientName.Text = selectedRow["F_Name"].ToString();
                lstClient.Visible = false; // Hide the ListBox after selection
            }
        }

        private void btnGenerateCS_Click(object sender, EventArgs e)
        {
            string selectedClient = txtClientName.Text;

            if (string.IsNullOrEmpty(selectedClient))
            {
                MessageBox.Show("Please enter or select a client.");
                return;
            }

            string connectionString = @"Data Source=LAPTOP-2IBBG9V4;Initial Catalog=Esgard;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"; // Update with your actual connection string

            string query = @"
            SELECT 
                p.Purchases_ID, 
                p.Purchase_Date_Time, 
                p.total_cost
            FROM 
                Purchases p
            INNER JOIN 
                Client c ON p.Client_ID = c.Client_ID
            WHERE 
                c.F_Name = @ClientName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@ClientName", selectedClient);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                lstClient.DataSource = dataTable;

                // Optionally, calculate and display the total amount of all purchases
                decimal totalAmount = 0;
                foreach (DataRow row in dataTable.Rows)
                {
                    totalAmount += Convert.ToDecimal(row["total_cost"]);
                }
                lblTotalAmount.Text = $"Total Amount: {totalAmount:C}";
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
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
    }
}
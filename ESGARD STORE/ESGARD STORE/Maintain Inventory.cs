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
    public partial class Maintain_Inventory : Form
    {

        String ConnectionString = @"Data Source=LAPTOP-EM1DCRUG;Initial Catalog=Esgard;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection Conn;
        SqlCommand Cmd;
        SqlDataAdapter Adap;
        SqlDataReader reader;
        DataSet Ds;
        public Maintain_Inventory()
        {
            InitializeComponent();
        }

        private void Maintain_Inventory_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void btnAddMI_Click(object sender, EventArgs e)
        {
            string description = txtDesrMInventory.Text;
            string color = txtColorMI.Text;
            string category = txtCategory.Text;
            int SerialNumber;
            int Quantity_on_Hand;
            int size;
            int price;

            if (int.TryParse(txtSNumberMe.Text, out SerialNumber))
            {
                if(int.TryParse(txtQty.Text, out Quantity_on_Hand))
                { 
                if (!(description == ""))
                {
                    if (!(color == ""))
                    {
                        if (!(category == ""))
                        {
                            if (int.TryParse(txtSizeMI.Text, out size))
                            {
                                if (int.TryParse(txtPriceMI.Text, out price))
                                {
                                        if (addInventory(description, color, SerialNumber, size, category, Quantity_on_Hand, price)) ;

                                }
                                else
                                {
                                    MessageBox.Show("Please enter valid price!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please enter valid size!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid color!");
                        }
                    }
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid description!");
                    }

                }
            } 
            else
            {
                MessageBox.Show("Please enter valid barcode!");
            }
        
    }
        private Boolean SerialNumberFound(int SerialNumberSearch)
        {

            
           
            Boolean didItThrewAnException = false;

            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                //Adap = new SqlDataAdapter();

                string sql = @"SELECT Quantity_On_Hand, Descri, Size, Color, Category, Serial_Number FROM Inventory WHERE Inventory_ID = " + SerialNumberSearch;
                Cmd = new SqlCommand(sql, Conn);

                Cmd.Parameters.AddWithValue("Inventory_ID", SerialNumberSearch);

                SqlDataReader reader = Cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtSNumberMe.Text = reader["Serial_No"].ToString();
                    txtBarMInventory.Text = reader["Serial_No"].ToString();
                    txtDesrMInventory.Text = reader["Descri"].ToString();
                    txtColorMI.Text = reader["Color"].ToString();
                    txtPriceMI.Text = reader["Price"].ToString();
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

            if (!didItThrewAnException && !(txtSNumberMe.Text == ""))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private Boolean addInventory(string description, string Color, long Serial_No, int Size, string Category, int Quantity_On_Hand, int price)
        {
            
            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                Adap = new SqlDataAdapter();

                string sql = @"INSERT INTO Inventory (Quantity_On_Hand, description, Size, Color, Category, Serial_Number) VALUES ('" + Serial_No + "','" +  description + "','" + Color + "','" + Size + "','" +price+ "')";
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
            txtBarMInventory.Text = "";
            txtColorMI.Text = "";
            txtDesrMInventory.Text = "";
            txtPriceMI.Text = "";
            txtSizeMI.Text = "";
            txtSNumberMe.Text = "";
            
        }
        private void btnSearchME_Click(object sender, EventArgs e)
        {

        }

        private void txtENumberMe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

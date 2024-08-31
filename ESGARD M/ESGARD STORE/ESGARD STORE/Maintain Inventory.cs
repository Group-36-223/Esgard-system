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

        String ConnectionString = @"Data Source=KAASKRULLE;Initial Catalog=Esgard;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection Conn;
        SqlCommand Cmd;
        SqlDataAdapter Adap;
        SqlDataReader reader;
        DataSet Ds;

        public Maintain_Inventory()
        {
            InitializeComponent();
        }

        private void btnClearMI_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
        }

        private void btnBTDMI_Click(object sender, EventArgs e)
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
        private Boolean SerialNumberFound(long SerialNumberSearch)
        {
            clearTextBoxes();

            Boolean didItThrewAnException = false;

            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                //Adap = new SqlDataAdapter();

                string sql = @"SELECT Descri, Color, Category, Serial_No, Unit_Price, Quantity_On_Hand, Size FROM Inventory WHERE Serial_No = " + SerialNumberSearch;
                Cmd = new SqlCommand(sql, Conn);

                Cmd.Parameters.AddWithValue("Serial_No", SerialNumberSearch);

                SqlDataReader reader = Cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtBarMInventory.Text = reader["Serial_No"].ToString();
                    txtDesrMInventory.Text = reader["Descri"].ToString();
                    txtColorMI.Text = reader["Color"].ToString();
                    txtCategory.Text = reader["Category"].ToString();
                    txtPriceMI.Text = reader["Unit_Price"].ToString();
                    txtQty.Text = reader["Quantity_On_Hand"].ToString();
                    txtSizeMI.Text = reader["Size"].ToString();
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

            if (!didItThrewAnException && !(txtBarMInventory.Text == ""))
            {
                return true;
            }
            else
            {
                return false;
            }



        }

        private Boolean addInventory(string description, string Color, long Serial_No, string Size, string Category, int Quantity_On_Hand, decimal price)
        {
            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                Adap = new SqlDataAdapter();

                string sql = @"INSERT INTO Inventory (Descri, Color, Category, Serial_No, Unit_Price, Quantity_On_Hand, Size) VALUES ('" + description + "','" + Color + "','" + Category + "','" + Serial_No + "','" + price + "','" + Quantity_On_Hand + "','" + Size + "')";
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
            txtCategory.Text = "";
            txtQty.Text = "";
        }


        private void btnAddMI_Click(object sender, EventArgs e)
        {
            string description = txtDesrMInventory.Text;
            string color = txtColorMI.Text;
            string category = txtCategory.Text;
            long SerialNumber;
            int Quantity_on_Hand;
            string size;
            decimal price;

            if (long.TryParse(txtBarMInventory.Text, out SerialNumber))
            {
                if (int.TryParse(txtQty.Text, out Quantity_on_Hand))
                {
                    if (!(description == ""))
                    {
                        if (!(color == ""))
                        {
                            if (!(category == ""))
                            {
                                size = txtSizeMI.Text;
                                if (!string.IsNullOrEmpty(size))
                                {
                                    if (decimal.TryParse(txtPriceMI.Text, out price))
                                    {
                                        if (addInventory(description, color, SerialNumber, size, category, Quantity_on_Hand, price))
                                        {
                                            MessageBox.Show("Inventory successfully added!");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Error while adding new inventory details!\nPlease try again!");
                                        }
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
                MessageBox.Show("Please enter valid Serial Number!");
            }
            clearTextBoxes();
            loadAll();

        }

        private void btnSearchME_Click(object sender, EventArgs e)
        {

            long serialNumber;
            if (long.TryParse(txtSNumberMe.Text, out serialNumber))
            {
                if (SerialNumberFound(serialNumber))
                {
                    MessageBox.Show("Inventory successfully found!");
                }
                else
                {
                    MessageBox.Show("Inventory does not exist!");
                }

            }
            else
            {
                MessageBox.Show("Invalid input!");
            }

        }

        private Boolean UpdateInventory(string Description, string color, string category, long newSerialNumber, double price, int Qty, string size, long oldSerialNumber)
        {

            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                Adap = new SqlDataAdapter();

                string sql = @"UPDATE Inventory SET Descri= '" + Description + "',Color= '" + color + "', Category= '" + category + "', Serial_No= '" + newSerialNumber + "', Unit_Price= '" + price + "', Quantity_On_Hand= '" + Qty + "', Size= '" + size + "' WHERE Serial_No= '" + oldSerialNumber + "'";
                Cmd = new SqlCommand(sql, Conn);



                Adap.UpdateCommand = Cmd;
                Adap.UpdateCommand.ExecuteNonQuery();


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

        private void btnUpdateMI_Click(object sender, EventArgs e)
        {
            string description = txtDesrMInventory.Text;
            string color = txtColorMI.Text;
            string category = txtCategory.Text;
            long oldSerialNumber;
            long newSerialNumber;
            int Quantity_on_Hand;
            string size;
            double price;

            if (long.TryParse(txtBarMInventory.Text, out newSerialNumber))
            {
                oldSerialNumber = newSerialNumber;
                if (!(description == ""))
                {
                    if (!(color == ""))
                    {
                        size = txtSizeMI.Text;
                        if (!string.IsNullOrEmpty(size))
                        {
                            if (double.TryParse(txtPriceMI.Text, out price))
                            {
                                if (!(category == ""))
                                {

                                    if (int.TryParse(txtQty.Text, out Quantity_on_Hand))
                                    {

                                        if (UpdateInventory(description, color, category, newSerialNumber, price, Quantity_on_Hand, size, oldSerialNumber))
                                        {
                                            MessageBox.Show("Inventory successfully updated!");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Error while updating new inventory details!\nPlease try again!");
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show("Please enter valid Quantity!");
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Please enter valid category!");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid price!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid size!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid colour!");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid description of the product!");
                }

            }
            else
            {
                MessageBox.Show("Please enter a valid serial number!");
            }

            //clearTextBoxes();
            loadAll();
        }
        private Boolean DeleteInventory(long serialNumber)
        {

            try
            {
                //String delete_sql 
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                Adap = new SqlDataAdapter();
                String delete_sql = "DELETE FROM Inventory WHERE Serial_No = '" + serialNumber + "'";
                Cmd = new SqlCommand(delete_sql, Conn);
                Cmd.ExecuteNonQuery();
                Adap.DeleteCommand = Cmd;
                Adap.DeleteCommand.ExecuteNonQuery();

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

        private void btnDeleteMI_Click(object sender, EventArgs e)
        {
            long serialNumber;
            if (long.TryParse(txtBarMInventory.Text, out serialNumber))
            {
                if (DeleteInventory(serialNumber))
                {
                    MessageBox.Show("Inventory successfully deleted!");
                    clearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Deleting inventory unsuccessfull!\n Please try again!");
                }

            }
            else
            {
                MessageBox.Show("Invalid input!");
            }

            loadAll();
        }

        private void loadAll()
        {
            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();
                string sql = "SELECT * FROM Inventory";
                Cmd = new SqlCommand(sql, Conn);
                Adap = new SqlDataAdapter();
                Ds = new DataSet();

                Adap.SelectCommand = Cmd;
                Adap.Fill(Ds, "Inventory");

                dgvInventory.DataSource = Ds;
                dgvInventory.DataMember = "Inventory";

                Conn.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnDisplayMI_Click(object sender, EventArgs e)
        {
            loadAll();
        }

        private void btnBTDMI_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

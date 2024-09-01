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
    public partial class MaintainPType : Form
    {
        public MaintainPType()
        {
            InitializeComponent();
        }

        string ConnectionString = @"Data Source=KAASKRULLE;Initial Catalog=Esgard;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection Conn;
        SqlCommand Cmd;
        SqlDataAdapter Adap;
        SqlDataReader reader;
        DataSet Ds;

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


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private Boolean AddPT(string New_Payment)
        {
            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();
                Adap = new SqlDataAdapter();

                String sql = $"INSERT INTO Payment_Type (Payment_Option) VALUES ('" + New_Payment + "')";
                Cmd = new SqlCommand(sql, Conn);

                Adap.InsertCommand = Cmd;
                Adap.InsertCommand.ExecuteNonQuery();


                Cmd.Dispose();
                Conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }




        private Boolean updatePT(string New_Payment, string oldPayment_Type)
        {
            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();
                Adap = new SqlDataAdapter();

                string sql = @"UPDATE Payment_Type SET  Payment_Option ='" + New_Payment + "' WHERE Payment_Option = '" + oldPayment_Type + "'";
              //  string sql = @"UPDATE Employee SET F_Name= '" + firstName + "',L_Name= '" + lastName + "', cell_No= '" + cellphoneNumber + "', Email_Address= '" + email + "', ID_Number= '" + idNumber + "', Pssword= '" + Password + "' WHERE Employee_Number= '" + Employee_No + "'";

                Cmd = new SqlCommand(sql, Conn);

                Adap.UpdateCommand = Cmd;
                Adap.UpdateCommand.ExecuteNonQuery();


                Cmd.Dispose();
                Conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }



        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                string payment_type = txtANPayType.Text;

                if (!(payment_type == ""))
                {
                    if (AddPT(payment_type))
                    {
                        MessageBox.Show("New Payment Type successfully added");
                        cBSPayType.Items.Add(payment_type);
                        txtANPayType.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error while adding new payment type!\nPlease try again!");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid Payment Method");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Boolean DeletePaymentType(string p_type)
        {
            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                Adap = new SqlDataAdapter();
                String delete_sql = "DELETE FROM Payment_Type WHERE Payment_Option = '" + p_type + "'";
                Cmd = new SqlCommand(delete_sql, Conn);
                Cmd.ExecuteNonQuery();
                Adap.DeleteCommand = Cmd;
                Adap.DeleteCommand.ExecuteNonQuery();

                Cmd.Dispose();
                Conn.Close();
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return false;
            }

            return true;
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            string p_type;
            if (!(cBSPayType.SelectedIndex == -1))
            {
                p_type = cBSPayType.SelectedItem.ToString();
               
                if (DeletePaymentType(p_type))
                {
                    MessageBox.Show("Payment Option successfully deleted!");
                    //cBSPayType.Text = string.Empty;
                    txtANPayType.Text = "";
                }
                else
                {
                    MessageBox.Show("Deleting Payment Option unsuccessfull!\n Please try again!");
                }

            }
            else
            {
                MessageBox.Show("Please select payment type!");
            }
            cBSPayType.Text = string.Empty;

            loadAll();
        }

        private void btnUPDATE_Click_1(object sender, EventArgs e)
        {
            try
            {
                string oldPayment_type;
                string newPayment_type = txtANPayType.Text;

                if (!(cBSPayType.SelectedIndex == -1))
                {
                    if (!(newPayment_type == ""))
                    {
                        oldPayment_type = cBSPayType.SelectedItem.ToString();
                        if (updatePT(newPayment_type, oldPayment_type))
                        {
                            MessageBox.Show("Payment Type updated successfully");
                            //cBSPayType.Items.Add(newPayment_type);
                            txtANPayType.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Error while updating payment type!\nPlease try again!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid Payment Method");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a valid Payment Method");
                }
                cBSPayType.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadAll();
        }

        private void MaintainPType_Load(object sender, EventArgs e)
        {
                cBSPayType.Items.Clear();

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
                        cBSPayType.Items.Add(reader["Payment_Option"].ToString());
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

        private void loadAll()
        {
            /*  try
              {
                  Conn = new SqlConnection(ConnectionString);
                  Conn.Open();
                  string sql = "SELECT * FROM Payment_Type";
                  Cmd = new SqlCommand(sql, Conn);
                  Adap = new SqlDataAdapter();
                  Ds = new DataSet();

                  Adap.SelectCommand = Cmd;
                  Adap.Fill(Ds, "Payment_Type");

                  cBSPayType.DataSource = Ds;
                  cBSPayType.DataMember = "Payment_Type";

                  Conn.Close();
              }
              catch (Exception Ex)
              {
                  MessageBox.Show(Ex.Message);
              }*/
            {
                cBSPayType.Items.Clear();
                

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
                        cBSPayType.Items.Add(reader["Payment_Option"].ToString());
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
}
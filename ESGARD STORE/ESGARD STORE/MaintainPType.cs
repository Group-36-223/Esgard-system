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

        string ConnectionString = @"Data Source=HIMALAYANTOP;Initial Catalog=Esgard;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection Conn;
        SqlCommand Cmd;
        SqlDataAdapter Adap;
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

        private void LoadAll()
        {
            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();
                string sql = "SELECT Payment_Option FROM Payment_Type";
                Cmd = new SqlCommand(sql, Conn);
                Adap = new SqlDataAdapter();
                Ds = new DataSet();

                Adap.SelectCommand = Cmd;
                Adap.Fill(Ds, "Payment_Type");

                dgvMPT.DataSource = Ds;
                dgvMPT.DataMember = "Payment_Type";

                Conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }

        


        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                string paymentType = txtANPayType.Text;

                if (!string.IsNullOrEmpty(paymentType))
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to add this payment type", "Confirm Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (AddPT(paymentType))
                        {
                            MessageBox.Show("New payment type successfully added");
                            txtANPayType.Text = string.Empty;
                            LoadAll();
                        }
                        else
                        {
                            MessageBox.Show("Error while adding new payment type!\n Please try again!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid payment method");
                }
            }
            catch(Exception ex)
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
            try
            {
                if (dgvMPT.SelectedRows.Count > 0)
                {
                    string payment_Type = dgvMPT.SelectedRows[0].Cells[0].Value.ToString();

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this payment type?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        if (DeletePaymentType(payment_Type))
                        {
                            MessageBox.Show("Payment option successfully deleted");
                            txtANPayType.Text = string.Empty;
                            LoadAll();
                        }
                        else
                        {
                            MessageBox.Show("Deleting Payment Option was unsuccessful!\nPlease try again!");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Please select a Payment Type");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUPDATE_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvMPT.SelectedRows.Count > 0)
                {
                    string oldPaymentType = dgvMPT.SelectedRows[0].Cells[0].Value.ToString();
                    string newPaymentType = txtANPayType.Text;

                    if (!string.IsNullOrEmpty(newPaymentType))
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to update this payment type", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (updatePT(newPaymentType, oldPaymentType))
                            {
                                MessageBox.Show("Payment Type updated successfully");
                                txtANPayType.Text = string.Empty;
                                LoadAll();
                            }
                            else
                            {
                                MessageBox.Show("Error while updating payment type!\n Please try again!");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid payment method");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a payment type to update");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoadAll();
        }

        private void MaintainPType_Load(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void dgvMPT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* if (dgvMPT.SelectedRows.Count > 0)
            {
                txtANPayType.Text = dgvMPT.SelectedRows[0].Cells[0].Value.ToString();
            }*/
        }

        //private void dgvMPT_SelectionChanged()
private void dgvMPT_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMPT.SelectedRows.Count > 0)
            {
                txtANPayType.Text = dgvMPT.SelectedRows[0].Cells[0].Value.ToString();
            }
        }
    }
}
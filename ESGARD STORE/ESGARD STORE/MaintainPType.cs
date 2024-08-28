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

        private void MaintainPType_Load(object sender, EventArgs e, string PaymentType)
        {

            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                //Adap = new SqlDataAdapter();

                string sql = @"SELECT Payment_Option FROM Payment_Type";
                Cmd = new SqlCommand(sql, Conn);

                Cmd.Parameters.AddWithValue("Payment_Option", PaymentType);

                SqlDataReader reader = Cmd.ExecuteReader();
                if (reader.Read())
                {
                    cbxSlcPT.Text = reader["Payment_Option"].ToString();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string payment_type = txtNewPT.Text;

                if (!(payment_type == ""))
                {
                    if (AddPT(payment_type))
                    {
                        MessageBox.Show("New Payment Type successfully added");
                        cbxSlcPT.Items.Add(payment_type);
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

       

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.Open();
                string sql = "DELETE FROM Payment_Type WHERE Payment_Option = @opt";
                Cmd = new SqlCommand(sql, Conn);
                Cmd.Parameters.AddWithValue("@opt", txtNewPT.Text);
                Cmd.ExecuteNonQuery();

                Conn.Close();

                MessageBox.Show("Deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

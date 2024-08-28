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

        private void MaintainPType_Load(object sender, EventArgs e)
        {

        }

        private Boolean AddPT(string New_Payment)
        {
            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                Adap = new SqlDataAdapter();

                string sql = @"INSERT INTO Payment_Type (Payment_Option) VALUES ('" + New_Payment + "')";
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
                string new_item;

                if(!(payment_type == ""))
                {
                    if(cbxSlcPT.SelectedValue == null)
                    {
                        new_item = txtNewPT.Text;
                    }
                    else
                    {
                        MessageBox.Show("Payment type already selected");
                    }
                }
                else
                {
                    MessageBox.Show("Clear current item added");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Boolean UpdatePT(string Payment)
        {
            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                Adap = new SqlDataAdapter();

                string sql = @"INSERT INTO Payment_Type (Payment_Option) VALUES ('" + Payment + "')";
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

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            try
            {
                string payment_type = txtNewPT.Text;
                string new_item;

                if (!(payment_type == ""))
                {
                    if (cbxSlcPT.SelectedValue == null)
                    {
                        new_item = txtNewPT.Text;
                    }
                    else
                    {
                        MessageBox.Show("Payment type already selected");
                    }
                }
                else
                {
                    MessageBox.Show("Clear current item added");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Conn.Open();
            string sql = "DELETE FROM Payment_Type WHERE Payment_Option = @opt";
            Cmd = new SqlCommand(sql, Conn);
            Cmd.Parameters.AddWithValue("@opt", txtNewPT.Text);
            Cmd.ExecuteNonQuery();

            Conn.Close();

            MessageBox.Show("Deleted Successfully");

        }
    }
}

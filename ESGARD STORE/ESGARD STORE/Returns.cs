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
{public partial class Returns : Form
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
            Exchanges ex = new Exchanges();
            ex.ShowDialog();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*private Boolean clientNumberFound(int clientNumberSearch)
        {

            //clearTextBoxes();
            Boolean didItThrewAnException = false;

            try
            {
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();

                //Adap = new SqlDataAdapter();

                string sql = @"SELECT F_Name, L_Name, Cell_No, Email_Address, ID_Number, Client_Number FROM Client WHERE Client_Number = " + clientNumberSearch;
                Cmd = new SqlCommand(sql, Conn);

                Cmd.Parameters.AddWithValue("Client_Number", clientNumberSearch);

                SqlDataReader reader = Cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtFNameMC.Text = reader["F_Name"].ToString();
                    txtLNameMC.Text = reader["L_Name"].ToString();
                    txtCellphoneMC.Text = reader["Cell_No"].ToString();
                    txtEmailMC.Text = reader["Email_Address"].ToString();
                    txtINumberMC.Text = reader["ID_Number"].ToString();
                    txtClientNumber.Text = reader["Client_Number"].ToString();
                }
                reader.Close();

                Cmd.Dispose();
                Conn.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                didItThrewAnException = true;

            }

            if (!didItThrewAnException && !(txtFNameMC.Text == ""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
        private void btnSearch_Click(object sender, EventArgs e)
        {
                /*int clientNumberSearch;
                if (int.TryParse(txtClientMC.Text, out clientNumberSearch))
                {
                    if (clientNumberFound(clientNumberSearch))
                    {
                        MessageBox.Show("Client successfully found!");
                        lbInfo.Items.Add("FName".PadRight(20)+ "LName".PadRight(20)+ "Purchases".PadRight(20)+ "Date");
                    }
                    else
                    {
                        MessageBox.Show("Client does not exist!");
                    }

                }
                else
                {
                    MessageBox.Show("Invalid input!");
                }*/

              
        }
    }
}

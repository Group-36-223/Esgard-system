/*using System;
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
           // string description = txtDesrMInventory.Text;
            //string color = txtColorMI.Text;
            //int barcode;
           // int size;
           // decimal price;

            //if (int.TryParse(txtBarMInventory.Text, out barcode))
           // {
               // if (!(description == ""))
                //{
                   // if (!(color == ""))
                   // {
                       // if (int.TryParse(txtSizeMI.Text, out size))
                        {
                           // if (decimal.TryParse(txtPriceMI.Text, out price))
                            {
                              //  if (addInventory(Serial_No,Descri,Color, Category, Price, Size)) ;

                            }
                           // else
                            {
                            //    MessageBox.Show("Please enter valid price!");
                            }
                        }
                       // else
                        {
                            //MessageBox.Show("Please enter valid size!");
                        }
                    }
                   // else
                   // {
                       // MessageBox.Show("Please enter valid color!");
                    }
               // }
               // else
               // {
                   // MessageBox.Show("Please enter valid description!");
              //  }

           // }
            //else
            //{
            //    MessageBox.Show("Please enter valid barcode!");
            }
        
   // }
       // private Boolean SerialNumberFound(int SerialNumberSearch)
        //{

            
           
          //  Boolean didItThrewAnException = false;

            //try
            //{
                //Conn = new SqlConnection(ConnectionString);
                //Conn.Open();

                //Adap = new SqlDataAdapter();

                //string sql = @"SELECT Quantity_On_Hand, Descri, Size, Color, Category, Serial_Number FROM Inventory WHERE Inventory_ID = " + SerialNumberSearch;
                //Cmd = new SqlCommand(sql, Conn);

               // Cmd.Parameters.AddWithValue("Inventory_ID", SerialNumberSearch);

               // SqlDataReader reader = Cmd.ExecuteReader();
                //if (reader.Read())
               // {
                    //txtSNumberMe.Text = reader["Serial_No"].ToString();
                   // txtBarMInventory.Text = reader["Serial_No"].ToString();
                   // txtDesrMInventory.Text = reader["Descri"].ToString();
                   // txtColorMI.Text = reader["Color"].ToString();
                   // txtPriceMI.Text = reader["Price"].ToString();
               // }
               // reader.Close();
                /* Ds = new DataSet();

                 Adap.SelectCommand = Cmd;
                 Adap.Fill(Ds, "Employee");

                 dgv_Employee.DataSource = Ds;
                 dgv_Employee.DataMember = "Employee";

 Cmd.Dispose();
  Conn.Close();
            

}
catch (Exception Ex)
{
  MessageBox.Show(Ex.Message);
  didItThrewAnException = true;

}
/*
if (!didItThrewAnException && !(txtSNumberMe.Text == ""))
{
  return true;
}
else
{
  return false;
}

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
*/
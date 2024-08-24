using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESGARD_STORE
{
    public partial class Maintain_Inventory : Form
    {
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
            long barcode;
            int size;
            decimal price;

            if (long.TryParse(txtBarMInventory.Text, out barcode))
            {
                if (description == "")
                {
                    if (color == "")
                    {
                        if (int.TryParse(txtSizeMI.Text, out size))
                        {
                            if (decimal.TryParse(txtPriceMI.Text, out price))
                            {

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
                else
                {
                    MessageBox.Show("Please enter valid description!");
                }

            }
            else
            {
                MessageBox.Show("Please enter valid barcode!");
            }
        
    }
    }
}

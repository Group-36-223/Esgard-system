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
        public Reports()
        {
            InitializeComponent();
        }

        

        private void Reports_Load(object sender, EventArgs e)
        {
        

         

            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Inventory item";
            dataGridView1.Columns[1].Name = "Category";
            dataGridView1.Columns[2].Name = "Size";
            dataGridView1.Columns[3].Name = "SOLD Date";
            dataGridView1.Columns[4].Name = "Units Sold";
            dataGridView1.Columns[5].Name = "Price";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(comboBox1.Selecteditem != null) 
            {
                string selectedItem = comboBox1.SelectedItem.ToString();
            }
            
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}

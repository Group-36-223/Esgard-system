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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            string selectedItem = comboBox1.SelectedItem.ToString();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
          //  lblSize.Text = hScrollBar1.Value.ToString();
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
         //   lblSold.Text = hScrollBar1.Value.ToString();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            //DateTime startDate = DateTime.Today.AddDays(-29); // 29 days before today
            //DateTime endDate = DateTime.Today;

            // for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            // {
            //     comboBox1.Items.Add(date.ToString("yyyy-MM-dd"));  // Add dates in "yyyy-MM-dd" format
            //}


            //comboBox1.SelectedItem = endDate.ToString("yyyy-MM-dd");


            //comboBox1.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // }

            //private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
            //{
            //    string selectedDate = comboBox1.SelectedItem.ToString();
            //  MessageBox.Show($"You selected: {selectedDate}");
            // }
        }
    }
}

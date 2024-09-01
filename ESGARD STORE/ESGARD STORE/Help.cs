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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Exchanges_Load(object sender, EventArgs e)
        {

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

        private void btnExchange_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The item has been exchanged successfully");
            this.Close();
        }

        Dictionary<string, string> helpContent = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "purchase", "To record a purchase, fill out the necessary fields and click 'Submit'." },
            { "payment types", "Select the payment method from the list and ensure the details are correct." },
            { "Clients", "Add, update and delete client records." },
            { "inventory", "Add, update and delete inventory records." },
            { "Returns", "Function for returning inventory purchased by clients." },
        };

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtSearch.Text.Trim();
                if (helpContent.ContainsKey(keyword))
                {
                    lblHelpDisplay.Text = helpContent[keyword];
                }
                else
                {
                    lblHelpDisplay.Text = "Help topic not found. Please try a different keyword.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lblHelpDisplay.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            ds.ShowDialog();
            this.Close();
        }
    }
}

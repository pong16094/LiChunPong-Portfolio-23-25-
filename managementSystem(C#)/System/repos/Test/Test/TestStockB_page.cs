using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace Test
{
    public partial class TestStockB_page : Form
    {
        private BackgroundWorker backgroundWorker;
        public TestStockB_page()
        {
            InitializeComponent();
            InitializeBackgroundWorker();
        }

        private void InitializeBackgroundWorker()
        {
            backgroundWorker = new BackgroundWorker();
        }

        private void PopulateStockItems()
        {
            
        }

        private void SortByDangerLevel_Click(object sender, EventArgs e)
        {
          
        }
      

        private void SortByOrderID_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void StockID_Click(object sender, EventArgs e)
        {

        }

        private void listBox_Stock_B_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StockName_Click(object sender, EventArgs e)
        {

        }

        private void Qty_Click(object sender, EventArgs e)
        {

        }

        private void DangerLevel_Click(object sender, EventArgs e)
        {

        }

        private void Supplier_Click(object sender, EventArgs e)
        {

        }

        private void LOD_Click(object sender, EventArgs e)
        {

        }

        private void LOI_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TestStockB_page_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;database=lmc"))
                {
                    conn.Open();

                    string query = "SELECT * FROM `type b stock`";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}

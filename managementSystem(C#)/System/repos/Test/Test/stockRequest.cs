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
    public partial class stockRequest : Form
    {
        public stockRequest()
        {
            InitializeComponent();
        }

        private void stockRequest_Load(object sender, EventArgs e)
        {
            LoadOrder();
        }
        public void LoadOrder() {

            try
            {
                using (MySqlConnection conn = new MySqlConnection("server = 127.0.0.1; user id = root; database = lmc"))
                {
                    conn.Open();

                    string query = "SELECT * FROM `type a stock` WHERE `StockDangerLevel` >= `StockCurrentQty` UNION ALL SELECT * FROM `type b stock` WHERE `StockDangerLevel` >= `StockCurrentQty` UNION ALL SELECT * FROM `type c stock` WHERE `StockDangerLevel` >= `StockCurrentQty` UNION ALL SELECT * FROM `type d stock` WHERE `StockDangerLevel` >= `StockCurrentQty`";
                    MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
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

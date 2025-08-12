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
    public partial class Stock_D_record : Form
    {
        public Stock_D_record()
        {
            InitializeComponent();
        }

        private void Stock_D_record_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;database=lmc"))
                {
                    conn.Open();

                    string query = "SELECT * FROM `type d stock`";

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

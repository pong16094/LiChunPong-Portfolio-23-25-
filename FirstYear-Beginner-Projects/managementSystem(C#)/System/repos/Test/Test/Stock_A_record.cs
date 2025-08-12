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
    public partial class Stock_A_record : Form
    {
        public Stock_A_record()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Stock_A_record_InputLanguageChanging(object sender, InputLanguageChangingEventArgs e)
        {

        }

        private void Stock_A_record_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;database=lmc"))
                {
                    conn.Open();

                    string query = "SELECT * FROM `stock` WHERE StockID LIKE @stockID";
                    string stockIDPattern = "A%";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@stockID", stockIDPattern);

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

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }
        private void SearchData()
        {
            string Type = cbtype.Text+"%%%%";
            if (Type== "") { Type = "%"; }


            using (MySqlConnection connect = new MySqlConnection("server = 127.0.0.1; user id = root; database=lmc"))
            {
                connect.Open();
                string query = "SELECT * FROM `stock` WHERE StockID like @Type";
                MySqlCommand command = new MySqlCommand(query, connect);
                command.Parameters.AddWithValue("@type", Type);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}

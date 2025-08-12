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


namespace Login
{
    public partial class SeeLog : Form
    {
        public SeeLog()
        {
            
            InitializeComponent();
        }

        private void SeeLog_Load(object sender, EventArgs e)
        {
            LoadLog();
        }
        public void LoadLog() {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("server = 127.0.0.1; user id = root; database = lmc"))
                {
                    conn.Open();

                    string query = "SELECT * FROM mysql.general_log";
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

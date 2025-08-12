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
    public partial class ViewReOrederProcess : Form
    {
        public ViewReOrederProcess()
        {
            InitializeComponent();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new New_StockRecord_Meun().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void LoadOrder()
        {

            try
            {
                using (MySqlConnection conn = new MySqlConnection("server = 127.0.0.1; user id = root; database = lmc"))
                {
                    conn.Open();

                    string query = "SELECT * FROM `reorder` WHERE `status`='Processing'";
                    MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;

                    query = "SELECT * FROM `reorder` WHERE `status`='Delivering'";
                    sda = new MySqlDataAdapter(query, conn);
                    dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView2.DataSource = dt;

                    query = "SELECT * FROM `reorder` WHERE `status`='Complete'";
                    sda = new MySqlDataAdapter(query, conn);
                    dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView3.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void ViewReOrederProcess_Load(object sender, EventArgs e)
        {
            LoadOrder();
        }

        public void LoadOrder(string Status, DataGridView dgv, string Orderid)
        {
            if (Orderid == "") {
                LoadOrder();
                return;
            }
            try
            {
                using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;database=lmc"))
                {
                    conn.Open();

                    string query = "SELECT * FROM `reorder` WHERE `status` = @status AND `orderID` = @orderid";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@status", Status);
                    cmd.Parameters.AddWithValue("@orderid", Orderid);

                    MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgv.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        public void LoadOrder(string Status, DataGridView dgv,string datePattern,int i)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;database=lmc"))
                {
                    conn.Open();

                    string query = "SELECT * FROM `reorder` WHERE `status` = @status AND CONVERT(`date`, CHAR) LIKE @date";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@status", Status);
                    cmd.Parameters.AddWithValue("@date", "%" + datePattern + "%");

                    MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgv.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            LoadOrder("Processing", dataGridView1, textBox4.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            LoadOrder("Delivering", dataGridView2, textBox6.Text);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadOrder("Complete", dataGridView3, textBox1.Text);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            LoadOrder("Processing", dataGridView1, textBox3.Text,1);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            LoadOrder("Delivering", dataGridView2, textBox5.Text,1);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            LoadOrder("Complete", dataGridView3, textBox2.Text,1);

        }
    }
}

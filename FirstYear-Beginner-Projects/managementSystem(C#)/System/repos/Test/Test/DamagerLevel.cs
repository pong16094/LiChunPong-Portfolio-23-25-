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
    public partial class DamagerLevel : Form
    {
     
        public DamagerLevel()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
            this.dateTimePicker1.Enabled = false;
            dateTimePicker2.Value = DateTime.Now;
            this.dateTimePicker2.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new New_StockRecord_Meun().Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //updated Stock ID
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //past danger level
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //new danger level
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //when the stock has updated the danger level
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //who updated the danger level empName or empID
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //update button
            if (tbNo.Text == "" || tbafdl.Text == ""||tbby.Text =="") {
                MessageBox.Show("Please type value");
                return;
            }
            UpdateProduct(tbNo, tbafdl);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //update New stock data button
            insertProduct();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            //if there are any new stock is promoting 
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            //New stock danger level, just case senstive :3
        }

        private void DamagerLevel_Load(object sender, EventArgs e)
        {
            tbNo2.MaxLength = 7;
            try
            {
                using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1; user id=root; database=lmc"))
                {
                    conn.Open();

                    string query = "SELECT `StockID` FROM `stock`";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            AutoCompleteStringCollection str_coll = new AutoCompleteStringCollection();

                            while (reader.Read())
                            {
                                str_coll.Add(reader.GetString(0));
                            }
                            tbNo.AutoCompleteCustomSource = str_coll;
                            tbNo.AutoCompleteSource = AutoCompleteSource.CustomSource;
                            tbNo.AutoCompleteMode = AutoCompleteMode.Suggest;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the setup
                MessageBox.Show("An error occurred while setting up autocomplete: " + ex.Message);
            }
        }

        private void ProcessOrder(TextBox textBox, TextBox dl)
        {
            try
            {
                // Check if the product ID exists in the AutoCompleteCustomSource
                if (textBox.AutoCompleteCustomSource.Contains(textBox.Text))
                {
                    // Establish a connection to the MySQL database
                    using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;database=lmc"))
                    {
                        conn.Open();

                        // Prepare the SELECT query to retrieve product details
                        string query = "SELECT `StockDangerLevel` FROM `stock` WHERE `StockID`='" + textBox.Text + "'";

                        // Create a MySqlCommand object with the query and connection
                        using (MySqlCommand command = new MySqlCommand(query, conn))
                        {

                            // Execute the query and read the result
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    dl.Text = reader.GetString(0);
                                }
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the process
                MessageBox.Show("An error occurred while processing the order: " + ex.Message);
            }
        }


        private void tbNo_KeyDown(object sender, KeyEventArgs e)
        {
            ProcessOrder(tbNo, tbbfdl);
        }

        private void UpdateProduct(TextBox ID,TextBox qty)
        {
            using (MySqlConnection conn = new MySqlConnection("server = 127.0.0.1; user id = root; database = lmc"))
            {
                conn.Open();

                string UpdateQuery = "UPDATE `stock` SET `StockDangerLevel`=@qty WHERE   `StockID`='" + ID.Text + "'";

                using (MySqlCommand UpdateCommand = new MySqlCommand(UpdateQuery, conn))
                {
                    UpdateCommand.Parameters.AddWithValue("@qty", qty.Text);
                    UpdateCommand.ExecuteNonQuery();
                }
            }
            tbNo.Clear();
            qty.Clear();
            tbafdl.Clear();
            tbbfdl.Clear();
            tbby.Clear();
            MessageBox.Show("Update succcess");
        }

        private void insertProduct()
        {
            using (MySqlConnection conn = new MySqlConnection("server = 127.0.0.1; user id = root; database = lmc"))
            {
                conn.Open();
                
                string insertQuery = "INSERT INTO `stock`(`StockID`, `StockName`, `StockDangerLevel`, `StockCurrentQty`, `StockSupplier`, `StockPrice`) VALUES(@ProductNo,@ProductName, @DangerLevel, @QtyInStock, @Supply, @Price)";
                using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, conn))
                {
                    insertCommand.Parameters.AddWithValue("@ProductNo", tbNo2.Text);
                    insertCommand.Parameters.AddWithValue("@ProductName", tbName.Text);
                    insertCommand.Parameters.AddWithValue("@QtyInStock", Convert.ToInt32(0));
                    insertCommand.Parameters.AddWithValue("@Supply",textBox8.Text);
                    insertCommand.Parameters.AddWithValue("@Price", Convert.ToDecimal(tbprice.Text));
                    insertCommand.Parameters.AddWithValue("@DangerLevel", Convert.ToInt32(tbdl.Text));
                    insertCommand.ExecuteNonQuery();
                }
            }
            tbNo2.Clear();
            tbName.Clear();
            textBox8.Clear();
            tbprice.Clear();
            tbdl.Clear();
            MessageBox.Show("Update succcess");
        }

        private void tbafdl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbdl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DamagerLevel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}

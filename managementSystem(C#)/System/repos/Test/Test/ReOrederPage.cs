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
    public partial class ReOrederPage : Form
    {
        int orderID;
        private System.Windows.Forms.GroupBox originalGroupBox;
        public DateTime today = DateTime.Today;
        public ReOrederPage()
        {
            InitializeComponent();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbprice1.ReadOnly = true;
            tbprice2.ReadOnly = true;
            tbprice3.ReadOnly = true;
            tbprice4.ReadOnly = true;
            tbprice5.ReadOnly = true;
            tbprice6.ReadOnly = true;
            loadComboboxValue();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ViewReOrederProcess().Show(); ;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
       
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // if the Edit order part can create more group box then modify this re order form
            // same as edit order, click a button then create one more same group box next to the first one
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdatePrice(tbprice1, numericUpDown1, tbID1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Test.stockRequest sr = new Test.stockRequest();
            sr.Show();
        }
        public void loadComboboxValue()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("server = 127.0.0.1; user id = root; database = lmc"))
                {
                    conn.Open();

                    string query = "SELECT `StockName` FROM `stock` WHERE `StockDangerLevel`>=`StockCurrentQty`";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    MySqlDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("StockName", typeof(string));

                    // Add a new row with an empty string
                    DataRow newRow = dt.NewRow();
                    newRow["StockName"] = "";
                    dt.Rows.Add(newRow);

                    // Load the product data from the database
                    while (reader.Read())
                    {
                        newRow = dt.NewRow();
                        newRow["StockName"] = reader.GetString("StockName");
                        dt.Rows.Add(newRow);
                    }
                    reader.Close();
                    cbName1.ValueMember = "StockName";
                    cbName1.DataSource = dt;
                    cbName1.SelectedItem = null;
                    List<ComboBox> comboBoxList = new List<ComboBox>
{
    comboBox1,
    comboBox2,comboBox3,comboBox4,comboBox5
};
                    foreach (ComboBox comboBox in comboBoxList)
                    {
                        comboBox.BindingContext = new BindingContext();
                        comboBox.ValueMember = "StockName";
                        comboBox.DataSource = dt;
                        comboBox.SelectedItem = null;
                    }


                    conn.Close();
                }
            }
            catch (Exception)
            {
            }

        }
        private void ProcessOrder(TextBox id, TextBox lbprice, ComboBox name)
        {
            try
            {
                    using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;database=lmc"))
                    {
                        conn.Open();

                        // Prepare the SELECT query to retrieve product details
                        string query = "SELECT StockID, StockPrice FROM stock WHERE StockName = '" + name.Text + "'";
                        using (MySqlCommand command = new MySqlCommand(query, conn))
                        {
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    id.Text = reader.GetString(0);
                                    lbprice.Text = reader.GetString(1);
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

        private void cbName1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void cbName1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void cbName1_TextChanged(object sender, EventArgs e)
        {
            ProcessOrder(tbID1, tbprice1, cbName1);

        }
        private void UpdatePrice(TextBox label, NumericUpDown qty, TextBox id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("server = 127.0.0.1; user id = root; database = lmc"))
                {
                    conn.Open();

                    string query = "SELECT StockPrice FROM stock WHERE StockID = '" + id.Text + "'";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            double price = Convert.ToDouble(result);
                            label.Text = Convert.ToString((int)qty.Value * Convert.ToDouble(result));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the process
                MessageBox.Show("An error occurred while updating the price: " + ex.Message);
            }
        }
        private void insertProduct()
        {
            if (tbaddress.Text == "" || cbName1.SelectedIndex == 0||numericUpDown1.Value==0) {
                MessageBox.Show("Something were missing");
                return;
            }
            if (checkRepeat()) {
                MessageBox.Show("Something was duplicated");
                return;
            }
            using (MySqlConnection conn = new MySqlConnection("server = 127.0.0.1; user id = root; database = lmc"))
            {
                conn.Open();
                string query = "SELECT max(`orderID`) FROM `reorder` ";
                using (MySqlCommand comm = new MySqlCommand(query, conn))
                {
                    orderID = Convert.ToInt32(comm.ExecuteScalar());
                    orderID++;
                }

                if (cbName1.Text != "" && tbID1.Text != "" & numericUpDown1.Value != 0 && tbaddress.Text != "") { 
                string insertQuery = "INSERT INTO `reorder`(`orderID`, `StockID`, `StockName`, `Qty`, `totalPrice`, `address`,`Date`, `status`) VALUES (@orderID,@StockID,@StockName,@qty,@totalprice,@address,@date,@status)";
                using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, conn))
                {
                    insertCommand.Parameters.AddWithValue("@orderID", orderID);
                    insertCommand.Parameters.AddWithValue("@StockID", tbID1.Text);
                    insertCommand.Parameters.AddWithValue("@StockName", cbName1.Text);
                    insertCommand.Parameters.AddWithValue("@qty", Convert.ToInt32(numericUpDown1.Value));
                    insertCommand.Parameters.AddWithValue("@totalprice", Convert.ToInt32(tbprice1.Text));
                    insertCommand.Parameters.AddWithValue("@address", tbaddress.Text);
                    insertCommand.Parameters.AddWithValue("@date", today);
                    insertCommand.Parameters.AddWithValue("@status", "Processing");
                    insertCommand.ExecuteNonQuery();
                }
                }
                if (comboBox1.Text != "" && tbID2.Text != "" & numericUpDown2.Value != 0 && tbaddress2.Text != "")
                {
                    orderID++;
                    string insertQuery = "INSERT INTO `reorder`(`orderID`, `StockID`, `StockName`, `Qty`, `totalPrice`, `address`,`Date`, `status`) VALUES (@orderID,@StockID,@StockName,@qty,@totalprice,@address,@date,@status)";
                    using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, conn))
                    {
                        insertCommand.Parameters.AddWithValue("@orderID", orderID);
                        insertCommand.Parameters.AddWithValue("@StockID", tbID2.Text);
                        insertCommand.Parameters.AddWithValue("@StockName", comboBox1.Text);
                        insertCommand.Parameters.AddWithValue("@qty", Convert.ToInt32(numericUpDown2.Value));
                        insertCommand.Parameters.AddWithValue("@totalprice", Convert.ToInt32(tbprice2.Text));
                        insertCommand.Parameters.AddWithValue("@address", tbaddress2.Text);
                        insertCommand.Parameters.AddWithValue("@date", today);
                        insertCommand.Parameters.AddWithValue("@status", "Processing");
                        insertCommand.ExecuteNonQuery();
                    }
                }
                if (comboBox2.Text != "" && tbID3.Text != "" & numericUpDown3.Value != 0 && tbaddress3.Text != "")
                {
                    orderID++;
                    string insertQuery = "INSERT INTO `reorder`(`orderID`, `StockID`, `StockName`, `Qty`, `totalPrice`, `address`,`Date`, `status`) VALUES (@orderID,@StockID,@StockName,@qty,@totalprice,@address,@date,@status)";
                    using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, conn))
                    {
                        insertCommand.Parameters.AddWithValue("@orderID", orderID);
                        insertCommand.Parameters.AddWithValue("@StockID", tbID3.Text);
                        insertCommand.Parameters.AddWithValue("@StockName", comboBox2.Text);
                        insertCommand.Parameters.AddWithValue("@qty", Convert.ToInt32(numericUpDown3.Value));
                        insertCommand.Parameters.AddWithValue("@totalprice", Convert.ToInt32(tbprice3.Text));
                        insertCommand.Parameters.AddWithValue("@address", tbaddress3.Text);
                        insertCommand.Parameters.AddWithValue("@date", today);
                        insertCommand.Parameters.AddWithValue("@status", "Processing");
                        insertCommand.ExecuteNonQuery();
                    }
                }

                if (comboBox3.Text != "" && tbID4.Text != "" & numericUpDown4.Value != 0 && tbaddress4.Text != "")
                {
                    orderID++;
                    string insertQuery = "INSERT INTO `reorder`(`orderID`, `StockID`, `StockName`, `Qty`, `totalPrice`, `address`,`Date`, `status`) VALUES (@orderID,@StockID,@StockName,@qty,@totalprice,@address,@date,@status)";
                    using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, conn))
                    {
                        insertCommand.Parameters.AddWithValue("@orderID", orderID);
                        insertCommand.Parameters.AddWithValue("@StockID", tbID4.Text);
                        insertCommand.Parameters.AddWithValue("@StockName", comboBox3.Text);
                        insertCommand.Parameters.AddWithValue("@qty", Convert.ToInt32(numericUpDown4.Value));
                        insertCommand.Parameters.AddWithValue("@totalprice", Convert.ToInt32(tbprice4.Text));
                        insertCommand.Parameters.AddWithValue("@address", tbaddress4.Text);
                        insertCommand.Parameters.AddWithValue("@date", today);
                        insertCommand.Parameters.AddWithValue("@status", "Processing");
                        insertCommand.ExecuteNonQuery();
                    }
                }
                if (comboBox4.Text != "" && tbID5.Text != "" & numericUpDown5.Value != 0 && tbaddress5.Text != "")
                {
                    orderID++;
                    string insertQuery = "INSERT INTO `reorder`(`orderID`, `StockID`, `StockName`, `Qty`, `totalPrice`, `address`,`Date`, `status`) VALUES (@orderID,@StockID,@StockName,@qty,@totalprice,@address,@date,@status)";
                    using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, conn))
                    {
                        insertCommand.Parameters.AddWithValue("@orderID", orderID);
                        insertCommand.Parameters.AddWithValue("@StockID", tbID5.Text);
                        insertCommand.Parameters.AddWithValue("@StockName", comboBox4.Text);
                        insertCommand.Parameters.AddWithValue("@qty", Convert.ToInt32(numericUpDown5.Value));
                        insertCommand.Parameters.AddWithValue("@totalprice", Convert.ToInt32(tbprice5.Text));
                        insertCommand.Parameters.AddWithValue("@address", tbaddress5.Text);
                        insertCommand.Parameters.AddWithValue("@date", today);
                        insertCommand.Parameters.AddWithValue("@status", "Processing");
                        insertCommand.ExecuteNonQuery();
                    }
                }
                if (comboBox5.Text != "" && tbID6.Text != "" & numericUpDown6.Value != 0 && tbaddress6.Text != "")
                {
                    orderID++;
                    string insertQuery = "INSERT INTO `reorder`(`orderID`, `StockID`, `StockName`, `Qty`, `totalPrice`, `address`,`Date`, `status`) VALUES (@orderID,@StockID,@StockName,@qty,@totalprice,@address,@date,@status)";
                    using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, conn))
                    {
                        insertCommand.Parameters.AddWithValue("@orderID", orderID);
                        insertCommand.Parameters.AddWithValue("@StockID", tbID6.Text);
                        insertCommand.Parameters.AddWithValue("@StockName", comboBox5.Text);
                        insertCommand.Parameters.AddWithValue("@qty", Convert.ToInt32(numericUpDown5.Value));
                        insertCommand.Parameters.AddWithValue("@totalprice", Convert.ToInt32(tbprice6.Text));
                        insertCommand.Parameters.AddWithValue("@address", tbaddress6.Text);
                        insertCommand.Parameters.AddWithValue("@date", today);
                        insertCommand.Parameters.AddWithValue("@status", "Processing");
                        insertCommand.ExecuteNonQuery();
                    }
                }



            }
            Clear();
            MessageBox.Show("Update succcess");
        }


        public void Clear() {
            cbName1.SelectedIndex = 0;
            tbID1.Clear();
            numericUpDown1.Value = 0;
            tbprice1.Clear();
            tbaddress.Clear();

            comboBox1.SelectedIndex = 0;
            tbID2.Clear();
            numericUpDown2.Value = 0;
            tbaddress2.Clear();
            tbprice2.Clear();

            comboBox2.SelectedIndex = 0;
            tbID3.Clear();
            numericUpDown3.Value = 0;
            tbaddress3.Clear();
            tbprice3.Clear();

            comboBox3.SelectedIndex = 0;
            tbID4.Clear();
            numericUpDown4.Value = 0;
            tbprice4.Clear();
            tbaddress4.Clear();

            comboBox4.SelectedIndex = 0;
            tbID5.Clear();
            numericUpDown5.Value = 0;
            tbaddress5.Clear();
            tbprice5.Clear();

            comboBox5.SelectedIndex = 0;
            tbID6.Clear();
            numericUpDown6.Value = 0;
            tbaddress6.Clear();
            tbprice6.Clear();

        }
        private void button6_Click(object sender, EventArgs e)
        {
            insertProduct();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new New_StockRecord_Meun().Show(); ;
            this.Hide();
        }
        public bool checkRepeat()
        {
            HashSet<String> productIdSet = new HashSet<String>();
            List<String> orderItemID = new List<String> { tbID1.Text, tbID2.Text, tbID3.Text, tbID4.Text, tbID5.Text };
            foreach (String item in orderItemID)
            {
                if (item == "")
                {
                    continue;
                }
                if (!productIdSet.Add(item))
                {
                    return true;
                }
            }
            return false;
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            ProcessOrder(tbID2, tbprice2, comboBox1);

        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            ProcessOrder(tbID3, tbprice3, comboBox2);
        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
            ProcessOrder(tbID4, tbprice4, comboBox3);

        }

        private void comboBox4_TextChanged(object sender, EventArgs e)
        {
            ProcessOrder(tbID5, tbprice5, comboBox4);

        }

        private void comboBox5_TextChanged(object sender, EventArgs e)
        {
            ProcessOrder(tbID6, tbprice6, comboBox5);

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            UpdatePrice(tbprice2, numericUpDown2, tbID2);

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            UpdatePrice(tbprice5, numericUpDown5, tbID5);

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            UpdatePrice(tbprice3, numericUpDown3, tbID3);

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            UpdatePrice(tbprice4, numericUpDown4, tbID4);

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            UpdatePrice(tbprice6, numericUpDown6, tbID6);

        }
    }
}

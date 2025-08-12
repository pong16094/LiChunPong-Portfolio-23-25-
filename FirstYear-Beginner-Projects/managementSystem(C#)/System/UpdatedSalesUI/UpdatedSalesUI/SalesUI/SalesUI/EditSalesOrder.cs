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


namespace SalesUI
{
    public partial class EditSalesOrder : Form
    {
        public String username;
        String productID;
        private string orderID;
        private Boolean isFirstClick = true;
        private int selectedRowIndex = -1;

        public EditSalesOrder()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
            this.dateTimePicker1.Enabled = false;
            dgv.ReadOnly = true;
        }

        private void BackToMainSalesPage_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //based in the user input to show different type of input text box
           
        }

        private void Update_Click(object sender, EventArgs e)
        {
            //send the new update to the database
            if ( tbNo1.Text == "" || tbqty.Text == "")
            {
                MessageBox.Show("Plase enter your name and  delivery address and the contact number");
                return;}

            String OrderID = "orderitems"+orderID;
            using (MySqlConnection conn = new MySqlConnection("server = 127.0.0.1; user id = root; database = lmc"))
            {
                conn.Open();
            
                string getprice = "SELECT Price FROM product WHERE ProductNo=@ID";
                MySqlCommand comm = new MySqlCommand(getprice, conn);
                    comm.Parameters.AddWithValue("@iD", tbNo1.Text);
                object price = comm.ExecuteScalar();



                MySqlCommand cmd = new MySqlCommand($"UPDATE {OrderID} SET `OrderItemID`= @OrderItemID,`OrderID`=@ID,`ProductName`= @ProductName,`Quantity`= @Quantity,`TotalPrice`= @TotalPrice where `OrderItemID`='"+productID+"'" , conn);
                cmd.Parameters.AddWithValue("@OrderItemID", tbNo1.Text);
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(orderID));
                cmd.Parameters.AddWithValue("@ProductName", tbName.Text);
                cmd.Parameters.AddWithValue("@Quantity", tbqty.Text);
                cmd.Parameters.AddWithValue("@TotalPrice", (Convert.ToInt32(tbqty.Text)* Convert.ToDouble(price)));

                int i = cmd.ExecuteNonQuery();
                if (i > 0) { MessageBox.Show("Record update success!", "CURD", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else{ MessageBox.Show("Record update failed!", "CURD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                LoadRecord(orderID);
                Clear();

               
            }
        }
        private void ProcessOrder(TextBox textBox, TextBox name)
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
                        string query = "SELECT ProductName FROM product WHERE ProductNo = '" + textBox.Text + "'";

                        // Create a MySqlCommand object with the query and connection
                        using (MySqlCommand command = new MySqlCommand(query, conn))
                        {
                            // Execute the query and read the result
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    name.Text = reader.GetString(0);                                }
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
        private void EditSalesOrder_Load(object sender, EventArgs e)
        {
            tbBy.Text =username;
            tbBy.ReadOnly = true;
            try
            {
                using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;database=lmc"))
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand("SELECT ProductNo FROM product", conn))
                    {
                        AutoCompleteStringCollection str_coll = new AutoCompleteStringCollection();
                        using (MySqlDataReader Noreader = command.ExecuteReader())
                        {
                            while (Noreader.Read())
                            {
                                string productNo = Noreader.GetString(0);
                                str_coll.Add(productNo);
                                Console.WriteLine(productNo);
                            }
                        }

                        tbNo1.AutoCompleteCustomSource = str_coll;
                        tbNo1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        tbNo1.AutoCompleteMode = AutoCompleteMode.Suggest;

                        Console.WriteLine($"AutoCompleteStringCollection Count: {str_coll.Count}");
                        Console.WriteLine($"tbNo1.AutoCompleteMode: {tbNo1.AutoCompleteMode}");
                        Console.WriteLine($"tbNo1.AutoCompleteSource: {tbNo1.AutoCompleteSource}");
                    }
                    LoadOrdersTable();
                   /* string load = "SELECT `OrderID`, `CustomerName`, `OrderDate`, `Address`, `Comment` FROM `orders`";
                    MySqlDataAdapter sda = new MySqlDataAdapter(load, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgv.DataSource = dt;*/
                }
               

                    
               
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        public void LoadOrdersTable() {

            MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;database=lmc");
                
                conn.Open();
                string load = "SELECT `OrderID`, `CustomerName`, `OrderDate`, `Address`, `Comment` FROM `orders`";
            MySqlDataAdapter sda = new MySqlDataAdapter(load, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv.DataSource = dt;
            conn.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
          // add another EitOrderBox next to the first box and let the user can Edit other data in the same order (if busy then igrone it)
          // update database, not require to create a new table
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //new groupbox example when the user click edit others
        }

        private void CreateSalesOrderPage_Load(object sender, EventArgs e)
        {
            
        }

        private void tbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
           
        }

        private void tbqty_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void EditSalesOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        public void LoadRecord(String orderID ) {
            string tableName = "orderitems" + orderID;

            using (MySqlConnection conn = new MySqlConnection("server = 127.0.0.1; user id = root; database = lmc"))
            {
                conn.Open();

                string query = $"SELECT `OrderItemID`, `OrderID`, `ProductName`, `Quantity`, `TotalPrice` FROM  {tableName}";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv.DataSource = dt;
                conn.Close();
            }
            
        }
        public void Clear() {
            tbBy.Clear();
            tbReason.Clear();
            tbName.Clear();
            tbNo1.Clear();
            tbqty.Clear();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            LoadOrdersTable();
            Clear();
            isFirstClick = true;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (isFirstClick)
                {
                    selectedRowIndex = e.RowIndex;
                    orderID = dgv.Rows[selectedRowIndex].Cells[0].Value.ToString();
                    LoadRecord(orderID);
                    isFirstClick = false;
                }
                else
                {
                    tbNo1.Text = dgv.CurrentRow.Cells[0].Value.ToString();
                    tbName.Text = dgv.CurrentRow.Cells[2].Value.ToString();
                    tbqty.Text = dgv.CurrentRow.Cells[3].Value.ToString();
                    productID = dgv.CurrentRow.Cells[0].Value.ToString();                    
                }
            }
        }

        private void tbNo1_KeyDown(object sender, KeyEventArgs e)
        {
            ProcessOrder(tbNo1, tbName);
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void EditSalesOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}

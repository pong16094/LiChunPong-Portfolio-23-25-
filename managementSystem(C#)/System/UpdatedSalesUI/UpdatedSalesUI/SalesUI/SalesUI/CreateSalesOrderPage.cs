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
    public partial class CreateSalesOrderPage : Form
    {
        public int orderID = 0;
        List<int> orderItems = new List<int>();
        

        public CreateSalesOrderPage()
        {
            InitializeComponent();
            this.AutoScroll = true;
            monthCalendar1.Enabled = false;


        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BackToMainSalesPage_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        public bool checkRepeat() {
                HashSet<String> productIdSet = new HashSet<String>();
            List<String> orderItemID = new List<String> { tbID1.Text, tbID2.Text, tbID3.Text, tbID4.Text, tbID5.Text };
            foreach (String item in orderItemID)
                {
                if (item == "") { 
                    continue;
                    }
                    if (!productIdSet.Add(item))
                    {
                        return true;
                    }
                }
                return false; 
            


        }
        private void button1_Click(object sender, EventArgs e)
        {

            // Sumbit the Order to the datebase > link to database(done)
            //generate the order ID(done)
            //It still can't process multi product order only can process the first product(not finish yet) 

            if (tbBuyerName.Text == "" || tbaddress.Text == "" || tbphoneNu.Text == "")
            {
                MessageBox.Show("Plase enter your name and  delivery address and the contact number");
                return;
            }

            if (checkRepeat()) { 
                MessageBox.Show("Some product was duplicated");
                return;
                }
            using (MySqlConnection conn = new MySqlConnection("server = 127.0.0.1; user id = root; database = lmc"))
            {
                conn.Open();
                string query = "SELECT MAX(OrderID) from orders";
                using (MySqlCommand comm = new MySqlCommand(query, conn))
                {
                    orderID = Convert.ToInt32(comm.ExecuteScalar());
                    orderID++;
                }
                

                // Insert the new order into the Orders table and get the generated OrderID
                string insertOrderQuery = "INSERT INTO orders VALUES ('"+orderID+"', '"+tbBuyerName.Text+"',@OrderDate, '"+tbaddress.Text+ "','" + tbMessage.Text + "');";
                using (MySqlCommand insertOrderCommand = new MySqlCommand(insertOrderQuery, conn))
                {
                    insertOrderCommand.Parameters.AddWithValue("@OrderDate", monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"));
                    insertOrderCommand.ExecuteNonQuery();
                }

                // Create the OrderItems table if it doesn't exist
                string tableName = "OrderItems" + orderID;
                string createOrderItemsTableQuery = $@"CREATE TABLE IF NOT EXISTS `{tableName}` (OrderItemID char(7) not null, OrderID INT not null, ProductName VARCHAR(255) NOT NULL, Quantity INT NOT NULL, TotalPrice DECIMAL(10, 2) NOT NULL, CONSTRAINT PK_OrderItems PRIMARY KEY (OrderItemID))";
                using (MySqlCommand createOrderItemsTableCommand = new MySqlCommand(createOrderItemsTableQuery, conn))
                {
                    createOrderItemsTableCommand.ExecuteNonQuery();
                }

                // Insert the new order item into the OrderItems 
                string insertOrderItemQuery = "INSERT INTO "+tableName+" VALUES ('"+tbID1.Text+"', @OrderID, '"+comboBox1.Text+"', @Quantity, @TotalPrice)"; 
                using (MySqlCommand insertOrderItemCommand = new MySqlCommand(insertOrderItemQuery, conn))
                {
                    insertOrderItemCommand.Parameters.AddWithValue("@OrderID", orderID);
                    insertOrderItemCommand.Parameters.AddWithValue("@Quantity", numericUpDown1.Value);
                    insertOrderItemCommand.Parameters.AddWithValue("@TotalPrice", decimal.Parse(lbprice1.Text)*Convert.ToInt32(numericUpDown1.Value));
                    int rowsAffected = insertOrderItemCommand.ExecuteNonQuery();
                    UpdateProduct(tbID1, numericUpDown1);
                    
                    if (rowsAffected > 0)
                    {
                        if (tbID2.Text != "" && comboBox1.Text != "" && numericUpDown2.Value > 0)
                        {
                            InsertMultipleOrderItems(orderID, tbID2, comboBox2, numericUpDown2, lbprice2, tableName);
                            UpdateProduct(tbID2, numericUpDown2);

                        }
                        if (tbID3.Text != "" && comboBox3.Text != "" && numericUpDown3.Value > 0)
                        {
                            InsertMultipleOrderItems(orderID, tbID3, comboBox3, numericUpDown3, lbprice3, tableName);
                            UpdateProduct(tbID3, numericUpDown3);
                        }
                        if (tbID4.Text != "" && comboBox4.Text != "" && numericUpDown4.Value > 0)
                        {
                            InsertMultipleOrderItems(orderID, tbID4, comboBox4, numericUpDown4, lbprice4, tableName);
                            UpdateProduct(tbID4, numericUpDown4);

                        }
                       /* if (tbID5.Text != "" && tbName5.Text != "" && numericUpDown5.Value > 0)//need to chaneg to combobox5
                        {
                            InsertMultipleOrderItems(orderID, tbID5, tbName5, numericUpDown5, lbprice5, tableName);
                            UpdateProduct(tbID5, numericUpDown5);

                        }*/
                        MessageBox.Show("Data inserted successfully.");
                    }
                }
            }
            tbBuyerName.Clear();
            tbphoneNu.Clear();
            tbaddress.Clear();
            comboBox1.SelectedIndex = 0;
            tbID1.Clear();
            lbprice1.Text ="";
            numericUpDown1.Value = 0;
            comboBox2.SelectedIndex = 0;
            tbID2.Clear();
            lbprice2.Text = "";
            numericUpDown2.Value = 0;
            comboBox3.SelectedIndex = 0;
            tbID3.Clear();
            lbprice3.Text = "";
            numericUpDown3.Value = 0;
            comboBox4.SelectedIndex = 0;
            tbID4.Clear();
            lbprice4.Text = "";
            numericUpDown4.Value = 0;
            comboBox5.SelectedIndex = 0;
            tbID5.Clear();
            lbprice5.Text = "";
            numericUpDown5.Value = 0;
            tbMessage.Clear();
            pb1.Image=null;
            pb2.Image = null;
            pb3.Image = null;
            pb4.Image = null;
            pb5.Image = null;




        }

        private void InsertMultipleOrderItems(int orderID,TextBox ID,ComboBox name, NumericUpDown qty,Label price,string table)
        {
            using (MySqlConnection conn = new MySqlConnection("server = 127.0.0.1; user id = root; database = lmc"))
            {
                conn.Open();

                string insertOrderItemQuery = "INSERT INTO  "+table+"  VALUES ('" + ID.Text + "', @OrderID, '" + name.Text + "', @Quantity, @TotalPrice)";

                using (MySqlCommand insertOrderItemCommand = new MySqlCommand(insertOrderItemQuery, conn))
                {
                    insertOrderItemCommand.Parameters.AddWithValue("@OrderID", orderID);
                    insertOrderItemCommand.Parameters.AddWithValue("@Quantity", qty.Value);
                    insertOrderItemCommand.Parameters.AddWithValue("@TotalPrice", decimal.Parse(price.Text)* Convert.ToInt32(qty.Value));
                    insertOrderItemCommand.ExecuteNonQuery();
                }
            }
        }

        private void UpdateProduct( TextBox ID,NumericUpDown qty)
        {
            using (MySqlConnection conn = new MySqlConnection("server = 127.0.0.1; user id = root; database = lmc"))
            {
                conn.Open();

                string UpdateQuery = "UPDATE product SET QtyInStock=(QtyInStock-@qty) WHERE ProductNo='"+ID.Text+"'";

                using (MySqlCommand UpdateCommand = new MySqlCommand(UpdateQuery, conn))
                {
                    UpdateCommand.Parameters.AddWithValue("@qty", qty.Value);
                    UpdateCommand.ExecuteNonQuery();
                }
            }
        }
        //UPDATE `product` SET `QtyInStock`= WHERE 1
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // default order date 
            DateTime today = DateTime.Today;

            // Check if the selected date is before today
            if (monthCalendar1.SelectionStart < today)
            {
                // Set the selection range to today's date
                monthCalendar1.SetSelectionRange(today, today);
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Limit the maximum number of digits to 5
            if (tbphoneNu.Text.Length == 8 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {
 
        }
        private List<string> GetProductSuggestions(string searchQuery)
        {
            List<string> suggestions = new List<string>();

            using (MySqlConnection conn = new MySqlConnection("server = 127.0.0.1; user id = root; database = lmc"))
            {
                conn.Open();
                string query = "SELECT Name FROM Products WHERE Name LIKE @SearchQuery LIMIT 10";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@SearchQuery", $"{searchQuery}%");
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            suggestions.Add(reader.GetString(0));
                        }
                    }
                }
            }

            return suggestions;
        }

        private void CreateSalesOrderPage_Load(object sender, EventArgs e)
        {
            List<TextBox> textBoxes = new List<TextBox> { tbID1, tbID2,tbID3,tbID4,tbID5 /*... add all your TextBox controls here */ };

            try
            {
                using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1; user id=root; database=lmc"))
                {
                    conn.Open();

                    string query = "SELECT ProductNo FROM product";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            AutoCompleteStringCollection str_coll = new AutoCompleteStringCollection();

                            while (reader.Read())
                            {
                                str_coll.Add(reader.GetString(0));
                            }

                            foreach (TextBox tb in textBoxes)
                            {
                                tb.AutoCompleteCustomSource = str_coll;
                                tb.AutoCompleteSource = AutoCompleteSource.CustomSource;
                                tb.AutoCompleteMode = AutoCompleteMode.Suggest;
                            }
                        }
                    }
                }
                loadComboboxValue();
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the setup
                MessageBox.Show("An error occurred while setting up autocomplete: " + ex.Message);
            }



            /*MySqlConnection conn = new MySqlConnection("server = 127.0.0.1; user id = root; database = lmc");
            MySqlCommand command = new MySqlCommand("select ProductNo from product", conn);
            conn.Open();
            AutoCompleteStringCollection str_coll = new AutoCompleteStringCollection();
            MySqlDataReader Noreader = command.ExecuteReader();
            while (Noreader.Read()) {
                str_coll.Add(Noreader.GetString(0));
            }
            tbID1.AutoCompleteCustomSource = str_coll;
            tbID1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbID1.AutoCompleteMode = AutoCompleteMode.Suggest;*/
        }

        private void tbID_KeyUp(object sender, KeyEventArgs e)
        {}

        private void tbID_KeyDown(object sender, KeyEventArgs e)
        {
            ProcessOrder(tbID1,lbprice1, comboBox1);
            ChangePickture(tbID1, pb1);
            /*if (tbID1.AutoCompleteCustomSource.Contains(tbID1.Text))
            {
                MySqlConnection conn = new MySqlConnection("server = 127.0.0.1; user id = root; database = lmc");
                MySqlCommand command = new MySqlCommand("select ProductName,Price from product where ProductNo ='"+tbID1.Text+"'", conn);
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    tbName1.Text = reader.GetString(0);
                    lbprice1.Text = reader.GetString(1);
                }
            } */
        }

  

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            UpdatePrice(lbprice1,numericUpDown1,tbID1);
            /*if (lbprice1.Text != "") {
                MySqlConnection conn = new MySqlConnection("server = 127.0.0.1; user id = root; database = lmc");
                MySqlCommand command = new MySqlCommand("select Price from product where ProductNo ='" + tbID1.Text + "'", conn);
                conn.Open();
                object result = command.ExecuteScalar();
                lbprice1.Text =Convert.ToString((int)numericUpDown1.Value * Convert.ToDouble(result));
            }*/
        }

        private void ProcessOrder(TextBox textBox,Label lbprice,ComboBox name)
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
                        string query = "SELECT ProductName, Price FROM product WHERE ProductNo = '"+ textBox.Text + "'";

                        // Create a MySqlCommand object with the query and connection
                        using (MySqlCommand command = new MySqlCommand(query, conn))
                        {

                            // Execute the query and read the result
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    name.Text = reader.GetString(0);
                                    lbprice.Text = reader.GetString(1);
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

        private void UpdatePrice(Label label, NumericUpDown qty, TextBox id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("server = 127.0.0.1; user id = root; database = lmc"))
                {
                    conn.Open();

                    string query = "SELECT Price FROM product WHERE ProductNo = '"+id.Text+"'";

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

        private void tbID2_KeyDown(object sender, KeyEventArgs e)
        {
            ProcessOrder(tbID2, lbprice2,comboBox2);
            ChangePickture(tbID2, pb2);

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            UpdatePrice(lbprice2, numericUpDown2, tbID2);

        }

        private void tbID4_KeyDown(object sender, KeyEventArgs e)
        {
            ProcessOrder(tbID4, lbprice4, comboBox4);
            ChangePickture(tbID4, pb4);

        }

        private void tbID3_KeyDown(object sender, KeyEventArgs e)
        {
            ProcessOrder(tbID3, lbprice3, comboBox3);
            ChangePickture(tbID3, pb3);

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            UpdatePrice(lbprice3, numericUpDown3, tbID3);

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            UpdatePrice(lbprice4, numericUpDown4, tbID4);

        }

        private void CreateSalesOrderPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void ChangePickture(TextBox id, PictureBox tb) { 
                if (id.Text== "AD24657") { 
                tb.Image = Properties.Resources._100002; }
            else { 
                    if(id.Text == "BT65432") {
                    tb.Image = Properties.Resources._200001;
                }
                else { if(id.Text== "CX98765") {
                        tb.Image = Properties.Resources._200002;
                    }
                    else
                    {
                        if (id.Text == "DY54321")
                        {
                            tb.Image = Properties.Resources._300001;
                        }
                        else
                        {
                            if (id.Text == "EW13579")
                            {
                                tb.Image = Properties.Resources._300002;
                            }
                            else { tb.Image = null; }
                        }
                    }
                }
            }
        }

        private void textBox13_KeyDown(object sender, KeyEventArgs e)
        {
           ProcessOrder(tbID5, lbprice5, comboBox5);
            ChangePickture(tbID5, pb5);
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
           UpdatePrice(lbprice5, numericUpDown5, tbID5);
            ChangePickture(tbID5, pb5);
        }
        public void loadComboboxValue()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("server = 127.0.0.1; user id = root; database = lmc"))
                {
                    conn.Open();

                    string query = "SELECT `ProductName` FROM `product`";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    MySqlDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ProductName", typeof(string));

                    // Add a new row with an empty string
                    DataRow newRow = dt.NewRow();
                    newRow["ProductName"] = "";
                    dt.Rows.Add(newRow);

                    // Load the product data from the database
                    while (reader.Read())
                    {
                        newRow = dt.NewRow();
                        newRow["ProductName"] = reader.GetString("ProductName");
                        dt.Rows.Add(newRow);
                    }
                    reader.Close();
                    comboBox1.ValueMember = "ProductName";
                    comboBox1.DataSource = dt;
                    comboBox1.SelectedItem = null;

                    comboBox2.BindingContext = new BindingContext();   
                    comboBox2.ValueMember = "ProductName";
                    comboBox2.DataSource = dt;
                    comboBox2.SelectedIndex = 0;


                    comboBox3.BindingContext = new BindingContext();   //create a new context
                    comboBox3.ValueMember = "ProductName";
                    comboBox3.DataSource = dt;
                    comboBox3.SelectedIndex = 0;


                    comboBox4.BindingContext = new BindingContext();   //create a new context\
                    comboBox4.ValueMember = "ProductName";
                    comboBox4.DataSource = dt;
                    comboBox4.SelectedIndex = 0;

                    comboBox5.BindingContext = new BindingContext();   //create a new context\
                    comboBox5.ValueMember = "ProductName";
                    comboBox5.DataSource = dt;
                    comboBox5.SelectedIndex = 0;
                    conn.Close();
                }
            }
            catch (Exception) { 
            }
        
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            ComboboxUse(comboBox1, tbID1, lbprice1);
            ChangePickture(tbID1, pb1);
        }
        public void ComboboxUse(ComboBox item,TextBox tbid,Label tbprice)
        {
            string selectedItem = item.Text;

            // Retrieve the ID and price from the database
            using (MySqlConnection conn = new MySqlConnection("server = 127.0.0.1; user id = root; database = lmc"))
            {
                conn.Open();
                string query = "SELECT `ProductNo`, `Price` FROM `product` WHERE `ProductName` = @name";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@name", selectedItem);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    String id = reader.GetString("ProductNo");
                    decimal price = reader.GetDecimal("Price");
                    tbid.Text = id+"";
                    tbprice.Text = price+"";
                }
                else
                {
                    tbid.Text = "";
                    tbprice.Text = "";
                }
            }
        }

       

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            ComboboxUse(comboBox2, tbID2, lbprice2);
            ChangePickture(tbID2, pb2);
        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
            ComboboxUse(comboBox3, tbID3, lbprice3);
            ChangePickture(tbID3, pb3);
        }

        private void comboBox4_TextChanged(object sender, EventArgs e)
        {
            ComboboxUse(comboBox4, tbID4, lbprice4);
            ChangePickture(tbID4, pb4);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenerateOrderViewButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text += "**********************************************************************\n";
            richTextBox1.Text += "*********************       Order View      **************************\n";
            richTextBox1.Text += "**********************************************************************\n";

            richTextBox1.Text += "Order Stock:" + comboBox1.Text + "  Stock ID:" + tbID1.Text + "  Qty:" + numericUpDown1.Text + "\n\n";
            richTextBox1.Text += "Order Stock:" + comboBox2.Text + "  Stock ID:" + tbID2.Text + "  Qty:" + numericUpDown2.Text + "\n\n";
            richTextBox1.Text += "Order Stock:" + comboBox3.Text + "  Stock ID:" + tbID3.Text + "  Qty:" + numericUpDown3.Text + "\n\n";
            richTextBox1.Text += "Order Stock:" + comboBox4.Text + "  Stock ID:" + tbID4.Text + "  Qty:" + numericUpDown4.Text + "\n\n";

            richTextBox1.Text += "Additional Requirement: " + tbMessage.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbID2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pesetbutton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

        }

        private void Printbutton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

        private void comboBox5_TextChanged(object sender, EventArgs e)
        {
            ComboboxUse(comboBox5, tbID5, lbprice5);
            ChangePickture(tbID5, pb5);
        }
    }
}

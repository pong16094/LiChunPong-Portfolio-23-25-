using Dispatch_Processing;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesUI
{
    public partial class Cancel : Form
    {
        DateTime startDate = DateTime.Now;
        DateTime endDate = DateTime.Now.AddDays(-3);
        private string orderID;
        private Boolean isFirstClick = true;
        private int selectedRowIndex = -1;
        MySqlConnection conn = new MySqlConnection("server = 127.0.0.1; user id = root; database = lmc");
        public Cancel()
        {
            InitializeComponent();
            dgv.ReadOnly = false; // Set the DataGridView to read-only
            Controls.Add(dgv);

        }

        private void Cancel_Load(object sender, EventArgs e)
        {
            LoadOrdersToDataGridView();
        }
        

        private void LoadOrdersToDataGridView()
        {

            try
            {
                conn.Open();
                string query = "SELECT `OrderID`, `CustomerName`, `OrderDate`, `Address`, `Comment` FROM `orders`";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                DataColumn checkBoxColumn = new DataColumn("Select", typeof(bool));
                checkBoxColumn.DefaultValue = false;
                dataTable.Columns.Add(checkBoxColumn);

                dgv.DataSource = dataTable;
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    if (column.Name != "Select")
                    {
                        column.ReadOnly = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0&& e.ColumnIndex < 5)
            {
                if (isFirstClick)
                {
                    selectedRowIndex = e.RowIndex;
                    orderID = dgv.Rows[selectedRowIndex].Cells[0].Value.ToString();
                    LoadRecord(orderID);
                    isFirstClick = false;
                }
            }
        }
        public void LoadRecord(String orderID)
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (dgv.Rows[i].Cells[5].Value != null)
                {
                    bool isChecked = (bool)dgv.Rows[i].Cells[5].Value;
                    if (isChecked) {
                        orderID = dgv.Rows[i].Cells[0].Value.ToString();
                        if (CheckDate(orderID)) {
                            DialogResult result = MessageBox.Show(
    "Are you sure you want to delete order"+orderID+"?",
    "Confirm Delete",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                deleteOrder(orderID);
                                LoadOrdersToDataGridView();
                                MessageBox.Show("delete successful");
                            }
                            else
                            {
                               continue;
                            }
                            
                        }
                    }
                }
            }

        }

        public Boolean CheckDate(string id) {
                conn.Open();
                string query = "SELECT *  FROM orders where OrderID=@orderid";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                command.Parameters.AddWithValue("@orderid", id);
                using (MySqlDataReader reader = command.ExecuteReader())
                    {
                    while (reader.Read())
                        {
                            DateTime dateValue = reader.GetDateTime("OrderDate");

                        if (startDate >= dateValue && dateValue >= endDate)
                        {
                            conn.Close();
                            return true;
                        }
                        else { MessageBox.Show("Order"+id+ "not in range, please delete the order within 3 days of you place an order. ");
                            conn.Close();
                            return false;
                        }
                        }
                    }
                }
            conn.Close();
            return false;
        }
        public void deleteOrder(string orderid) {
            conn.Open();
            string table ="orderitems" + orderID;
            string dropTablequery = $"DROP TABLE {table}";
            using (MySqlCommand dropTableCommand = new MySqlCommand(dropTablequery, conn))
            {
                dropTableCommand.ExecuteNonQuery();
            }
            string deleteOrder = $"DELETE FROM `orders` WHERE `OrderID`={orderid}";
            using (MySqlCommand deleteOrderCommand = new MySqlCommand(deleteOrder, conn))
            {
                deleteOrderCommand.ExecuteNonQuery();
            }
            conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadOrdersToDataGridView();
            isFirstClick = true;
        }
    }
}

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
    public partial class ViewSalesOrder : Form
    {
        public ViewSalesOrder()
        {
            InitializeComponent();
        }

        private void BackToMainSalesPage_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // searching the order by the the order ID and the searching result will be display in  ViewOrderScreen_Paint

            string tableName = "orderitems" + tbsearch.Text;

            using (MySqlConnection conn = new MySqlConnection("server = 127.0.0.1; user id = root; database = lmc"))
            {
                conn.Open();

                string query = $"SELECT * FROM {tableName}";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv.DataSource = dt;
            }
        }

        private void ViewOrderScreen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
        //search the Order by the user input


        }

        private void ViewSalesOrder_Load(object sender, EventArgs e)
        {
           MySqlConnection conn = new MySqlConnection("server = 127.0.0.1; user id = root; database = lmc");
           MySqlCommand command = new MySqlCommand("select OrderID from orders", conn);
           conn.Open();
           AutoCompleteStringCollection str_coll = new AutoCompleteStringCollection();
           MySqlDataReader Noreader = command.ExecuteReader();
           while (Noreader.Read()) {
               str_coll.Add(Noreader.GetString(0));
           }
           tbsearch.AutoCompleteCustomSource = str_coll;
           tbsearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
           tbsearch.AutoCompleteMode = AutoCompleteMode.Suggest;
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // view order ID, when the order is placed, plase by, and delivery address
            // ordered Stock, ordered stuck qty and order situation is it completed or not (if lazy then ignore :3)
            // new table may not necessary 
        }

        private void ViewSalesOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}

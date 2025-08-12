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
    public partial class Record_of_inward_goods : Form
    {
        public Record_of_inward_goods()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           //display panel for the inward goods 
           // show re order date, re-ordered stock, re-ordered stock qty, completed or not
           // those labe is just a example output if the user click show all rerord
           // completed then delete those label
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // click the nutton then show all the inward record in panel3_Paint
            LoadRecord();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // click the nutton then only show all the incomplete inward record in panel3_Paint
            LoadRecord("incomplete");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // click the button then only show all the completed inward record in panel3_Paint
            LoadRecord("complete");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void Record_of_inward_goods_Load(object sender, EventArgs e)
        {
            LoadRecord();
            
        }
        public void LoadRecord() {
            dgv.Rows.Clear();

            using (MySqlConnection conn = new MySqlConnection("server = 127.0.0.1; user id = root; database = lmc"))
            {
                conn.Open();

                string query = "SELECT `StockID`,`OrderDate`,`OrderQty`, `Status`, `OrderNo` FROM `purchase_order`";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dgv.Rows.Add( dr["OrderDate"].ToString(), dr["OrderNo"].ToString(), dr["StockID"].ToString(), dr["OrderQty"].ToString(), dr["Status"].ToString());
                }
                dr.Close();
                conn.Close();
            }
        }
        public void LoadRecord(String status)
        {
            dgv.Rows.Clear();
            using (MySqlConnection conn = new MySqlConnection("server = 127.0.0.1; user id = root; database = lmc"))
            {
                conn.Open();
                String Status = status;
                string query = "SELECT `StockID`,`OrderDate`,`OrderQty`, `Status`, `OrderNo` FROM `purchase_order` WHERE `Status`= '"+Status+"'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dgv.Rows.Add(dr["OrderDate"].ToString(), dr["OrderNo"].ToString(), dr["StockID"].ToString(), dr["OrderQty"].ToString(), dr["Status"].ToString());
                }
                dr.Close();
                conn.Close();
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
using System.Data.SqlClient;
namespace Login
{
    public partial class search : Form
    {
        private List<string> Material = new List<string> { "-------------", "Steel","Aluminum","Cast","Iron","Stainless","Steel","Titanium","Brass","Bronze"};
        private List<string> Type = new List<string> { "--All--","A", "B", "C", "D" };

        public search()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void search_Load(object sender, EventArgs e)
        {
            this.infoTableAdapter1.Fill(this.usefortestDataSet.info);
            cbType.SelectedIndex =0;
            cbMaterial.SelectedIndex = 0;
            this.infoTableAdapter.Fill(this.productDataSet.info);

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if(tbSearch.Text== "Enter proID or proName")
                tbSearch.Text = string.Empty;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("server = 127.0.0.1; user id = root; database=usefortest");
            string query = "select * from info where proID like @search or proName like @search ";
            MySqlCommand cmd = new MySqlCommand(query, connect);
            cmd.Parameters.AddWithValue("@search", "%" + tbSearch.Text + "%");

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void tbSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text == "Enter proID or proName")
                tbSearch.Text = string.Empty;
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btSearch_Click(sender, e);
                e.Handled = true;
            }
        }

        private void cbCom_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void cbCom_KeyUp(object sender, KeyEventArgs e)
        {
            string searchText = cbMaterial.Text;

            cbMaterial.Items.Clear();
            foreach (var item in Material)
            {
                if (item.ToString().StartsWith(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    cbMaterial.Items.Add(item);
                }
            }

            if (cbMaterial.Items.Count > 0)
            {
                cbMaterial.DroppedDown = true;

            }
            
            cbMaterial.SelectionStart = cbMaterial.Text.Length;
            cbMaterial.SelectionLength = 0;
        }

        private void cbType_KeyUp(object sender, KeyEventArgs e)
        {
            string searchText = cbType.Text;
            cbType.Items.Clear();
            foreach (var item in Type)
            {
                if (item.ToString().StartsWith(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    cbType.Items.Add(item);
                }
            }

            if (cbType.Items.Count > 0)
            {
                cbType.DroppedDown = true;

            }
        }

        private void SearchData()
        {
            string Type = cbType.Text;
            string Material = cbMaterial.Text;
            if (cbType.Text == "--All--"){ Type = "%";}
            if (cbMaterial.Text == "-------------"){ Material = "%";}


            using (MySqlConnection connect = new MySqlConnection("server = 127.0.0.1; user id = root; database=usefortest"))
            {
                connect.Open();
                string query = "SELECT * FROM info WHERE proID like @Type and proName like @Material";
                MySqlCommand command = new MySqlCommand(query, connect);
                command.Parameters.AddWithValue("@type",Type + "%");
                command.Parameters.AddWithValue("@Material",Material + "%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        private void cbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchData();
        }
    }
}




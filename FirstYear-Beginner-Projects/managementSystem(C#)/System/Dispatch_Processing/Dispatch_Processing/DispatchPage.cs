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


namespace Dispatch_Processing
{
    public partial class DispatchPage : Form
    {
        public DispatchPage()
        {
            InitializeComponent();
            
        }

        private void generatebtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DispatchNote());
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("going to Logout");
        }

        private void mainpagebtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("going to Main Page");
        }

        private void dnbtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DispatchNote());
        }

        private void grnbtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GoodRecievedNote());
        }
        private Form activeChildForm;
        private void OpenChildForm(Form childForm)
        {
            if (activeChildForm != null)
            {
                activeChildForm.Close();
            }

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Controls.Add(childForm);
            Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            activeChildForm = childForm;
        }

        private void logo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("going to Main Page");
        }


        private void DispatchPage_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'lmc1DataSet.purchase_order' 資料表。您可以視需要進行移動或移除。
            //this.purchase_orderTableAdapter.Fill(this.lmc1DataSet.purchase_order);
            LoadRecord();
        }
        public void LoadRecord()
        {

            using (MySqlConnection conn = new MySqlConnection("server = 127.0.0.1; user id = root; database = lmc"))
            {
                conn.Open();

                string query = "SELECT * FROM `purchase_order` ";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                purchase_orderDataGridView.DataSource = dt;
            }
        }

        private void purchase_orderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

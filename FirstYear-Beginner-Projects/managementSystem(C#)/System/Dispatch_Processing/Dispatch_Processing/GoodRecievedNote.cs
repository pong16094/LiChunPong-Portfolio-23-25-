using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dispatch_Processing
{
    public partial class GoodRecievedNote : Form
    {

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

        public GoodRecievedNote() {
            InitializeComponent();
            grnTimer.Start();
            staffID.Text = "20243024";
            orderNo.Text = "90422151";
            deliverLocat.Text = "987 Pine Road, Seattle, WA 98101";
            receivedBy.Text = "Chau Wai Man";
            checkBy.Text = "Chau Wai Man";
        }


        private void grnLogo_Click(object sender, EventArgs e){
            MessageBox.Show("going to Main Page");
        }

        private void mainpagebtn_Click_1(object sender, EventArgs e){
            OpenChildForm(new DispatchPage());
        }

        private void grnSendbtn_Click(object sender, EventArgs e){
            MessageBox.Show("going to Send");
        }

        private void button1_Click(object sender, EventArgs e){
            MessageBox.Show("Logout");
        }

        //private void test_Click(object sender, EventArgs e){
            //MySqlConnection connect = new MySqlConnection("server = 127.0.0.1; user id = root; database = lmc1");
            //connect.Open();
            //MySqlCommand cmd1 = new MySqlCommand("select * from usefortest", connect);
            //cmd1.Parameters.AddWithValue("test", label1.Text);
            //AutoCompleteStringCollection str_coll = new AutoCompleteStringCollection();

            //MySqlDataReader reader1 = cmd1.ExecuteReader();

            //if (reader1.Read()){
            //SuppName.Text = reader1["LMSerialNumber"].ToString();
            //}
            //else{
            //MessageBox.Show("No data found");
            //}


        
        private void GoodRecievedNote_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server = 127.0.0.1; user id = root; database = lmc");
            MySqlCommand command = new MySqlCommand("select * from purchase_order", conn);
            conn.Open();
            AutoCompleteStringCollection str_coll = new AutoCompleteStringCollection();
            MySqlDataReader Noreader = command.ExecuteReader();
            while (Noreader.Read())
            {
                str_coll.Add(Noreader.GetString(0));
            }
        }

        private void grnTimer_Tick(object sender, EventArgs e)
        {
            dateTime.Text = DateTime.Now.ToString("dd:MM:yyyy hh:mm:ss");
            grnTimer.Stop();
        }

        private void GRN_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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

namespace Login
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
            //this.AutoSize = true;
            //this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
        private void hide_Click(object sender, EventArgs e)
        {
            if (passwordbox.PasswordChar == '\0')
            {
                show.BringToFront();
                passwordbox.PasswordChar = '*';
            }    
        }

        private void show_Click(object sender, EventArgs e)
        {
            if (passwordbox.PasswordChar == '*')
            {
                hide.BringToFront();
                passwordbox.PasswordChar = '\0';
            }
        }

        private void passwordbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (!HasUpperAndLowerCase(passwordbox.Text))
            {
                MessageBox.Show("Password must need uppercase and lower case");
                return;
            }

            MySqlConnection connect = new MySqlConnection("server = 127.0.0.1; user id = root; database = lmc");
            MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from user where binary UserName='" + UserIDBox.Text + "' and binary Password='" + passwordbox.Text + "'", connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1") {

                MySqlCommand cmd = new MySqlCommand("SELECT Job FROM user WHERE BINARY userName = '" + UserIDBox.Text + "'", connect);
                connect.Open();
                string job = cmd.ExecuteScalar().ToString();
                connect.Close();

                switch (job)
                {
                    case "Admin":
                        admin adminForm= new admin();
                        adminForm.username = UserIDBox.Text;
                        adminForm.Logined = true;
                        adminForm.Show();
                            break;
                    case "SalesManager":
                        SalesUI.Form1 form1 = new SalesUI.Form1();
                        form1.username = UserIDBox.Text;
                        form1.Show();
                            break;
                    case "StockRecordStaff":
                        Test.New_StockRecord_Meun form = new Test.New_StockRecord_Meun();
                        form.Show();
                        break;
                    default:
                        MessageBox.Show("Unknown job role. Please contact the administrator.");
                        break;
                }
                this.Hide();
            }
            else {
                MessageBox.Show("Invalid username or password. Please try again.", "alter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void passwordbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login_Click(sender, e);
                e.Handled = true; 
            }
        }

        private void UserIDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbFP_Click(object sender, EventArgs e)
        {
            changePassword cpForm = new changePassword();
            cpForm.Show();
            this.Hide();
        }
        public bool HasUpperAndLowerCase(string input)
        {
            bool hasUpper = false;
            bool hasLower = false;

            foreach (char c in input)
            {
                if (char.IsUpper(c))
                {
                    hasUpper = true;
                }
                else if (char.IsLower(c))
                {
                    hasLower = true;
                }
            }

            return hasUpper && hasLower;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            hide.BringToFront();
            show.BringToFront();
        }

        private void UserID_Click(object sender, EventArgs e)
        {

        }
    }
}

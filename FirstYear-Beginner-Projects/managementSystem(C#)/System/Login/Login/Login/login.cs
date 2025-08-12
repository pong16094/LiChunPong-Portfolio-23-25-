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
            MySqlConnection connect = new MySqlConnection("server = 127.0.0.1; user id = root; database = usefortest");
            MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from logininfo where binary userName='" + UserIDBox.Text + "' and binary password='" + passwordbox.Text + "'", connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1") {

                MySqlCommand cmd = new MySqlCommand("SELECT job FROM logininfo WHERE BINARY userName = '" + UserIDBox.Text + "'", connect);
                connect.Open();
                string job = cmd.ExecuteScalar().ToString();
                connect.Close();

                switch (job)
                {
                    case "Admin":
                        admin adminForm= new admin();
                        adminForm.username = UserIDBox.Text;
                        adminForm.Show();
                            break;
                    case "Employee":
                        emp employeeForm = new emp();
                        employeeForm.username = UserIDBox.Text;
                        employeeForm.Show();
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
    }
}

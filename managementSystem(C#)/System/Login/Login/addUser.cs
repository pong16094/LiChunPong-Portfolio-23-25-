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
using System.Text.RegularExpressions;



namespace Login
{
    public partial class addUser : Form
    {
        string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).*$";
        string emailRegex = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";


        public addUser()
        {
            InitializeComponent();
            comboBox1.SelectedItem = "Admin"; // Selects the item with the text "Option 1"

        }

        private void addUser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbEmail.Text == "" || tbpassword.Text == "" || tbpassword1.Text == "")
            {
                MessageBox.Show("Something was missing");
                return;
            }
            else {
                string email = tbEmail.Text.Trim();

                if (Regex.IsMatch(email, emailRegex)) { 
                    if (Regex.IsMatch(tbpassword.Text, pattern))
                    {
                        if (tbpassword.Text != tbpassword1.Text)
                        {
                            MessageBox.Show("Plase enter two same password");
                            return;
                        }
                        else {

                            using (MySqlConnection conn = new MySqlConnection("server = 127.0.0.1; user id = root; database = lmc"))
                            {
                                conn.Open();

                                string insertQuery = "INSERT INTO `user`(`UserName`, `Password`, `Job`, `Email`) VALUES (@UserName,@Password,@Job,@Email)";

                                using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, conn))
                                {
                                    insertCommand.Parameters.AddWithValue("@UserName", tbName.Text);
                                    insertCommand.Parameters.AddWithValue("@Password", tbpassword.Text);
                                    insertCommand.Parameters.AddWithValue("@Job", comboBox1.SelectedItem);
                                    insertCommand.Parameters.AddWithValue("@Email", tbEmail.Text);
                                    int i = insertCommand.ExecuteNonQuery();
                                    if (i > 0) { MessageBox.Show("Create success!", "CURD", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                                    else { MessageBox.Show("Create failed!", "CURD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                                }
                            }
                            tbEmail.Clear();
                            tbName.Clear();
                            tbpassword.Clear();
                            tbpassword1.Clear();
                        }

                    }
                     else {
                    MessageBox.Show("The password must include upper and lower case and number");
                    }
                }
                else
                {
                    MessageBox.Show("Email is not valid.");
                }
            }
        }

        private void addUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

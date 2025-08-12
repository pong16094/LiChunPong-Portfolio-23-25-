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
    public partial class reset : Form
    {
        string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).*$";
        string emailRegex = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
        public reset()
        {
            InitializeComponent();
        }

        private void reset_Load(object sender, EventArgs e)
        {
            LoadRecord();

        }

        private void UpdateUserPassword(string userId, string newPassword)
        {
            // Implement the logic to update the user's password in the data source
            // This will depend on how you store and manage user accounts
            // For example, if you're using a database, you would execute an SQL query to update the password
            try
            {
                // Update the password in the database
                using (MySqlConnection connection = new MySqlConnection("server = 127.0.0.1; user id = root; database = usefortest"))
                {
                    connection.Open();
                    string updateQuery = "UPDATE Users SET Password = @NewPassword WHERE UserID = @UserID";
                    using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@NewPassword", newPassword);
                        command.Parameters.AddWithValue("@UserID", userId);
                        command.ExecuteNonQuery();
                    }
                }

                // Optionally, you can update the DataGridView to reflect the saved changes
                //dataGridView1.Rows[e.RowIndex].Cells["Password"].Value = newPassword;
            }
            catch (Exception ex)
            {
                // Handle any errors that occurred during the update
                MessageBox.Show($"Error saving password: {ex.Message}");
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (Checking()) {
                MySqlConnection connection = new MySqlConnection("server = 127.0.0.1; user id = root; database = lmc");


                string updateQuery = "UPDATE `user` SET`Password`=@Password WHERE `UserName`=@UserName and `Email`=@Email";
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Password", tbCpassword.Text);
                    command.Parameters.AddWithValue("@UserName", tbUserID.Text);
                    command.Parameters.AddWithValue("@Email", tbEmail.Text);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Reset password successful");
                        Clear();
                        LoadRecord();
                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("User ID not found in the database");
                    }
                }
            }

                       
           
        
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
           
            
        }
        public void LoadRecord()
        {
            using (MySqlConnection conn = new MySqlConnection("server = 127.0.0.1; user id = root; database = lmc"))
            {
                conn.Open();

                string query = "SELECT `UserName`,`Email` FROM `user`";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbEmail.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbUserID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
        public void Clear()
        {
            tbUserID.Clear();
            tbEmail.Clear();
            tbPassword.Clear();
            tbCpassword.Clear();
        }
        public  Boolean Checking()
        {
            if (tbUserID.Text == "" || tbPassword.Text == "" || tbEmail.Text == "" || tbCpassword.Text == "")
            {
                MessageBox.Show("Something was missing");
                return false;
            }
            else
            {
                string email = tbEmail.Text.Trim();

                if (Regex.IsMatch(email, emailRegex))
                {
                    if (Regex.IsMatch(tbPassword.Text, pattern))
                    {
                        if (tbPassword.Text != tbCpassword.Text)
                        {
                            MessageBox.Show("Plase enter two same password");
                            return false;
                        }
                        else
                        {
                            return true;
                        }

                    }
                    else
                    {
                        MessageBox.Show("The password must include upper and lower case and number");
                        return false;

                    }
                }
                else
                {
                    MessageBox.Show("Email is not valid.");
                    return false;

                }
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
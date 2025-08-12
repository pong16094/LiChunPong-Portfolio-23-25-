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
    public partial class changePassword : Form
    {
        string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).*$";
        string emailRegex = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
        public changePassword()
        {
            InitializeComponent();
        }

        private void btcf_Click(object sender, EventArgs e)
        {
            if (tbemail.Text == "" || tbop.Text == "" || tbnp.Text == "" || tbcnp.Text == "")
            {
                MessageBox.Show("Something was missing");
                return;
            }
            else
            {
                if (!HasUpperAndLowerCase(tbnp.Text))
                {
                    MessageBox.Show("Password must need uppercase and lower case");
                    return;
                }
                string email = tbemail.Text.Trim();

                if (Regex.IsMatch(email, emailRegex))
                {
                    if (Regex.IsMatch(tbop.Text, pattern))
                    {
                        if (tbnp.Text != tbcnp.Text)
                        {
                            MessageBox.Show("Plase enter two same password");
                            return;
                        }
                        else
                        {

                            MySqlConnection connect = new MySqlConnection("server = 127.0.0.1; user id = root; database = lmc");
                            MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from user where binary Email='" + tbemail.Text + "' and binary Password='" + tbop.Text + "'", connect);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            if (dt.Rows[0][0].ToString() == "1")
                            {
                                string query = "UPDATE `user` SET `Password`=@Password WHERE `Email`=@Email and `Password`=@OldPassword";
                                MySqlCommand cmd = new MySqlCommand(query, connect);
                                cmd.Parameters.AddWithValue("@Password", tbnp.Text);
                                cmd.Parameters.AddWithValue("@Email", tbemail.Text);
                                cmd.Parameters.AddWithValue("@OldPassword", tbop.Text);

                                connect.Open();
                                cmd.ExecuteNonQuery();
                                connect.Close();
                                MessageBox.Show("Password reset successful.");
                                tbemail.Clear();
                                tbop.Clear();
                                tbnp.Clear();
                                tbcnp.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Email address or old password were wrong");
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("The password must include upper and lower case and number");
                    }
                }
                else
                {
                    MessageBox.Show("Email is not valid.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbemail.Text == "" || tbop.Text == "" || tbnp.Text == "" || tbcnp.Text == "")
            {
                MessageBox.Show("Something was missing");
                return;
            }
            else
            {
                string email = tbemail.Text.Trim();

                if (Regex.IsMatch(email, emailRegex))
                {
                    if (Regex.IsMatch(tbop.Text, pattern))
                    {
                        if (tbnp.Text != tbcnp.Text)
                        {
                            MessageBox.Show("Plase enter two same password");
                            return;
                        }
                        else
                        {

                            MySqlConnection connect = new MySqlConnection("server = 127.0.0.1; user id = root; database = lmc");
                            MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from user where binary Email='" + tbemail.Text + "' and binary Password='" + tbop.Text + "'", connect);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            if (dt.Rows[0][0].ToString() == "1")
                            {
                                string query = "UPDATE `user` SET `Password`=@Password WHERE `Eamil`=@Email and `Password`=@OldPassword";
                                MySqlCommand cmd = new MySqlCommand(query, connect);
                                cmd.Parameters.AddWithValue("@Password", tbnp.Text);
                                cmd.Parameters.AddWithValue("@Email",tbemail.Text );
                                cmd.Parameters.AddWithValue("@OldPassword",tbop.Text );

                                connect.Open();
                                cmd.ExecuteNonQuery();
                                connect.Close();
                                MessageBox.Show("Password reset successful.");
                            }
                            else
                            {
                                MessageBox.Show("Email address or old password were wrong");
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("The password must include upper and lower case and number");
                    }
                }
                else
                {
                    MessageBox.Show("Email is not valid.");
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            
            Form1 back = new Form1();
            this.Close();
            back.Show();
        }

        private void hide_Click(object sender, EventArgs e)
        {
            if (tbnp.PasswordChar == '\0')
            {
                show.BringToFront();
                tbnp.PasswordChar = '*';
            }
        }

        private void show_Click(object sender, EventArgs e)
        {
            if (tbnp.PasswordChar == '*')
            {
                hide.BringToFront();
                tbnp.PasswordChar = '\0';
            }
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

        private void changePassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) {
                SendKeys.Send("{TAB}");
            }
        }
    }
}

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
    public partial class changePassword : Form
    {
        public changePassword()
        {
            InitializeComponent();
        }

        private void btcf_Click(object sender, EventArgs e)
        {
            if (tbnp.Text == tbcnp.Text)
            {
                MySqlConnection connect = new MySqlConnection("server = 127.0.0.1; user id = root; database = usefortest");
                MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from logininfo where binary email='" + tbemail.Text + "' and binary password='" + tbop.Text + "'", connect);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    string query = "UPDATE logininfo SET password = @newPassword WHERE email = @email";
                    MySqlCommand cmd = new MySqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@newPassword", tbnp.Text);
                    cmd.Parameters.AddWithValue("@email", tbemail.Text);

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
            else
            {
                MessageBox.Show("two password not the same!");
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
    }
}

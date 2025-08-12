using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class admin : Form
    {
        public String username;

        public admin()
        {
            InitializeComponent();
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            userLabel.Text = username;
        }

        private void searchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            search s1 = new search();
            s1.TopLevel = false;
            s1.FormBorderStyle = FormBorderStyle.None;
            s1.Dock = DockStyle.None;
            if (page.Controls.Count > 0)
                page.Controls.Clear();
            page.Controls.Add(s1);
            s1.BringToFront();
            s1.Show();
        }

        private void lbLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 back = new Form1();
            back.Show();
        }
    }
}

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
        private Form activeChildForm;
        public Boolean Logined = false;
        public String username;

        public admin()
        {
            InitializeComponent();
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Logined)
            {
                userLabel.Text = username;
            }
            else {
                Login.Form1 login = new Login.Form1();
                MessageBox.Show("Please login first");
                login.Show();
                this.Dispose();

            }
        }

        private void searchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new addUser());

            /*addUser a1 = new addUser();
            a1.TopLevel = false;
            a1.FormBorderStyle = FormBorderStyle.None;
            a1.Dock = DockStyle.None;
            if (page.Controls.Count > 0)
                page.Controls.Clear();
            page.Controls.Add(a1);
            a1.BringToFront();
            a1.Show();*/
        }

        private void lbLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login.Form1 back = new Login.Form1();
            back.Show();
        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new reset());

            /*reset r1 = new reset();
            r1.TopLevel = false;
            r1.FormBorderStyle = FormBorderStyle.None;
            r1.Dock = DockStyle.None;
            if (page.Controls.Count > 0)
                page.Controls.Clear();
            page.Controls.Add(r1);
            r1.BringToFront();
            r1.Show();*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
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
        private void lOgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SeeLog());
            /*SeeLog l1 = new SeeLog();
            l1.TopLevel = false;
            l1.FormBorderStyle = FormBorderStyle.None;
            l1.Dock = DockStyle.None;
            if (page.Controls.Count > 0)
                page.Controls.Clear();
            page.Controls.Add(l1);
            l1.BringToFront();
            l1.Show();*/
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

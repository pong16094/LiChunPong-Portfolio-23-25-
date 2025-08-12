using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Main_StockMenu : Form
    {
        private Form activeChildForm;
        public Main_StockMenu()
        {
            InitializeComponent();
    }

        private void OpenChildForm(Form childForm, object sender)
        {
            if (activeChildForm != null)
            {
                activeChildForm.Close();
            }

            // Set the parent control of the childForm to the panelDeskTop
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDeskTop.Controls.Add(childForm);
            panelDeskTop.Tag = childForm; // Set the childForm as the tag of panelDeskTop
            childForm.BringToFront();
            childForm.Show();

            activeChildForm = childForm;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDeskTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //view re-order process
            new ViewReOrederProcess().Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //go to view danager level or modify the danager level
            new DamagerLevel().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // go to re-order page
            new ReOrederPage().Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new TestStockB_page(), sender);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           OpenChildForm(new TestStockB_page(), sender);
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}

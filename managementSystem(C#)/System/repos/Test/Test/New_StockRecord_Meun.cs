using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class New_StockRecord_Meun : Form
    {
        public New_StockRecord_Meun()
        {
            InitializeComponent();
        }
        private bool MenuExpand = false;
 
        private void ViewStock_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(MenuExpand == false)
            {
                Meun_FlowLayoutPanel1.Height += 10;
                if(Meun_FlowLayoutPanel1.Height >= 435)
                {
                    timer1.Stop();
                    MenuExpand = true;
                }
            } 
            else
            {
                Meun_FlowLayoutPanel1.Height -= 10;
                if (Meun_FlowLayoutPanel1.Height <= 70) {
                    timer1.Stop();
                    MenuExpand = false;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible)
            {
                // If the groupBox1 is currently visible, hide it
                groupBox1.Visible = false;
            }
            else
            {
                // If the groupBox1 is currently hidden, show it
                groupBox1.Visible = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DL_Click(object sender, EventArgs e)
        {
            new DamagerLevel().Show();
            this.Hide();
        }

        private void VRO_Click(object sender, EventArgs e)
        {
            new ReOrederPage().Show();
            this.Hide();
        }

        private void VO_Click(object sender, EventArgs e)
        {
            new ViewReOrederProcess().Show();
            this.Hide();
        }

        private void New_StockRecord_Meun_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ST1_Click(object sender, EventArgs e)
        {
            // Create an instance of the TestStockB_page form
            Stock_A_record stockARecord = new Stock_A_record();

            // Set the TopLevel property to false to embed it within another control
            stockARecord.TopLevel = false;

            // Set the FormBorderStyle property to None to remove the border
            stockARecord.FormBorderStyle = FormBorderStyle.None;

            // Set the Dock property to Fill to occupy the entire panel
            stockARecord.Dock = DockStyle.Fill;

            // Clear the panel's existing controls
            panel4.Controls.Clear();

            // Add the Stock_A_record form to the panel
            panel4.Controls.Add(stockARecord);

            // Show the Stock_A_record form
            stockARecord.Show();
        }

        private void ST2_Click(object sender, EventArgs e)
        {
            // Create an instance of the TestStockB_page form
            // Create an instance of the TestStockB_page form
            TestStockB_page testStockBPage = new TestStockB_page();

            // Set the TopLevel property to false to embed it within another control
            testStockBPage.TopLevel = false;

            // Set the FormBorderStyle property to None to remove the border
            testStockBPage.FormBorderStyle = FormBorderStyle.None;

            // Set the Dock property to Fill to occupy the entire panel
            testStockBPage.Dock = DockStyle.Fill;

            // Clear the panel's existing controls
            panel4.Controls.Clear();

            // Add the TestStockB_page form to the panel
            panel4.Controls.Add(testStockBPage);

            // Show the TestStockB_page form
            testStockBPage.Show();
        }

        private void ST3_Click(object sender, EventArgs e)
        {
           Type_C_Stock_record stockCRecord = new Type_C_Stock_record();

            // Set the TopLevel property to false to embed it within another control
            stockCRecord.TopLevel = false;

            // Set the FormBorderStyle property to None to remove the border
            stockCRecord.FormBorderStyle = FormBorderStyle.None;

            // Set the Dock property to Fill to occupy the entire panel
            stockCRecord.Dock = DockStyle.Fill;

            // Clear the panel's existing controls
            panel4.Controls.Clear();

            // Add the Stock_A_record form to the panel
            panel4.Controls.Add(stockCRecord);

            // Show the Stock_A_record form
            stockCRecord.Show();
        }

        private void ST4_Click(object sender, EventArgs e)
        {
            Stock_D_record stockDRecord = new Stock_D_record();

            // Set the TopLevel property to false to embed it within another control
            stockDRecord.TopLevel = false;

            // Set the FormBorderStyle property to None to remove the border
            stockDRecord.FormBorderStyle = FormBorderStyle.None;

            // Set the Dock property to Fill to occupy the entire panel
            stockDRecord.Dock = DockStyle.Fill;

            // Clear the panel's existing controls
            panel4.Controls.Clear();

            // Add the Stock_A_record form to the panel
            panel4.Controls.Add(stockDRecord);

            // Show the Stock_A_record form
            stockDRecord.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new SalesUI.Record_of_inward_goods().Show();
            this.Hide();
        }
    }
}

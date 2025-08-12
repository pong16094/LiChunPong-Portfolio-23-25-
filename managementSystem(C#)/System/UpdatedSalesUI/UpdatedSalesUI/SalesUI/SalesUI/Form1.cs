using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesUI
{
    public partial class Form1 : Form
    {
        private Form activeChildForm;
        public String username;

        public Form1()
        {
            InitializeComponent();
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



        private void CreateSalesOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CreateSalesOrderPage());
        }

        private void EditSalesOrder_Click(object sender, EventArgs e)
        {
            SalesUI.EditSalesOrder eo = new SalesUI.EditSalesOrder();
            eo.username = username;
            OpenChildForm(eo);
        }

        private void ViewSalesOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewSalesOrder());
        }

        private void LogoutBurron_Click(object sender, EventArgs e)
        {
            //back to the Login Screen
            this.Close();
        }

        private void ChildScreen_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dispatch_Processing.DispatchNote());
        }

        private void DICButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dispatch_Processing.DispatchPage());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new SalesUI.Record_of_inward_goods());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dispatch_Processing.GoodRecievedNote());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SalesUI.Update_DID());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SalesUI.Cancel());
        }
    }
}

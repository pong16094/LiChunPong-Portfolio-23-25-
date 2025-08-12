using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dispatch_Processing
{
    public partial class DispatchNote : Form
    {
        private Form activeChildForm;

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
        private void mainpagebtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DispatchPage());
        }

        public DispatchNote()
        {
            InitializeComponent();
            dnTimer.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("going to Main Page");
        }
        private void DispatchNote_Load(object sender, EventArgs e)
        {
            dispatchBy.Text = "San Yue Qi";
            dn_no_txt.Text = "204221465";
            dn_loc_txt.Text = "1178 Maple Lane, Denver, CO 80202";
        }

        private void dispatchbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dispatch successful");
        }

        private void dnTimer_Tick(object sender, EventArgs e)
        {
            dn_dt_txt.Text = DateTime.Now.ToString("dd:MM:yyyy hh:mm:ss");
            dnTimer.Stop();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

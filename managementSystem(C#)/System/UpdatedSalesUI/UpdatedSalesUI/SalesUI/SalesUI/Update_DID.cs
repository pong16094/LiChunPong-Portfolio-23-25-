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
    public partial class Update_DID : Form
    {
        public Update_DID()
        {
            InitializeComponent();
            this.MouseWheel += Form1_MouseWheel;
        }

        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            int scrollLines = SystemInformation.MouseWheelScrollLines;

            // Calculate the amount to scroll based on the number of lines per notch and the wheel delta
            int scrollAmount = scrollLines * e.Delta;

            // Adjust the vertical scroll position
            this.AutoScrollPosition = new Point(0, this.AutoScrollPosition.Y - scrollAmount);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Order_By_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrderID_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Date_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrderedStockName_TextChanged(object sender, EventArgs e)
        {

        }

        private void StockQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fee_TextChanged(object sender, EventArgs e)
        {

        }

        private void Generatebutton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text += "*******************************************************************************************\n";
            richTextBox1.Text += "******************************      DID receipt      **************************************\n";
            richTextBox1.Text += "*******************************************************************************************\n";

            richTextBox1.Text += "Order by:" + Order_By_textBox.Text + "\n\n";
            richTextBox1.Text += "Order ID:" + OrderID_textBox.Text + "\n\n";
            richTextBox1.Text += "Order Date:" + Date_textBox.Text + "\n\n";
            richTextBox1.Text += "Stock:" + OrderedStockName.Text + "    qty: " + StockQty.Text + "\n\n";
            richTextBox1.Text += "Stock Fee:" + Fee.Text + "\n\n";
            richTextBox1.Text += "Total Fee:" + "\n\n";
            richTextBox1.Text += "signature:" + "\n\n";
        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            Order_By_textBox.Text = "";
            OrderID_textBox.Text = "";
            Date_textBox.Text = "";
            OrderedStockName.Text = "";
            StockQty.Text = "";
            Fee.Text = "";
            richTextBox1.Clear();

        }

        private void Printbutton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void Save_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }
    }
}

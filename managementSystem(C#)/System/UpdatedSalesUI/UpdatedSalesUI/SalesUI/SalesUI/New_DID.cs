using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legend
{
    public partial class New_DID : Form
    {
        public New_DID()
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Order_By_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //print button
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Generatebutton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text += "*************************************************************************************\n";
            richTextBox1.Text += "***************************      DID receipt      ***********************************\n";
            richTextBox1.Text += "*************************************************************************************\n";

            richTextBox1.Text += "Order by:" + Order_By_textBox.Text + "\n\n";
            richTextBox1.Text += "Order ID:" + OrderID_textBox.Text + "\n\n";
            richTextBox1.Text += "Order Date:" + Date_textBox.Text + "\n\n";
            richTextBox1.Text += "Stock:" + textBox3.Text + "    qty: " + textBox1.Text + "\n\n";
            richTextBox1.Text += "Stock Fee:" + textBox4.Text + "\n\n";
            richTextBox1.Text += "Total Fee:" + "\n\n";
            richTextBox1.Text += "signature:" + "\n\n";
        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            Order_By_textBox.Text = "";
            OrderID_textBox.Text = "";
            Date_textBox.Text = "";
            textBox3.Text = "";
            textBox1.Text = "";
            textBox4.Text = "";
        }

        private void printPreviewControl3_Click(object sender, EventArgs e)
        {

        }

        private void OrderID_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Date_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }
    }
}

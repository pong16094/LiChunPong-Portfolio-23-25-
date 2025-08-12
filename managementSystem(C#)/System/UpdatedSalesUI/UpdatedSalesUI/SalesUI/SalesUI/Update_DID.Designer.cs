
namespace SalesUI
{
    partial class Update_DID
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_DID));
            this.Save = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.OrderID_textBox = new System.Windows.Forms.TextBox();
            this.Order_By_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Order_by = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Fee = new System.Windows.Forms.TextBox();
            this.Date_textBox = new System.Windows.Forms.TextBox();
            this.StockQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OrderedStockName = new System.Windows.Forms.TextBox();
            this.Printbutton = new System.Windows.Forms.Button();
            this.Resetbutton = new System.Windows.Forms.Button();
            this.Generatebutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Save.Location = new System.Drawing.Point(976, 85);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(127, 47);
            this.Save.TabIndex = 5;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(577, 152);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(517, 583);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // OrderID_textBox
            // 
            this.OrderID_textBox.Location = new System.Drawing.Point(149, 79);
            this.OrderID_textBox.Name = "OrderID_textBox";
            this.OrderID_textBox.Size = new System.Drawing.Size(225, 27);
            this.OrderID_textBox.TabIndex = 6;
            this.OrderID_textBox.TextChanged += new System.EventHandler(this.OrderID_textBox_TextChanged);
            // 
            // Order_By_textBox
            // 
            this.Order_By_textBox.Location = new System.Drawing.Point(149, 23);
            this.Order_By_textBox.Name = "Order_By_textBox";
            this.Order_By_textBox.Size = new System.Drawing.Size(225, 27);
            this.Order_By_textBox.TabIndex = 5;
            this.Order_By_textBox.TextChanged += new System.EventHandler(this.Order_By_textBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(22, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Order Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(22, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "OrderID";
            // 
            // txt_Order_by
            // 
            this.txt_Order_by.AutoSize = true;
            this.txt_Order_by.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Order_by.Location = new System.Drawing.Point(22, 23);
            this.txt_Order_by.Name = "txt_Order_by";
            this.txt_Order_by.Size = new System.Drawing.Size(99, 24);
            this.txt_Order_by.TabIndex = 1;
            this.txt_Order_by.Text = "Order by";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(235, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Stock fee:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Stock Qty:";
            // 
            // Fee
            // 
            this.Fee.Location = new System.Drawing.Point(357, 79);
            this.Fee.Name = "Fee";
            this.Fee.Size = new System.Drawing.Size(85, 27);
            this.Fee.TabIndex = 10;
            this.Fee.TextChanged += new System.EventHandler(this.Fee_TextChanged);
            // 
            // Date_textBox
            // 
            this.Date_textBox.Location = new System.Drawing.Point(149, 137);
            this.Date_textBox.Name = "Date_textBox";
            this.Date_textBox.Size = new System.Drawing.Size(225, 27);
            this.Date_textBox.TabIndex = 7;
            this.Date_textBox.TextChanged += new System.EventHandler(this.Date_textBox_TextChanged);
            // 
            // StockQty
            // 
            this.StockQty.Location = new System.Drawing.Point(128, 79);
            this.StockQty.Name = "StockQty";
            this.StockQty.Size = new System.Drawing.Size(85, 27);
            this.StockQty.TabIndex = 9;
            this.StockQty.TextChanged += new System.EventHandler(this.StockQty_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ordered Stock name";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Fee);
            this.groupBox2.Controls.Add(this.StockQty);
            this.groupBox2.Controls.Add(this.OrderedStockName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(15, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(522, 125);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // OrderedStockName
            // 
            this.OrderedStockName.Location = new System.Drawing.Point(238, 26);
            this.OrderedStockName.Name = "OrderedStockName";
            this.OrderedStockName.Size = new System.Drawing.Size(278, 27);
            this.OrderedStockName.TabIndex = 8;
            this.OrderedStockName.TextChanged += new System.EventHandler(this.OrderedStockName_TextChanged);
            // 
            // Printbutton
            // 
            this.Printbutton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Printbutton.Location = new System.Drawing.Point(843, 85);
            this.Printbutton.Name = "Printbutton";
            this.Printbutton.Size = new System.Drawing.Size(127, 47);
            this.Printbutton.TabIndex = 4;
            this.Printbutton.Text = "Print";
            this.Printbutton.UseVisualStyleBackColor = true;
            this.Printbutton.Click += new System.EventHandler(this.Printbutton_Click);
            // 
            // Resetbutton
            // 
            this.Resetbutton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Resetbutton.Location = new System.Drawing.Point(710, 85);
            this.Resetbutton.Name = "Resetbutton";
            this.Resetbutton.Size = new System.Drawing.Size(127, 47);
            this.Resetbutton.TabIndex = 3;
            this.Resetbutton.Text = "Reset";
            this.Resetbutton.UseVisualStyleBackColor = true;
            this.Resetbutton.Click += new System.EventHandler(this.Resetbutton_Click);
            // 
            // Generatebutton
            // 
            this.Generatebutton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Generatebutton.Location = new System.Drawing.Point(577, 85);
            this.Generatebutton.Name = "Generatebutton";
            this.Generatebutton.Size = new System.Drawing.Size(127, 47);
            this.Generatebutton.TabIndex = 2;
            this.Generatebutton.Text = "Generate";
            this.Generatebutton.UseVisualStyleBackColor = true;
            this.Generatebutton.Click += new System.EventHandler(this.Generatebutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.Date_textBox);
            this.groupBox1.Controls.Add(this.OrderID_textBox);
            this.groupBox1.Controls.Add(this.Order_By_textBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Order_by);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 499);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "information Box";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(296, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DID create view";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 79);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.Save);
            this.panel2.Controls.Add(this.Printbutton);
            this.panel2.Controls.Add(this.Resetbutton);
            this.panel2.Controls.Add(this.Generatebutton);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1127, 838);
            this.panel2.TabIndex = 3;
            // 
            // Update_DID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 838);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Update_DID";
            this.Text = "Update_DID";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox OrderID_textBox;
        private System.Windows.Forms.TextBox Order_By_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txt_Order_by;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Fee;
        private System.Windows.Forms.TextBox Date_textBox;
        private System.Windows.Forms.TextBox StockQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox OrderedStockName;
        private System.Windows.Forms.Button Printbutton;
        private System.Windows.Forms.Button Resetbutton;
        private System.Windows.Forms.Button Generatebutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
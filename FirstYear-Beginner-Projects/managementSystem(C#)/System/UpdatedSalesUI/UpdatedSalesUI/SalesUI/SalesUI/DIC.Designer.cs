namespace SalesUI
{
    partial class DIC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AdditionalInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.AddtionalTextBox = new System.Windows.Forms.TextBox();
            this.DealerGroupBox = new System.Windows.Forms.GroupBox();
            this.DealerOrderNoTextBox = new System.Windows.Forms.TextBox();
            this.DeliveryAddressGroupBox = new System.Windows.Forms.GroupBox();
            this.DeliveryTextBox = new System.Windows.Forms.TextBox();
            this.InvoiceNameAndAddress = new System.Windows.Forms.GroupBox();
            this.IvoiceNameAndAddressTextBox2 = new System.Windows.Forms.TextBox();
            this.OrderSerialGroupBox = new System.Windows.Forms.GroupBox();
            this.OrderSerialTextBox = new System.Windows.Forms.TextBox();
            this.DateGroupBox = new System.Windows.Forms.GroupBox();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.DespatchInstructionGroupBox = new System.Windows.Forms.GroupBox();
            this.DITextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.AdditionalInfoGroupBox.SuspendLayout();
            this.DealerGroupBox.SuspendLayout();
            this.DeliveryAddressGroupBox.SuspendLayout();
            this.InvoiceNameAndAddress.SuspendLayout();
            this.OrderSerialGroupBox.SuspendLayout();
            this.DateGroupBox.SuspendLayout();
            this.DespatchInstructionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightYellow;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 108);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(319, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = " Despatch Instruction Cover";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1092, 702);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.AdditionalInfoGroupBox);
            this.groupBox1.Controls.Add(this.DealerGroupBox);
            this.groupBox1.Controls.Add(this.DeliveryAddressGroupBox);
            this.groupBox1.Controls.Add(this.InvoiceNameAndAddress);
            this.groupBox1.Controls.Add(this.OrderSerialGroupBox);
            this.groupBox1.Controls.Add(this.DateGroupBox);
            this.groupBox1.Controls.Add(this.DespatchInstructionGroupBox);
            this.groupBox1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(75, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 618);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DIC Main detail";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(437, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "Create DIC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdditionalInfoGroupBox
            // 
            this.AdditionalInfoGroupBox.Controls.Add(this.AddtionalTextBox);
            this.AdditionalInfoGroupBox.Location = new System.Drawing.Point(6, 373);
            this.AdditionalInfoGroupBox.Name = "AdditionalInfoGroupBox";
            this.AdditionalInfoGroupBox.Size = new System.Drawing.Size(406, 159);
            this.AdditionalInfoGroupBox.TabIndex = 4;
            this.AdditionalInfoGroupBox.TabStop = false;
            this.AdditionalInfoGroupBox.Text = "Addtional Information";
            // 
            // AddtionalTextBox
            // 
            this.AddtionalTextBox.Location = new System.Drawing.Point(6, 28);
            this.AddtionalTextBox.Name = "AddtionalTextBox";
            this.AddtionalTextBox.Size = new System.Drawing.Size(387, 27);
            this.AddtionalTextBox.TabIndex = 3;
            // 
            // DealerGroupBox
            // 
            this.DealerGroupBox.Controls.Add(this.DealerOrderNoTextBox);
            this.DealerGroupBox.Location = new System.Drawing.Point(6, 258);
            this.DealerGroupBox.Name = "DealerGroupBox";
            this.DealerGroupBox.Size = new System.Drawing.Size(406, 108);
            this.DealerGroupBox.TabIndex = 3;
            this.DealerGroupBox.TabStop = false;
            this.DealerGroupBox.Text = "Dealer Order No";
            // 
            // DealerOrderNoTextBox
            // 
            this.DealerOrderNoTextBox.Location = new System.Drawing.Point(6, 28);
            this.DealerOrderNoTextBox.Name = "DealerOrderNoTextBox";
            this.DealerOrderNoTextBox.Size = new System.Drawing.Size(394, 27);
            this.DealerOrderNoTextBox.TabIndex = 3;
            // 
            // DeliveryAddressGroupBox
            // 
            this.DeliveryAddressGroupBox.Controls.Add(this.DeliveryTextBox);
            this.DeliveryAddressGroupBox.Location = new System.Drawing.Point(212, 143);
            this.DeliveryAddressGroupBox.Name = "DeliveryAddressGroupBox";
            this.DeliveryAddressGroupBox.Size = new System.Drawing.Size(200, 108);
            this.DeliveryAddressGroupBox.TabIndex = 2;
            this.DeliveryAddressGroupBox.TabStop = false;
            this.DeliveryAddressGroupBox.Text = "Delivery Address";
            // 
            // DeliveryTextBox
            // 
            this.DeliveryTextBox.Location = new System.Drawing.Point(14, 40);
            this.DeliveryTextBox.Name = "DeliveryTextBox";
            this.DeliveryTextBox.Size = new System.Drawing.Size(173, 27);
            this.DeliveryTextBox.TabIndex = 3;
            // 
            // InvoiceNameAndAddress
            // 
            this.InvoiceNameAndAddress.Controls.Add(this.IvoiceNameAndAddressTextBox2);
            this.InvoiceNameAndAddress.Location = new System.Drawing.Point(6, 143);
            this.InvoiceNameAndAddress.Name = "InvoiceNameAndAddress";
            this.InvoiceNameAndAddress.Size = new System.Drawing.Size(200, 108);
            this.InvoiceNameAndAddress.TabIndex = 2;
            this.InvoiceNameAndAddress.TabStop = false;
            this.InvoiceNameAndAddress.Text = "Invoice Name And Address";
            // 
            // IvoiceNameAndAddressTextBox2
            // 
            this.IvoiceNameAndAddressTextBox2.Location = new System.Drawing.Point(14, 40);
            this.IvoiceNameAndAddressTextBox2.Name = "IvoiceNameAndAddressTextBox2";
            this.IvoiceNameAndAddressTextBox2.Size = new System.Drawing.Size(173, 27);
            this.IvoiceNameAndAddressTextBox2.TabIndex = 3;
            // 
            // OrderSerialGroupBox
            // 
            this.OrderSerialGroupBox.Controls.Add(this.OrderSerialTextBox);
            this.OrderSerialGroupBox.Location = new System.Drawing.Point(212, 28);
            this.OrderSerialGroupBox.Name = "OrderSerialGroupBox";
            this.OrderSerialGroupBox.Size = new System.Drawing.Size(200, 108);
            this.OrderSerialGroupBox.TabIndex = 1;
            this.OrderSerialGroupBox.TabStop = false;
            this.OrderSerialGroupBox.Text = "Order Serial";
            // 
            // OrderSerialTextBox
            // 
            this.OrderSerialTextBox.Location = new System.Drawing.Point(6, 28);
            this.OrderSerialTextBox.Name = "OrderSerialTextBox";
            this.OrderSerialTextBox.Size = new System.Drawing.Size(173, 27);
            this.OrderSerialTextBox.TabIndex = 1;
            // 
            // DateGroupBox
            // 
            this.DateGroupBox.Controls.Add(this.DateTextBox);
            this.DateGroupBox.Location = new System.Drawing.Point(6, 28);
            this.DateGroupBox.Name = "DateGroupBox";
            this.DateGroupBox.Size = new System.Drawing.Size(200, 108);
            this.DateGroupBox.TabIndex = 1;
            this.DateGroupBox.TabStop = false;
            this.DateGroupBox.Text = "Date";
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(6, 28);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(173, 27);
            this.DateTextBox.TabIndex = 2;
            // 
            // DespatchInstructionGroupBox
            // 
            this.DespatchInstructionGroupBox.Controls.Add(this.DITextBox);
            this.DespatchInstructionGroupBox.Location = new System.Drawing.Point(418, 28);
            this.DespatchInstructionGroupBox.Name = "DespatchInstructionGroupBox";
            this.DespatchInstructionGroupBox.Size = new System.Drawing.Size(241, 504);
            this.DespatchInstructionGroupBox.TabIndex = 0;
            this.DespatchInstructionGroupBox.TabStop = false;
            this.DespatchInstructionGroupBox.Text = "Despatch Instruction";
            // 
            // DITextBox
            // 
            this.DITextBox.Location = new System.Drawing.Point(6, 28);
            this.DITextBox.Name = "DITextBox";
            this.DITextBox.Size = new System.Drawing.Size(229, 27);
            this.DITextBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 631);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1092, 71);
            this.panel3.TabIndex = 1;
            // 
            // DIC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 810);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DIC";
            this.Text = "DIC";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.AdditionalInfoGroupBox.ResumeLayout(false);
            this.AdditionalInfoGroupBox.PerformLayout();
            this.DealerGroupBox.ResumeLayout(false);
            this.DealerGroupBox.PerformLayout();
            this.DeliveryAddressGroupBox.ResumeLayout(false);
            this.DeliveryAddressGroupBox.PerformLayout();
            this.InvoiceNameAndAddress.ResumeLayout(false);
            this.InvoiceNameAndAddress.PerformLayout();
            this.OrderSerialGroupBox.ResumeLayout(false);
            this.OrderSerialGroupBox.PerformLayout();
            this.DateGroupBox.ResumeLayout(false);
            this.DateGroupBox.PerformLayout();
            this.DespatchInstructionGroupBox.ResumeLayout(false);
            this.DespatchInstructionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox DealerGroupBox;
        private System.Windows.Forms.GroupBox DeliveryAddressGroupBox;
        private System.Windows.Forms.GroupBox InvoiceNameAndAddress;
        private System.Windows.Forms.GroupBox OrderSerialGroupBox;
        private System.Windows.Forms.GroupBox DateGroupBox;
        private System.Windows.Forms.GroupBox DespatchInstructionGroupBox;
        private System.Windows.Forms.GroupBox AdditionalInfoGroupBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox AddtionalTextBox;
        private System.Windows.Forms.TextBox DealerOrderNoTextBox;
        private System.Windows.Forms.TextBox DeliveryTextBox;
        private System.Windows.Forms.TextBox IvoiceNameAndAddressTextBox2;
        private System.Windows.Forms.TextBox OrderSerialTextBox;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.TextBox DITextBox;
        private System.Windows.Forms.Panel panel3;
    }
}
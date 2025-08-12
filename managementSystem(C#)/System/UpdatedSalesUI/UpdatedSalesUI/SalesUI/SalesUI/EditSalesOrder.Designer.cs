
namespace SalesUI
{
    partial class EditSalesOrder
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
            this.Update = new System.Windows.Forms.Button();
            this.EditOrderBox = new System.Windows.Forms.GroupBox();
            this.btClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbqty = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.group = new System.Windows.Forms.GroupBox();
            this.tbNo1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EditReason = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbReason = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.EditDate = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.OrderEditor = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBy = new System.Windows.Forms.TextBox();
            this.EditRequiredOrderID = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btEdit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.EditOrderBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.group.SuspendLayout();
            this.EditReason.SuspendLayout();
            this.EditDate.SuspendLayout();
            this.OrderEditor.SuspendLayout();
            this.EditRequiredOrderID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1397, 115);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(541, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Sales Order";
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(369, 444);
            this.Update.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(108, 39);
            this.Update.TabIndex = 0;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // EditOrderBox
            // 
            this.EditOrderBox.Controls.Add(this.btClear);
            this.EditOrderBox.Controls.Add(this.Update);
            this.EditOrderBox.Controls.Add(this.groupBox1);
            this.EditOrderBox.Controls.Add(this.groupBox3);
            this.EditOrderBox.Controls.Add(this.panel5);
            this.EditOrderBox.Controls.Add(this.group);
            this.EditOrderBox.Controls.Add(this.EditReason);
            this.EditOrderBox.Controls.Add(this.panel4);
            this.EditOrderBox.Controls.Add(this.EditDate);
            this.EditOrderBox.Controls.Add(this.panel3);
            this.EditOrderBox.Controls.Add(this.OrderEditor);
            this.EditOrderBox.Controls.Add(this.EditRequiredOrderID);
            this.EditOrderBox.Location = new System.Drawing.Point(0, 121);
            this.EditOrderBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EditOrderBox.Name = "EditOrderBox";
            this.EditOrderBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EditOrderBox.Size = new System.Drawing.Size(549, 507);
            this.EditOrderBox.TabIndex = 4;
            this.EditOrderBox.TabStop = false;
            this.EditOrderBox.Text = "EditOrderBox";
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(17, 441);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(101, 42);
            this.btClear.TabIndex = 0;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Location = new System.Drawing.Point(8, 301);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(521, 47);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // tbName
            // 
            this.tbName.AcceptsReturn = true;
            this.tbName.Location = new System.Drawing.Point(253, 22);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(224, 25);
            this.tbName.TabIndex = 0;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(8, 18);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(148, 25);
            this.label25.TabIndex = 4;
            this.label25.Text = "Product Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tbqty);
            this.groupBox3.Location = new System.Drawing.Point(8, 344);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(521, 47);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Quantity";
            // 
            // tbqty
            // 
            this.tbqty.Location = new System.Drawing.Point(241, 17);
            this.tbqty.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbqty.Multiline = true;
            this.tbqty.Name = "tbqty";
            this.tbqty.Size = new System.Drawing.Size(236, 31);
            this.tbqty.TabIndex = 0;
            this.tbqty.TextChanged += new System.EventHandler(this.tbqty_TextChanged);
            this.tbqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbqty_KeyPress);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(8, 178);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(471, 3);
            this.panel5.TabIndex = 32;
            // 
            // group
            // 
            this.group.Controls.Add(this.tbNo1);
            this.group.Controls.Add(this.label6);
            this.group.Location = new System.Drawing.Point(0, 248);
            this.group.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.group.Name = "group";
            this.group.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.group.Size = new System.Drawing.Size(521, 47);
            this.group.TabIndex = 33;
            this.group.TabStop = false;
            // 
            // tbNo1
            // 
            this.tbNo1.AcceptsReturn = true;
            this.tbNo1.Location = new System.Drawing.Point(253, 22);
            this.tbNo1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNo1.Name = "tbNo1";
            this.tbNo1.Size = new System.Drawing.Size(224, 25);
            this.tbNo1.TabIndex = 0;
            this.tbNo1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNo1_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Product No.";
            // 
            // EditReason
            // 
            this.EditReason.Controls.Add(this.label5);
            this.EditReason.Controls.Add(this.tbReason);
            this.EditReason.Location = new System.Drawing.Point(4, 192);
            this.EditReason.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EditReason.Name = "EditReason";
            this.EditReason.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EditReason.Size = new System.Drawing.Size(521, 47);
            this.EditReason.TabIndex = 31;
            this.EditReason.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Edit reason";
            // 
            // tbReason
            // 
            this.tbReason.Location = new System.Drawing.Point(245, 17);
            this.tbReason.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbReason.Multiline = true;
            this.tbReason.Name = "tbReason";
            this.tbReason.Size = new System.Drawing.Size(228, 31);
            this.tbReason.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(8, 123);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(471, 3);
            this.panel4.TabIndex = 30;
            // 
            // EditDate
            // 
            this.EditDate.Controls.Add(this.dateTimePicker1);
            this.EditDate.Controls.Add(this.label4);
            this.EditDate.Location = new System.Drawing.Point(8, 130);
            this.EditDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EditDate.Name = "EditDate";
            this.EditDate.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EditDate.Size = new System.Drawing.Size(521, 47);
            this.EditDate.TabIndex = 29;
            this.EditDate.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(245, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 25);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Edit Date";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(8, 69);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(471, 3);
            this.panel3.TabIndex = 28;
            // 
            // OrderEditor
            // 
            this.OrderEditor.Controls.Add(this.label3);
            this.OrderEditor.Controls.Add(this.tbBy);
            this.OrderEditor.Location = new System.Drawing.Point(8, 76);
            this.OrderEditor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OrderEditor.Name = "OrderEditor";
            this.OrderEditor.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OrderEditor.Size = new System.Drawing.Size(521, 47);
            this.OrderEditor.TabIndex = 7;
            this.OrderEditor.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Edit By";
            // 
            // tbBy
            // 
            this.tbBy.Location = new System.Drawing.Point(245, 17);
            this.tbBy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbBy.Name = "tbBy";
            this.tbBy.Size = new System.Drawing.Size(236, 25);
            this.tbBy.TabIndex = 0;
            // 
            // EditRequiredOrderID
            // 
            this.EditRequiredOrderID.Controls.Add(this.label2);
            this.EditRequiredOrderID.Location = new System.Drawing.Point(8, 22);
            this.EditRequiredOrderID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EditRequiredOrderID.Name = "EditRequiredOrderID";
            this.EditRequiredOrderID.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EditRequiredOrderID.Size = new System.Drawing.Size(521, 47);
            this.EditRequiredOrderID.TabIndex = 6;
            this.EditRequiredOrderID.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Edit reqired Order ID";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel6.Location = new System.Drawing.Point(212, 361);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(278, 3);
            this.panel6.TabIndex = 34;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(566, 179);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 27;
            this.dgv.Size = new System.Drawing.Size(806, 449);
            this.dgv.TabIndex = 35;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(566, 134);
            this.btEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(108, 39);
            this.btEdit.TabIndex = 0;
            this.btEdit.Text = "Back to order";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("PMingLiU", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(724, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 19);
            this.label7.TabIndex = 36;
            this.label7.Text = "*Tab the order for more detail";
            // 
            // EditSalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 781);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.EditOrderBox);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "EditSalesOrder";
            this.Text = "EditSalesOrder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditSalesOrder_FormClosing);
            this.Load += new System.EventHandler(this.EditSalesOrder_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditSalesOrder_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.EditOrderBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            this.EditReason.ResumeLayout(false);
            this.EditReason.PerformLayout();
            this.EditDate.ResumeLayout(false);
            this.EditDate.PerformLayout();
            this.OrderEditor.ResumeLayout(false);
            this.OrderEditor.PerformLayout();
            this.EditRequiredOrderID.ResumeLayout(false);
            this.EditRequiredOrderID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox EditOrderBox;
        private System.Windows.Forms.GroupBox OrderEditor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBy;
        private System.Windows.Forms.GroupBox EditRequiredOrderID;
        private System.Windows.Forms.Label label2;
        private new System.Windows.Forms.Button Update;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox EditReason;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbReason;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox EditDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbqty;
        private System.Windows.Forms.TextBox tbNo1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btClear;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label7;
    }
}
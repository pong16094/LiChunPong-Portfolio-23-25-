namespace Test
{
    partial class New_StockRecord_Meun
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logout_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VO = new System.Windows.Forms.Button();
            this.VRO = new System.Windows.Forms.Button();
            this.DL = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Meun_FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ViewStock = new System.Windows.Forms.Button();
            this.ST1 = new System.Windows.Forms.Button();
            this.ST2 = new System.Windows.Forms.Button();
            this.ST3 = new System.Windows.Forms.Button();
            this.ST4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.Meun_FlowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.Logout_button);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1467, 107);
            this.panel1.TabIndex = 0;
            // 
            // Logout_button
            // 
            this.Logout_button.Location = new System.Drawing.Point(1340, 14);
            this.Logout_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Logout_button.Name = "Logout_button";
            this.Logout_button.Size = new System.Drawing.Size(111, 44);
            this.Logout_button.TabIndex = 9;
            this.Logout_button.Text = "Logout";
            this.Logout_button.UseVisualStyleBackColor = true;
            this.Logout_button.Click += new System.EventHandler(this.Logout_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.VO);
            this.groupBox1.Controls.Add(this.VRO);
            this.groupBox1.Controls.Add(this.DL);
            this.groupBox1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(124, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(910, 107);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Move to:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // VO
            // 
            this.VO.Location = new System.Drawing.Point(341, 16);
            this.VO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VO.Name = "VO";
            this.VO.Size = new System.Drawing.Size(234, 43);
            this.VO.TabIndex = 2;
            this.VO.Text = "View re-order process";
            this.VO.UseVisualStyleBackColor = true;
            this.VO.Click += new System.EventHandler(this.VO_Click);
            // 
            // VRO
            // 
            this.VRO.Location = new System.Drawing.Point(143, 60);
            this.VRO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VRO.Name = "VRO";
            this.VRO.Size = new System.Drawing.Size(177, 43);
            this.VRO.TabIndex = 1;
            this.VRO.Text = " re-order Stock";
            this.VRO.UseVisualStyleBackColor = true;
            this.VRO.Click += new System.EventHandler(this.VRO_Click);
            // 
            // DL
            // 
            this.DL.Location = new System.Drawing.Point(5, 16);
            this.DL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DL.Name = "DL";
            this.DL.Size = new System.Drawing.Size(151, 43);
            this.DL.TabIndex = 0;
            this.DL.Text = "Danger Level";
            this.DL.UseVisualStyleBackColor = true;
            this.DL.Click += new System.EventHandler(this.DL_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Test.Properties.Resources.meun;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Test.Properties.Resources.legend_motor_company_high_resolution_logo_black;
            this.pictureBox2.Location = new System.Drawing.Point(1111, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(196, 106);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.panel2.Controls.Add(this.Meun_FlowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 107);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 683);
            this.panel2.TabIndex = 1;
            // 
            // Meun_FlowLayoutPanel1
            // 
            this.Meun_FlowLayoutPanel1.Controls.Add(this.ViewStock);
            this.Meun_FlowLayoutPanel1.Controls.Add(this.ST1);
            this.Meun_FlowLayoutPanel1.Controls.Add(this.ST2);
            this.Meun_FlowLayoutPanel1.Controls.Add(this.ST3);
            this.Meun_FlowLayoutPanel1.Controls.Add(this.ST4);
            this.Meun_FlowLayoutPanel1.Location = new System.Drawing.Point(11, 5);
            this.Meun_FlowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Meun_FlowLayoutPanel1.Name = "Meun_FlowLayoutPanel1";
            this.Meun_FlowLayoutPanel1.Size = new System.Drawing.Size(267, 367);
            this.Meun_FlowLayoutPanel1.TabIndex = 8;
            this.Meun_FlowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint_1);
            // 
            // ViewStock
            // 
            this.ViewStock.Font = new System.Drawing.Font("PMingLiU", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ViewStock.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ViewStock.Location = new System.Drawing.Point(3, 2);
            this.ViewStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewStock.Name = "ViewStock";
            this.ViewStock.Size = new System.Drawing.Size(212, 68);
            this.ViewStock.TabIndex = 3;
            this.ViewStock.Text = "View Stock";
            this.ViewStock.UseVisualStyleBackColor = true;
            this.ViewStock.Click += new System.EventHandler(this.ViewStock_Click);
            // 
            // ST1
            // 
            this.ST1.BackColor = System.Drawing.Color.Gray;
            this.ST1.Font = new System.Drawing.Font("PMingLiU", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ST1.ForeColor = System.Drawing.Color.Black;
            this.ST1.Location = new System.Drawing.Point(3, 74);
            this.ST1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ST1.Name = "ST1";
            this.ST1.Size = new System.Drawing.Size(212, 68);
            this.ST1.TabIndex = 4;
            this.ST1.Text = " Stock Type A";
            this.ST1.UseVisualStyleBackColor = false;
            this.ST1.Click += new System.EventHandler(this.ST1_Click);
            // 
            // ST2
            // 
            this.ST2.BackColor = System.Drawing.Color.DarkGray;
            this.ST2.Font = new System.Drawing.Font("PMingLiU", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ST2.ForeColor = System.Drawing.Color.Black;
            this.ST2.Location = new System.Drawing.Point(3, 146);
            this.ST2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ST2.Name = "ST2";
            this.ST2.Size = new System.Drawing.Size(212, 68);
            this.ST2.TabIndex = 5;
            this.ST2.Text = " Stock Type B";
            this.ST2.UseVisualStyleBackColor = false;
            this.ST2.Click += new System.EventHandler(this.ST2_Click);
            // 
            // ST3
            // 
            this.ST3.BackColor = System.Drawing.Color.Silver;
            this.ST3.Font = new System.Drawing.Font("PMingLiU", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ST3.ForeColor = System.Drawing.Color.Black;
            this.ST3.Location = new System.Drawing.Point(3, 218);
            this.ST3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ST3.Name = "ST3";
            this.ST3.Size = new System.Drawing.Size(212, 68);
            this.ST3.TabIndex = 6;
            this.ST3.Text = " Stock Type C";
            this.ST3.UseVisualStyleBackColor = false;
            this.ST3.Click += new System.EventHandler(this.ST3_Click);
            // 
            // ST4
            // 
            this.ST4.BackColor = System.Drawing.Color.LightGray;
            this.ST4.Font = new System.Drawing.Font("PMingLiU", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ST4.ForeColor = System.Drawing.Color.Black;
            this.ST4.Location = new System.Drawing.Point(3, 290);
            this.ST4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ST4.Name = "ST4";
            this.ST4.Size = new System.Drawing.Size(212, 61);
            this.ST4.TabIndex = 7;
            this.ST4.Text = " Stock Type D";
            this.ST4.UseVisualStyleBackColor = false;
            this.ST4.Click += new System.EventHandler(this.ST4_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(228, 107);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1239, 683);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 58);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Record of inward goods";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // New_StockRecord_Meun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1467, 790);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "New_StockRecord_Meun";
            this.Text = "New_StockRecord_Meun";
            this.Load += new System.EventHandler(this.New_StockRecord_Meun_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.Meun_FlowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ViewStock;
        private System.Windows.Forms.Button ST1;
        private System.Windows.Forms.Button ST2;
        private System.Windows.Forms.Button ST3;
        private System.Windows.Forms.Button ST4;
        private System.Windows.Forms.FlowLayoutPanel Meun_FlowLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button VO;
        private System.Windows.Forms.Button VRO;
        private System.Windows.Forms.Button DL;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Logout_button;
        private System.Windows.Forms.Button button1;
    }
}
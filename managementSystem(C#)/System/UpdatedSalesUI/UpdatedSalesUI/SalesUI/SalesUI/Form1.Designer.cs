
namespace SalesUI
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.DICButton = new System.Windows.Forms.Button();
            this.DIDButton = new System.Windows.Forms.Button();
            this.ViewSalesOrder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LogoutBurron = new System.Windows.Forms.Button();
            this.EditSalesOrder = new System.Windows.Forms.Button();
            this.CreateSalesOrder = new System.Windows.Forms.Button();
            this.ChildScreen = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1672, 115);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SalesUI.Properties.Resources.legend_motor_company_high_resolution_logo_black;
            this.pictureBox1.Location = new System.Drawing.Point(15, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the sales mangement Page ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.DICButton);
            this.panel2.Controls.Add(this.DIDButton);
            this.panel2.Controls.Add(this.ViewSalesOrder);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.EditSalesOrder);
            this.panel2.Controls.Add(this.CreateSalesOrder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 115);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 940);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 438);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 51);
            this.button2.TabIndex = 6;
            this.button2.Text = "Good Recieved Note";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DICButton
            // 
            this.DICButton.Location = new System.Drawing.Point(18, 372);
            this.DICButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DICButton.Name = "DICButton";
            this.DICButton.Size = new System.Drawing.Size(153, 51);
            this.DICButton.TabIndex = 4;
            this.DICButton.Text = "Dispathch Page";
            this.DICButton.UseVisualStyleBackColor = true;
            this.DICButton.Click += new System.EventHandler(this.DICButton_Click);
            // 
            // DIDButton
            // 
            this.DIDButton.Location = new System.Drawing.Point(17, 303);
            this.DIDButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DIDButton.Name = "DIDButton";
            this.DIDButton.Size = new System.Drawing.Size(153, 51);
            this.DIDButton.TabIndex = 3;
            this.DIDButton.Text = "Dispathch Note";
            this.DIDButton.UseVisualStyleBackColor = true;
            this.DIDButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewSalesOrder
            // 
            this.ViewSalesOrder.Location = new System.Drawing.Point(15, 132);
            this.ViewSalesOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ViewSalesOrder.Name = "ViewSalesOrder";
            this.ViewSalesOrder.Size = new System.Drawing.Size(153, 51);
            this.ViewSalesOrder.TabIndex = 2;
            this.ViewSalesOrder.Text = "View Sales Order";
            this.ViewSalesOrder.UseVisualStyleBackColor = true;
            this.ViewSalesOrder.Click += new System.EventHandler(this.ViewSalesOrder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LogoutBurron);
            this.groupBox1.Location = new System.Drawing.Point(22, 495);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(149, 118);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logout";
            // 
            // LogoutBurron
            // 
            this.LogoutBurron.Location = new System.Drawing.Point(-1, 33);
            this.LogoutBurron.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LogoutBurron.Name = "LogoutBurron";
            this.LogoutBurron.Size = new System.Drawing.Size(153, 51);
            this.LogoutBurron.TabIndex = 3;
            this.LogoutBurron.Text = "logout";
            this.LogoutBurron.UseVisualStyleBackColor = true;
            this.LogoutBurron.Click += new System.EventHandler(this.LogoutBurron_Click);
            // 
            // EditSalesOrder
            // 
            this.EditSalesOrder.Location = new System.Drawing.Point(12, 75);
            this.EditSalesOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EditSalesOrder.Name = "EditSalesOrder";
            this.EditSalesOrder.Size = new System.Drawing.Size(153, 51);
            this.EditSalesOrder.TabIndex = 1;
            this.EditSalesOrder.Text = "Edit Sales Order";
            this.EditSalesOrder.UseVisualStyleBackColor = true;
            this.EditSalesOrder.Click += new System.EventHandler(this.EditSalesOrder_Click);
            // 
            // CreateSalesOrder
            // 
            this.CreateSalesOrder.Location = new System.Drawing.Point(15, 18);
            this.CreateSalesOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CreateSalesOrder.Name = "CreateSalesOrder";
            this.CreateSalesOrder.Size = new System.Drawing.Size(153, 51);
            this.CreateSalesOrder.TabIndex = 0;
            this.CreateSalesOrder.Text = "Create Sales Order";
            this.CreateSalesOrder.UseVisualStyleBackColor = true;
            this.CreateSalesOrder.Click += new System.EventHandler(this.CreateSalesOrder_Click);
            // 
            // ChildScreen
            // 
            this.ChildScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildScreen.Location = new System.Drawing.Point(185, 115);
            this.ChildScreen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChildScreen.Name = "ChildScreen";
            this.ChildScreen.Size = new System.Drawing.Size(1487, 940);
            this.ChildScreen.TabIndex = 2;
            this.ChildScreen.Paint += new System.Windows.Forms.PaintEventHandler(this.ChildScreen_Paint);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 246);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 51);
            this.button3.TabIndex = 7;
            this.button3.Text = "DID";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 189);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 51);
            this.button4.TabIndex = 8;
            this.button4.Text = "Cancel Order";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1672, 1055);
            this.Controls.Add(this.ChildScreen);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ViewSalesOrder;
        private System.Windows.Forms.Button EditSalesOrder;
        private System.Windows.Forms.Button CreateSalesOrder;
        private System.Windows.Forms.Panel ChildScreen;
        private System.Windows.Forms.Button LogoutBurron;
        private System.Windows.Forms.Button DIDButton;
        private System.Windows.Forms.Button DICButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}


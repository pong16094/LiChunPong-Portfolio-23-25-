
namespace Dispatch_Processing
{
    partial class GoodRecievedNote
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
            this.grnLogo = new System.Windows.Forms.PictureBox();
            this.grnTxt = new System.Windows.Forms.Label();
            this.grnPanel = new System.Windows.Forms.Panel();
            this.checkBy = new System.Windows.Forms.TextBox();
            this.receivedBy = new System.Windows.Forms.TextBox();
            this.CheckByTxt = new System.Windows.Forms.Label();
            this.ReceiveByTxt = new System.Windows.Forms.Label();
            this.deliverLocat = new System.Windows.Forms.TextBox();
            this.LocationTxt = new System.Windows.Forms.Label();
            this.orderNoTxt = new System.Windows.Forms.Label();
            this.DTTxt = new System.Windows.Forms.Label();
            this.orderNo = new System.Windows.Forms.TextBox();
            this.dateTime = new System.Windows.Forms.TextBox();
            this.GRN_dataGridView = new System.Windows.Forms.DataGridView();
            this.staffID = new System.Windows.Forms.TextBox();
            this.StaffIDTxt = new System.Windows.Forms.Label();
            this.grnmainpagebtn = new System.Windows.Forms.Button();
            this.grnSendbtn = new System.Windows.Forms.Button();
            this.grnLogoutbtn = new System.Windows.Forms.Button();
            this.lmc1DataSet = new Dispatch_Processing.lmc1DataSet();
            this.lmc1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grnTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grnLogo)).BeginInit();
            this.grnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRN_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lmc1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lmc1DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grnLogo
            // 
            this.grnLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.grnLogo.Image = global::Dispatch_Processing.Properties.Resources.legend_motor_company_high_resolution_logo_black;
            this.grnLogo.Location = new System.Drawing.Point(18, 18);
            this.grnLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grnLogo.Name = "grnLogo";
            this.grnLogo.Size = new System.Drawing.Size(219, 160);
            this.grnLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.grnLogo.TabIndex = 0;
            this.grnLogo.TabStop = false;
            this.grnLogo.Click += new System.EventHandler(this.grnLogo_Click);
            // 
            // grnTxt
            // 
            this.grnTxt.AutoSize = true;
            this.grnTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grnTxt.Location = new System.Drawing.Point(284, 46);
            this.grnTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.grnTxt.Name = "grnTxt";
            this.grnTxt.Size = new System.Drawing.Size(572, 37);
            this.grnTxt.TabIndex = 1;
            this.grnTxt.Text = "Welcome to Good Recieved Note Page";
            // 
            // grnPanel
            // 
            this.grnPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grnPanel.Controls.Add(this.checkBy);
            this.grnPanel.Controls.Add(this.receivedBy);
            this.grnPanel.Controls.Add(this.CheckByTxt);
            this.grnPanel.Controls.Add(this.ReceiveByTxt);
            this.grnPanel.Controls.Add(this.deliverLocat);
            this.grnPanel.Controls.Add(this.LocationTxt);
            this.grnPanel.Controls.Add(this.orderNoTxt);
            this.grnPanel.Controls.Add(this.DTTxt);
            this.grnPanel.Controls.Add(this.orderNo);
            this.grnPanel.Controls.Add(this.dateTime);
            this.grnPanel.Controls.Add(this.GRN_dataGridView);
            this.grnPanel.Controls.Add(this.staffID);
            this.grnPanel.Controls.Add(this.StaffIDTxt);
            this.grnPanel.Location = new System.Drawing.Point(291, 204);
            this.grnPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grnPanel.Name = "grnPanel";
            this.grnPanel.Size = new System.Drawing.Size(1570, 722);
            this.grnPanel.TabIndex = 2;
            // 
            // checkBy
            // 
            this.checkBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBy.Location = new System.Drawing.Point(837, 678);
            this.checkBy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBy.Name = "checkBy";
            this.checkBy.Size = new System.Drawing.Size(148, 28);
            this.checkBy.TabIndex = 10;
            // 
            // receivedBy
            // 
            this.receivedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receivedBy.Location = new System.Drawing.Point(165, 678);
            this.receivedBy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.receivedBy.Name = "receivedBy";
            this.receivedBy.Size = new System.Drawing.Size(148, 28);
            this.receivedBy.TabIndex = 9;
            // 
            // CheckByTxt
            // 
            this.CheckByTxt.AutoSize = true;
            this.CheckByTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckByTxt.Location = new System.Drawing.Point(681, 678);
            this.CheckByTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CheckByTxt.Name = "CheckByTxt";
            this.CheckByTxt.Size = new System.Drawing.Size(148, 29);
            this.CheckByTxt.TabIndex = 8;
            this.CheckByTxt.Text = "Checked By:";
            // 
            // ReceiveByTxt
            // 
            this.ReceiveByTxt.AutoSize = true;
            this.ReceiveByTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiveByTxt.Location = new System.Drawing.Point(4, 678);
            this.ReceiveByTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReceiveByTxt.Name = "ReceiveByTxt";
            this.ReceiveByTxt.Size = new System.Drawing.Size(154, 29);
            this.ReceiveByTxt.TabIndex = 7;
            this.ReceiveByTxt.Text = "Received By:";
            // 
            // deliverLocat
            // 
            this.deliverLocat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliverLocat.Location = new System.Drawing.Point(1155, 12);
            this.deliverLocat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deliverLocat.Name = "deliverLocat";
            this.deliverLocat.Size = new System.Drawing.Size(390, 28);
            this.deliverLocat.TabIndex = 2;
            // 
            // LocationTxt
            // 
            this.LocationTxt.AutoSize = true;
            this.LocationTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationTxt.Location = new System.Drawing.Point(952, 15);
            this.LocationTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LocationTxt.Name = "LocationTxt";
            this.LocationTxt.Size = new System.Drawing.Size(197, 29);
            this.LocationTxt.TabIndex = 6;
            this.LocationTxt.Text = "Delivery Location";
            // 
            // orderNoTxt
            // 
            this.orderNoTxt.AutoSize = true;
            this.orderNoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderNoTxt.Location = new System.Drawing.Point(681, 16);
            this.orderNoTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderNoTxt.Name = "orderNoTxt";
            this.orderNoTxt.Size = new System.Drawing.Size(108, 29);
            this.orderNoTxt.TabIndex = 5;
            this.orderNoTxt.Text = "OrderNo";
            // 
            // DTTxt
            // 
            this.DTTxt.AutoSize = true;
            this.DTTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTTxt.Location = new System.Drawing.Point(264, 16);
            this.DTTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DTTxt.Name = "DTTxt";
            this.DTTxt.Size = new System.Drawing.Size(171, 29);
            this.DTTxt.TabIndex = 3;
            this.DTTxt.Text = "Date and Time";
            // 
            // orderNo
            // 
            this.orderNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderNo.Location = new System.Drawing.Point(794, 12);
            this.orderNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orderNo.Name = "orderNo";
            this.orderNo.Size = new System.Drawing.Size(148, 28);
            this.orderNo.TabIndex = 3;
            // 
            // dateTime
            // 
            this.dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Location = new System.Drawing.Point(442, 12);
            this.dateTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(228, 28);
            this.dateTime.TabIndex = 4;
            // 
            // GRN_dataGridView
            // 
            this.GRN_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRN_dataGridView.Location = new System.Drawing.Point(0, 54);
            this.GRN_dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GRN_dataGridView.Name = "GRN_dataGridView";
            this.GRN_dataGridView.RowHeadersWidth = 62;
            this.GRN_dataGridView.RowTemplate.Height = 24;
            this.GRN_dataGridView.Size = new System.Drawing.Size(1566, 594);
            this.GRN_dataGridView.TabIndex = 2;
            this.GRN_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRN_dataGridView_CellContentClick);
            // 
            // staffID
            // 
            this.staffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffID.Location = new System.Drawing.Point(105, 12);
            this.staffID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.staffID.Name = "staffID";
            this.staffID.Size = new System.Drawing.Size(148, 28);
            this.staffID.TabIndex = 1;
            // 
            // StaffIDTxt
            // 
            this.StaffIDTxt.AutoSize = true;
            this.StaffIDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffIDTxt.Location = new System.Drawing.Point(4, 16);
            this.StaffIDTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StaffIDTxt.Name = "StaffIDTxt";
            this.StaffIDTxt.Size = new System.Drawing.Size(83, 29);
            this.StaffIDTxt.TabIndex = 0;
            this.StaffIDTxt.Text = "StaffID";
            // 
            // grnmainpagebtn
            // 
            this.grnmainpagebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grnmainpagebtn.Location = new System.Drawing.Point(18, 975);
            this.grnmainpagebtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grnmainpagebtn.Name = "grnmainpagebtn";
            this.grnmainpagebtn.Size = new System.Drawing.Size(112, 34);
            this.grnmainpagebtn.TabIndex = 11;
            this.grnmainpagebtn.Text = "back";
            this.grnmainpagebtn.UseVisualStyleBackColor = true;
            this.grnmainpagebtn.Click += new System.EventHandler(this.mainpagebtn_Click_1);
            // 
            // grnSendbtn
            // 
            this.grnSendbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grnSendbtn.Location = new System.Drawing.Point(1749, 975);
            this.grnSendbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grnSendbtn.Name = "grnSendbtn";
            this.grnSendbtn.Size = new System.Drawing.Size(112, 34);
            this.grnSendbtn.TabIndex = 12;
            this.grnSendbtn.Text = "Send";
            this.grnSendbtn.UseVisualStyleBackColor = true;
            this.grnSendbtn.Click += new System.EventHandler(this.grnSendbtn_Click);
            // 
            // grnLogoutbtn
            // 
            this.grnLogoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grnLogoutbtn.Location = new System.Drawing.Point(1749, 18);
            this.grnLogoutbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grnLogoutbtn.Name = "grnLogoutbtn";
            this.grnLogoutbtn.Size = new System.Drawing.Size(112, 34);
            this.grnLogoutbtn.TabIndex = 13;
            this.grnLogoutbtn.Text = "Logout";
            this.grnLogoutbtn.UseVisualStyleBackColor = true;
            // 
            // lmc1DataSet
            // 
            this.lmc1DataSet.DataSetName = "lmc1DataSet";
            this.lmc1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lmc1DataSetBindingSource
            // 
            this.lmc1DataSetBindingSource.DataSource = this.lmc1DataSet;
            this.lmc1DataSetBindingSource.Position = 0;
            // 
            // grnTimer
            // 
            this.grnTimer.Tick += new System.EventHandler(this.grnTimer_Tick);
            // 
            // GoodRecievedNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1880, 1028);
            this.Controls.Add(this.grnLogoutbtn);
            this.Controls.Add(this.grnSendbtn);
            this.Controls.Add(this.grnmainpagebtn);
            this.Controls.Add(this.grnPanel);
            this.Controls.Add(this.grnTxt);
            this.Controls.Add(this.grnLogo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GoodRecievedNote";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GoodRecievedNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grnLogo)).EndInit();
            this.grnPanel.ResumeLayout(false);
            this.grnPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRN_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lmc1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lmc1DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox grnLogo;
        private System.Windows.Forms.Label grnTxt;
        private System.Windows.Forms.Panel grnPanel;
        private System.Windows.Forms.Button grnmainpagebtn;
        private System.Windows.Forms.Button grnSendbtn;
        private System.Windows.Forms.Button grnLogoutbtn;
        private lmc1DataSet lmc1DataSet;
        private System.Windows.Forms.BindingSource lmc1DataSetBindingSource;
        private System.Windows.Forms.Label StaffIDTxt;
        private System.Windows.Forms.TextBox staffID;
        private System.Windows.Forms.TextBox deliverLocat;
        private System.Windows.Forms.TextBox orderNo;
        private System.Windows.Forms.TextBox dateTime;
        private System.Windows.Forms.TextBox checkBy;
        private System.Windows.Forms.TextBox receivedBy;
        private System.Windows.Forms.Label CheckByTxt;
        private System.Windows.Forms.Label ReceiveByTxt;
        private System.Windows.Forms.Label LocationTxt;
        private System.Windows.Forms.Label orderNoTxt;
        private System.Windows.Forms.Label DTTxt;
        private System.Windows.Forms.DataGridView GRN_dataGridView;
        private System.Windows.Forms.Timer grnTimer;
    }
}
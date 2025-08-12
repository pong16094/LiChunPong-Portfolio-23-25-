
namespace Dispatch_Processing
{
    partial class DispatchNote
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
            this.dn_Txt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dn_loc_txt = new System.Windows.Forms.TextBox();
            this.dn_no_txt = new System.Windows.Forms.TextBox();
            this.dn_loc_lbl = new System.Windows.Forms.Label();
            this.dn_no_lbl = new System.Windows.Forms.Label();
            this.dn_dt_txt = new System.Windows.Forms.TextBox();
            this.dispatchBy = new System.Windows.Forms.TextBox();
            this.diapatchLbl = new System.Windows.Forms.Label();
            this.dn_DT_Lbl = new System.Windows.Forms.Label();
            this.dnLogo = new System.Windows.Forms.PictureBox();
            this.mainpagebtn = new System.Windows.Forms.Button();
            this.dnLogoutbtn = new System.Windows.Forms.Button();
            this.dispatchbtn = new System.Windows.Forms.Button();
            this.dnTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dn_Txt
            // 
            this.dn_Txt.AutoSize = true;
            this.dn_Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dn_Txt.Location = new System.Drawing.Point(180, 29);
            this.dn_Txt.Name = "dn_Txt";
            this.dn_Txt.Size = new System.Drawing.Size(147, 25);
            this.dn_Txt.TabIndex = 1;
            this.dn_Txt.Text = "Dispatch Note";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.dn_loc_txt);
            this.panel1.Controls.Add(this.dn_no_txt);
            this.panel1.Controls.Add(this.dn_loc_lbl);
            this.panel1.Controls.Add(this.dn_no_lbl);
            this.panel1.Controls.Add(this.dn_dt_txt);
            this.panel1.Controls.Add(this.dispatchBy);
            this.panel1.Controls.Add(this.diapatchLbl);
            this.panel1.Controls.Add(this.dn_DT_Lbl);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(158, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 566);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1079, 478);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dn_loc_txt
            // 
            this.dn_loc_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dn_loc_txt.Location = new System.Drawing.Point(842, 12);
            this.dn_loc_txt.Name = "dn_loc_txt";
            this.dn_loc_txt.Size = new System.Drawing.Size(240, 21);
            this.dn_loc_txt.TabIndex = 7;
            // 
            // dn_no_txt
            // 
            this.dn_no_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dn_no_txt.Location = new System.Drawing.Point(593, 14);
            this.dn_no_txt.Name = "dn_no_txt";
            this.dn_no_txt.Size = new System.Drawing.Size(100, 21);
            this.dn_no_txt.TabIndex = 6;
            // 
            // dn_loc_lbl
            // 
            this.dn_loc_lbl.AutoSize = true;
            this.dn_loc_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dn_loc_lbl.Location = new System.Drawing.Point(699, 14);
            this.dn_loc_lbl.Name = "dn_loc_lbl";
            this.dn_loc_lbl.Size = new System.Drawing.Size(137, 20);
            this.dn_loc_lbl.TabIndex = 5;
            this.dn_loc_lbl.Text = "Dispatch Location";
            // 
            // dn_no_lbl
            // 
            this.dn_no_lbl.AutoSize = true;
            this.dn_no_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dn_no_lbl.Location = new System.Drawing.Point(495, 14);
            this.dn_no_lbl.Name = "dn_no_lbl";
            this.dn_no_lbl.Size = new System.Drawing.Size(92, 20);
            this.dn_no_lbl.TabIndex = 3;
            this.dn_no_lbl.Text = "DispatchNo";
            // 
            // dn_dt_txt
            // 
            this.dn_dt_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dn_dt_txt.Location = new System.Drawing.Point(357, 13);
            this.dn_dt_txt.Name = "dn_dt_txt";
            this.dn_dt_txt.Size = new System.Drawing.Size(132, 21);
            this.dn_dt_txt.TabIndex = 2;
            // 
            // dispatchBy
            // 
            this.dispatchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispatchBy.Location = new System.Drawing.Point(132, 11);
            this.dispatchBy.Name = "dispatchBy";
            this.dispatchBy.Size = new System.Drawing.Size(100, 21);
            this.dispatchBy.TabIndex = 1;
            // 
            // diapatchLbl
            // 
            this.diapatchLbl.AutoSize = true;
            this.diapatchLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diapatchLbl.Location = new System.Drawing.Point(14, 11);
            this.diapatchLbl.Name = "diapatchLbl";
            this.diapatchLbl.Size = new System.Drawing.Size(112, 20);
            this.diapatchLbl.TabIndex = 1;
            this.diapatchLbl.Text = "Dispatched By";
            // 
            // dn_DT_Lbl
            // 
            this.dn_DT_Lbl.AutoSize = true;
            this.dn_DT_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dn_DT_Lbl.Location = new System.Drawing.Point(238, 13);
            this.dn_DT_Lbl.Name = "dn_DT_Lbl";
            this.dn_DT_Lbl.Size = new System.Drawing.Size(113, 20);
            this.dn_DT_Lbl.TabIndex = 0;
            this.dn_DT_Lbl.Text = "Date and Time";
            // 
            // dnLogo
            // 
            this.dnLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.dnLogo.Image = global::Dispatch_Processing.Properties.Resources.legend_motor_company_high_resolution_logo_black;
            this.dnLogo.Location = new System.Drawing.Point(12, 13);
            this.dnLogo.Name = "dnLogo";
            this.dnLogo.Size = new System.Drawing.Size(132, 105);
            this.dnLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dnLogo.TabIndex = 0;
            this.dnLogo.TabStop = false;
            this.dnLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mainpagebtn
            // 
            this.mainpagebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainpagebtn.Location = new System.Drawing.Point(12, 704);
            this.mainpagebtn.Name = "mainpagebtn";
            this.mainpagebtn.Size = new System.Drawing.Size(75, 25);
            this.mainpagebtn.TabIndex = 10;
            this.mainpagebtn.Text = "back";
            this.mainpagebtn.UseVisualStyleBackColor = true;
            this.mainpagebtn.Click += new System.EventHandler(this.mainpagebtn_Click);
            // 
            // dnLogoutbtn
            // 
            this.dnLogoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dnLogoutbtn.Location = new System.Drawing.Point(1166, 13);
            this.dnLogoutbtn.Name = "dnLogoutbtn";
            this.dnLogoutbtn.Size = new System.Drawing.Size(75, 25);
            this.dnLogoutbtn.TabIndex = 14;
            this.dnLogoutbtn.Text = "Logout";
            this.dnLogoutbtn.UseVisualStyleBackColor = true;
            // 
            // dispatchbtn
            // 
            this.dispatchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispatchbtn.Location = new System.Drawing.Point(1166, 704);
            this.dispatchbtn.Name = "dispatchbtn";
            this.dispatchbtn.Size = new System.Drawing.Size(75, 25);
            this.dispatchbtn.TabIndex = 15;
            this.dispatchbtn.Text = "Dispatch";
            this.dispatchbtn.UseVisualStyleBackColor = true;
            this.dispatchbtn.Click += new System.EventHandler(this.dispatchbtn_Click);
            // 
            // dnTimer
            // 
            this.dnTimer.Tick += new System.EventHandler(this.dnTimer_Tick);
            // 
            // DispatchNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1255, 742);
            this.Controls.Add(this.dispatchbtn);
            this.Controls.Add(this.dnLogoutbtn);
            this.Controls.Add(this.mainpagebtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dn_Txt);
            this.Controls.Add(this.dnLogo);
            this.Name = "DispatchNote";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.DispatchNote_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dnLogo;
        private System.Windows.Forms.Label dn_Txt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button mainpagebtn;
        private System.Windows.Forms.Button dnLogoutbtn;
        private System.Windows.Forms.Label dn_DT_Lbl;
        private System.Windows.Forms.Label dn_no_lbl;
        private System.Windows.Forms.TextBox dn_dt_txt;
        private System.Windows.Forms.TextBox dispatchBy;
        private System.Windows.Forms.Label diapatchLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox dn_loc_txt;
        private System.Windows.Forms.TextBox dn_no_txt;
        private System.Windows.Forms.Label dn_loc_lbl;
        private System.Windows.Forms.Button dispatchbtn;
        private System.Windows.Forms.Timer dnTimer;
    }
}
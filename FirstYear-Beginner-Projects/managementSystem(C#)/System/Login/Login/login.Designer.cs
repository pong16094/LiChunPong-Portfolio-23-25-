namespace Login
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
            this.UserID = new System.Windows.Forms.Label();
            this.UserIDBox = new System.Windows.Forms.TextBox();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.lbFP = new System.Windows.Forms.Label();
            this.show = new System.Windows.Forms.Button();
            this.hide = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Font = new System.Drawing.Font("Romantic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.UserID.Location = new System.Drawing.Point(179, 69);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(164, 37);
            this.UserID.TabIndex = 1;
            this.UserID.Text = "Username :";
            this.UserID.Click += new System.EventHandler(this.UserID_Click);
            // 
            // UserIDBox
            // 
            this.UserIDBox.BackColor = System.Drawing.Color.White;
            this.UserIDBox.Location = new System.Drawing.Point(355, 81);
            this.UserIDBox.Name = "UserIDBox";
            this.UserIDBox.Size = new System.Drawing.Size(228, 25);
            this.UserIDBox.TabIndex = 0;
            this.UserIDBox.TextChanged += new System.EventHandler(this.UserIDBox_TextChanged);
            // 
            // passwordbox
            // 
            this.passwordbox.BackColor = System.Drawing.Color.White;
            this.passwordbox.Location = new System.Drawing.Point(355, 154);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.PasswordChar = '*';
            this.passwordbox.Size = new System.Drawing.Size(228, 25);
            this.passwordbox.TabIndex = 1;
            this.passwordbox.TextChanged += new System.EventHandler(this.passwordbox_TextChanged);
            this.passwordbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordbox_KeyPress);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Romantic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.password.Location = new System.Drawing.Point(185, 140);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(158, 37);
            this.password.TabIndex = 3;
            this.password.Text = "Password :";
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(233)))), ((int)(((byte)(247)))));
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.Black;
            this.Login.Location = new System.Drawing.Point(529, 227);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(115, 54);
            this.Login.TabIndex = 2;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // lbFP
            // 
            this.lbFP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFP.ForeColor = System.Drawing.Color.Black;
            this.lbFP.Location = new System.Drawing.Point(221, 227);
            this.lbFP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFP.Name = "lbFP";
            this.lbFP.Size = new System.Drawing.Size(211, 54);
            this.lbFP.TabIndex = 8;
            this.lbFP.Text = "Change Password";
            this.lbFP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbFP.Click += new System.EventHandler(this.lbFP_Click);
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.Color.White;
            this.show.BackgroundImage = global::Login.Properties.Resources.show__1_;
            this.show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show.ForeColor = System.Drawing.Color.Black;
            this.show.Location = new System.Drawing.Point(550, 154);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(33, 25);
            this.show.TabIndex = 7;
            this.show.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.show.UseVisualStyleBackColor = false;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // hide
            // 
            this.hide.BackColor = System.Drawing.Color.White;
            this.hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hide.Font = new System.Drawing.Font("PMingLiU", 4F);
            this.hide.ForeColor = System.Drawing.Color.Black;
            this.hide.Image = global::Login.Properties.Resources.hide__1_;
            this.hide.Location = new System.Drawing.Point(550, 154);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(33, 25);
            this.hide.TabIndex = 6;
            this.hide.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.hide.UseVisualStyleBackColor = false;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login.Properties.Resources.legend_motor_company_high_resolution_logo_black;
            this.pictureBox1.Location = new System.Drawing.Point(3, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(190)))), ((int)(((byte)(235)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 567);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Welcome to LMC system Login page";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(308, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 91);
            this.panel2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Please enter the information";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(183)))), ((int)(((byte)(194)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.UserID);
            this.panel3.Controls.Add(this.UserIDBox);
            this.panel3.Controls.Add(this.password);
            this.panel3.Controls.Add(this.lbFP);
            this.panel3.Controls.Add(this.passwordbox);
            this.panel3.Controls.Add(this.show);
            this.panel3.Controls.Add(this.Login);
            this.panel3.Controls.Add(this.hide);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(308, 91);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(660, 476);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 406);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(660, 70);
            this.panel4.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(968, 567);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Legend Motor Company";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.TextBox UserIDBox;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button hide;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Label lbFP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}


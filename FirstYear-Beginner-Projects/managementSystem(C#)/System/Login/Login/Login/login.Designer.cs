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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.UserID.Location = new System.Drawing.Point(265, 178);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(95, 30);
            this.UserID.TabIndex = 1;
            this.UserID.Text = "UserID";
            // 
            // UserIDBox
            // 
            this.UserIDBox.BackColor = System.Drawing.Color.White;
            this.UserIDBox.Location = new System.Drawing.Point(408, 183);
            this.UserIDBox.Name = "UserIDBox";
            this.UserIDBox.Size = new System.Drawing.Size(228, 25);
            this.UserIDBox.TabIndex = 2;
            this.UserIDBox.TextChanged += new System.EventHandler(this.UserIDBox_TextChanged);
            // 
            // passwordbox
            // 
            this.passwordbox.BackColor = System.Drawing.Color.White;
            this.passwordbox.Location = new System.Drawing.Point(408, 242);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.PasswordChar = '*';
            this.passwordbox.Size = new System.Drawing.Size(228, 25);
            this.passwordbox.TabIndex = 4;
            this.passwordbox.TextChanged += new System.EventHandler(this.passwordbox_TextChanged);
            this.passwordbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordbox_KeyPress);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.password.Location = new System.Drawing.Point(265, 237);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(119, 30);
            this.password.TabIndex = 3;
            this.password.Text = "password";
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Red;
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Location = new System.Drawing.Point(583, 330);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(115, 54);
            this.Login.TabIndex = 5;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // lbFP
            // 
            this.lbFP.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFP.ForeColor = System.Drawing.Color.Black;
            this.lbFP.Location = new System.Drawing.Point(275, 330);
            this.lbFP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFP.Name = "lbFP";
            this.lbFP.Size = new System.Drawing.Size(210, 54);
            this.lbFP.TabIndex = 8;
            this.lbFP.Text = "Change password";
            this.lbFP.Click += new System.EventHandler(this.lbFP_Click);
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.Color.White;
            this.show.BackgroundImage = global::Login.Properties.Resources.show__1_;
            this.show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show.ForeColor = System.Drawing.Color.Black;
            this.show.Location = new System.Drawing.Point(603, 242);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(33, 23);
            this.show.TabIndex = 7;
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
            this.hide.Location = new System.Drawing.Point(603, 242);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(33, 23);
            this.hide.TabIndex = 6;
            this.hide.UseVisualStyleBackColor = false;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login.Properties.Resources.legend_motor_company_high_resolution_logo_black;
            this.pictureBox1.Location = new System.Drawing.Point(12, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(968, 567);
            this.Controls.Add(this.lbFP);
            this.Controls.Add(this.show);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.UserIDBox);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Legend Motor Company";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}


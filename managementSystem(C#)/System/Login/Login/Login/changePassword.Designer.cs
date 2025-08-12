
namespace Login
{
    partial class changePassword
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
            this.label4 = new System.Windows.Forms.Label();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbcnp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btcf = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.hide = new System.Windows.Forms.Button();
            this.tbnp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(106, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email address";
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(269, 93);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(234, 25);
            this.tbemail.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(106, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Old password";
            // 
            // tbop
            // 
            this.tbop.Location = new System.Drawing.Point(269, 146);
            this.tbop.Name = "tbop";
            this.tbop.Size = new System.Drawing.Size(234, 25);
            this.tbop.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(24, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Confirm new password";
            // 
            // tbcnp
            // 
            this.tbcnp.Location = new System.Drawing.Point(269, 249);
            this.tbcnp.Name = "tbcnp";
            this.tbcnp.PasswordChar = '*';
            this.tbcnp.Size = new System.Drawing.Size(234, 25);
            this.tbcnp.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(102, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "New password";
            // 
            // btcf
            // 
            this.btcf.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btcf.Location = new System.Drawing.Point(392, 298);
            this.btcf.Name = "btcf";
            this.btcf.Size = new System.Drawing.Size(111, 77);
            this.btcf.TabIndex = 15;
            this.btcf.Text = "Reset";
            this.btcf.UseVisualStyleBackColor = true;
            this.btcf.Click += new System.EventHandler(this.btcf_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.back.Location = new System.Drawing.Point(269, 298);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(111, 77);
            this.back.TabIndex = 16;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.Color.White;
            this.show.BackgroundImage = global::Login.Properties.Resources.show__1_;
            this.show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.show.ForeColor = System.Drawing.Color.Black;
            this.show.Location = new System.Drawing.Point(470, 192);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(33, 25);
            this.show.TabIndex = 17;
            this.show.UseVisualStyleBackColor = false;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // hide
            // 
            this.hide.BackColor = System.Drawing.Color.White;
            this.hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hide.Font = new System.Drawing.Font("PMingLiU", 4F);
            this.hide.ForeColor = System.Drawing.Color.Black;
            this.hide.Image = global::Login.Properties.Resources.hide__1_;
            this.hide.Location = new System.Drawing.Point(470, 192);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(33, 25);
            this.hide.TabIndex = 18;
            this.hide.UseVisualStyleBackColor = false;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // tbnp
            // 
            this.tbnp.BackColor = System.Drawing.Color.White;
            this.tbnp.Location = new System.Drawing.Point(269, 192);
            this.tbnp.Name = "tbnp";
            this.tbnp.PasswordChar = '*';
            this.tbnp.Size = new System.Drawing.Size(234, 25);
            this.tbnp.TabIndex = 19;
            // 
            // changePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.show);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.tbnp);
            this.Controls.Add(this.back);
            this.Controls.Add(this.btcf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbcnp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbemail);
            this.Name = "changePassword";
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbcnp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btcf;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button hide;
        private System.Windows.Forms.TextBox tbnp;
    }
}
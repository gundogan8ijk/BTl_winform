namespace QuanLiNhanSu
{
    partial class DangKi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKi));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pass1DK = new System.Windows.Forms.TextBox();
            this.txt_pass2DK = new System.Windows.Forms.TextBox();
            this.txt_emailDK = new System.Windows.Forms.TextBox();
            this.btn_Dangki = new System.Windows.Forms.Button();
            this.rdb_User = new System.Windows.Forms.RadioButton();
            this.rdb_Admin = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_quaylai = new System.Windows.Forms.LinkLabel();
            this.lb_Error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(142, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            // 
            // txt_pass1DK
            // 
            this.txt_pass1DK.Location = new System.Drawing.Point(83, 314);
            this.txt_pass1DK.Name = "txt_pass1DK";
            this.txt_pass1DK.Size = new System.Drawing.Size(281, 22);
            this.txt_pass1DK.TabIndex = 2;
            // 
            // txt_pass2DK
            // 
            this.txt_pass2DK.Location = new System.Drawing.Point(86, 385);
            this.txt_pass2DK.Name = "txt_pass2DK";
            this.txt_pass2DK.Size = new System.Drawing.Size(281, 22);
            this.txt_pass2DK.TabIndex = 3;
            // 
            // txt_emailDK
            // 
            this.txt_emailDK.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_emailDK.Location = new System.Drawing.Point(86, 237);
            this.txt_emailDK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_emailDK.Name = "txt_emailDK";
            this.txt_emailDK.Size = new System.Drawing.Size(281, 22);
            this.txt_emailDK.TabIndex = 5;
            this.txt_emailDK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_emailDK.TextChanged += new System.EventHandler(this.txt_emailDK_TextChanged);
            // 
            // btn_Dangki
            // 
            this.btn_Dangki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Dangki.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dangki.ForeColor = System.Drawing.Color.White;
            this.btn_Dangki.Location = new System.Drawing.Point(83, 490);
            this.btn_Dangki.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Dangki.Name = "btn_Dangki";
            this.btn_Dangki.Size = new System.Drawing.Size(129, 39);
            this.btn_Dangki.TabIndex = 7;
            this.btn_Dangki.Text = "&Đăng kí";
            this.btn_Dangki.UseVisualStyleBackColor = false;
            this.btn_Dangki.Click += new System.EventHandler(this.btn_Dangki_Click);
            // 
            // rdb_User
            // 
            this.rdb_User.AutoSize = true;
            this.rdb_User.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdb_User.Location = new System.Drawing.Point(89, 444);
            this.rdb_User.Name = "rdb_User";
            this.rdb_User.Size = new System.Drawing.Size(57, 20);
            this.rdb_User.TabIndex = 8;
            this.rdb_User.TabStop = true;
            this.rdb_User.Text = "User";
            this.rdb_User.UseVisualStyleBackColor = false;
            // 
            // rdb_Admin
            // 
            this.rdb_Admin.AutoSize = true;
            this.rdb_Admin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdb_Admin.Location = new System.Drawing.Point(172, 444);
            this.rdb_Admin.Name = "rdb_Admin";
            this.rdb_Admin.Size = new System.Drawing.Size(66, 20);
            this.rdb_Admin.TabIndex = 9;
            this.rdb_Admin.TabStop = true;
            this.rdb_Admin.Text = "Admin";
            this.rdb_Admin.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(86, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Email Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(83, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(83, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Password:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(172, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // lb_quaylai
            // 
            this.lb_quaylai.AutoSize = true;
            this.lb_quaylai.Location = new System.Drawing.Point(86, 569);
            this.lb_quaylai.Name = "lb_quaylai";
            this.lb_quaylai.Size = new System.Drawing.Size(56, 16);
            this.lb_quaylai.TabIndex = 17;
            this.lb_quaylai.TabStop = true;
            this.lb_quaylai.Text = "Quay lai";
            this.lb_quaylai.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_quaylai_LinkClicked);
            // 
            // lb_Error
            // 
            this.lb_Error.AutoSize = true;
            this.lb_Error.BackColor = System.Drawing.Color.White;
            this.lb_Error.ForeColor = System.Drawing.Color.Red;
            this.lb_Error.Location = new System.Drawing.Point(86, 425);
            this.lb_Error.Name = "lb_Error";
            this.lb_Error.Size = new System.Drawing.Size(0, 16);
            this.lb_Error.TabIndex = 18;
            // 
            // DangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(452, 635);
            this.Controls.Add(this.lb_Error);
            this.Controls.Add(this.lb_quaylai);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdb_Admin);
            this.Controls.Add(this.rdb_User);
            this.Controls.Add(this.btn_Dangki);
            this.Controls.Add(this.txt_emailDK);
            this.Controls.Add(this.txt_pass2DK);
            this.Controls.Add(this.txt_pass1DK);
            this.Controls.Add(this.label1);
            this.Name = "DangKi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangKi";
            this.Load += new System.EventHandler(this.DangKi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pass1DK;
        private System.Windows.Forms.TextBox txt_pass2DK;
        private System.Windows.Forms.TextBox txt_emailDK;
        private System.Windows.Forms.Button btn_Dangki;
        private System.Windows.Forms.RadioButton rdb_User;
        private System.Windows.Forms.RadioButton rdb_Admin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lb_quaylai;
        private System.Windows.Forms.Label lb_Error;
    }
}
namespace QuanLiNhanSu
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.btn_Dangnhap = new System.Windows.Forms.Button();
            this.link_Dangky = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_Showpass = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Taikhoan = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(30, 246);
            this.txt_matkhau.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.PasswordChar = '*';
            this.txt_matkhau.Size = new System.Drawing.Size(281, 27);
            this.txt_matkhau.TabIndex = 2;
            this.txt_matkhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Dangnhap
            // 
            this.btn_Dangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Dangnhap.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dangnhap.ForeColor = System.Drawing.Color.White;
            this.btn_Dangnhap.Location = new System.Drawing.Point(30, 302);
            this.btn_Dangnhap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Dangnhap.Name = "btn_Dangnhap";
            this.btn_Dangnhap.Size = new System.Drawing.Size(129, 39);
            this.btn_Dangnhap.TabIndex = 3;
            this.btn_Dangnhap.Text = "&Đăng nhập";
            this.btn_Dangnhap.UseVisualStyleBackColor = false;
            this.btn_Dangnhap.Click += new System.EventHandler(this.btn_Dangnhap_Click);
            // 
            // link_Dangky
            // 
            this.link_Dangky.AutoSize = true;
            this.link_Dangky.Location = new System.Drawing.Point(232, 379);
            this.link_Dangky.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.link_Dangky.Name = "link_Dangky";
            this.link_Dangky.Size = new System.Drawing.Size(65, 20);
            this.link_Dangky.TabIndex = 4;
            this.link_Dangky.TabStop = true;
            this.link_Dangky.Text = "&Đăng kí";
            this.link_Dangky.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(57, 379);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(136, 20);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "&Quên mật khẩu ?";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 427);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.cb_Showpass);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.link_Dangky);
            this.panel2.Controls.Add(this.txt_Taikhoan);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.txt_matkhau);
            this.panel2.Controls.Add(this.btn_Dangnhap);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(264, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 427);
            this.panel2.TabIndex = 7;
            // 
            // cb_Showpass
            // 
            this.cb_Showpass.AutoSize = true;
            this.cb_Showpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb_Showpass.Location = new System.Drawing.Point(239, 288);
            this.cb_Showpass.Name = "cb_Showpass";
            this.cb_Showpass.Size = new System.Drawing.Size(72, 24);
            this.cb_Showpass.TabIndex = 9;
            this.cb_Showpass.Text = "Show";
            this.cb_Showpass.UseVisualStyleBackColor = false;
            this.cb_Showpass.CheckedChanged += new System.EventHandler(this.cb_Showpass_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(30, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(30, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(126, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 53);
            this.label1.TabIndex = 6;
            this.label1.Text = "&Login";
            // 
            // txt_Taikhoan
            // 
            this.txt_Taikhoan.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_Taikhoan.Location = new System.Drawing.Point(30, 171);
            this.txt_Taikhoan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Taikhoan.Name = "txt_Taikhoan";
            this.txt_Taikhoan.Size = new System.Drawing.Size(281, 27);
            this.txt_Taikhoan.TabIndex = 1;
            this.txt_Taikhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Taikhoan.TextChanged += new System.EventHandler(this.txt_Taikhoan_TextChanged);
            this.txt_Taikhoan.Enter += new System.EventHandler(this.txt_Taikhoan_Enter);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(633, 427);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.Button btn_Dangnhap;
        private System.Windows.Forms.LinkLabel link_Dangky;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Taikhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cb_Showpass;
    }
}
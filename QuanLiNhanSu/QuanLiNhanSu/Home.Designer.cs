namespace QuanLiNhanSu
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Taikhoan = new System.Windows.Forms.Button();
            this.btn_Thongke = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Luong = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btn_Chamcong = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hienthidanhsach1 = new QuanLiNhanSu.Hienthidanhsach();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 638);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Taikhoan);
            this.groupBox1.Controls.Add(this.btn_Thongke);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Thoat);
            this.groupBox1.Controls.Add(this.btn_Luong);
            this.groupBox1.Controls.Add(this.btn_CapNhat);
            this.groupBox1.Controls.Add(this.btn_Chamcong);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 638);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chuc nang";
            // 
            // btn_Taikhoan
            // 
            this.btn_Taikhoan.Location = new System.Drawing.Point(26, 178);
            this.btn_Taikhoan.Name = "btn_Taikhoan";
            this.btn_Taikhoan.Size = new System.Drawing.Size(110, 38);
            this.btn_Taikhoan.TabIndex = 6;
            this.btn_Taikhoan.Text = "&Tai khoan";
            this.btn_Taikhoan.UseVisualStyleBackColor = true;
            this.btn_Taikhoan.Click += new System.EventHandler(this.btn_Taikhoan_Click);
            // 
            // btn_Thongke
            // 
            this.btn_Thongke.Location = new System.Drawing.Point(26, 333);
            this.btn_Thongke.Name = "btn_Thongke";
            this.btn_Thongke.Size = new System.Drawing.Size(110, 38);
            this.btn_Thongke.TabIndex = 5;
            this.btn_Thongke.Text = "&Thống kê";
            this.btn_Thongke.UseVisualStyleBackColor = true;
            this.btn_Thongke.Click += new System.EventHandler(this.btn_Thongke_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 4;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.Transparent;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Thoat.Image = global::QuanLiNhanSu.Properties.Resources.logout;
            this.btn_Thoat.Location = new System.Drawing.Point(-9, 584);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(185, 58);
            this.btn_Thoat.TabIndex = 3;
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Luong
            // 
            this.btn_Luong.Location = new System.Drawing.Point(26, 255);
            this.btn_Luong.Name = "btn_Luong";
            this.btn_Luong.Size = new System.Drawing.Size(110, 38);
            this.btn_Luong.TabIndex = 2;
            this.btn_Luong.Text = "&Luong";
            this.btn_Luong.UseVisualStyleBackColor = true;
            this.btn_Luong.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Location = new System.Drawing.Point(26, 85);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(110, 38);
            this.btn_CapNhat.TabIndex = 0;
            this.btn_CapNhat.Text = "&Nhan vien";
            this.btn_CapNhat.UseVisualStyleBackColor = true;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_Chamcong
            // 
            this.btn_Chamcong.Location = new System.Drawing.Point(26, 401);
            this.btn_Chamcong.Name = "btn_Chamcong";
            this.btn_Chamcong.Size = new System.Drawing.Size(110, 38);
            this.btn_Chamcong.TabIndex = 1;
            this.btn_Chamcong.Text = "&Cham Cong";
            this.btn_Chamcong.UseVisualStyleBackColor = true;
            this.btn_Chamcong.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.hienthidanhsach1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(176, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(960, 638);
            this.panel3.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1136, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // hienthidanhsach1
            // 
            this.hienthidanhsach1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hienthidanhsach1.Location = new System.Drawing.Point(0, 0);
            this.hienthidanhsach1.Name = "hienthidanhsach1";
            this.hienthidanhsach1.Size = new System.Drawing.Size(960, 638);
            this.hienthidanhsach1.TabIndex = 1;
            this.hienthidanhsach1.Load += new System.EventHandler(this.hienthidanhsach1_Load);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 666);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phan mem quan li nhan su";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Luong;
        private System.Windows.Forms.Button btn_Chamcong;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private Hienthidanhsach hienthidanhsach1;
        private System.Windows.Forms.Button btn_Thongke;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button btn_Taikhoan;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}


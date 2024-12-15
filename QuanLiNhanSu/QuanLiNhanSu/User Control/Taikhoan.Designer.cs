namespace QuanLiNhanSu.User_Control
{
    partial class Taikhoan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_TK_Huy = new System.Windows.Forms.Button();
            this.btn_TK_Luu = new System.Windows.Forms.Button();
            this.btn_TKXoa = new System.Windows.Forms.Button();
            this.btn_TKSua = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TK_matkhau = new System.Windows.Forms.TextBox();
            this.cb_TK_Quyen = new System.Windows.Forms.ComboBox();
            this.btn_TKThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TK_ten = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_TaiKhoan = new System.Windows.Forms.DataGridView();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_TKtimkiem = new System.Windows.Forms.Button();
            this.txt_TK_Tktentaikhoan = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TaiKhoan)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 600);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_TK_Huy);
            this.groupBox3.Controls.Add(this.btn_TK_Luu);
            this.groupBox3.Controls.Add(this.btn_TKXoa);
            this.groupBox3.Controls.Add(this.btn_TKSua);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txt_TK_matkhau);
            this.groupBox3.Controls.Add(this.cb_TK_Quyen);
            this.groupBox3.Controls.Add(this.btn_TKThem);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_TK_ten);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 600);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chuc nang";
            // 
            // btn_TK_Huy
            // 
            this.btn_TK_Huy.Location = new System.Drawing.Point(173, 411);
            this.btn_TK_Huy.Name = "btn_TK_Huy";
            this.btn_TK_Huy.Size = new System.Drawing.Size(124, 33);
            this.btn_TK_Huy.TabIndex = 13;
            this.btn_TK_Huy.Text = "&Huy";
            this.btn_TK_Huy.UseVisualStyleBackColor = true;
            this.btn_TK_Huy.Click += new System.EventHandler(this.btn_TK_Huy_Click);
            // 
            // btn_TK_Luu
            // 
            this.btn_TK_Luu.Location = new System.Drawing.Point(30, 411);
            this.btn_TK_Luu.Name = "btn_TK_Luu";
            this.btn_TK_Luu.Size = new System.Drawing.Size(119, 33);
            this.btn_TK_Luu.TabIndex = 12;
            this.btn_TK_Luu.Text = "&Luu";
            this.btn_TK_Luu.UseVisualStyleBackColor = true;
            this.btn_TK_Luu.Click += new System.EventHandler(this.btn_TK_Luu_Click);
            // 
            // btn_TKXoa
            // 
            this.btn_TKXoa.Location = new System.Drawing.Point(76, 541);
            this.btn_TKXoa.Name = "btn_TKXoa";
            this.btn_TKXoa.Size = new System.Drawing.Size(153, 33);
            this.btn_TKXoa.TabIndex = 11;
            this.btn_TKXoa.Text = "&Xoa";
            this.btn_TKXoa.UseVisualStyleBackColor = true;
            this.btn_TKXoa.Click += new System.EventHandler(this.btn_TKXoa_Click);
            // 
            // btn_TKSua
            // 
            this.btn_TKSua.Location = new System.Drawing.Point(173, 486);
            this.btn_TKSua.Name = "btn_TKSua";
            this.btn_TKSua.Size = new System.Drawing.Size(124, 33);
            this.btn_TKSua.TabIndex = 10;
            this.btn_TKSua.Text = "&Sua";
            this.btn_TKSua.UseVisualStyleBackColor = true;
            this.btn_TKSua.Click += new System.EventHandler(this.btn_TKSua_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Loai tai khoan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mat khau";
            // 
            // txt_TK_matkhau
            // 
            this.txt_TK_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TK_matkhau.Location = new System.Drawing.Point(76, 227);
            this.txt_TK_matkhau.Name = "txt_TK_matkhau";
            this.txt_TK_matkhau.Size = new System.Drawing.Size(191, 27);
            this.txt_TK_matkhau.TabIndex = 7;
            // 
            // cb_TK_Quyen
            // 
            this.cb_TK_Quyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TK_Quyen.FormattingEnabled = true;
            this.cb_TK_Quyen.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cb_TK_Quyen.Location = new System.Drawing.Point(76, 316);
            this.cb_TK_Quyen.Name = "cb_TK_Quyen";
            this.cb_TK_Quyen.Size = new System.Drawing.Size(191, 28);
            this.cb_TK_Quyen.TabIndex = 6;
            // 
            // btn_TKThem
            // 
            this.btn_TKThem.Location = new System.Drawing.Point(30, 486);
            this.btn_TKThem.Name = "btn_TKThem";
            this.btn_TKThem.Size = new System.Drawing.Size(119, 33);
            this.btn_TKThem.TabIndex = 0;
            this.btn_TKThem.Text = "&Them";
            this.btn_TKThem.UseVisualStyleBackColor = true;
            this.btn_TKThem.Click += new System.EventHandler(this.btn_TKThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ten tai khoan";
            // 
            // txt_TK_ten
            // 
            this.txt_TK_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TK_ten.Location = new System.Drawing.Point(76, 140);
            this.txt_TK_ten.Name = "txt_TK_ten";
            this.txt_TK_ten.Size = new System.Drawing.Size(191, 27);
            this.txt_TK_ten.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(315, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(585, 600);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 122);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(585, 478);
            this.panel4.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_TaiKhoan);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 478);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hien thi tai khoan";
            // 
            // dgv_TaiKhoan
            // 
            this.dgv_TaiKhoan.AllowUserToAddRows = false;
            this.dgv_TaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.email,
            this.matkhau,
            this.quyen});
            this.dgv_TaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_TaiKhoan.Location = new System.Drawing.Point(3, 18);
            this.dgv_TaiKhoan.Name = "dgv_TaiKhoan";
            this.dgv_TaiKhoan.RowHeadersWidth = 51;
            this.dgv_TaiKhoan.RowTemplate.Height = 24;
            this.dgv_TaiKhoan.Size = new System.Drawing.Size(579, 457);
            this.dgv_TaiKhoan.TabIndex = 0;
            this.dgv_TaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TaiKhoan_CellClick);
            this.dgv_TaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TaiKhoan_CellContentClick);
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 125;
            // 
            // matkhau
            // 
            this.matkhau.DataPropertyName = "matkhau";
            this.matkhau.HeaderText = "matkhau";
            this.matkhau.MinimumWidth = 6;
            this.matkhau.Name = "matkhau";
            this.matkhau.Width = 125;
            // 
            // quyen
            // 
            this.quyen.DataPropertyName = "quyen";
            this.quyen.HeaderText = "quyen";
            this.quyen.MinimumWidth = 6;
            this.quyen.Name = "quyen";
            this.quyen.Width = 125;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(585, 122);
            this.panel3.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_TKtimkiem);
            this.groupBox2.Controls.Add(this.txt_TK_Tktentaikhoan);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(585, 122);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tim kiem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Ten tai khoan:";
            // 
            // btn_TKtimkiem
            // 
            this.btn_TKtimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TKtimkiem.Location = new System.Drawing.Point(413, 42);
            this.btn_TKtimkiem.Name = "btn_TKtimkiem";
            this.btn_TKtimkiem.Size = new System.Drawing.Size(105, 30);
            this.btn_TKtimkiem.TabIndex = 2;
            this.btn_TKtimkiem.Text = "Tim kiem";
            this.btn_TKtimkiem.UseVisualStyleBackColor = true;
            this.btn_TKtimkiem.Click += new System.EventHandler(this.btn_TKtimkiem_Click);
            // 
            // txt_TK_Tktentaikhoan
            // 
            this.txt_TK_Tktentaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TK_Tktentaikhoan.Location = new System.Drawing.Point(194, 44);
            this.txt_TK_Tktentaikhoan.Name = "txt_TK_Tktentaikhoan";
            this.txt_TK_Tktentaikhoan.Size = new System.Drawing.Size(149, 27);
            this.txt_TK_Tktentaikhoan.TabIndex = 1;
            // 
            // Taikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Taikhoan";
            this.Size = new System.Drawing.Size(900, 600);
            this.Load += new System.EventHandler(this.Taikhoan_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TaiKhoan)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_TaiKhoan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_TKtimkiem;
        private System.Windows.Forms.TextBox txt_TK_Tktentaikhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_TKThem;
        private System.Windows.Forms.TextBox txt_TK_ten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_TK_Quyen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TK_matkhau;
        private System.Windows.Forms.Button btn_TKXoa;
        private System.Windows.Forms.Button btn_TKSua;
        private System.Windows.Forms.Button btn_TK_Huy;
        private System.Windows.Forms.Button btn_TK_Luu;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn matkhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn quyen;
    }
}

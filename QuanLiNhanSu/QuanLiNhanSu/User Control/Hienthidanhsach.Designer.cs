namespace QuanLiNhanSu
{
    partial class Hienthidanhsach
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_Hienthithongtin = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_TKTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TKMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gb_chucnang = new System.Windows.Forms.GroupBox();
            this.btn_TImkiem = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.gb_thongtin = new System.Windows.Forms.GroupBox();
            this.cb_Chucvu = new System.Windows.Forms.ComboBox();
            this.rdb_Nu = new System.Windows.Forms.RadioButton();
            this.rdb_Nam = new System.Windows.Forms.RadioButton();
            this.dtp_Ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txt_Diachi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Tennv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Sdt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Masv = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hienthithongtin)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gb_chucnang.SuspendLayout();
            this.gb_thongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 600);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(660, 500);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 80);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(660, 420);
            this.panel5.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_Hienthithongtin);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(660, 420);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "&Hien thi thong tin";
            // 
            // dgv_Hienthithongtin
            // 
            this.dgv_Hienthithongtin.AllowUserToAddRows = false;
            this.dgv_Hienthithongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Hienthithongtin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.NgaySinh,
            this.GioiTinh,
            this.SoDienThoai,
            this.Email,
            this.ChucVu,
            this.DiaChi});
            this.dgv_Hienthithongtin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Hienthithongtin.Location = new System.Drawing.Point(3, 18);
            this.dgv_Hienthithongtin.Name = "dgv_Hienthithongtin";
            this.dgv_Hienthithongtin.RowHeadersWidth = 51;
            this.dgv_Hienthithongtin.RowTemplate.Height = 24;
            this.dgv_Hienthithongtin.Size = new System.Drawing.Size(654, 399);
            this.dgv_Hienthithongtin.TabIndex = 0;
            this.dgv_Hienthithongtin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Hienthithongtin_CellClick);
            this.dgv_Hienthithongtin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Hienthithongtin_CellContentClick);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "MaNV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 125;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "TenNV";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.Width = 125;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "NgaySinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 125;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "GioiTinh";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 125;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "SoDienThoai";
            this.SoDienThoai.MinimumWidth = 6;
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.HeaderText = "ChucVu";
            this.ChucVu.MinimumWidth = 6;
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.Width = 125;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "DiaChi";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 125;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(660, 80);
            this.panel4.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_TKTen);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_TKMa);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(660, 80);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "&Tim Kiem";
            // 
            // txt_TKTen
            // 
            this.txt_TKTen.Location = new System.Drawing.Point(491, 28);
            this.txt_TKTen.Name = "txt_TKTen";
            this.txt_TKTen.Size = new System.Drawing.Size(134, 22);
            this.txt_TKTen.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ten Nhan Su";
            // 
            // txt_TKMa
            // 
            this.txt_TKMa.Location = new System.Drawing.Point(142, 30);
            this.txt_TKMa.Name = "txt_TKMa";
            this.txt_TKMa.Size = new System.Drawing.Size(134, 22);
            this.txt_TKMa.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ma Nhan Su";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gb_chucnang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 500);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 100);
            this.panel2.TabIndex = 1;
            // 
            // gb_chucnang
            // 
            this.gb_chucnang.Controls.Add(this.btn_TImkiem);
            this.gb_chucnang.Controls.Add(this.btn_Xoa);
            this.gb_chucnang.Controls.Add(this.btn_Sua);
            this.gb_chucnang.Controls.Add(this.btn_Them);
            this.gb_chucnang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_chucnang.Location = new System.Drawing.Point(0, 0);
            this.gb_chucnang.Name = "gb_chucnang";
            this.gb_chucnang.Size = new System.Drawing.Size(660, 100);
            this.gb_chucnang.TabIndex = 0;
            this.gb_chucnang.TabStop = false;
            this.gb_chucnang.Text = "&Chuc nang";
            // 
            // btn_TImkiem
            // 
            this.btn_TImkiem.Location = new System.Drawing.Point(66, 32);
            this.btn_TImkiem.Name = "btn_TImkiem";
            this.btn_TImkiem.Size = new System.Drawing.Size(107, 36);
            this.btn_TImkiem.TabIndex = 12;
            this.btn_TImkiem.Text = "&TIM KIEM";
            this.btn_TImkiem.UseVisualStyleBackColor = true;
            this.btn_TImkiem.Click += new System.EventHandler(this.btn_TImkiem_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(468, 32);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(107, 36);
            this.btn_Xoa.TabIndex = 11;
            this.btn_Xoa.Text = "&XOA";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(334, 32);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(107, 36);
            this.btn_Sua.TabIndex = 10;
            this.btn_Sua.Text = "&SUA";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(200, 32);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(107, 36);
            this.btn_Them.TabIndex = 9;
            this.btn_Them.Text = "&THEM";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(660, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 600);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // gb_thongtin
            // 
            this.gb_thongtin.Controls.Add(this.cb_Chucvu);
            this.gb_thongtin.Controls.Add(this.rdb_Nu);
            this.gb_thongtin.Controls.Add(this.rdb_Nam);
            this.gb_thongtin.Controls.Add(this.dtp_Ngaysinh);
            this.gb_thongtin.Controls.Add(this.txt_Diachi);
            this.gb_thongtin.Controls.Add(this.label10);
            this.gb_thongtin.Controls.Add(this.btn_Huy);
            this.gb_thongtin.Controls.Add(this.btn_Luu);
            this.gb_thongtin.Controls.Add(this.label8);
            this.gb_thongtin.Controls.Add(this.txt_Email);
            this.gb_thongtin.Controls.Add(this.label7);
            this.gb_thongtin.Controls.Add(this.label6);
            this.gb_thongtin.Controls.Add(this.label5);
            this.gb_thongtin.Controls.Add(this.txt_Tennv);
            this.gb_thongtin.Controls.Add(this.label4);
            this.gb_thongtin.Controls.Add(this.txt_Sdt);
            this.gb_thongtin.Controls.Add(this.label3);
            this.gb_thongtin.Controls.Add(this.txt_Masv);
            this.gb_thongtin.Controls.Add(this.a);
            this.gb_thongtin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_thongtin.Location = new System.Drawing.Point(670, 0);
            this.gb_thongtin.Name = "gb_thongtin";
            this.gb_thongtin.Size = new System.Drawing.Size(280, 600);
            this.gb_thongtin.TabIndex = 1;
            this.gb_thongtin.TabStop = false;
            this.gb_thongtin.Text = "&Thong tin";
            // 
            // cb_Chucvu
            // 
            this.cb_Chucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Chucvu.FormattingEnabled = true;
            this.cb_Chucvu.Items.AddRange(new object[] {
            "Quản lí",
            "Kế toán ",
            "Nhân viên",
            "Thưc tập",
            "Bảo vệ"});
            this.cb_Chucvu.Location = new System.Drawing.Point(97, 317);
            this.cb_Chucvu.Name = "cb_Chucvu";
            this.cb_Chucvu.Size = new System.Drawing.Size(160, 26);
            this.cb_Chucvu.TabIndex = 23;
            // 
            // rdb_Nu
            // 
            this.rdb_Nu.AutoSize = true;
            this.rdb_Nu.Location = new System.Drawing.Point(185, 197);
            this.rdb_Nu.Name = "rdb_Nu";
            this.rdb_Nu.Size = new System.Drawing.Size(45, 20);
            this.rdb_Nu.TabIndex = 22;
            this.rdb_Nu.TabStop = true;
            this.rdb_Nu.Text = "&Nu";
            this.rdb_Nu.UseVisualStyleBackColor = true;
            // 
            // rdb_Nam
            // 
            this.rdb_Nam.AutoSize = true;
            this.rdb_Nam.Location = new System.Drawing.Point(99, 197);
            this.rdb_Nam.Name = "rdb_Nam";
            this.rdb_Nam.Size = new System.Drawing.Size(57, 20);
            this.rdb_Nam.TabIndex = 21;
            this.rdb_Nam.TabStop = true;
            this.rdb_Nam.Text = "&Nam";
            this.rdb_Nam.UseVisualStyleBackColor = true;
            // 
            // dtp_Ngaysinh
            // 
            this.dtp_Ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Ngaysinh.Location = new System.Drawing.Point(97, 153);
            this.dtp_Ngaysinh.Name = "dtp_Ngaysinh";
            this.dtp_Ngaysinh.Size = new System.Drawing.Size(162, 22);
            this.dtp_Ngaysinh.TabIndex = 20;
            // 
            // txt_Diachi
            // 
            this.txt_Diachi.Location = new System.Drawing.Point(99, 373);
            this.txt_Diachi.Multiline = true;
            this.txt_Diachi.Name = "txt_Diachi";
            this.txt_Diachi.Size = new System.Drawing.Size(160, 78);
            this.txt_Diachi.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "&DiaChi";
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(156, 532);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(107, 36);
            this.btn_Huy.TabIndex = 17;
            this.btn_Huy.Text = "&HUY";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(26, 532);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(107, 36);
            this.btn_Luu.TabIndex = 16;
            this.btn_Luu.Text = "&LUU";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "&ChucVu";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(99, 274);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(160, 22);
            this.txt_Email.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "&Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "GioiTinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "NgaySinh";
            // 
            // txt_Tennv
            // 
            this.txt_Tennv.Location = new System.Drawing.Point(99, 114);
            this.txt_Tennv.Name = "txt_Tennv";
            this.txt_Tennv.Size = new System.Drawing.Size(160, 22);
            this.txt_Tennv.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "TenNV";
            // 
            // txt_Sdt
            // 
            this.txt_Sdt.Location = new System.Drawing.Point(99, 234);
            this.txt_Sdt.Name = "txt_Sdt";
            this.txt_Sdt.Size = new System.Drawing.Size(160, 22);
            this.txt_Sdt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "&SDT";
            // 
            // txt_Masv
            // 
            this.txt_Masv.Location = new System.Drawing.Point(97, 74);
            this.txt_Masv.Name = "txt_Masv";
            this.txt_Masv.Size = new System.Drawing.Size(160, 22);
            this.txt_Masv.TabIndex = 1;
            this.txt_Masv.TextChanged += new System.EventHandler(this.txt_Masv_TextChanged);
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(23, 80);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(40, 16);
            this.a.TabIndex = 0;
            this.a.Text = "Masv";
            // 
            // Hienthidanhsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_thongtin);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Name = "Hienthidanhsach";
            this.Size = new System.Drawing.Size(950, 600);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hienthithongtin)).EndInit();
            this.panel4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.gb_chucnang.ResumeLayout(false);
            this.gb_thongtin.ResumeLayout(false);
            this.gb_thongtin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gb_thongtin;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gb_chucnang;
        private System.Windows.Forms.TextBox txt_TKTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TKMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_TImkiem;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_Masv;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Tennv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Sdt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.TextBox txt_Diachi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgv_Hienthithongtin;
        private System.Windows.Forms.DateTimePicker dtp_Ngaysinh;
        private System.Windows.Forms.RadioButton rdb_Nam;
        private System.Windows.Forms.RadioButton rdb_Nu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.ComboBox cb_Chucvu;
    }
}

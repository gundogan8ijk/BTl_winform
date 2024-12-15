namespace QuanLiNhanSu.User_Control
{
    partial class ChamC
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnbochon = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txthienthima = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.textmanv = new System.Windows.Forms.TextBox();
            this.btnxemcong = new System.Windows.Forms.Button();
            this.combbnam = new System.Windows.Forms.ComboBox();
            this.combbthang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dGVchamcong = new System.Windows.Forms.DataGridView();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThangCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongNgayCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.day2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.day3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.day4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.day5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.day6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.day7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.day8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.day9 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.day10 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.day11 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.day12 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVchamcong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 147);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnbochon);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.txthienthima);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.textmanv);
            this.groupBox1.Controls.Add(this.btnxemcong);
            this.groupBox1.Controls.Add(this.combbnam);
            this.groupBox1.Controls.Add(this.combbthang);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "&Chuc nang";
            // 
            // btnbochon
            // 
            this.btnbochon.Location = new System.Drawing.Point(525, 97);
            this.btnbochon.Name = "btnbochon";
            this.btnbochon.Size = new System.Drawing.Size(97, 23);
            this.btnbochon.TabIndex = 20;
            this.btnbochon.Text = "Bỏ Chọn";
            this.btnbochon.UseVisualStyleBackColor = true;
            this.btnbochon.Visible = false;
            this.btnbochon.Click += new System.EventHandler(this.btnbochon_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(464, 96);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(55, 24);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Visible = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(384, 96);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(62, 24);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txthienthima
            // 
            this.txthienthima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthienthima.Location = new System.Drawing.Point(259, 35);
            this.txthienthima.Name = "txthienthima";
            this.txthienthima.ReadOnly = true;
            this.txthienthima.Size = new System.Drawing.Size(89, 30);
            this.txthienthima.TabIndex = 17;
            // 
            // btnTim
            // 
            this.btnTim.Enabled = false;
            this.btnTim.Location = new System.Drawing.Point(382, 38);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(64, 23);
            this.btnTim.TabIndex = 16;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // textmanv
            // 
            this.textmanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textmanv.Location = new System.Drawing.Point(464, 33);
            this.textmanv.Name = "textmanv";
            this.textmanv.Size = new System.Drawing.Size(89, 30);
            this.textmanv.TabIndex = 12;
            this.textmanv.TextChanged += new System.EventHandler(this.textmanv_TextChanged_1);
            // 
            // btnxemcong
            // 
            this.btnxemcong.Enabled = false;
            this.btnxemcong.Location = new System.Drawing.Point(259, 90);
            this.btnxemcong.Name = "btnxemcong";
            this.btnxemcong.Size = new System.Drawing.Size(84, 29);
            this.btnxemcong.TabIndex = 11;
            this.btnxemcong.Text = "Xem";
            this.btnxemcong.UseVisualStyleBackColor = true;
            this.btnxemcong.Click += new System.EventHandler(this.btnxemcong_Click);
            // 
            // combbnam
            // 
            this.combbnam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combbnam.FormattingEnabled = true;
            this.combbnam.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024"});
            this.combbnam.Location = new System.Drawing.Point(113, 90);
            this.combbnam.Name = "combbnam";
            this.combbnam.Size = new System.Drawing.Size(121, 28);
            this.combbnam.TabIndex = 10;
            this.combbnam.SelectedIndexChanged += new System.EventHandler(this.combbnam_SelectedIndexChanged);
            // 
            // combbthang
            // 
            this.combbthang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combbthang.FormattingEnabled = true;
            this.combbthang.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.combbthang.Location = new System.Drawing.Point(113, 35);
            this.combbthang.Name = "combbthang";
            this.combbthang.Size = new System.Drawing.Size(121, 28);
            this.combbthang.TabIndex = 9;
            this.combbthang.SelectedIndexChanged += new System.EventHandler(this.combbthang_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Năm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tháng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 453);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dGVchamcong);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(900, 453);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "&Bang cham cong";
            // 
            // dGVchamcong
            // 
            this.dGVchamcong.AllowUserToAddRows = false;
            this.dGVchamcong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVchamcong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenNV,
            this.Column1,
            this.ThangCong,
            this.TongNgayCong,
            this.day1,
            this.day2,
            this.day3,
            this.day4,
            this.day5,
            this.day6,
            this.day7,
            this.day8,
            this.day9,
            this.day10,
            this.day11,
            this.day12});
            this.dGVchamcong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVchamcong.Location = new System.Drawing.Point(3, 18);
            this.dGVchamcong.Name = "dGVchamcong";
            this.dGVchamcong.RowHeadersWidth = 51;
            this.dGVchamcong.RowTemplate.Height = 24;
            this.dGVchamcong.Size = new System.Drawing.Size(894, 432);
            this.dGVchamcong.TabIndex = 3;
            this.dGVchamcong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVchamcong_CellClick);
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "MaNV";
            this.TenNV.HeaderText = "Mã NV";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            this.TenNV.Width = 83;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TenNV";
            this.Column1.HeaderText = "Tên NV";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // ThangCong
            // 
            this.ThangCong.DataPropertyName = "ThangTC";
            this.ThangCong.FillWeight = 66.16754F;
            this.ThangCong.HeaderText = "Tháng";
            this.ThangCong.MinimumWidth = 6;
            this.ThangCong.Name = "ThangCong";
            this.ThangCong.ReadOnly = true;
            this.ThangCong.Width = 50;
            // 
            // TongNgayCong
            // 
            this.TongNgayCong.DataPropertyName = "TongNgayCong";
            this.TongNgayCong.FillWeight = 66.16754F;
            this.TongNgayCong.HeaderText = "Số Ngày";
            this.TongNgayCong.MinimumWidth = 6;
            this.TongNgayCong.Name = "TongNgayCong";
            this.TongNgayCong.ReadOnly = true;
            this.TongNgayCong.Width = 54;
            // 
            // day1
            // 
            this.day1.DataPropertyName = "Day1";
            this.day1.HeaderText = "DAY1";
            this.day1.MinimumWidth = 6;
            this.day1.Name = "day1";
            this.day1.ReadOnly = true;
            this.day1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.day1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.day1.Width = 50;
            // 
            // day2
            // 
            this.day2.DataPropertyName = "Day2";
            this.day2.FillWeight = 66.16754F;
            this.day2.HeaderText = "DAY2";
            this.day2.MinimumWidth = 6;
            this.day2.Name = "day2";
            this.day2.ReadOnly = true;
            this.day2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.day2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.day2.Width = 55;
            // 
            // day3
            // 
            this.day3.DataPropertyName = "Day3";
            this.day3.FillWeight = 66.16754F;
            this.day3.HeaderText = "DAY3";
            this.day3.MinimumWidth = 6;
            this.day3.Name = "day3";
            this.day3.ReadOnly = true;
            this.day3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.day3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.day3.Width = 54;
            // 
            // day4
            // 
            this.day4.DataPropertyName = "Day4";
            this.day4.FillWeight = 66.16754F;
            this.day4.HeaderText = "DAY4";
            this.day4.MinimumWidth = 6;
            this.day4.Name = "day4";
            this.day4.ReadOnly = true;
            this.day4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.day4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.day4.Width = 55;
            // 
            // day5
            // 
            this.day5.DataPropertyName = "Day5";
            this.day5.FillWeight = 66.16754F;
            this.day5.HeaderText = "DAY5";
            this.day5.MinimumWidth = 6;
            this.day5.Name = "day5";
            this.day5.ReadOnly = true;
            this.day5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.day5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.day5.Width = 54;
            // 
            // day6
            // 
            this.day6.DataPropertyName = "Day6";
            this.day6.FillWeight = 66.16754F;
            this.day6.HeaderText = "DAY6";
            this.day6.MinimumWidth = 6;
            this.day6.Name = "day6";
            this.day6.ReadOnly = true;
            this.day6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.day6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.day6.Width = 55;
            // 
            // day7
            // 
            this.day7.DataPropertyName = "Day7";
            this.day7.FillWeight = 66.16754F;
            this.day7.HeaderText = "DAY7";
            this.day7.MinimumWidth = 6;
            this.day7.Name = "day7";
            this.day7.ReadOnly = true;
            this.day7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.day7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.day7.Width = 54;
            // 
            // day8
            // 
            this.day8.DataPropertyName = "Day8";
            this.day8.FillWeight = 66.16754F;
            this.day8.HeaderText = "DAY8";
            this.day8.MinimumWidth = 6;
            this.day8.Name = "day8";
            this.day8.ReadOnly = true;
            this.day8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.day8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.day8.Width = 55;
            // 
            // day9
            // 
            this.day9.DataPropertyName = "Day9";
            this.day9.FillWeight = 66.16754F;
            this.day9.HeaderText = "DAY9";
            this.day9.MinimumWidth = 6;
            this.day9.Name = "day9";
            this.day9.ReadOnly = true;
            this.day9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.day9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.day9.Width = 54;
            // 
            // day10
            // 
            this.day10.DataPropertyName = "Day10";
            this.day10.FillWeight = 66.16754F;
            this.day10.HeaderText = "DAY10";
            this.day10.MinimumWidth = 6;
            this.day10.Name = "day10";
            this.day10.ReadOnly = true;
            this.day10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.day10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.day10.Width = 48;
            // 
            // day11
            // 
            this.day11.DataPropertyName = "Day11";
            this.day11.FillWeight = 66.16754F;
            this.day11.HeaderText = "DAY11";
            this.day11.MinimumWidth = 6;
            this.day11.Name = "day11";
            this.day11.ReadOnly = true;
            this.day11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.day11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.day11.Width = 56;
            // 
            // day12
            // 
            this.day12.DataPropertyName = "Day12";
            this.day12.FillWeight = 66.16754F;
            this.day12.HeaderText = "DAY12";
            this.day12.MinimumWidth = 6;
            this.day12.Name = "day12";
            this.day12.ReadOnly = true;
            this.day12.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.day12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.day12.Width = 55;
            // 
            // ChamC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ChamC";
            this.Size = new System.Drawing.Size(900, 600);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVchamcong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textmanv;
        private System.Windows.Forms.Button btnxemcong;
        private System.Windows.Forms.ComboBox combbnam;
        private System.Windows.Forms.ComboBox combbthang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dGVchamcong;
        private System.Windows.Forms.TextBox txthienthima;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThangCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongNgayCong;
        private System.Windows.Forms.DataGridViewCheckBoxColumn day1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn day2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn day3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn day4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn day5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn day6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn day7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn day8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn day9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn day10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn day11;
        private System.Windows.Forms.DataGridViewCheckBoxColumn day12;
        private System.Windows.Forms.Button btnbochon;
    }
}

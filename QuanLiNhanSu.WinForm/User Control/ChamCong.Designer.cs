namespace QuanLiNhanSu.User_Control
{
    partial class ChamCong
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dGVchamcong = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThangCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongNgayCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combbthang = new System.Windows.Forms.ComboBox();
            this.combbnam = new System.Windows.Forms.ComboBox();
            this.btnxemcong = new System.Windows.Forms.Button();
            this.textmanv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVchamcong)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dGVchamcong);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1009, 483);
            this.panel3.TabIndex = 1;
            // 
            // dGVchamcong
            // 
            this.dGVchamcong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVchamcong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVchamcong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.ThangCong,
            this.TongNgayCong,
            this.day1,
            this.day2,
            this.day3,
            this.day4,
            this.day5,
            this.day6,
            this.day7,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dGVchamcong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVchamcong.Location = new System.Drawing.Point(0, 69);
            this.dGVchamcong.Name = "dGVchamcong";
            this.dGVchamcong.RowHeadersWidth = 51;
            this.dGVchamcong.RowTemplate.Height = 24;
            this.dGVchamcong.Size = new System.Drawing.Size(1009, 414);
            this.dGVchamcong.TabIndex = 2;
            this.dGVchamcong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVchamcong_CellContentClick_1);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.FillWeight = 66.16754F;
            this.MaNV.HeaderText = "MaNV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên NV";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            // 
            // ThangCong
            // 
            this.ThangCong.DataPropertyName = "thang";
            this.ThangCong.FillWeight = 66.16754F;
            this.ThangCong.HeaderText = "Tháng";
            this.ThangCong.MinimumWidth = 6;
            this.ThangCong.Name = "ThangCong";
            // 
            // TongNgayCong
            // 
            this.TongNgayCong.DataPropertyName = "TongNgayCong";
            this.TongNgayCong.FillWeight = 66.16754F;
            this.TongNgayCong.HeaderText = "Số Ngày";
            this.TongNgayCong.MinimumWidth = 6;
            this.TongNgayCong.Name = "TongNgayCong";
            // 
            // day1
            // 
            this.day1.DataPropertyName = "Day1";
            this.day1.FillWeight = 66.16754F;
            this.day1.HeaderText = "DAY1";
            this.day1.MinimumWidth = 6;
            this.day1.Name = "day1";
            // 
            // day2
            // 
            this.day2.DataPropertyName = "Day2";
            this.day2.FillWeight = 66.16754F;
            this.day2.HeaderText = "DAY2";
            this.day2.MinimumWidth = 6;
            this.day2.Name = "day2";
            // 
            // day3
            // 
            this.day3.DataPropertyName = "Day3";
            this.day3.FillWeight = 66.16754F;
            this.day3.HeaderText = "DAY3";
            this.day3.MinimumWidth = 6;
            this.day3.Name = "day3";
            // 
            // day4
            // 
            this.day4.DataPropertyName = "Day4";
            this.day4.FillWeight = 66.16754F;
            this.day4.HeaderText = "DAY4";
            this.day4.MinimumWidth = 6;
            this.day4.Name = "day4";
            // 
            // day5
            // 
            this.day5.DataPropertyName = "Day5";
            this.day5.FillWeight = 66.16754F;
            this.day5.HeaderText = "DAY5";
            this.day5.MinimumWidth = 6;
            this.day5.Name = "day5";
            // 
            // day6
            // 
            this.day6.DataPropertyName = "Day6";
            this.day6.FillWeight = 66.16754F;
            this.day6.HeaderText = "DAY6";
            this.day6.MinimumWidth = 6;
            this.day6.Name = "day6";
            // 
            // day7
            // 
            this.day7.DataPropertyName = "Day7";
            this.day7.FillWeight = 66.16754F;
            this.day7.HeaderText = "DAY7";
            this.day7.MinimumWidth = 6;
            this.day7.Name = "day7";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Day8";
            this.Column2.FillWeight = 66.16754F;
            this.Column2.HeaderText = "DAY8";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Day9";
            this.Column3.FillWeight = 66.16754F;
            this.Column3.HeaderText = "DAY9";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Day10";
            this.Column4.FillWeight = 66.16754F;
            this.Column4.HeaderText = "DAY10";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Day11";
            this.Column5.FillWeight = 66.16754F;
            this.Column5.HeaderText = "DAY11";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Day12";
            this.Column6.FillWeight = 66.16754F;
            this.Column6.HeaderText = "DAY12";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textmanv);
            this.panel2.Controls.Add(this.btnxemcong);
            this.panel2.Controls.Add(this.combbnam);
            this.panel2.Controls.Add(this.combbthang);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1009, 69);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tháng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Năm";
            // 
            // combbthang
            // 
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
            this.combbthang.Location = new System.Drawing.Point(107, 24);
            this.combbthang.Name = "combbthang";
            this.combbthang.Size = new System.Drawing.Size(121, 24);
            this.combbthang.TabIndex = 2;
            this.combbthang.SelectedIndexChanged += new System.EventHandler(this.combbthang_SelectedIndexChanged);
            // 
            // combbnam
            // 
            this.combbnam.FormattingEnabled = true;
            this.combbnam.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024"});
            this.combbnam.Location = new System.Drawing.Point(343, 24);
            this.combbnam.Name = "combbnam";
            this.combbnam.Size = new System.Drawing.Size(121, 24);
            this.combbnam.TabIndex = 3;
            this.combbnam.SelectedIndexChanged += new System.EventHandler(this.combbnam_SelectedIndexChanged);
            // 
            // btnxemcong
            // 
            this.btnxemcong.Enabled = false;
            this.btnxemcong.Location = new System.Drawing.Point(534, 25);
            this.btnxemcong.Name = "btnxemcong";
            this.btnxemcong.Size = new System.Drawing.Size(75, 23);
            this.btnxemcong.TabIndex = 4;
            this.btnxemcong.Text = "Xem";
            this.btnxemcong.UseVisualStyleBackColor = true;
            this.btnxemcong.Click += new System.EventHandler(this.btnxemcong_Click);
            // 
            // textmanv
            // 
            this.textmanv.Location = new System.Drawing.Point(850, 29);
            this.textmanv.Name = "textmanv";
            this.textmanv.Size = new System.Drawing.Size(100, 22);
            this.textmanv.TabIndex = 5;
            this.textmanv.TextChanged += new System.EventHandler(this.textmanv_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(796, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã NV";
            // 
            // ChamCong
            // 
            this.ClientSize = new System.Drawing.Size(1009, 483);
            this.Controls.Add(this.panel3);
            this.Name = "ChamCong";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVchamcong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBBThang;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dGVchamcong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThangCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongNgayCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn day1;
        private System.Windows.Forms.DataGridViewTextBoxColumn day2;
        private System.Windows.Forms.DataGridViewTextBoxColumn day3;
        private System.Windows.Forms.DataGridViewTextBoxColumn day4;
        private System.Windows.Forms.DataGridViewTextBoxColumn day5;
        private System.Windows.Forms.DataGridViewTextBoxColumn day6;
        private System.Windows.Forms.DataGridViewTextBoxColumn day7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textmanv;
        private System.Windows.Forms.Button btnxemcong;
        private System.Windows.Forms.ComboBox combbnam;
        private System.Windows.Forms.ComboBox combbthang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
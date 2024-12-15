namespace QuanLiNhanSu
{
    partial class Xuatds
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
            this.btn_Xuatds = new System.Windows.Forms.Button();
            this.txt_FilePath = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_Hienthi = new System.Windows.Forms.DataGridView();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hienthi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 127);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Xuatds);
            this.groupBox1.Controls.Add(this.txt_FilePath);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "&Xuat danh sach";
            // 
            // btn_Xuatds
            // 
            this.btn_Xuatds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xuatds.Location = new System.Drawing.Point(649, 53);
            this.btn_Xuatds.Name = "btn_Xuatds";
            this.btn_Xuatds.Size = new System.Drawing.Size(135, 34);
            this.btn_Xuatds.TabIndex = 1;
            this.btn_Xuatds.Text = "&Xuat Và Luu";
            this.btn_Xuatds.UseVisualStyleBackColor = true;
            this.btn_Xuatds.Click += new System.EventHandler(this.btn_Xuatds_Click);
            // 
            // txt_FilePath
            // 
            this.txt_FilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FilePath.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_FilePath.Location = new System.Drawing.Point(59, 53);
            this.txt_FilePath.Name = "txt_FilePath";
            this.txt_FilePath.Size = new System.Drawing.Size(533, 30);
            this.txt_FilePath.TabIndex = 0;
            this.txt_FilePath.Text = "Đường dẫn lưu file";
            this.txt_FilePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 431);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_Hienthi);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(900, 431);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "&Hien thi danh sach";
            // 
            // dgv_Hienthi
            // 
            this.dgv_Hienthi.AllowUserToAddRows = false;
            this.dgv_Hienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Hienthi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Hienthi.Location = new System.Drawing.Point(3, 18);
            this.dgv_Hienthi.Name = "dgv_Hienthi";
            this.dgv_Hienthi.RowHeadersWidth = 51;
            this.dgv_Hienthi.RowTemplate.Height = 24;
            this.dgv_Hienthi.Size = new System.Drawing.Size(894, 410);
            this.dgv_Hienthi.TabIndex = 0;
            this.dgv_Hienthi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Hienthi_CellContentClick);
            // 
            // Xuatds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Xuatds";
            this.Size = new System.Drawing.Size(900, 558);
            this.Load += new System.EventHandler(this.Xuatds_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hienthi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_Hienthi;
        private System.Windows.Forms.Button btn_Xuatds;
        private System.Windows.Forms.TextBox txt_FilePath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

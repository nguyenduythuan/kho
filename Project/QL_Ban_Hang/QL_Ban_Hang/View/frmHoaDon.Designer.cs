namespace QL_Ban_Hang.View
{
    partial class frmHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.acv = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.ll = new System.Windows.Forms.Label();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.acb = new System.Windows.Forms.Label();
            this.nv = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbNhanVien = new System.Windows.Forms.ComboBox();
            this.cbKH = new System.Windows.Forms.ComboBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSHD = new System.Windows.Forms.DataGridView();
            this.st = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btTao = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btBot = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbHH = new System.Windows.Forms.ComboBox();
            this.lbThanhTien = new System.Windows.Forms.LinkLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // acv
            // 
            this.acv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.acv.AutoSize = true;
            this.acv.Location = new System.Drawing.Point(37, 45);
            this.acv.Name = "acv";
            this.acv.Size = new System.Drawing.Size(85, 17);
            this.acv.TabIndex = 0;
            this.acv.Text = "Mã hóa đơn";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaHD.Location = new System.Drawing.Point(128, 42);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(147, 25);
            this.txtMaHD.TabIndex = 1;
            this.txtMaHD.TextChanged += new System.EventHandler(this.txtMaHD_TextChanged);
            // 
            // ll
            // 
            this.ll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ll.AutoSize = true;
            this.ll.Location = new System.Drawing.Point(46, 100);
            this.ll.Name = "ll";
            this.ll.Size = new System.Drawing.Size(64, 17);
            this.ll.TabIndex = 2;
            this.ll.Text = "Ngày lập";
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNgayLap.Location = new System.Drawing.Point(128, 97);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(147, 25);
            this.txtNgayLap.TabIndex = 3;
            // 
            // acb
            // 
            this.acb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.acb.AutoSize = true;
            this.acb.Location = new System.Drawing.Point(297, 45);
            this.acb.Name = "acb";
            this.acb.Size = new System.Drawing.Size(85, 17);
            this.acb.TabIndex = 4;
            this.acb.Text = "Khách hàng";
            // 
            // nv
            // 
            this.nv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nv.AutoSize = true;
            this.nv.Location = new System.Drawing.Point(308, 95);
            this.nv.Name = "nv";
            this.nv.Size = new System.Drawing.Size(74, 17);
            this.nv.TabIndex = 6;
            this.nv.Text = "Nhân viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNhanVien);
            this.groupBox1.Controls.Add(this.cbKH);
            this.groupBox1.Controls.Add(this.nv);
            this.groupBox1.Controls.Add(this.acb);
            this.groupBox1.Controls.Add(this.txtNgayLap);
            this.groupBox1.Controls.Add(this.ll);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.acv);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // cbNhanVien
            // 
            this.cbNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbNhanVien.FormattingEnabled = true;
            this.cbNhanVien.Location = new System.Drawing.Point(386, 92);
            this.cbNhanVien.Name = "cbNhanVien";
            this.cbNhanVien.Size = new System.Drawing.Size(178, 25);
            this.cbNhanVien.TabIndex = 10;
            // 
            // cbKH
            // 
            this.cbKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbKH.FormattingEnabled = true;
            this.cbKH.Location = new System.Drawing.Point(386, 42);
            this.cbKH.Name = "cbKH";
            this.cbKH.Size = new System.Drawing.Size(178, 25);
            this.cbKH.TabIndex = 9;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.Location = new System.Drawing.Point(3, 21);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(609, 222);
            this.dgvHoaDon.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvDSHD);
            this.groupBox2.Controls.Add(this.dgvHoaDon);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(12, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(615, 246);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hóa đơn";
            // 
            // dgvDSHD
            // 
            this.dgvDSHD.AllowUserToAddRows = false;
            this.dgvDSHD.AllowUserToDeleteRows = false;
            this.dgvDSHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSHD.BackgroundColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.st,
            this.M,
            this.ngay,
            this.kh,
            this.nvien});
            this.dgvDSHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSHD.GridColor = System.Drawing.Color.Chartreuse;
            this.dgvDSHD.Location = new System.Drawing.Point(3, 21);
            this.dgvDSHD.Name = "dgvDSHD";
            this.dgvDSHD.ReadOnly = true;
            this.dgvDSHD.RowHeadersVisible = false;
            this.dgvDSHD.Size = new System.Drawing.Size(609, 222);
            this.dgvDSHD.TabIndex = 1;
            this.dgvDSHD.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHD_RowEnter);
            this.dgvDSHD.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvDSHD_RowsAdded);
            // 
            // st
            // 
            this.st.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.st.HeaderText = "STT";
            this.st.Name = "st";
            this.st.ReadOnly = true;
            this.st.Width = 50;
            // 
            // M
            // 
            this.M.DataPropertyName = "MaHD";
            this.M.HeaderText = "Mã hóa dơn";
            this.M.Name = "M";
            this.M.ReadOnly = true;
            // 
            // ngay
            // 
            this.ngay.DataPropertyName = "NgayLap";
            this.ngay.HeaderText = "Ngày lập";
            this.ngay.Name = "ngay";
            this.ngay.ReadOnly = true;
            // 
            // kh
            // 
            this.kh.DataPropertyName = "TenKH";
            this.kh.HeaderText = "Khách hàng";
            this.kh.Name = "kh";
            this.kh.ReadOnly = true;
            // 
            // nvien
            // 
            this.nvien.DataPropertyName = "TenNV";
            this.nvien.HeaderText = "Nhân viên";
            this.nvien.Name = "nvien";
            this.nvien.ReadOnly = true;
            // 
            // btTao
            // 
            this.btTao.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTao.ForeColor = System.Drawing.Color.Red;
            this.btTao.Location = new System.Drawing.Point(110, 180);
            this.btTao.Name = "btTao";
            this.btTao.Size = new System.Drawing.Size(87, 41);
            this.btTao.TabIndex = 2;
            this.btTao.Text = "Tạo mới một hóa đơn";
            this.btTao.UseVisualStyleBackColor = true;
            this.btTao.Click += new System.EventHandler(this.btTao_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.Red;
            this.btXoa.Location = new System.Drawing.Point(225, 180);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 41);
            this.btXoa.TabIndex = 3;
            this.btXoa.Text = "Xóa hóa đơn";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btHuy
            // 
            this.btHuy.Enabled = false;
            this.btHuy.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.ForeColor = System.Drawing.Color.Red;
            this.btHuy.Location = new System.Drawing.Point(549, 180);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(75, 41);
            this.btHuy.TabIndex = 21;
            this.btHuy.Text = "Hủy thao tác";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btLuu
            // 
            this.btLuu.Enabled = false;
            this.btLuu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.ForeColor = System.Drawing.Color.Red;
            this.btLuu.Location = new System.Drawing.Point(430, 180);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 41);
            this.btLuu.TabIndex = 20;
            this.btLuu.Text = "Lưu hóa đơn\r\n";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvChiTiet);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Location = new System.Drawing.Point(5, 238);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(575, 246);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dánh sách hàng hóa";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AllowUserToAddRows = false;
            this.dgvChiTiet.AllowUserToDeleteRows = false;
            this.dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTiet.BackgroundColor = System.Drawing.Color.Aqua;
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTiet.GridColor = System.Drawing.Color.Chartreuse;
            this.dgvChiTiet.Location = new System.Drawing.Point(3, 21);
            this.dgvChiTiet.MultiSelect = false;
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.ReadOnly = true;
            this.dgvChiTiet.RowHeadersVisible = false;
            this.dgvChiTiet.Size = new System.Drawing.Size(569, 222);
            this.dgvChiTiet.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hàng hóa";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSoLuong.Location = new System.Drawing.Point(413, 89);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(72, 25);
            this.txtSoLuong.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Đơn giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDonGia.Location = new System.Drawing.Point(165, 92);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(120, 25);
            this.txtDonGia.TabIndex = 15;
            // 
            // btThem
            // 
            this.btThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.Red;
            this.btThem.Location = new System.Drawing.Point(107, 185);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 41);
            this.btThem.TabIndex = 18;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btBot
            // 
            this.btBot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btBot.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBot.ForeColor = System.Drawing.Color.Red;
            this.btBot.Location = new System.Drawing.Point(216, 185);
            this.btBot.Name = "btBot";
            this.btBot.Size = new System.Drawing.Size(75, 41);
            this.btBot.TabIndex = 19;
            this.btBot.Text = "Bớt";
            this.btBot.UseVisualStyleBackColor = true;
            this.btBot.Click += new System.EventHandler(this.btBot_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "(VNĐ)";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Thành tiền :";
            // 
            // cbHH
            // 
            this.cbHH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbHH.FormattingEnabled = true;
            this.cbHH.Location = new System.Drawing.Point(165, 50);
            this.cbHH.Name = "cbHH";
            this.cbHH.Size = new System.Drawing.Size(320, 25);
            this.cbHH.TabIndex = 24;
            // 
            // lbThanhTien
            // 
            this.lbThanhTien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbThanhTien.AutoSize = true;
            this.lbThanhTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanhTien.ForeColor = System.Drawing.Color.Blue;
            this.lbThanhTien.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbThanhTien.LinkColor = System.Drawing.SystemColors.MenuText;
            this.lbThanhTien.Location = new System.Drawing.Point(197, 141);
            this.lbThanhTien.Name = "lbThanhTien";
            this.lbThanhTien.Size = new System.Drawing.Size(21, 19);
            this.lbThanhTien.TabIndex = 25;
            this.lbThanhTien.TabStop = true;
            this.lbThanhTien.Text = "0 ";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lbThanhTien);
            this.groupBox3.Controls.Add(this.cbHH);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btBot);
            this.groupBox3.Controls.Add(this.btThem);
            this.groupBox3.Controls.Add(this.txtDonGia);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtSoLuong);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(633, 1);
            this.groupBox3.MinimumSize = new System.Drawing.Size(580, 473);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(580, 473);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết hóa đơn";
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1214, 486);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btTao);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MinimumSize = new System.Drawing.Size(1230, 525);
            this.Name = "frmHoaDon";
            this.Text = "Thông tin hóa đơn";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label acv;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label ll;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.Label acb;
        private System.Windows.Forms.Label nv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDSHD;
        private System.Windows.Forms.Button btTao;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.ComboBox cbKH;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btBot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbHH;
        private System.Windows.Forms.LinkLabel lbThanhTien;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn st;
        private System.Windows.Forms.DataGridViewTextBoxColumn M;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn kh;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvien;
    }
}
namespace QL_Ban_Hang.View
{
    partial class frmHangHoa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Gia = new System.Windows.Forms.Label();
            this.txtGiaHangHoa = new System.Windows.Forms.TextBox();
            this.SoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.TenHangHoa = new System.Windows.Forms.Label();
            this.txtTenHangHoa = new System.Windows.Forms.TextBox();
            this.MaHangHoa = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtMaHangHoa = new System.Windows.Forms.TextBox();
            this.dtgvDS2 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDS2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gia
            // 
            this.Gia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Gia.AutoSize = true;
            this.Gia.Location = new System.Drawing.Point(258, 152);
            this.Gia.Name = "Gia";
            this.Gia.Size = new System.Drawing.Size(92, 17);
            this.Gia.TabIndex = 11;
            this.Gia.Text = "Giá hàng hóa";
            // 
            // txtGiaHangHoa
            // 
            this.txtGiaHangHoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGiaHangHoa.Enabled = false;
            this.txtGiaHangHoa.Location = new System.Drawing.Point(356, 149);
            this.txtGiaHangHoa.Name = "txtGiaHangHoa";
            this.txtGiaHangHoa.Size = new System.Drawing.Size(190, 25);
            this.txtGiaHangHoa.TabIndex = 10;
            this.txtGiaHangHoa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaHangHoa_KeyPress);
            // 
            // SoLuong
            // 
            this.SoLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SoLuong.AutoSize = true;
            this.SoLuong.Location = new System.Drawing.Point(273, 111);
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Size = new System.Drawing.Size(65, 17);
            this.SoLuong.TabIndex = 9;
            this.SoLuong.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Location = new System.Drawing.Point(356, 108);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(250, 25);
            this.txtSoLuong.TabIndex = 8;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(352, 231);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 36);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Red;
            this.btnThem.Location = new System.Drawing.Point(219, 231);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 36);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // TenHangHoa
            // 
            this.TenHangHoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TenHangHoa.AutoSize = true;
            this.TenHangHoa.Location = new System.Drawing.Point(259, 68);
            this.TenHangHoa.Name = "TenHangHoa";
            this.TenHangHoa.Size = new System.Drawing.Size(96, 17);
            this.TenHangHoa.TabIndex = 5;
            this.TenHangHoa.Text = "Tên hàng hóa";
            // 
            // txtTenHangHoa
            // 
            this.txtTenHangHoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenHangHoa.Enabled = false;
            this.txtTenHangHoa.Location = new System.Drawing.Point(357, 65);
            this.txtTenHangHoa.Name = "txtTenHangHoa";
            this.txtTenHangHoa.Size = new System.Drawing.Size(249, 25);
            this.txtTenHangHoa.TabIndex = 4;
            // 
            // MaHangHoa
            // 
            this.MaHangHoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MaHangHoa.AutoSize = true;
            this.MaHangHoa.Location = new System.Drawing.Point(259, 27);
            this.MaHangHoa.Name = "MaHangHoa";
            this.MaHangHoa.Size = new System.Drawing.Size(92, 17);
            this.MaHangHoa.TabIndex = 1;
            this.MaHangHoa.Text = "Mã hàng hóa";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.Enabled = false;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Red;
            this.btnHuy.Location = new System.Drawing.Point(587, 231);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 36);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtMaHangHoa
            // 
            this.txtMaHangHoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaHangHoa.Enabled = false;
            this.txtMaHangHoa.Location = new System.Drawing.Point(357, 24);
            this.txtMaHangHoa.Name = "txtMaHangHoa";
            this.txtMaHangHoa.Size = new System.Drawing.Size(249, 25);
            this.txtMaHangHoa.TabIndex = 0;
            // 
            // dtgvDS2
            // 
            this.dtgvDS2.AllowUserToAddRows = false;
            this.dtgvDS2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDS2.BackgroundColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDS2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDS2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDS2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaHH,
            this.TenHH,
            this.G,
            this.SL});
            this.dtgvDS2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDS2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dtgvDS2.Location = new System.Drawing.Point(3, 21);
            this.dtgvDS2.MultiSelect = false;
            this.dtgvDS2.Name = "dtgvDS2";
            this.dtgvDS2.ReadOnly = true;
            this.dtgvDS2.RowHeadersVisible = false;
            this.dtgvDS2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDS2.Size = new System.Drawing.Size(858, 188);
            this.dtgvDS2.TabIndex = 0;
            this.dtgvDS2.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDS2_RowEnter);
            this.dtgvDS2.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtgvDS2_RowsAdded);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.STT.DefaultCellStyle = dataGridViewCellStyle2;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 90;
            // 
            // MaHH
            // 
            this.MaHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHH.DataPropertyName = "MaHH";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MaHH.DefaultCellStyle = dataGridViewCellStyle3;
            this.MaHH.HeaderText = "Mã hàng";
            this.MaHH.Name = "MaHH";
            this.MaHH.ReadOnly = true;
            // 
            // TenHH
            // 
            this.TenHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TenHH.DataPropertyName = "TenHH";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TenHH.DefaultCellStyle = dataGridViewCellStyle4;
            this.TenHH.HeaderText = "Tên hàng hóa";
            this.TenHH.Name = "TenHH";
            this.TenHH.ReadOnly = true;
            this.TenHH.Width = 210;
            // 
            // G
            // 
            this.G.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.G.DataPropertyName = "DonGia";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.G.DefaultCellStyle = dataGridViewCellStyle5;
            this.G.HeaderText = "Giá";
            this.G.Name = "G";
            this.G.ReadOnly = true;
            // 
            // SL
            // 
            this.SL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SL.DataPropertyName = "SoLuong";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.SL.DefaultCellStyle = dataGridViewCellStyle6;
            this.SL.HeaderText = "Số lượng";
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.Enabled = false;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Red;
            this.btnLuu.Location = new System.Drawing.Point(481, 231);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 36);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtgvDS2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(5, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(864, 212);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hàng hóa";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Gia);
            this.groupBox1.Controls.Add(this.txtGiaHangHoa);
            this.groupBox1.Controls.Add(this.SoLuong);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.TenHangHoa);
            this.groupBox1.Controls.Add(this.txtTenHangHoa);
            this.groupBox1.Controls.Add(this.MaHangHoa);
            this.groupBox1.Controls.Add(this.txtMaHangHoa);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(13, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(864, 198);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hàng hóa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "(VNĐ)";
            // 
            // frmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(888, 486);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(904, 525);
            this.Name = "frmHangHoa";
            this.Text = "Quản lý hàng hóa";
            this.Load += new System.EventHandler(this.frmHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDS2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Gia;
        private System.Windows.Forms.TextBox txtGiaHangHoa;
        private System.Windows.Forms.Label SoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label TenHangHoa;
        private System.Windows.Forms.TextBox txtTenHangHoa;
        private System.Windows.Forms.Label MaHangHoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtMaHangHoa;
        private System.Windows.Forms.DataGridView dtgvDS2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn G;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.Label label1;
    }
}
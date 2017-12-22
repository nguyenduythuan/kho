namespace QL_Ban_Hang.View
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkMK = new System.Windows.Forms.CheckBox();
            this.lMa = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(348, 59);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(222, 26);
            this.txtTen.TabIndex = 0;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(348, 107);
            this.txtMK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(222, 26);
            this.txtMK.TabIndex = 1;
            this.txtMK.UseSystemPasswordChar = true;
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(348, 187);
            this.btThoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(108, 31);
            this.btThoat.TabIndex = 2;
            this.btThoat.Text = "Cancel";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btDangNhap
            // 
            this.btDangNhap.Location = new System.Drawing.Point(480, 187);
            this.btDangNhap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(115, 31);
            this.btDangNhap.TabIndex = 3;
            this.btDangNhap.Text = "Login";
            this.btDangNhap.UseVisualStyleBackColor = true;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "User Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(371, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "LOGIN\r\n";
            // 
            // checkMK
            // 
            this.checkMK.AutoSize = true;
            this.checkMK.Location = new System.Drawing.Point(251, 149);
            this.checkMK.Name = "checkMK";
            this.checkMK.Size = new System.Drawing.Size(129, 23);
            this.checkMK.TabIndex = 8;
            this.checkMK.Text = "Show password";
            this.checkMK.UseVisualStyleBackColor = true;
            this.checkMK.CheckedChanged += new System.EventHandler(this.checkMK_CheckedChanged);
            // 
            // lMa
            // 
            this.lMa.AutoSize = true;
            this.lMa.LinkColor = System.Drawing.Color.Cyan;
            this.lMa.Location = new System.Drawing.Point(212, 222);
            this.lMa.Name = "lMa";
            this.lMa.Size = new System.Drawing.Size(80, 19);
            this.lMa.TabIndex = 9;
            this.lMa.TabStop = true;
            this.lMa.Text = "linkLabel1";
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(608, 247);
            this.Controls.Add(this.lMa);
            this.Controls.Add(this.checkMK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btDangNhap);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTen);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(624, 286);
            this.MinimumSize = new System.Drawing.Size(624, 286);
            this.Name = "frmDangNhap";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkMK;
        private System.Windows.Forms.LinkLabel lMa;
    }
}
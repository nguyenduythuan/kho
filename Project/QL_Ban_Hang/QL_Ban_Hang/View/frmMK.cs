using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_Ban_Hang.Object;
using QL_Ban_Hang.Control;
using QL_Ban_Hang.Model;

namespace QL_Ban_Hang.View
{
    public partial class frmMK : Form
    {
        NhanVienMod Obj = new NhanVienMod();
        NhanVienCtrl nvCtr = new NhanVienCtrl();
        public frmMK()
        {
            InitializeComponent();
        }

        private void frmMK_Load(object sender, EventArgs e)
        {
            lNguoidung.Text = frmDangNhap.LuThongTin.ma;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkMK_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMK.Checked)
            {
                txtMKM.UseSystemPasswordChar = false;
                txtL.UseSystemPasswordChar = false;
                txtcu.UseSystemPasswordChar = false;
            }
            else
            {
                txtMKM.UseSystemPasswordChar = true;
                txtL.UseSystemPasswordChar = true;
                txtcu.UseSystemPasswordChar = true;
            }
        }
        void ganData(NhanVienObj nvobj)
        {
            nvobj.MaNhanVien = lNguoidung.Text.Trim();
            nvobj.MatKhau = txtL.Text.Trim();
        }
        private void btLuu_Click(object sender, EventArgs e)
        {
            NhanVienObj nobj = new NhanVienObj();
            ganData(nobj);
            if (txtcu.Text != txtMKM.Text)
            {
                if (txtMKM.Text == txtL.Text)
                {
                    if (nvCtr.UpdMK(nobj))
                        MessageBox.Show("Đổi mật khẩu thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Đổi mật khẩu thất bại ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Nhập lại mật khẩu không  đúng ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("mật khẩu mới trùng mật khẩu cũ ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}

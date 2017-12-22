using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_Ban_Hang.Control;
using QL_Ban_Hang.Object;

namespace QL_Ban_Hang.View
{
    public partial class frmNhanVien : Form
    {
        private int flagluu = 0;
       
        NhanVienCtrl nvCtr = new NhanVienCtrl();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            DataTable dtNhanVien = new DataTable();
            dtNhanVien = nvCtr.getData();
            dtgvDS.DataSource = dtNhanVien;
            binhding();
            dis_en(false);

        }
        private void binhding()
        {
            txtMaNhanVien.DataBindings.Clear();
            txtMaNhanVien.DataBindings.Add("Text", dtgvDS.DataSource, "MaNV");
            txtTenNhanVien.DataBindings.Clear();
            txtTenNhanVien.DataBindings.Add("Text", dtgvDS.DataSource, "TenNV");
            cbGioiTinh.DataBindings.Clear();
            cbGioiTinh.DataBindings.Add("Text", dtgvDS.DataSource, "GioiTinh");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dtgvDS.DataSource, "DiaChi");
            txtSoDienThoai.DataBindings.Clear();
            txtSoDienThoai.DataBindings.Add("Text", dtgvDS.DataSource, "SDT");
            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", dtgvDS.DataSource, "MatKhau");
        }
        private void FillNogridvew()
        {
            for (int i = 0; i < dtgvDS.Rows.Count; i++)
                dtgvDS["STT", i].Value = i +1;

        }

        private void dtgvDS_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            FillNogridvew();
        }

        private void dtgvDS_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            FillNogridvew();
        }
        void dis_en(bool e)
        {

            txtMaNhanVien.Enabled = e;
            txtTenNhanVien.Enabled = e;
            txtDiaChi.Enabled = e;
            txtSoDienThoai.Enabled = e;
            cbGioiTinh.Enabled = e;
            txtMatKhau.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled =!e;
            //btSua.Enabled =!e;
            btnXoa.Enabled =!e;
        }
        void ganData(NhanVienObj nvobj)
        {
            nvobj.MaNhanVien = txtMaNhanVien.Text.Trim();
            nvobj.TenNhanVien = txtTenNhanVien.Text.Trim();
            nvobj.GioiTinh = cbGioiTinh.Text.Trim();
            nvobj.DiaChi = txtDiaChi.Text.Trim();
            nvobj.SDT = txtSoDienThoai.Text.Trim();
            nvobj.MatKhau = txtMatKhau.Text.Trim();
        }
        void Loadcontrol()
        {
            cbGioiTinh.Items.Clear();
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
            cbGioiTinh.SelectedItem = 0;

        }
        private void clearData()
        {
            txtMaNhanVien.Text = "";
            txtTenNhanVien.Text = "";
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";
            txtMatKhau.Text = "";
            Loadcontrol();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            flagluu = 0;
            clearData();
            dis_en(true);
            Loadcontrol();
           
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            flagluu = 1;
            dis_en(true);
            Loadcontrol();
        }

       

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NhanVienObj nvobj = new NhanVienObj();
            ganData(nvobj);
            //if(flagluu==0)
            //{
                if (nvCtr.addData(nvobj))
                    MessageBox.Show("Thêm thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm thất bại ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{

            //    if (nvCtr.updData(nvobj))
            //        MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    else
            //        MessageBox.Show("Sửa thất bại ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            frmNhanVien_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn xóa", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (nvCtr.DelData(txtMaNhanVien.Text.Trim()))
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa thất bại ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else return;
            frmNhanVien_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                frmNhanVien_Load(sender, e);
            else
                return;
        }
    }
}

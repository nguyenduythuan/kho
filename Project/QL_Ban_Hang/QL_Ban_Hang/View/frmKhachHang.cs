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
    public partial class frmKhachHang : Form
    {
        private int flagluu = 0;

        KhachHangCtrl khCtr = new KhachHangCtrl();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            DataTable dtKh = new DataTable();
            dtKh = khCtr.getData();
            dtgvDS1.DataSource = dtKh;
            binhding();
            dis_en(false);
        }
        private void binhding()
        {
            txtMaKhachHang.DataBindings.Clear();
            txtMaKhachHang.DataBindings.Add("Text", dtgvDS1.DataSource, "MaKH");
            txtTenKhachHang.DataBindings.Clear();
            txtTenKhachHang.DataBindings.Add("Text", dtgvDS1.DataSource, "TenKH");
            cbGioiTinh.DataBindings.Clear();
            cbGioiTinh.DataBindings.Add("Text", dtgvDS1.DataSource, "GioiTinh");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dtgvDS1.DataSource, "DiaChi");
            txtSoDienThoai.DataBindings.Clear();
            txtSoDienThoai.DataBindings.Add("Text", dtgvDS1.DataSource, "SDT");
        }
        private void FillNogridvew()
        {
            for (int i = 0; i < dtgvDS1.Rows.Count; i++)
                dtgvDS1["STT", i].Value = i + 1;

        }

        private void dtgvDS_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            FillNogridvew();
        }
        void dis_en(bool e)
        {

            txtMaKhachHang.Enabled = e;
            txtTenKhachHang.Enabled = e;
            txtDiaChi.Enabled = e;
            txtSoDienThoai.Enabled = e;
            cbGioiTinh.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            //btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
        }
        void ganData(KhachHangObj nvobj)
        {
            nvobj.MaKhachHang = txtMaKhachHang.Text.Trim();
            nvobj.TenKhachHang = txtTenKhachHang.Text.Trim();
            nvobj.GioiTinh = cbGioiTinh.Text.Trim();
            nvobj.DiaChi = txtDiaChi.Text.Trim();
            nvobj.SDT = txtSoDienThoai.Text.Trim();
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
            txtMaKhachHang.Text = "";
            txtTenKhachHang.Text = "";
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";
            Loadcontrol();
        }

        private void dtgvDS_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            FillNogridvew();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flagluu = 0;
            clearData();
            dis_en(true);
            Loadcontrol();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            flagluu = 1;
            dis_en(true);
            Loadcontrol();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn xóa", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (khCtr.DelData(txtMaKhachHang.Text.Trim()))
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa thất bại ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else return;
            frmKhachHang_Load(sender, e);

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            KhachHangObj khobj = new KhachHangObj();
            ganData(khobj);
            
                if (khCtr.addData(khobj))
                    MessageBox.Show("Thêm thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm thất bại ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
            frmKhachHang_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                frmKhachHang_Load(sender, e);
            else
                return;
        }

        
    }
}

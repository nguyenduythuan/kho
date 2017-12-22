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

namespace QL_Ban_Hang.View
{
    public partial class frmHoaDon : Form
    {
        HoaDonCtrl hdctr = new HoaDonCtrl();
        ChiTietHDCtrl ctctr = new ChiTietHDCtrl();
        HangHoaCtrl hhctr = new HangHoaCtrl();
        int a = 0;
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dis_en(false);
            DataTable dt = new DataTable();
            dt = hdctr.getData();
            dgvDSHD.DataSource = dt;
            bingding();
            LoadcbKhachHang();
            LoadcbHangHoa();         
        }
        private void FillNogridvew()
        {
            for (int i = 0; i < dgvDSHD.Rows.Count; i++)
               dgvDSHD["st", i].Value = i + 1;

        }
        private void bingding()
        {
            txtMaHD.DataBindings.Clear();
            txtMaHD.DataBindings.Add("Text", dgvDSHD.DataSource, "MaHD");
            txtNgayLap.DataBindings.Clear();
            txtNgayLap.DataBindings.Add("Text", dgvDSHD.DataSource, "NgayLap");
            cbNhanVien.DataBindings.Clear();
            cbNhanVien.DataBindings.Add("Text", dgvDSHD.DataSource, "TenNV");
            cbKH.DataBindings.Clear();
            cbKH.DataBindings.Add("Text", dgvDSHD.DataSource, "TenKH");

        }

        private void bingding1()
        {
            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", dgvChiTiet.DataSource, "DonGia");
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text",dgvChiTiet.DataSource, "SoLuong");
            cbHH.DataBindings.Clear();
            cbHH.DataBindings.Add("Text", dgvChiTiet.DataSource, "HangHoa");
            lbThanhTien.DataBindings.Clear();
            lbThanhTien.DataBindings.Add("Text",dgvChiTiet.DataSource,"ThanhTien");
           
        }
        private void bingding2()
        {
            txtMaHD.DataBindings.Clear();
            txtMaHD.DataBindings.Add("Text", dgvChiTiet.DataSource, "MaHD");
          
        }
        private void LoadcbKhachHang()
        {
            KhachHangCtrl khctr = new KhachHangCtrl();
           cbKH.DataSource = khctr.getData();
           cbKH.DisplayMember = "TenKH";
           cbKH.ValueMember = "MaKH";
           cbKH.SelectedIndex = 0;
        }

        private void LoadcbHangHoa()
        {
            HangHoaCtrl hhctr = new HangHoaCtrl();
            cbHH.DataSource = hhctr.GetData();
            cbHH.DisplayMember = "TenHH";
            cbHH.ValueMember = "MaHH";
           

        }
        private void LoadcbNhanVien()
        {
            NhanVienCtrl nvctr = new NhanVienCtrl();
            cbNhanVien.DataSource = nvctr.getData();
            cbNhanVien.DisplayMember = "TenNV";
            cbNhanVien.ValueMember = "MaNV";

        }
        private void clearData()
        {
            txtMaHD.Text = "";
            LoadcbNhanVien();
            txtNgayLap.Text = DateTime.Now.Date.ToShortDateString();
            LoadcbKhachHang();
        }
        private void clearData1()
        {
            txtMaHD.Text = "";
            LoadcbHangHoa();
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
            lbThanhTien.Text = "0";
           
        }
        private void addData(HoaDonObj hdObj)
        {
            hdObj.MaHoaDon = txtMaHD.Text.Trim();
            hdObj.NgayLap = txtNgayLap.Text.Trim();
            hdObj.NguoiLap = cbNhanVien.SelectedValue.ToString();
            hdObj.KhachHang = cbKH.SelectedValue.ToString();
        }
        private void gandata(ChiTietHoaDonObj ctObj)
        {
            ctObj.MaHoaDon = txtMaHD.Text.Trim();
            ctObj.MaHangHoa = cbHH.SelectedValue.ToString();
            ctObj.DonGia = int.Parse(txtDonGia.Text.Trim()); ;
            ctObj.SoLuong = int.Parse(txtSoLuong.Text.Trim());
        }
        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = ctctr.getData(txtMaHD.Text.Trim());
                dgvChiTiet.DataSource = dt;
                
            }
            catch
            {
                dgvChiTiet.DataSource = null;
                
            }
            bingding1();
            
        }
        private void dis_en(bool e)
        {
            txtMaHD.Enabled = e;
            txtDonGia.Enabled = e;
            txtNgayLap.Enabled = e;
            cbNhanVien.Enabled = e;
            txtSoLuong.Enabled = e;
            cbKH.Enabled = e;
            cbHH.Enabled = e;
            btLuu.Enabled = e;
            btHuy.Enabled = e;
          
        }
        private void dis_en1(bool e)
        {
            txtMaHD.Enabled = e;
            txtSoLuong.Enabled = e;
            txtDonGia.Enabled = e;
            cbHH.Enabled = e;
            btLuu.Enabled = e;
            btHuy.Enabled = e;

        }


        private void btTao_Click(object sender, EventArgs e)
        {
            a = 1;
            dis_en(true);
            txtNgayLap.Enabled = false;
            clearData();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Bạn chắc chắn xóa hóa đơn này", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (hdctr.DelData(txtMaHD.Text.Trim()))
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa thất bại ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else return;
            frmHoaDon_Load(sender, e);
        }
      
        private void btLuu_Click(object sender, EventArgs e)
        {

            if (a == 1)
            {
                HoaDonObj hdobj = new HoaDonObj();
                addData(hdobj);
                if (hdctr.addData(hdobj))
                    MessageBox.Show("Thêm hóa đơn thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm hóa đơn thất bại ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                ChiTietHoaDonObj ctobj = new ChiTietHoaDonObj();
                gandata(ctobj);
                bingding2();
                hhctr.getSL();
                if (ctctr.AddData(ctobj))
                    MessageBox.Show("Thêm chi tiết hóa đơn thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm chi tiết hóa đơn thất bại ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            frmHoaDon_Load(sender, e);
            }
        

        private void btHuy_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                frmHoaDon_Load(sender, e);
            else
                return;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            a = 2;
            dis_en1(true);
            clearData1();
        }

        private void btBot_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Bạn chắc chắn bỏ hóa đơn này", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (ctctr.DelData(txtMaHD.Text.Trim()))
                    MessageBox.Show("Bớt thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Bớt thất bại ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else return;
            frmHoaDon_Load(sender, e);
        }

        private void dgvDSHD_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            FillNogridvew();
        }

        private void dgvDSHD_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            FillNogridvew();
        }

       
    }
}
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
    public partial class frmHangHoa : Form
    {

        private int flagluu = 0;
        HangHoaCtrl hhCtr = new HangHoaCtrl();
        public frmHangHoa()
        {
            InitializeComponent();
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            DataTable dtHangHoa = new DataTable();
            dtHangHoa = hhCtr.GetData();
            dtgvDS2.DataSource = dtHangHoa;
            binhding();
            dis_en(false);
        }
        private void binhding()
        {
            txtMaHangHoa.DataBindings.Clear();
            txtMaHangHoa.DataBindings.Add("Text", dtgvDS2.DataSource, "MaHH");
            txtTenHangHoa.DataBindings.Clear();
            txtTenHangHoa.DataBindings.Add("Text", dtgvDS2.DataSource, "TenHH");
            txtGiaHangHoa.DataBindings.Clear();
            txtGiaHangHoa.DataBindings.Add("Text", dtgvDS2.DataSource, "DonGia");
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dtgvDS2.DataSource, "SoLuong");
        }
        private void FillNogridvew()
        {
            for (int i = 0; i < dtgvDS2.Rows.Count; i++)
                dtgvDS2["STT", i].Value = i + 1;

        }

        void dis_en(bool e)
        {

            txtMaHangHoa.Enabled = e;
            txtTenHangHoa.Enabled = e;
            txtGiaHangHoa.Enabled = e;
            txtSoLuong.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            //btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
        }
        void ganData(HangHoaObj hhobj)
        {
            hhobj.MaHangHoa = txtMaHangHoa.Text.Trim();
            hhobj.TenHangHoa = txtTenHangHoa.Text.Trim();
            hhobj.Gia =int.Parse( txtGiaHangHoa.Text.Trim());
            hhobj.Soluong = int.Parse( txtSoLuong.Text.Trim());
        }
        private void clearData()
        {
            txtMaHangHoa.Text = "";
            txtTenHangHoa.Text = "";
            txtGiaHangHoa.Text = "";
            txtSoLuong.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flagluu = 0;
            clearData();
            dis_en(true);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            flagluu = 1;
            dis_en(true);
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn xóa", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (hhCtr.DelData(txtMaHangHoa.Text.Trim()))
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa thất bại ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else return;
            frmHangHoa_Load(sender, e);

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            HangHoaObj hhobj = new HangHoaObj();
            ganData(hhobj);
           
                if (hhCtr.addData(hhobj))
                    MessageBox.Show("Thêm thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm thất bại ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
            frmHangHoa_Load(sender, e);

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                frmHangHoa_Load(sender, e);
            else
                return;
        }

        private void dtgvDS2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            FillNogridvew();
        }

        private void dtgvDS2_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            FillNogridvew();
        }

        private void txtGiaHangHoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_Ban_Hang.View;


namespace QL_Ban_Hang
{
    public partial class frmMain : Form
    {
      
        public frmMain()
        {
            InitializeComponent();
           

        }
        private void hệThốngToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmDangNhap DN = new frmDangNhap();
            DN.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMK mk = new frmMK();
            mk.ShowDialog();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát ", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void hàngHóaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHangHoa HH = new frmHangHoa();
            HH.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            frmKhachHang kh = new frmKhachHang();
            kh.ShowDialog();
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            frmNhanVien NV = new frmNhanVien();
            NV.ShowDialog();

        }

        private void hóaĐơnChiTiếtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHoaDon hd = new frmHoaDon();
            hd.ShowDialog();
        }

        private void thôngTinBảnQuyềnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TT tt = new TT();
            tt.ShowDialog();

        }

        private void hướngDẫnSửDụngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Liên hệ nhà phát hành để được trợ giúp ", "Thông tin", MessageBoxButtons.OK);
        }

        private void inHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Chức năng chưa được phát triển ", "Thông tin", MessageBoxButtons.OK);
        }

        private void inBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng chưa được phát triển ", "Thông tin", MessageBoxButtons.OK);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtNguoiD.Text = frmDangNhap.LuThongTin.Ten;
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinCửaHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cửa hàng bán quần áo XXX ", "Thông tin", MessageBoxButtons.OK);
        }
    }
}

        
    

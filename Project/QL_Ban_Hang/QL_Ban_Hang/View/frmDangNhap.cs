using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace QL_Ban_Hang.View
{
    public partial class frmDangNhap : Form
    {
        string  StrCon = @"Data Source=.\SQLEXPRESS; Initial Catalog = BANHANG ; integrated security = true ";
        SqlConnection Conn;
        SqlCommand cmd;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            try
            {

                Conn = new SqlConnection(StrCon);
                Conn.Open();
                string sql = ("Select COUNT(*)  from NhanVien where TenNV=N'" + txtTen.Text + "'and MatKhau ='" + txtMK.Text + "'");              
                cmd = new SqlCommand(sql, Conn);              
                int x = (int)cmd.ExecuteScalar();
                string sql1 = ("Select  MaNV "+lMa.Text+" from NhanVien where TenNV=N'" + txtTen.Text + "'and MatKhau ='" + txtMK.Text + "'");
                if (x == 1)
                {
                    //Đăng nhập thành công
                    LuThongTin.Ten = txtTen.Text;
                    cmd = new SqlCommand(sql1, Conn);                                   
                    lMa.Text = (string)cmd.ExecuteScalar();
                    LuThongTin.ma = lMa.Text;
                    frmMain M = new frmMain();
                    this.Hide();
                    M.Show();
                   

                }
                else
                {
                    //Đăng nhập thất bại
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void checkMK_CheckedChanged(object sender, EventArgs e)
        {
            if(checkMK.Checked)
            {
                txtMK.UseSystemPasswordChar = false;
            }
            else
            {
                txtMK.UseSystemPasswordChar = true;
            }
        }
         public class LuThongTin
        {
            static public string Ten;
            static public string ma;

        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}

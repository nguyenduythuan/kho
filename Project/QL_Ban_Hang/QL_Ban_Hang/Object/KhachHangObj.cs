using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Ban_Hang.Object
{
    class KhachHangObj
    {
        string ma, ten, gioitinh, diachi, sdt;

        public string DiaChi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }

        public string GioiTinh
        {
            get
            {
                return gioitinh;
            }

            set
            {
                gioitinh = value;
            }
        }

        public string MaKhachHang
        {
            get
            {
                return ma;
            }

            set
            {
                ma = value;
            }
        }
        public string SDT
        {
            get
            {
                return sdt;
            }

            set
            {
                sdt = value;
            }
        }

        public string TenKhachHang
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
            }
        }
        public KhachHangObj() { }
        public KhachHangObj(string ma, string ten, string gioitinh, string diachi, string sdt)
        {
            this.ma = ma;
            this.ten = ten;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.sdt = sdt;

        }

    }
}

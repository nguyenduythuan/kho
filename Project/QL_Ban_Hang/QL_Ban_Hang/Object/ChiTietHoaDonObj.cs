using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Ban_Hang.Object
{
    class ChiTietHoaDonObj
    {
        string mahd, mahh;
        int soluong, dongia;

       

        public string MaHoaDon
        {
            get
            {
                return mahd;
            }

            set
            {
                mahd = value;
            }
        }

        public string MaHangHoa
        {
            get
            {
                return mahh;
            }

            set
            {
                mahh = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return soluong;
            }

            set
            {
                soluong = value;
            }
        }

        public int DonGia
        {
            get
            {
                return dongia;
            }

            set
            {
                dongia = value;
            }
        }

        public ChiTietHoaDonObj() { }
        public ChiTietHoaDonObj(string mahd, string mahh, int soluong, int dongia)
        {
            this.mahd = mahd;
            this.mahh = mahh;
            this.soluong = soluong;
            this.dongia = dongia;
        }
    }
}

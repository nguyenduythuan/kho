using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QL_Ban_Hang.Object
{
    class HoaDonObj
    {
        string mahd, ngaylap, nguoilap, khachhang;

        public string KhachHang
        {
            get
            {
                return khachhang;
            }

            set
            {
                khachhang = value;
            }
        }

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

        public string NgayLap
        {
            get
            {
                return ngaylap;
            }

            set
            {
                ngaylap = value;
            }
        }

        public string NguoiLap
        {
            get
            {
                return nguoilap;
            }

            set
            {
                nguoilap = value;
            }
        }
        public HoaDonObj() { }
        public HoaDonObj(string ma, string ngaylap, string khachhang, string nguoilap)
        {
            this.mahd = mahd;
            this.ngaylap = ngaylap;
            this.nguoilap = nguoilap;
            this.khachhang = khachhang;
        }
    }
}

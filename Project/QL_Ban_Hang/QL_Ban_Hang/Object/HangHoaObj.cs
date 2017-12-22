using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Ban_Hang.Object
{
    class HangHoaObj
    {
        string ma, ten;
        int soluong, gia;

       

        public string MaHangHoa
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

       

        public string TenHangHoa
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

        public int Soluong
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

        public int Gia
        {
            get
            {
                return gia;
            }

            set
            {
                gia = value;
            }
        }

        public HangHoaObj() { }
        public HangHoaObj(string ma, string ten, string gioitinh, string diachi, string sdt, string matkhau)
        {
            this.MaHangHoa = ma;
            this.TenHangHoa = ten;
            this.Soluong = Soluong;
            this.Gia = Gia;
        }
    }
}
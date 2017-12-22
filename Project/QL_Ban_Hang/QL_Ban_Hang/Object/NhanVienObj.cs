﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QL_Ban_Hang.Object
{
    class NhanVienObj
    {
        string ma, ten, gioitinh, diachi, sdt, matkhau;

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

        public string MaNhanVien
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

        public string MatKhau
        {
            get
            {
                return matkhau;
            }

            set
            {
                matkhau = value;
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

        public string TenNhanVien
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
        public NhanVienObj() { }
        public NhanVienObj(string ma, string ten, string gioitinh, string diachi, string sdt, string matkhau)
        {
            this.ma = ma;
            this.ten = ten;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.sdt = sdt;
            this.matkhau = matkhau;

        }

    }
}

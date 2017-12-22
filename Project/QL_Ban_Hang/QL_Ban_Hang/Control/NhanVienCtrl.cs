using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QL_Ban_Hang.Model;
using QL_Ban_Hang.Object;

namespace QL_Ban_Hang.Control
{
    class NhanVienCtrl
    {
        NhanVienMod nvMod = new NhanVienMod();
        public DataTable getData()
        {
            return nvMod.GetData();
        }
        public bool addData(NhanVienObj nvobj)
        {
            return nvMod.AddData(nvobj);
                
        }
        //public bool updData(NhanVienObj nvobj )
        //{
        //    return nvMod.UpdData(nvobj);
        //}
        public bool UpdMK(NhanVienObj nvobj)
        {
            return nvMod.UpdMK(nvobj);
        }
        public bool DelData(string ma)
        {
            return nvMod.DelData(ma);
        }

    }
}

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
    class ChiTietHDCtrl
    {
        ChiTietHoaDonMod ctMod = new ChiTietHoaDonMod();
        public DataTable getData(string ma)
        {
            return ctMod.GetData(ma);
        }
       
        public bool AddData(ChiTietHoaDonObj ctobj)
        {
            return ctMod.AddData(ctobj);
        }
        public bool DelData(string ma)
        {
            return ctMod.DelData(ma);
        }
    }
}

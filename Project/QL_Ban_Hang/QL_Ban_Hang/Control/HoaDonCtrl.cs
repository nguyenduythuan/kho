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
    class HoaDonCtrl
    {

        HoaDonMod hdMod = new HoaDonMod();
        public DataTable getData()
        {
            return hdMod.GetData();
        }
        public bool addData(HoaDonObj hdobj)
        {
            return hdMod.AddData(hdobj);

        }
        public bool DelData(string ma)
        {
            return hdMod.DelData(ma);
        }
    }
}

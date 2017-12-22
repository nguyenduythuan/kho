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
    class KhachHangCtrl
    {
        KhachHangMod nvMod = new KhachHangMod();
        public DataTable getData()
        {
            return nvMod.GetData();
        }
        public bool addData(KhachHangObj khobj)
        {
            return nvMod.AddData(khobj);

        }
      
        public bool DelData(string ma)
        {
            return nvMod.DelData(ma);
        }
    }
}

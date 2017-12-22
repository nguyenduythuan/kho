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
    class HangHoaCtrl
    {
        HangHoaMod hhMod = new HangHoaMod();
        public DataTable getSL()
        {
            return hhMod.GetSL();
        
        }
        public bool addData(HangHoaObj hhobj)
        {
            return hhMod.AddData(hhobj);

        }
        public bool UpdSL(string mahh, int sl)
        {
            return hhMod.UpdSL(mahh, sl);

        }
        public DataTable GetData()
        {
            return hhMod.GetData();

        }
        public bool DelData(string ma)
        {
            return hhMod.DelData(ma);
        }
    }
}

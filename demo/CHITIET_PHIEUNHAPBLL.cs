using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class CHITIET_PHIEUNHAPBLL
    {
        CHITIET_PHIEUNHAPDAL dalCTPN;
        public CHITIET_PHIEUNHAPBLL()
        {
            dalCTPN = new CHITIET_PHIEUNHAPDAL();
        }
        public DataTable getAllCTPN()
        {
            return dalCTPN.getAllCTPN();
        }
        public bool InsertCTPN(CHITIET_PHIEUNHAP c)
        {
            return dalCTPN.InsertCTPN(c);
        }
        public bool UpdateCTPN(CHITIET_PHIEUNHAP c)
        {
            return dalCTPN.UpdateCTPN(c);
        }
        public bool DeleteCTPN(CHITIET_PHIEUNHAP c)
        {
            return dalCTPN.DeleteCTPN(c);
        }
        public DataTable FindCTPN(string c)
        {
            return dalCTPN.FindCTPN(c);
        }
        public DataTable getAllCTPN1(string SOPN)
        {
            return dalCTPN.getAllCTPN1(SOPN);
        }
    }
}

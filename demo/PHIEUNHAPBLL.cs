using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class PHIEUNHAPBLL
    {
        PHIEUNHAPDAL dalPN;
        public PHIEUNHAPBLL()
        {
            dalPN = new PHIEUNHAPDAL();
        }
        public DataTable getAllPN()
        {
            return dalPN.getAllPN();
        }
        public bool InsertPN(PHIEUNHAP pn)
        {
            return dalPN.InsertPN(pn);
        }
        public bool UpdatePN(PHIEUNHAP pn)
        {
            return dalPN.UpdatePN(pn);
        }
        public bool DeletePN(PHIEUNHAP pn)
        {
            return dalPN.DeletePN(pn);
        }
        public DataTable FindPN(string p)
        {
            return dalPN.FindPN(p);
        }
    }
}

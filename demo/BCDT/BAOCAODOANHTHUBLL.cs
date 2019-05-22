using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ThucTapNhom
{
    class BAOCAODOANHTHUBLL
    {
        BAOCAODOANHTHUDAL dalbc;

        public BAOCAODOANHTHUBLL()
        {
            dalbc = new BAOCAODOANHTHUDAL(); 
        }
        public DataTable getAllPBCDT()
        {
            return dalbc.getAllBCDT();
        }
        public bool InsertPBCDT(BCDT bc)
        {
            return dalbc.InsertPBCDT(bc);
        }
        public bool UpdatePBCDT(BCDT bc)
        {
            return dalbc.UpdatePBCDT(bc);
        }
        public bool DeletePBCDT(BCDT bc)
        {
            return dalbc.DeletePBCDT(bc);
        }
        public DataTable FindPBCDT(string b)
        {
            return dalbc.FindPBCDT(b);
        }
    }
}

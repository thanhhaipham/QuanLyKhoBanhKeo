using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucTapNhom
{
    class PHIEUKKCLBLL
    {
        PHIEUKKCLDAL dalPKKCL;
        public PHIEUKKCLBLL()
        {
            dalPKKCL = new PHIEUKKCLDAL();
        }
        public DataTable LayTatCaPKKCL()
        {
            return dalPKKCL.LayTatCaPKKCL();
        }
        public bool InsertPKKCL(PHIEUKKCL KKCL)
        {
            return dalPKKCL.InsertPKKCL(KKCL);
        }
        public bool UpdatePKKCL(PHIEUKKCL KKCL)
        {
            return dalPKKCL.UpdatePKKCL(KKCL);
        }
        public bool DeletePKKCL(PHIEUKKCL KKCL)
        {
            return dalPKKCL.DeletePKKCL(KKCL);
        }
        public DataTable TimKiem_PKKCL(string n)
        {
            return dalPKKCL.TimKiem_PKKCL(n);
        }
    }
}

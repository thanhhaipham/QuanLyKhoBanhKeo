using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucTapNhom
{
    class PHIEUKKSLBLL
    {
        PHIEUKKSLDAL dalPKKSL;
        public PHIEUKKSLBLL()
        {
            dalPKKSL = new PHIEUKKSLDAL();
        }
        public DataTable LayTatCaPKKSL()
        {
            return dalPKKSL.LayTatCaPKKSL();
        }
        public bool InsertPKKSL(PHIEUKKSL KKSL)
        {
            return dalPKKSL.InsertPKKSL(KKSL);
        }
        public bool UpdatePKKSL(PHIEUKKSL KKSL)
        {
            return dalPKKSL.UpdatePKKSL(KKSL);
        }
        public bool DeletePKKSL(PHIEUKKSL KKSL)
        {
            return dalPKKSL.DeletePKKSL(KKSL);
        }
        public DataTable TimKiem_PKKSL(string n)
        {
            return dalPKKSL.TimKiem_PKKSL(n);
        }
    }
}

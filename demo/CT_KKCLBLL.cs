using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucTapNhom
{
    class CT_KKCLBLL
    {
        CT_KKCLDAL dalCT_KKCL;
        public CT_KKCLBLL()
        {
            dalCT_KKCL = new CT_KKCLDAL();
        }
        public DataTable LayTatCaCT_KKCL()
        {
            return dalCT_KKCL.LayTatCaCT_KKCL();
        }
        public bool InsertCT_KKCL(CT_KKCL CTKKCL)
        {
            return dalCT_KKCL.InsertCT_KKCL(CTKKCL);
        }
        public bool UpdateCT_KKCL(CT_KKCL CTKKCL)
        {
            return dalCT_KKCL.UpdateCT_KKCL(CTKKCL);
        }
        public bool DeleteCT_KKCL(CT_KKCL CTKKCL)
        {
            return dalCT_KKCL.DeleteCT_KKCL(CTKKCL);
        }
        public DataTable TimKiem_CTKKCL(string n)
        {
            return dalCT_KKCL.TimKiem_CTKKCL(n);
        }
    }

}

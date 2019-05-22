using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucTapNhom
{
    class CT_KKSLBLL
    {
        CT_KKSLDAL dalCT_KKSL;
        public CT_KKSLBLL()
        {
            dalCT_KKSL = new CT_KKSLDAL();
        }
        public DataTable LayTatCaCT_KKSL()
        {
            return dalCT_KKSL.LayTatCaCT_KKSL();
        }
        public bool InsertCT_KKSL(CT_KKSL CTKKSL)
        {
            return dalCT_KKSL.InsertCT_KKSL(CTKKSL);
        }
        public bool UpdateCT_KKSL(CT_KKSL CTKKSL)
        {
            return dalCT_KKSL.UpdateCT_KKSL(CTKKSL);
        }
        public bool DeleteCT_KKSL(CT_KKSL CTKKSL)
        {
            return dalCT_KKSL.DeleteCT_KKSL(CTKKSL);
        }
        public DataTable TimKiem_CTKKSL(string n)
        {
            return dalCT_KKSL.TimKiem_CTKKSL(n);
        }
    }

}

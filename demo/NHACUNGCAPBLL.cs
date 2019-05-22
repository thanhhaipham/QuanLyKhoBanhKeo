using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class NHACUNGCAPBLL
    {
        NHACUNGCAPDAL dalNCC;
        public NHACUNGCAPBLL()
        {
            dalNCC = new NHACUNGCAPDAL();
        }
        public DataTable getAllNCC()
        {
            return dalNCC.getAllNCC();
        }
        public bool InsertNCC(NHACUNGCAP ncc)
        {
            return dalNCC.InsertNCC(ncc);
        }
        public bool UpdateNCC(NHACUNGCAP ncc)
        {
            return dalNCC.UpdateNCC(ncc);
        }
        public bool DeleteNCC(NHACUNGCAP ncc)
        {
            return dalNCC.DeleteNCC(ncc);
        }
        public DataTable FindNCC(string n)
        {
            return dalNCC.FindNCC(n);
        }
    }
}

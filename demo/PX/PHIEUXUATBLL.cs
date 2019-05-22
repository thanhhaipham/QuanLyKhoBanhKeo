using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ThucTapNhom
{
    class PHIEUXUATBLL
    {
        PHIEUXUATDAL dalpx;

        public PHIEUXUATBLL()
        {
            dalpx = new PHIEUXUATDAL();
        }

        public DataTable getAllPHIEUXUAT()
        {
            return dalpx.getAllPHIEUXUAT();
        }
        public bool InsertPHIEUXUAT(PHIEU_XUAT px)
        {
            return dalpx.InsertPHIEUXUAT(px);
        }
        public bool UpdatePHIEUXUAT(PHIEU_XUAT px)
        {
            return dalpx.UpdatePHIEUXUAT(px);
        }
        public bool DeletePHIEUXUAT(PHIEU_XUAT px)
        {
            return dalpx.DeletePHIEUXUAT(px);
        }
        public DataTable FindPHIEUXUAT(string p)
        {
            return dalpx.FindPHIEUXUAT(p);
        }
    }
}

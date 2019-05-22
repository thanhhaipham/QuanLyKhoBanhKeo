using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ThucTapNhom
{
    class CHITIET_PHIEUXUATBLL
    {
        CHITIET_PHIEUXUATDAL dalct;

        public CHITIET_PHIEUXUATBLL()
        {
            dalct = new CHITIET_PHIEUXUATDAL();
        }
        public DataTable getAllCHITIET_PHIEUXUAT()
        {
            return dalct.getAllCHITIET_PHIEUXUAT();
        }
        public bool InsertCHITIET_PHIEUXUAT(CHITIET_PHIEUXUAT ct)
        {
            return dalct.InsertCHITIET_PHIEUXUAT(ct); 
        }
        public bool UpdateCHITIET_PHIEUXUAT(CHITIET_PHIEUXUAT ct)
        {
            return dalct.UpdateCHITIET_PHIEUXUAT(ct);
        }
        public bool DeleteCHITIET_PHIEUXUAT(CHITIET_PHIEUXUAT ct)
        {
            return dalct.DeleteCHITIET_PHIEUXUAT(ct);
        }
        public DataTable FindCHITIET_PHIEUXUAT(string c)
        {
            return dalct.FindCHITIET_PHIEUXUAT(c);
        }
    }
}

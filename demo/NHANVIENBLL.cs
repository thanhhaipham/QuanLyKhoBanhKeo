using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class NHANVIENBLL
    {
        NHANVIENDAL dalNV;
        public NHANVIENBLL()
        {
            dalNV = new NHANVIENDAL();
        }
        public DataTable getAllNV()
        {
            return dalNV.getAllNV();
        }
        public bool InsertNhanVien(NHANVIEN nv)
        {
            return dalNV.InsertNhanVien(nv);
        }
        public bool UpdateNhanVien(NHANVIEN nv)
        {
            return dalNV.UpdateNhanVien(nv);
        }
        public bool DeleteNhanVien(NHANVIEN nv)
        {
            return dalNV.DeleteNhanVien(nv);
        }
        public DataTable FindNhanVien(string nv)
        {
            return dalNV.FindNhanVien(nv);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class HANGHOABLL
    {
        HANGHOADAL dalHH;
        public HANGHOABLL()
        {
            dalHH = new HANGHOADAL();
        }
        public DataTable getAllHH()
        {
            return dalHH.getAllHH();
        }
        public bool InsertHangHoa(HANGHOA hh)
        {
            return dalHH.InsertHangHoa(hh);
        }
        public bool UpdateHangHoa(HANGHOA hh)
        {
            return dalHH.UpdateHangHoa(hh);
        }
        public bool DeleteHangHoa(HANGHOA hh)
        {
            return dalHH.DeleteHangHoa(hh);
        }
        public DataTable FindHangHoa(string hh)
        {
            return dalHH.FindHangHoa(hh);
        }
    }
}

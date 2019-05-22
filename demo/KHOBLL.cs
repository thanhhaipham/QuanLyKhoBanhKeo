using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class KHOBLL
    {
        KHODAL dalK;
        public KHOBLL()
        {
            dalK = new KHODAL();
        }
        public DataTable getAllKho()
        {
            return dalK.getAllKho();
        }
        public DataTable getAllK6()
        {
            return dalK.getAllK6();
        }
        public DataTable getAllK7()
        {
            return dalK.getAllK7();
        }
        public DataTable getAllK8()
        {
            return dalK.getAllK8();
        }
        public DataTable getAllK9()
        {
            return dalK.getAllK9();
        }
        public DataTable getAllK10()
        {
            return dalK.getAllK10();
        }
        public bool InsertKho(KHO k)
        {
            return dalK.InsertKho(k);
        }
        public bool UpdateKho(KHO k)
        {
            return dalK.UpdateKho(k);
        }
        public bool DeleteKho(KHO k)
        {
            return dalK.DeleteKho(k);
        }
        public DataTable FindKho(string k)
        {
            return dalK.FindKho(k);
        }
    }
}

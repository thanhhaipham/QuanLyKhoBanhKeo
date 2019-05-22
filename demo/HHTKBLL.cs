using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class HHTKBLL
    {
        HHTKDAL dalHHTK;
        public HHTKBLL()
        {
            dalHHTK = new HHTKDAL();
        }
        public DataTable getAllHHTK()
        {
            return dalHHTK.getAllHHTK();
        }
        public DataTable getK6()
        {
            return dalHHTK.getK6();
        }
        public DataTable getK7()
        {
            return dalHHTK.getK7();
        }
        public DataTable getK8()
        {
            return dalHHTK.getK8();
        }
        public DataTable getK9()
        {
            return dalHHTK.getK9();
        }
        public DataTable getK10()
        {
            return dalHHTK.getK10();
        }
    }
}

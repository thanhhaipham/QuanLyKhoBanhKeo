using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class HHTKDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        public HHTKDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllHHTK()
        {
            string sql = "SELECT TENHH, KHO.MAKHO, KHO.TENKHO, SOLUONG FROM HHTK,HANGHOA, KHO WHERE HHTK.MAHH = HANGHOA.MAHH AND HHTK.MAKHO = KHO.MAKHO";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getK6()
        {
            string sql = "SELECT TENHH, SOLUONG FROM HHTK, HANGHOA WHERE HHTK.MAKHO LIKE 'K6%' AND HHTK.MAHH = HANGHOA.MAHH ";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getK7()
        {
            string sql = "SELECT TENHH, SOLUONG FROM HHTK, HANGHOA WHERE HHTK.MAKHO LIKE 'K7%' AND HHTK.MAHH = HANGHOA.MAHH ";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getK8()
        {
            string sql = "SELECT TENHH, SOLUONG FROM HHTK, HANGHOA WHERE HHTK.MAKHO LIKE 'K8%' AND HHTK.MAHH = HANGHOA.MAHH ";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getK9()
        {
            string sql = "SELECT TENHH, SOLUONG FROM HHTK, HANGHOA WHERE HHTK.MAKHO LIKE 'K9%' AND HHTK.MAHH = HANGHOA.MAHH ";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getK10()
        {
            string sql = "SELECT TENHH, SOLUONG FROM HHTK, HANGHOA WHERE HHTK.MAKHO LIKE 'K10%' AND HHTK.MAHH = HANGHOA.MAHH ";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}

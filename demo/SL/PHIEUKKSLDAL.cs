using demo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucTapNhom
{
    class PHIEUKKSLDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public PHIEUKKSLDAL()
        {
            dc = new DataConnection();
        }
        public DataTable LayTatCaPKKSL()
        {
            string sql = "SELECT * FROM PHIEUKKSL";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool InsertPKKSL(PHIEUKKSL KKSL)
        {
            string sql = "INSERT INTO PHIEUKKSL( SOPSL, NGAYKK, MAKHO, MANV) VALUES(@SOPSL, @NGAYKK, @MAKHO, @MANV) ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@SOPSL", SqlDbType.NChar).Value = KKSL.SOPSL;
                cmd.Parameters.Add("@NGAYKK", SqlDbType.Date).Value = KKSL.NGAYKK;
                cmd.Parameters.Add("@MAKHO", SqlDbType.NChar).Value = KKSL.MAKHO;
                cmd.Parameters.Add("@MANV", SqlDbType.NChar).Value = KKSL.MANV;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool UpdatePKKSL(PHIEUKKSL KKSL)
        {
            string sql = "UPDATE PHIEUKKSL SET SOPSL = @SOPSL, NGAYKK = @NGAYKK, MAKHO = @MAKHO, MANV = @MANV WHERE SOPSL = @SOPSL ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@SOPSL", SqlDbType.NChar).Value = KKSL.SOPSL;
                cmd.Parameters.Add("@NGAYKK", SqlDbType.Date).Value = KKSL.NGAYKK;
                cmd.Parameters.Add("@MAKHO", SqlDbType.NChar).Value = KKSL.MAKHO;
                cmd.Parameters.Add("@MANV", SqlDbType.NChar).Value = KKSL.MANV;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool DeletePKKSL(PHIEUKKSL KKSL)
        {
            string sql = "DELETE PHIEUKKSL WHERE SOPSL = @SOPSL ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@SOPSL", SqlDbType.NChar).Value = KKSL.SOPSL;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable TimKiem_PKKSL(string n)
        {
            string sql = "SELECT * FROM PHIEUKKSL WHERE SOPSL LIKE '%" + n + "%' OR NGAYKK LIKE N'%" + n + "%' OR MAKHO LIKE N'%"+ n + "%' OR MANV LIKE N'%"+ n + "%'";
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

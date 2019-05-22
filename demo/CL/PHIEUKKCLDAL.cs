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
    class PHIEUKKCLDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public PHIEUKKCLDAL()
        {
            dc = new DataConnection();
        }
        public DataTable LayTatCaPKKCL()
        {
            string sql = "SELECT * FROM PHIEUKKCL";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool InsertPKKCL(PHIEUKKCL KKCL)
        {
            string sql = "INSERT INTO PHIEUKKCL( SOPCL, NGAYKK, MAKHO, MANV) VALUES(@SOPCL, @NGAYKK, @MAKHO, @MANV) ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@SOPCL", SqlDbType.NChar).Value = KKCL.SOPCL;
                cmd.Parameters.Add("@NGAYKK", SqlDbType.Date).Value = KKCL.NGAYKK;
                cmd.Parameters.Add("@MAKHO", SqlDbType.NChar).Value = KKCL.MAKHO;
                cmd.Parameters.Add("@MANV", SqlDbType.NChar).Value = KKCL.MANV;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool UpdatePKKCL(PHIEUKKCL KKCL)
        {
            string sql = "UPDATE PHIEUKKCL SET SOPCL = @SOPCL, NGAYKK = @NGAYKK, MAKHO = @MAKHO, MANV = @MANV WHERE SOPCL = @SOPCL ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@SOPCL", SqlDbType.NChar).Value = KKCL.SOPCL;
                cmd.Parameters.Add("@NGAYKK", SqlDbType.Date).Value = KKCL.NGAYKK;
                cmd.Parameters.Add("@MAKHO", SqlDbType.NChar).Value = KKCL.MAKHO;
                cmd.Parameters.Add("@MANV", SqlDbType.NChar).Value = KKCL.MANV;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool DeletePKKCL(PHIEUKKCL KKCL)
        {
            string sql = "DELETE PHIEUKKCL WHERE SOPCL = @SOPCL ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@SOPCL", SqlDbType.NChar).Value = KKCL.SOPCL;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable TimKiem_PKKCL(string n)
        {
            string sql = "SELECT * FROM PHIEUKKCL WHERE SOPCL LIKE '%" + n + "%' OR NGAYKK LIKE N'%" + n + "%' OR MAKHO LIKE N'%" + n + "%' OR MANV LIKE N'%" + n + "%'";
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

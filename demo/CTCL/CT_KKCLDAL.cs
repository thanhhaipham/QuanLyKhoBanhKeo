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
    class CT_KKCLDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public CT_KKCLDAL()
        {
            dc = new DataConnection();
        }
        public DataTable LayTatCaCT_KKCL()
        {
            string sql = "SELECT * FROM CHITIET_PHIEUKKCL";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool InsertCT_KKCL(CT_KKCL CTKKCL)
        {
            string sql = "INSERT INTO CHITIET_PHIEUKKCL( SOPCL, MAHH, SOLUONGSPKT, SOLUONGSPL, SOLUONGSPHH, GHICHU) VALUES(@SOPCL, @MAHH, @SOLUONGSPKT, @SOLUONGSPL, @SOLUONGSPHH, @GHICHU) ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@SOPCL", SqlDbType.NChar).Value = CTKKCL.SOPCL;
                cmd.Parameters.Add("@MAHH", SqlDbType.NChar).Value = CTKKCL.MAHH;
                cmd.Parameters.Add("@SOLUONGSPKT", SqlDbType.Int).Value = CTKKCL.SOLUONGSPKT;
                cmd.Parameters.Add("@SOLUONGSPL", SqlDbType.Int).Value = CTKKCL.SOLUONGSPL;
                cmd.Parameters.Add("@SOLUONGSPHH", SqlDbType.Int).Value = CTKKCL.SOLUONGSPHH;
                cmd.Parameters.Add("@GHICHU", SqlDbType.NVarChar).Value = CTKKCL.GHICHU;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool UpdateCT_KKCL(CT_KKCL CTKKCL)
        {
            string sql = "UPDATE CHITIET_PHIEUKKCL SET SOPCL = @SOPCL, MAHH = @MAHH, SOLUONGSPKT = @SOLUONGSPKT, SOLUONGSPL = @SOLUONGSPL, SOLUONGSPHH = @SOLUONGSPHH, GHICHU = @GHICHU WHERE SOPCL = @SOPCL ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@SOPCL", SqlDbType.NChar).Value = CTKKCL.SOPCL;
                cmd.Parameters.Add("@MAHH", SqlDbType.NChar).Value = CTKKCL.MAHH;
                cmd.Parameters.Add("@SOLUONGSPKT", SqlDbType.Int).Value = CTKKCL.SOLUONGSPKT;
                cmd.Parameters.Add("@SOLUONGSPL", SqlDbType.Int).Value = CTKKCL.SOLUONGSPL;
                cmd.Parameters.Add("@SOLUONGSPHH", SqlDbType.Int).Value = CTKKCL.SOLUONGSPHH;
                cmd.Parameters.Add("@GHICHU", SqlDbType.NVarChar).Value = CTKKCL.GHICHU;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool DeleteCT_KKCL(CT_KKCL CTKKCL)
        {
            string sql = "DELETE CHITIET_PHIEUKKCL WHERE SOPCL = @SOPCL ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@SOPCL", SqlDbType.NChar).Value = CTKKCL.SOPCL;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable TimKiem_CTKKCL(string n)
        {
            string sql = "SELECT * FROM CHITIET_PHIEUKKCL WHERE SOPCL LIKE '%" + n + "%' OR MAHH LIKE N'%" + n + "%' OR SOLUONGSPKT LIKE N'%" + n + "%' OR SOLUONGSPL LIKE N'%" + n + "%' OR SOLUONGSPHH LIKE N'%" + n + "%' OR GHICHU LIKE N'%" + n + "%'";
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

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
    class CT_KKSLDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public CT_KKSLDAL()
        {
            dc = new DataConnection();
        }
        public DataTable LayTatCaCT_KKSL()
        {
            string sql = "SELECT * FROM CHITIET_PHIEUKKSL";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool InsertCT_KKSL(CT_KKSL CTKKSL)
        {
            string sql = "INSERT INTO CHITIET_PHIEUKKSL( SOPSL, MAHH, PHUONGTHUCKK, SOLUONGCT, SOLUONGTT, GHICHU) VALUES(@SOPSL, @MAHH, @PHUONGTHUCKK, @SOLUONGCT, @SOLUONGTT, @GHICHU) ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@SOPSL", SqlDbType.NChar).Value = CTKKSL.SOPSL;
                cmd.Parameters.Add("@MAHH", SqlDbType.NChar).Value = CTKKSL.MAHH;
                cmd.Parameters.Add("@PHUONGTHUCKK", SqlDbType.NVarChar).Value = CTKKSL.PHUONGTHUCKK;
                cmd.Parameters.Add("@SOLUONGCT", SqlDbType.Int).Value = CTKKSL.SOLUONGCT;
                cmd.Parameters.Add("@SOLUONGTT", SqlDbType.Int).Value = CTKKSL.SOLUONGTT;
                cmd.Parameters.Add("@GHICHU", SqlDbType.NVarChar).Value = CTKKSL.GHICHU;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool UpdateCT_KKSL(CT_KKSL CTKKSL)
        {
            string sql = "UPDATE CHITIET_PHIEUKKSL SET SOPSL = @SOPSL, MAHH = @MAHH, PHUONGTHUCKK = @PHUONGTHUCKK, SOLUONGCT = @SOLUONGCT, SOLUONGTT = @SOLUONGTT, GHICHU = @GHICHU WHERE SOPSL = @SOPSL ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@SOPSL", SqlDbType.NChar).Value = CTKKSL.SOPSL;
                cmd.Parameters.Add("@MAHH", SqlDbType.NChar).Value = CTKKSL.MAHH;
                cmd.Parameters.Add("@PHUONGTHUCKK", SqlDbType.NVarChar).Value = CTKKSL.PHUONGTHUCKK;
                cmd.Parameters.Add("@SOLUONGCT", SqlDbType.Int).Value = CTKKSL.SOLUONGCT;
                cmd.Parameters.Add("@SOLUONGTT", SqlDbType.Int).Value = CTKKSL.SOLUONGTT;
                cmd.Parameters.Add("@GHICHU", SqlDbType.NVarChar).Value = CTKKSL.GHICHU;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool DeleteCT_KKSL(CT_KKSL CTKKSL)
        {
            string sql = "DELETE CHITIET_PHIEUKKSL WHERE SOPSL = @SOPSL ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@SOPSL", SqlDbType.NChar).Value = CTKKSL.SOPSL;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable TimKiem_CTKKSL(string n)
        {
            string sql = "SELECT * FROM CHITIET_PHIEUKKSL WHERE SOPSL LIKE '%" + n + "%' OR MAHH LIKE N'%" + n + "%' OR PHUONGTHUCKK LIKE N'%" + n + "%' OR SOLUONGCT LIKE N'%" + n + "%' OR SOLUONGTT LIKE N'%" + n + "%' OR GHICHU LIKE N'%" + n + "%'";
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

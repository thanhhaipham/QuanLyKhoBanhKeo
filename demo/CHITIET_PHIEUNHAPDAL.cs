using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class CHITIET_PHIEUNHAPDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public CHITIET_PHIEUNHAPDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllCTPN()
        {
            string sql = "SELECT SOPN, C.MAHH, H.TENHH, SLGIAO, SLNHAN, C.DONGIA, SOHIEUDH FROM CHITIET_PHIEUNHAP C, HANGHOA H WHERE C.MAHH = H.MAHH";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool InsertCTPN(CHITIET_PHIEUNHAP c)
        {
            string sql = "INSERT INTO CHITIET_PHIEUNHAP(SOPN, MAHH, SLGIAO, SLNHAN, DONGIA, SOHIEUDH) VALUES(@SOPN, @MAHH, @SLGIAO, @SLNHAN, @DONGIA, @SOHIEUDH)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@SOPN", SqlDbType.NChar).Value = c.SOPN;
                cmd.Parameters.Add("@MAHH", SqlDbType.NChar).Value = c.MAHH;
                cmd.Parameters.Add("@SLGIAO", SqlDbType.Int).Value = c.SLGIAO;
                cmd.Parameters.Add("@SLNHAN", SqlDbType.Int).Value = c.SLNHAN;
                cmd.Parameters.Add("@DONGIA", SqlDbType.Int).Value = c.DONGIA;
                cmd.Parameters.Add("@SOHIEUDH", SqlDbType.NChar).Value = c.SOHIEUDH;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool UpdateCTPN(CHITIET_PHIEUNHAP c)
        {
            string sql = "UPDATE CHITIET_PHIEUNHAP SET MAHH = @MAHH, SLNHAN = @SLNHAN, SLGIAO = @SLGIAO, DONGIA = @DONGIA, SOHIEUDH = @SOHIEUDH WHERE SOPN = @SOPN AND MAHH = @MAHH";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@SOPN", SqlDbType.NChar).Value = c.SOPN;
                cmd.Parameters.Add("@MAHH", SqlDbType.NChar).Value = c.MAHH;
                cmd.Parameters.Add("@SLGIAO", SqlDbType.Int).Value = c.SLGIAO;
                cmd.Parameters.Add("@SLNHAN", SqlDbType.Int).Value = c.SLNHAN;
                cmd.Parameters.Add("@DONGIA", SqlDbType.Int).Value = c.DONGIA;
                cmd.Parameters.Add("@SOHIEUDH", SqlDbType.NChar).Value = c.SOHIEUDH;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool DeleteCTPN(CHITIET_PHIEUNHAP c)
        {
            string sql = "DELETE CHITIET_PHIEUNHAP WHERE SOPN = @SOPN AND MAHH = @MAHH";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@SOPN", SqlDbType.NChar).Value = c.SOPN;
                cmd.Parameters.Add("@MAHH", SqlDbType.NChar).Value = c.MAHH;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable FindCTPN(string c)
        {
            string sql = "SELECT SOPN, C.MAHH, H.TENHH, SLGIAO, SLNHAN, C.DONGIA, SOHIEUDH FROM CHITIET_PHIEUNHAP C, HANGHOA H WHERE C.MAHH = H.MAHH AND C.MAHH LIKE '%" + c + "%' OR SOPN LIKE '%" + c + "%' OR SLGIAO LIKE '%" + c + "%' OR SLNHAN LIKE '%" + c + "%' OR SOHIEUDH LIKE '%" + c + "%' OR C.DONGIA LIKE '%" + c + "%' OR SOHIEUDH LIKE '%" + c + "%'  ";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getAllCTPN1(string SOPN)
        {
            string sql = "SELECT SOPN, C.MAHH, H.TENHH, SLGIAO, SLNHAN, C.DONGIA, SOHIEUDH FROM CHITIET_PHIEUNHAP C, HANGHOA H WHERE C.SOPN LIKE '%" +SOPN+ "%'";
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


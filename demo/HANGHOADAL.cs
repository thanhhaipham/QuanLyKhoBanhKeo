using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class HANGHOADAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public HANGHOADAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllHH()
        {
            string sql = "SELECT MAHH, TENHH, DVT, DONGIA, HANGHOA.MANCC, NHACUNGCAP.TENNCC FROM HANGHOA, NHACUNGCAP WHERE HANGHOA.MANCC = NHACUNGCAP.MANCC"; 
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool InsertHangHoa(HANGHOA hh)
        {
            string sql = "INSERT INTO HANGHOA(MAHH, TENHH, DVT, DONGIA, MANCC) VALUES(@MAHH, @TENHH, @DVT, @DONGIA, @MANCC)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MAHH", SqlDbType.NChar).Value = hh.MAHH;
                cmd.Parameters.Add("@TENHH", SqlDbType.NVarChar).Value = hh.TENHH;
                cmd.Parameters.Add("@DVT", SqlDbType.NVarChar).Value = hh.DVT;
                cmd.Parameters.Add("@DONGIA", SqlDbType.Int).Value = hh.DONGIA;
                cmd.Parameters.Add("@MANCC", SqlDbType.NChar).Value = hh.MANCC;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception e)
            {
                return false;
            }
            return true;
        }
        public bool UpdateHangHoa(HANGHOA hh)
        {
            string sql = "UPDATE HANGHOA SET MAHH = @MAHH, TENHH = @TENHH, DONGIA = @DONGIA, DVT = @DVT, MANCC = @MANCC WHERE MAHH = @MAHH";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MAHH", SqlDbType.NChar).Value = hh.MAHH;
                cmd.Parameters.Add("@TENHH", SqlDbType.NVarChar).Value = hh.TENHH;
                cmd.Parameters.Add("@DVT", SqlDbType.NVarChar).Value = hh.DVT;
                cmd.Parameters.Add("@DONGIA", SqlDbType.Int).Value = hh.DONGIA;
                cmd.Parameters.Add("@MANCC", SqlDbType.NChar).Value = hh.MANCC;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool DeleteHangHoa(HANGHOA hh)
        {
            string sql = "DELETE HANGHOA WHERE MAHH = @MAHH";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MAHH", SqlDbType.NChar).Value = hh.MAHH;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable FindHangHoa(string hh)
        {
            string sql = "SELECT MAHH, TENHH, DVT, DONGIA, HANGHOA.MANCC, NHACUNGCAP.TENNCC FROM HANGHOA, NHACUNGCAP WHERE HANGHOA.MANCC = NHACUNGCAP.MANCC AND MAHH LIKE '%" + hh + "%' OR TENHH LIKE N'%" + hh + "%' OR DVT LIKE  N'%" + hh + "%' OR DONGIA LIKE '%" + hh + "%' OR TENNCC LIKE N'%" + hh + "%' OR HANGHOA.MANCC LIKE '%" + hh + "%' ";
            SqlConnection con = dc.getConnect();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }
    }
}

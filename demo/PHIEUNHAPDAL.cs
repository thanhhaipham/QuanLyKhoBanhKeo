using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class PHIEUNHAPDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public PHIEUNHAPDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllPN()
        {
            string sql = "SELECT SOPN, NGAYNHAP, PHIEUNHAP.MAKHO, PHIEUNHAP.MANCC, PHIEUNHAP.MANV, KHO.TENKHO, NHANVIEN.TENNV, NHACUNGCAP.TENNCC FROM PHIEUNHAP, NHACUNGCAP, NHANVIEN, KHO WHERE PHIEUNHAP.MAKHO = KHO.MAKHO AND PHIEUNHAP.MANV = NHANVIEN.MANV AND PHIEUNHAP.MANCC = NHACUNGCAP.MANCC";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool InsertPN(PHIEUNHAP pn)
        {
            string sql = "INSERT INTO PHIEUNHAP(SOPN, NGAYNHAP, MAKHO, MANCC, MANV) VALUES(@SOPN, @NGAYNHAP, @MAKHO, @MANCC, @MANV) ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@SOPN", SqlDbType.NChar).Value = pn.SOPN;
                cmd.Parameters.Add("@NGAYNHAP", SqlDbType.DateTime).Value = pn.NGAYNHAP;
                cmd.Parameters.Add("@MAKHO", SqlDbType.NChar).Value = pn.MAKHO;
                cmd.Parameters.Add("@MANV", SqlDbType.NChar).Value = pn.MANV;
                cmd.Parameters.Add("@MANCC", SqlDbType.NChar).Value = pn.MANCC;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool UpdatePN(PHIEUNHAP pn)
        {
            string sql = "UPDATE PHIEUNHAP SET SOPN = @SOPN, NGAYNHAP = @NGAYNHAP, MAKHO = @MAKHO, MANCC = @MANCC, MANV = @MANV WHERE SOPN = @SOPN";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@SOPN", SqlDbType.NChar).Value = pn.SOPN;
                cmd.Parameters.Add("@NGAYNHAP", SqlDbType.DateTime).Value = pn.NGAYNHAP;
                cmd.Parameters.Add("@MAKHO", SqlDbType.NChar).Value = pn.MAKHO;
                cmd.Parameters.Add("@MANV", SqlDbType.NChar).Value = pn.MANV;
                cmd.Parameters.Add("@MANCC", SqlDbType.NChar).Value = pn.MANCC;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception e)
            {
                return false;
            }
            return true;
        }
        public bool DeletePN(PHIEUNHAP pn)
        {
            string sql = "DELETE PHIEUNHAP WHERE SOPN = @SOPN";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@SOPN", SqlDbType.NChar).Value = pn.SOPN;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public DataTable FindPN(string p)
        {
            string sql = "SELECT SOPN, NGAYNHAP, PHIEUNHAP.MAKHO, PHIEUNHAP.MANCC, PHIEUNHAP.MANV, KHO.TENKHO, NHANVIEN.TENNV, NHACUNGCAP.TENNCC FROM PHIEUNHAP, NHACUNGCAP, NHANVIEN, KHO WHERE PHIEUNHAP.MAKHO = KHO.MAKHO AND PHIEUNHAP.MANV = NHANVIEN.MANV AND PHIEUNHAP.MANCC = NHACUNGCAP.MANCC AND SOPN LIKE '%" + p + "%' OR NGAYNHAP LIKE '%" + p + "%' OR PHIEUNHAP.MAKHO LIKE '%" + p + "%' OR PHIEUNHAP.MANCC LIKE '%" + p + "%' OR PHIEUNHAP.MANV LIKE '%" + p + "%' ";
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

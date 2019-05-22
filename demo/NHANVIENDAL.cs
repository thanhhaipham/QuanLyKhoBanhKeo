using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class NHANVIENDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public NHANVIENDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllNV()
        {
            string sql = "SELECT MANV, TENNV, NS, GT, SDTNV, LUONG, NHANVIEN.MAKHO, KHO.TENKHO FROM NHANVIEN, KHO WHERE NHANVIEN.MAKHO = KHO.MAKHO";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool InsertNhanVien(NHANVIEN nv)
        {
            string sql = "INSERT INTO NHANVIEN(MANV, TENNV, NS, GT, SDTNV, LUONG, MAKHO) VALUES(@MANV, @TENNV, @NS, @GT, @SDTNV, @LUONG, @MAKHO)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MANV", SqlDbType.NChar).Value = nv.MANV;
                cmd.Parameters.Add("@TENNV", SqlDbType.NVarChar).Value = nv.TENNV;
                cmd.Parameters.Add("@NS", SqlDbType.DateTime).Value = nv.NS;
                cmd.Parameters.Add("@GT", SqlDbType.NVarChar).Value = nv.GT;
                cmd.Parameters.Add("@SDTNV", SqlDbType.Int).Value = nv.SDTNV;
                cmd.Parameters.Add("@LUONG", SqlDbType.Int).Value = nv.LUONG;
                cmd.Parameters.Add("@MAKHO", SqlDbType.NChar).Value = nv.MAKHO;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception e)
            {
                return false;
            }
            return true;
        }
        public bool UpdateNhanVien(NHANVIEN nv)
        {
            string sql = "UPDATE NHANVIEN SET MANV = @MANV, TENNV = @TENNV, NS = @NS, GT = @GT, SDTNV = @SDTNV, LUONG = @LUONG, MAKHO = @MAKHO WHERE MANV = @MANV";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MANV", SqlDbType.NChar).Value = nv.MANV;
                cmd.Parameters.Add("@TENNV", SqlDbType.NVarChar).Value = nv.TENNV;
                cmd.Parameters.Add("@NS", SqlDbType.DateTime).Value = nv.NS;
                cmd.Parameters.Add("@GT", SqlDbType.NVarChar).Value = nv.GT;
                cmd.Parameters.Add("@SDTNV", SqlDbType.Int).Value = nv.SDTNV;
                cmd.Parameters.Add("@LUONG", SqlDbType.Int).Value = nv.LUONG;
                cmd.Parameters.Add("@MAKHO", SqlDbType.NChar).Value = nv.MAKHO;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool DeleteNhanVien(NHANVIEN nv)
        {
            string sql = "DELETE NHANVIEN WHERE MANV = @MANV";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MANV", SqlDbType.NChar).Value = nv.MANV;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable FindNhanVien(string nv)
        {
            string sql = "SELECT MANV, TENNV, NS, GT, SDTNV, LUONG, NHANVIEN.MAKHO, KHO.TENKHO FROM NHANVIEN, KHO WHERE NHANVIEN.MAKHO = KHO.MAKHO AND MANV LIKE '%" + nv + "%' OR TENNV LIKE N'%" + nv + "%' OR NS LIKE N'%" + nv + "%' OR GT LIKE N'%" + nv + "%' OR SDTNV LIKE '%" + nv + "%' OR LUONG LIKE '%" + nv + "%' OR NHANVIEN.MAKHO LIKE '%" + nv + "%' ";
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

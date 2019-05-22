using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class KHODAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public KHODAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllKho()
        {
            string sql = "SELECT KHO.MAKHO, TENKHO, DIACHIKHO, KHO.MATK, NHANVIEN.TENNV FROM KHO, NHANVIEN WHERE KHO.MATK = NHANVIEN.MANV";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getAllK6()
        {
            string sql = "SELECT KHO.MAKHO, TENKHO, DIACHIKHO, TENNV FROM KHO, NHANVIEN WHERE KHO.MATK = NHANVIEN.MANV AND KHO.MAKHO LIKE 'K6%'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getAllK7()
        {
            string sql = "SELECT KHO.MAKHO, TENKHO, DIACHIKHO, TENNV FROM KHO, NHANVIEN WHERE KHO.MATK = NHANVIEN.MANV AND KHO.MAKHO LIKE 'K7%'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getAllK8()
        {
            string sql = "SELECT KHO.MAKHO, TENKHO, DIACHIKHO, TENNV FROM KHO, NHANVIEN WHERE KHO.MATK = NHANVIEN.MANV AND KHO.MAKHO LIKE 'K8%'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getAllK9()
        {
            string sql = "SELECT KHO.MAKHO, TENKHO, DIACHIKHO, TENNV FROM KHO, NHANVIEN WHERE KHO.MATK = NHANVIEN.MANV AND KHO.MAKHO LIKE 'K9%'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getAllK10()
        {
            string sql = "SELECT KHO.MAKHO, TENKHO, DIACHIKHO, TENNV FROM KHO, NHANVIEN WHERE KHO.MATK = NHANVIEN.MANV AND KHO.MAKHO LIKE 'K10%'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool InsertKho(KHO k)
        {
            string sql = "INSERT INTO KHO(MAKHO, TENKHO, DIACHIKHO, MATK) VALUES(@MAKHO, @TENKHO, @DIACHIKHO, @MATK)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MAKHO", SqlDbType.NChar).Value = k.MAKHO;
                cmd.Parameters.Add("@TENKHO", SqlDbType.NVarChar).Value = k.TENKHO;
                cmd.Parameters.Add("@DIACHIKHO", SqlDbType.NVarChar).Value = k.DIACHIKHO;
                cmd.Parameters.Add("@MATK", SqlDbType.NChar).Value = k.MATK;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception e)
            {
                return false;
            }
            return true;
        }
        public bool UpdateKho(KHO k)
        {
            string sql = "UPDATE KHO SET MAKHO = @MAKHO, TENKHO = @TENKHO, DIACHIKHO = @DIACHIKHO, MATK = @MATK WHERE MAKHO = @MAKHO";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MAKHO", SqlDbType.NChar).Value = k.MAKHO;
                cmd.Parameters.Add("@TENKHO", SqlDbType.NVarChar).Value = k.TENKHO;
                cmd.Parameters.Add("@DIACHIKHO", SqlDbType.NVarChar).Value = k.DIACHIKHO;
                cmd.Parameters.Add("@MATK", SqlDbType.NChar).Value = k.MATK;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception e)
            {
                return false;
            }
            return true;
        }
        public bool DeleteKho(KHO k)
        {
            string sql = "DELETE KHO WHERE MAKHO = @MAKHO";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("MAKHO", SqlDbType.NChar).Value = k.MAKHO;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable FindKho(string k)
        {
            string sql = "SELECT KHO.MAKHO, TENKHO, DIACHIKHO, KHO.MATK, NHANVIEN.TENNV FROM KHO, NHANVIEN WHERE KHO.MATK = NHANVIEN.MANV AND KHO.MAKHO LIKE '%" + k + "%' OR TENKHO LIKE N'%" + k + "%' OR DIACHIKHO LIKE N'%" + k + "%' OR NHANVIEN.TENNV LIKE N'%" + k + "%'";
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



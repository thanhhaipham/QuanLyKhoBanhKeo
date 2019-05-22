using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using demo;

namespace ThucTapNhom
{
    class PHIEUXUATDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;

        public PHIEUXUATDAL()
        {
            dc = new DataConnection();
        }

        public DataTable getAllPHIEUXUAT()
        {
            string sql = "SELECT * FROM PHIEUXUAT";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();

            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Close();

            return dt;
        }
        public bool InsertPHIEUXUAT(PHIEU_XUAT px)
        {
            string sql = "INSERT INTO PHIEUXUAT (SOPX, NGAYXUAT, MAKHO, TENKH) VALUES (@SOPX, @NGAYXUAT, @MAKHO, @TENKH) ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@SOPX", SqlDbType.NChar).Value = px.SOPX;
                cmd.Parameters.Add("@NGAYXUAT", SqlDbType.DateTime).Value = px.NGAYXUAT;
                cmd.Parameters.Add("@MAKHO", SqlDbType.NChar).Value = px.NGAYXUAT;
                cmd.Parameters.Add("@TENKH", SqlDbType.NVarChar).Value = px.TENKH;
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool UpdatePHIEUXUAT(PHIEU_XUAT px)
        {
            string sql = "UPDATE PHIEUXUAT SET NGAYXUAT = @NGAYXUAT, MAKHO=@MAKHO, TENKH=@TENKH WHERE SOPX = @SOPX  ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@SOPX", SqlDbType.NChar).Value = px.SOPX;
                cmd.Parameters.Add("@NGAYXUAT", SqlDbType.DateTime).Value = px.NGAYXUAT;
                cmd.Parameters.Add("@MAKHO", SqlDbType.NChar).Value = px.NGAYXUAT;
                cmd.Parameters.Add("@TENKH", SqlDbType.NVarChar).Value = px.TENKH;
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool DeletePHIEUXUAT(PHIEU_XUAT px)
        {
            string sql = "DELETE PHIEUXUAT WHERE SOPX = @SOPX ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@SOPX", SqlDbType.NChar).Value = px.SOPX;
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable FindPHIEUXUAT(string p)
        {
            string sql = "SELECT SOPX, NGAYXUAT, MAKHO, TENKH FROM PHIEUXUAT  WHERE SOPX LIKE '%" + p + "%' OR NGAYXUAT LIKE '%" + p + "%' OR MAKHO LIKE '%" + p + "%' OR TENKH LIKE N'%" + p + "%'";
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

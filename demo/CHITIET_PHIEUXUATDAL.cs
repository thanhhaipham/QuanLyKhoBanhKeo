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
    class CHITIET_PHIEUXUATDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;

        public CHITIET_PHIEUXUATDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllCHITIET_PHIEUXUAT()
        {
            string sql = "SELECT * FROM CHITIET_PHIEUXUAT";

            SqlConnection con = dc.getConnect();

            da = new SqlDataAdapter(sql, con);

            con.Open();

            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Close();

            return dt;
        }

        public bool InsertCHITIET_PHIEUXUAT(CHITIET_PHIEUXUAT ct)
        {
            string sql = "INSERT INTO CHITIET_PHIEUXUAT (SOPX, MAHH, SLXUAT) VALUES (@SOPX, @MAHH, @SLXUAT) ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@SOPX", SqlDbType.NChar).Value = ct.SOPX;
                cmd.Parameters.Add("@MAHH", SqlDbType.NChar).Value = ct.MAHH;
                cmd.Parameters.Add("@SLXUAT", SqlDbType.Int).Value = ct.SLXUAT;
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch(Exception e)
            {
                return false;
            }
            return true;
        }
        public bool UpdateCHITIET_PHIEUXUAT(CHITIET_PHIEUXUAT ct)
        {
            string sql = "UPDATE CHITIET_PHIEUXUAT SET MAHH = @MAHH, SLXUAT=@SLXUAT WHERE SOPX = @SOPX  ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@SOPX", SqlDbType.NChar).Value = ct.SOPX;
                cmd.Parameters.Add("@MAHH", SqlDbType.NChar).Value = ct.MAHH;
                cmd.Parameters.Add("@SLXUAT", SqlDbType.Int).Value = ct.SLXUAT;
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool DeleteCHITIET_PHIEUXUAT(CHITIET_PHIEUXUAT ct)
        {
            string sql = "DELETE CHITIET_PHIEUXUAT WHERE SOPX = @SOPX ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@SOPX", SqlDbType.NChar).Value = ct.SOPX;
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable FindCHITIET_PHIEUXUAT(string c)
        {
            string sql = "select SOPX, MAHH, SLXUAT FROM CHITIET_PHIEUXUAT WHERE SOPX LIKE '%"+c+"%' OR MAHH LIKE '%"+c+"%' OR SLXUAT LIKE '%"+c+"%'";
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

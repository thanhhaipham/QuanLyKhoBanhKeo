using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class NHACUNGCAPDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public NHACUNGCAPDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllNCC()
        {
            string sql = "SELECT * FROM NHACUNGCAP";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool InsertNCC(NHACUNGCAP ncc)
        {
            string sql = "INSERT INTO NHACUNGCAP(MANCC, TENNCC, DIACHINCC, SDTNCC) VALUES(@MANCC, @TENNCC, @DIACHINCC, @SDTNCC)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MANCC", SqlDbType.NChar).Value = ncc.MANCC;
                cmd.Parameters.Add("@TENNCC", SqlDbType.NVarChar).Value = ncc.TENNCC;
                cmd.Parameters.Add("@DIACHINCC", SqlDbType.NVarChar).Value = ncc.DIACHINCC;
                cmd.Parameters.Add("@SDTNCC", SqlDbType.Int).Value = ncc.SDTNCC;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool UpdateNCC(NHACUNGCAP ncc)
        {
            string sql = "UPDATE NHACUNGCAP SET MANCC = @MANCC, TENNCC = @TENNCC, DIACHINCC = @DIACHINCC, SDTNCC = @SDTNCC WHERE MANCC = @MANCC ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MANCC", SqlDbType.NChar).Value = ncc.MANCC;
                cmd.Parameters.Add("@TENNCC", SqlDbType.NVarChar).Value = ncc.TENNCC;
                cmd.Parameters.Add("@DIACHINCC", SqlDbType.NVarChar).Value = ncc.DIACHINCC;
                cmd.Parameters.Add("@SDTNCC", SqlDbType.Int).Value = ncc.SDTNCC;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool DeleteNCC(NHACUNGCAP ncc)
        {
            string sql = "DELETE NHACUNGCAP WHERE MANCC = @MANCC ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MANCC", SqlDbType.NChar).Value = ncc.MANCC;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable FindNCC(string n)
        {
            string sql = "SELECT * FROM NHACUNGCAP WHERE MANCC LIKE '%" + n + "%' OR TENNCC LIKE N'%" + n + "%' OR DIACHINCC LIKE N'%" + n + "%' OR SDTNCC LIKE '%" + n + "%'";
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

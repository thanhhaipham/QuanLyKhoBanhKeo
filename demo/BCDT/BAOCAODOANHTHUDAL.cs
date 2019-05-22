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
    class BAOCAODOANHTHUDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;

        public BAOCAODOANHTHUDAL()
        {
            dc = new DataConnection();
        }

        public DataTable getAllBCDT()
        {
            string sql = "SELECT * FROM PHIEUBCDT";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();

            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool InsertPBCDT(BCDT bc)
        {
            string sql = "INSERT INTO PHIEUBCDT (SOPBC, MAKHO, TUNGAY, DENNGAY, SOPX) VALUES (@SOPBC, @MAKHO, @TUNGAY, @DENNGAY, @SOPX) ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@SOPBC", SqlDbType.NChar).Value = bc.SOPBC;
                cmd.Parameters.Add("@MAKHO", SqlDbType.NChar).Value = bc.MAKHO;
                cmd.Parameters.Add("@TUNGAY", SqlDbType.Date).Value = bc.TUNGAY;
                cmd.Parameters.Add("@DENNGAY", SqlDbType.Date).Value = bc.DENNGAY;
                cmd.Parameters.Add("@SOPX", SqlDbType.NChar).Value = bc.SOPX;
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool UpdatePBCDT(BCDT bc)
        {
            string sql = "UPDATE PHIEUBCDT SET MAKHO=@MAKHO, TUNGAY=@TUNGAY, DENNGAY=@DENNGAY, SOPX=@SOPX WHERE SOPBC = @SOPBC  ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@SOPBC", SqlDbType.NChar).Value = bc.SOPBC;
                cmd.Parameters.Add("@MAKHO", SqlDbType.NChar).Value = bc.MAKHO;
                cmd.Parameters.Add("@TUNGAY", SqlDbType.Date).Value = bc.TUNGAY;
                cmd.Parameters.Add("@DENNGAY", SqlDbType.Date).Value = bc.DENNGAY;
                cmd.Parameters.Add("@SOPX", SqlDbType.NChar).Value = bc.SOPX;
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool DeletePBCDT(BCDT bc)
        {
            string sql = "DELETE PHIEUBCDT WHERE SOPBC = @SOPBC ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@SOPBC", SqlDbType.NChar).Value = bc.SOPBC;
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable FindPBCDT(string b)
        {
            string sql = "SELECT SOPBC, MAKHO, TUNGAY, DENNGAY, SOPX FROM PHIEUBCDT  WHERE SOPBC LIKE '%" + b + "%' OR MAKHO LIKE '%" + b + "%' OR TUNGAY LIKE '%" + b + "%' OR DENNGAY LIKE '%" + b + "%' OR SOPX LIKE '%" + b +"%' ";
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

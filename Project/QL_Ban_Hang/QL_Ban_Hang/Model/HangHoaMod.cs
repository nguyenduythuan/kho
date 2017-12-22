using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QL_Ban_Hang.Object;

namespace QL_Ban_Hang.Model
{
    class HangHoaMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();
        public DataTable GetSL()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = ("select SoLuong  from HangHoa ");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                con.CloseConn();


            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();

            }
            return dt;
        }
        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = ("select * from HangHoa") ;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                con.CloseConn();


            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();

            }
            return dt;
        }
        public bool UpdSL(string mahh, int SL)
        {
            cmd.CommandText = "Update HangHoa set  SoLuong = " + SL + " Where MaHH = '" + mahh + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }
        public bool AddData(HangHoaObj hhobj)
        {
            cmd.CommandText = "Insert into HangHoa values('" + hhobj.MaHangHoa + "',N'" + hhobj.TenHangHoa + "','" + hhobj.Gia + "','" + hhobj.Soluong + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                con.CloseConn();
                return true;

            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();

            }
            return false;
        }
      
        public bool DelData(string ma)
        {
            cmd.CommandText = "Delete HangHoa Where MaHH = '" + ma + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }

    }
}

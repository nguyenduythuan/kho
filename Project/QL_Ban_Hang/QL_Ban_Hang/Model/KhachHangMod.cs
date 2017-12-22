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
    class KhachHangMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();
        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = ("select * from KhachHang");
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
        public bool AddData(KhachHangObj nvobj)
        {
            cmd.CommandText = "Insert into KhachHang values('" + nvobj.MaKhachHang + "',N'" + nvobj.TenKhachHang + "',N'" + nvobj.GioiTinh + "',N'" + nvobj.DiaChi + "','" + nvobj.SDT + "')";
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
            cmd.CommandText = "Delete KhachHang Where MaKH = '" + ma + "'";
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


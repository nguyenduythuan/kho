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
    class ChiTietHoaDonMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();
        public DataTable GetData(string ma)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = cmd.CommandText = @"select ct.MaHD, hh.TenHH HangHoa, ct.DonGia, ct.SoLuong , ct.SoLuong*ct.DonGia ThanhTien from ChiTietHD ct, HangHoa hh where ct.MaHH = hh.MaHH and MaHD='" + ma+"'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();

            }
            return dt;
        }
       
        public bool AddData(ChiTietHoaDonObj ctobj)
        {
            cmd.CommandText = "Insert into ChiTietHD values('" + ctobj.MaHoaDon + "','" + ctobj.MaHangHoa + "'," + ctobj.SoLuong + "," + ctobj.DonGia + ")";
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
            cmd.CommandText = "Delete ChiTietHD Where MaHD = '" + ma + "'";
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

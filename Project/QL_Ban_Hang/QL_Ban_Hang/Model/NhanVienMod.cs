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
    class NhanVienMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();
        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = ("select * from NhanVien");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                con.CloseConn();


            }
            catch (Exception ex )
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();

            }
            return dt;
        }
        public bool AddData(NhanVienObj nvobj)
        {
            cmd.CommandText = "Insert into NhanVien values('"+nvobj.MaNhanVien+ "',N'"+nvobj.TenNhanVien+"',N'"+nvobj.GioiTinh+"',N'"+nvobj.DiaChi + "','"+nvobj.SDT+"','"+nvobj.MatKhau+"')";
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
        //public bool UpdData(NhanVienObj nvobj) 
        //{
            
        //    cmd.CommandText = "update NhanVien set MaNV = '"+nvobj.MaNhanVien+"', TenNV = N'"+nvobj.TenNhanVien+"', GioiTinh = '"+nvobj.GioiTinh+"',DiaChi = N'"+nvobj.DiaChi+"',SDT = '"+nvobj.SDT+"'";
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Connection = con.Connection;
        //    try
        //    {
        //        con.OpenConn();
        //        cmd.ExecuteNonQuery();
        //        con.CloseConn();
        //        return true;

        //    }
        //    catch (Exception ex)
        //    {
        //        string mex = ex.Message;
        //        cmd.Dispose();
        //        con.CloseConn();

        //    }
        //    return false;
        //}
        public bool UpdMK(NhanVienObj nvObj)
        {
            cmd.CommandText = "Update NhanVien set MatKhau ='" + nvObj.MatKhau + "' Where MaNV = '" + nvObj.MaNhanVien + "'";
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
        public bool DelData(string ma)
        {
            cmd.CommandText = "Delete NhanVien Where MaNV = '" + ma + "'";
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

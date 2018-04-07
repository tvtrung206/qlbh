using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLy;


namespace DAL_QuanLy
{
public   class DAL_KhachHang : DBConnect
    {
        /// <summary>
        /// Hàm trả về danh sách khách hàng
        /// </summary>
        /// <returns>dt</returns>
        public DataTable getKhachHang()
        {
            DataTable dataTable = new DataTable();
            try
            {
                string SQL = string.Format("SELECT * FROM KHACHHANG");
                SqlDataAdapter dt = new SqlDataAdapter(SQL, openConnect());
                dt.Fill(dataTable);
            }
            catch (Exception e)
            {
                Console.Write("Loi: " + e);                
            }
           
            return dataTable;
        }
        /// <summary>
        /// Thêm khách hàng
        /// </summary>
        /// <param name="kh"></param>
        /// <returns>true</returns>
        public bool themKhachHang(DTO_KhachHang kh)
        {
            try
            {
                // Mo KetNoi
                openConnect();
                //query
                string SQL = string.Format("INSERT INTO KHACHHANG(KH_NAME,KH_ADDRESS,KH_PHONE) VALUES('{0}','{1}','{2}')", kh.KH_NAME, kh.KH_ADDRESS, kh.KH_PHONE);
                // Mac dinh SqlCommand  para la chuoi
                SqlCommand cmd = new SqlCommand(SQL, openConnect());
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.Write(e.StackTrace.ToString());
                return false;
            }
            finally
            {
                closeConnect();
            }
            return false;
        }

        public bool suaKhachHang(DTO_KhachHang kh)
        {
            try
            {
                //Mở kết nối
                //_conn.Open();

                //Query
                string SQL = string.Format("UPDATE KHACHHANG SET KH_NAME='{0}', KH_ADDRESS='{1}', KH_PHONE='{2}' WHERE KH_ID={3}", kh.KH_NAME, kh.KH_ADDRESS, kh.KH_PHONE, kh.KH_ID);

                //SqlCommand
                SqlCommand cmd = new SqlCommand(SQL, openConnect());

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.Write(e.StackTrace.ToString());
                return false;
            }
            finally
            {
                closeConnect();
            }
            return false;
        }
        public bool xoaKhachHang(int KH_ID)
        {
            try
            {
                // Ket Noi
                //_conn.Open();

                //Query
                string SQL = string.Format("DELETE KHACHHANG WHERE KH_ID={0}", KH_ID);
                SqlCommand cmd = new SqlCommand(SQL, openConnect());
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

                Console.Write(e.StackTrace.ToString());
                return false;
            }
            finally
            {
               closeConnect();
            }
            return false;
        }

        public DataTable getKhachHangByName(string name)
        {
            DataTable dt = new DataTable();
            try
            {
                
                string SQL = string.Format("SELECT * FROM KHACHHANG WHERE KH_NAME LIKE '%{0}%'", name);
                SqlDataAdapter dtA = new SqlDataAdapter(SQL, openConnect());
                dtA.Fill(dt);
            }
            catch (Exception e)
            {

                Console.Write(e.StackTrace.ToString());
            }
           
            return dt;
        }
        
       
    }
}

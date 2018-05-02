using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLy;


namespace DAL_QuanLy
{
public   class DAL_LoaiSanPham : DBConnect
    {
        /// <summary>
        /// Hàm trả về danh sách khách hàng
        /// </summary>
        /// <returns>dt</returns>
        public DataTable getLoaiSanPham()
        {
            DataTable dataTable = new DataTable();
            try
            {
                string SQL = string.Format("SELECT * FROM LOAISANPHAM");
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
        /// Thêm Loại sản phẩm
        /// </summary>
        /// <param name="lsp"></param>
        /// <returns>true</returns>
        public bool themLoaiSanPham(DTO_LoaiSanPham lsp)
        {
            try
            {
                // Mo KetNoi
                openConnect();
                //query
                string SQL = string.Format("INSERT INTO LOAISANPHAM(LSP_NAME,LSP_DVT) VALUES(N'{0}',N'{1}')", lsp.LSP_NAME, lsp.LSP_DVT);
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

        public bool suaLoaiSanPham(DTO_LoaiSanPham lsp)
        {
            try
            {
                //Mở kết nối
                //_conn.Open();
                
                //Query
                string SQL = string.Format("UPDATE LOAISANPHAM SET LSP_NAME=N'{0}', LSP_DVT=N'{1}'  WHERE LSP_ID={2}", lsp.LSP_NAME, lsp.LSP_DVT,lsp.LSP_ID);

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
        public bool xoaLoaiSanPham(int LSP_ID)
        {
            try
            {
                // Ket Noi
                //_conn.Open();

                //Query
                string SQL = string.Format("DELETE LOAISANPHAM WHERE LSP_ID={0}", LSP_ID);
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

        public DataTable getLoaiSanPhamByName(string name)
        {
            DataTable dt = new DataTable();
            try
            {
                
                string SQL = string.Format("SELECT * FROM LOAISANPHAM WHERE LSP_NAME LIKE '%{0}%'", name);
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

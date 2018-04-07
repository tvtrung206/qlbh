using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DAL_QuanLy
{
    public class DBConnect
    {
      private  SqlConnection _conn = new SqlConnection("Data Source=VTRUNG-PC\\SQLEXPRESS;Initial Catalog=QLBH_QuangXieu;Integrated Security=True");
        public SqlConnection openConnect()
        {

            try
            {
                if (_conn.State == ConnectionState.Closed || _conn.State ==
                     ConnectionState.Broken)
                {
                    _conn.Open();
                }
            }
            catch (Exception )
            {

                Console.WriteLine("Loi Ket Noi");
                throw;
            }
                       
            return _conn;
        }

        public SqlConnection closeConnect()
        {
           if(_conn.State==ConnectionState.Open|| _conn.State!=ConnectionState.Broken)
            {
                _conn.Close();
            }
            return _conn;
        }
         
    }
}

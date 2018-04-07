using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO_QuanLy;
using DAL_QuanLy;

namespace BUS_QuanLy
{
 public  class BUS_KhachHang
    {
        DAL_KhachHang dalKhachHang = new DAL_KhachHang();
        public DataTable getKhachHang()
        {
            return dalKhachHang.getKhachHang();
        }
        public bool themKhachHang(DTO_KhachHang kh)
        {
            return dalKhachHang.themKhachHang(kh);
        }
        public bool suaKhachHang(DTO_KhachHang kh)
        {
            return dalKhachHang.suaKhachHang(kh);
        }

        public bool xoaKhachHang(int KH_ID)
        {
            return dalKhachHang.xoaKhachHang(KH_ID);
        }
        public DataTable getKhachHangByName(string name)
        {
            return dalKhachHang.getKhachHangByName(name);
        }
    }
}

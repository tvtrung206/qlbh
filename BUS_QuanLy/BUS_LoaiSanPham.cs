using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO_QuanLy;
using DAL_QuanLy;

namespace BUS_QuanLy
{
 public  class BUS_LoaiSanPham
    {
        DAL_LoaiSanPham dalLoaiSanPham = new DAL_LoaiSanPham();
        public DataTable getLoaiSanPham()
        {
            return dalLoaiSanPham.getLoaiSanPham();
        }
        public bool themLoaiSanPham(DTO_LoaiSanPham ob)
        {
            return dalLoaiSanPham.themLoaiSanPham(ob);
        }
        public bool suaLoaiSanPham(DTO_LoaiSanPham ob)
        {
            return dalLoaiSanPham.suaLoaiSanPham(ob);
        }

        public bool xoaLoaiSanPham(int ID)
        {
            return dalLoaiSanPham.xoaLoaiSanPham(ID);
        }
        public DataTable getLoaiSanPhamByName(string name)
        {
            return dalLoaiSanPham.getLoaiSanPhamByName(name);
        }
    }
}

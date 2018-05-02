using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLy
{
    public class DTO_LoaiSanPham
    {
        private int _LSP_ID;
        private string _LSP_NAME;
        private string _LSP_DVT;
       

        public int LSP_ID
        {
            get { return _LSP_ID; }
            set { _LSP_ID = value; }
        }
        public string LSP_NAME
        {
            get { return _LSP_NAME; }
            set { _LSP_NAME = value; }
        }
        public string LSP_DVT
        {
            get { return _LSP_DVT; }
            set { _LSP_DVT = value; }
        }

        // CONSTRUCTOR
        public DTO_LoaiSanPham()
        {

        }
        public DTO_LoaiSanPham(int id, string name, string dvt)
        {
            this.LSP_ID =  id;
            this.LSP_NAME = name.Trim();
            this.LSP_DVT = dvt.Trim();
            
        }
    }
}

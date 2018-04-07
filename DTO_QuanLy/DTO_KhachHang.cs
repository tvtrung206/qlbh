using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLy
{
    public class DTO_KhachHang
    {
        private int _KH_ID;
        private string _KH_NAME;
        private string _KH_ADDRESS;
        private string _KH_PHONE;

        public int KH_ID
        {
            get { return _KH_ID; }
            set { _KH_ID = value; }
        }
        public string KH_NAME
        {
            get { return _KH_NAME; }
            set { _KH_NAME = value; }
        }
        public string KH_PHONE
        {
            get { return _KH_PHONE; }
            set { _KH_PHONE = value; }
        }
        public string KH_ADDRESS
        {
            get { return _KH_ADDRESS; }
            set { _KH_ADDRESS = value; }
        }

        // CONSTRUCTOR
        public DTO_KhachHang()
        {

        }
        public DTO_KhachHang(int id, string name, string address, string phone)
        {
            this.KH_ID =  id;
            this.KH_NAME = name.Trim();
            this.KH_ADDRESS = address.Trim();
            this.KH_PHONE = phone.Trim();
        }
    }
}

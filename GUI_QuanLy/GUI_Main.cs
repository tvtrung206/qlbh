using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO_QuanLy;
using BUS_QuanLy;

namespace GUI_QuanLy
{
    public partial class GUI_QuanLy : DevExpress.XtraBars.TabForm
    {
        BUS_KhachHang buskh = new BUS_KhachHang();
        public GUI_QuanLy()
        {
            InitializeComponent();
        }
        void OnOuterFormCreating(object sender, OuterFormCreatingEventArgs e)
        {
            GUI_QuanLy form = new GUI_QuanLy();
            form.TabFormControl.Pages.Clear();
            e.Form = form;
            OpenFormCount++;
        }
        static int OpenFormCount = 1;

        private void GUI_QuanLy_Load(object sender, EventArgs e)
        {
            
            grdKhachhang_PKhachHang.DataSource = buskh.getKhachHang();
           
        }


        private void btnCreate_PKhachHang_Click(object sender, EventArgs e)
        {
            clearAll();
            grdKhachhang_PKhachHang.DataSource = buskh.getKhachHang();
        }

        private void btnPrefesh_PKhachhang_Click(object sender, EventArgs e)
        {
            grdKhachhang_PKhachHang.DataSource = buskh.getKhachHang();
        }

        private void grdKhachhang_PKhachHang_Click(object sender, EventArgs e)
        {
            //GetFocusedRowCellValue  là giấy giá trị từ cell theo tên trường trong csdl. devexpress
            // Console.Write(grdKhachhang.GetFocusedRowCellValue("KH_ID").ToString());
            txtName_PKhachHang.Text = grdKhachhang.GetFocusedRowCellValue("KH_NAME").ToString().Trim();
            txtAddress_PKhachHang.Text = grdKhachhang.GetFocusedRowCellValue("KH_ADDRESS").ToString().Trim();
            txtPhone_PKhachHang.Text = grdKhachhang.GetFocusedRowCellValue("KH_PHONE").ToString().Trim();
            txtidKhachHang.Text = grdKhachhang.GetFocusedRowCellValue("KH_ID").ToString().Trim();

        }

        private void btnDelete_PKhachhang_Click(object sender, EventArgs e)
        {
            //Lấy id 
            int idkh = Convert.ToInt16(grdKhachhang.GetFocusedRowCellValue("KH_ID").ToString());            
            DialogResult dialogResult = MessageBox.Show("Chọn `Yes` nếu đồng ý xóa","Thông báo!", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                buskh.xoaKhachHang(idkh);
                MessageBox.Show("Xóa thành công");
                clearAll();                
            }
           
        }


        private void btnSave_PKhachHang_Click(object sender, EventArgs e)
        {

            if (txtName_PKhachHang.Text != "" && txtAddress_PKhachHang.Text !="" && txtPhone_PKhachHang.Text!="")
            {
                if(txtidKhachHang.Text!="")
                {
                    int id = Convert.ToInt16(txtidKhachHang.Text);
                    DTO_KhachHang dtokh = new DTO_KhachHang(id, txtName_PKhachHang.Text, txtAddress_PKhachHang.Text, txtPhone_PKhachHang.Text);
                    if(buskh.suaKhachHang(dtokh))
                    {
                        MessageBox.Show("Cập nhật hoàn tất");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại");
                    }
                }
                else
                {
                    // toi tao doi tuong
                    DTO_KhachHang dtokh = new DTO_KhachHang(0, txtName_PKhachHang.Text, txtAddress_PKhachHang.Text, txtPhone_PKhachHang.Text);
                    // dùng buss thêm đối tượng
                    if (buskh.themKhachHang(dtokh))
                    {
                        MessageBox.Show("Thêm thành công");

                    }
                    else
                    {
                        MessageBox.Show("Không thêm được");
                    }
                }

                clearAll();
            }
            else
            {
                MessageBox.Show("Nhập thông tin đầy đủ ở  các ô có `*`;");
            }
        }
        private void clearAll()
        {
            txtAddress_PKhachHang.Text = "";
            txtName_PKhachHang.Text = "";
            txtPhone_PKhachHang.Text = "";
            txtidKhachHang.Text = "";
            grdKhachhang_PKhachHang.DataSource = buskh.getKhachHang();
        }

    }
}

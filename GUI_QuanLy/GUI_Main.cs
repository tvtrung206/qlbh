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
        BUS_LoaiSanPham busloaisanpham = new BUS_LoaiSanPham();
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

        // Khach hang  // 
        
        private void GUI_QuanLy_Load(object sender, EventArgs e)
        {
            
            grdKhachhang_PKhachHang.DataSource = buskh.getKhachHang();
            gridControlLSP.DataSource = busloaisanpham.getLoaiSanPham();
           
        }

        private void btnCreate_PKhachHang_Click(object sender, EventArgs e)
        {
            clearKhachHang();
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
                clearKhachHang();                
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

                clearKhachHang();
            }
            else
            {
                MessageBox.Show("Nhập thông tin đầy đủ ở  các ô có `*`;");
            }
        }
        private void clearKhachHang()
        {
            txtAddress_PKhachHang.Text = "";
            txtName_PKhachHang.Text = "";
            txtPhone_PKhachHang.Text = "";
            txtidKhachHang.Text = "";
            grdKhachhang_PKhachHang.DataSource = buskh.getKhachHang();
        }

     


        // Loai San Pham  // 
        // ******************************************** //
        private void clearLoaiSanPham()
        {
            txtNAMELSP.Text = "";
            txtIDLSP.Text = "";
            txtDVTLSP.Text = "";
            gridControlLSP.DataSource = busloaisanpham.getLoaiSanPham();
            
        }

        private void btnCreateLSP_Click(object sender, EventArgs e)
        {
            clearLoaiSanPham();
            gridControlLSP.DataSource = busloaisanpham.getLoaiSanPham();
        }

        private void btnSaveLSP_Click(object sender, EventArgs e)
        {
            if (txtNAMELSP.Text != "" && txtDVTLSP.Text != "")
            {
                if (txtIDLSP.Text != "")
                {
                    int id = Convert.ToInt16(txtIDLSP.Text);
                    DTO_LoaiSanPham dtolsp = new DTO_LoaiSanPham(id,txtNAMELSP.Text, txtDVTLSP.Text);
                    if (busloaisanpham.suaLoaiSanPham(dtolsp))
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
                    DTO_LoaiSanPham dtolsp = new DTO_LoaiSanPham(0, txtNAMELSP.Text, txtDVTLSP.Text);
                    // dùng buss thêm đối tượng
                    if (busloaisanpham.themLoaiSanPham(dtolsp))
                    {
                        MessageBox.Show("Thêm thành công");

                    }
                    else
                    {
                        MessageBox.Show("Không thêm được");
                    }
                }

                clearLoaiSanPham();
            }
            else
            {
                MessageBox.Show("Nhập thông tin đầy đủ ở  các ô có `*`;");
            }
        }

        private void gridControlLSP_Click(object sender, EventArgs e)
        {
            //GetFocusedRowCellValue  là giấy giá trị từ cell theo tên trường trong csdl. devexpress
            // Console.Write(grdKhachhang.GetFocusedRowCellValue("KH_ID").ToString());
            txtNAMELSP.Text = gridViewLSP.GetFocusedRowCellValue("LSP_NAME").ToString().Trim();
            txtDVTLSP.Text = gridViewLSP.GetFocusedRowCellValue("LSP_DVT").ToString().Trim();
            txtIDLSP.Text = gridViewLSP.GetFocusedRowCellValue("LSP_ID").ToString().Trim();
        }

        private void btnCanceLSP_Click(object sender, EventArgs e)
        {
            clearLoaiSanPham();
        }

        private void btnF5LSP_Click(object sender, EventArgs e)
        {
            gridControlLSP.DataSource = busloaisanpham.getLoaiSanPham();
        }

        private void btnDeleteLSP_Click(object sender, EventArgs e)
        {
            //Lấy id 
            int id = Convert.ToInt16(gridViewLSP.GetFocusedRowCellValue("LSP_ID").ToString());
            DialogResult dialogResult = MessageBox.Show("Chọn `Yes` nếu đồng ý xóa", "Thông báo!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                busloaisanpham.xoaLoaiSanPham(id);
                MessageBox.Show("Xóa thành công");
                clearLoaiSanPham();
            }
        }
    }
}

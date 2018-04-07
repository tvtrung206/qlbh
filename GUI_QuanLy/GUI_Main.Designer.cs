namespace GUI_QuanLy
{
    partial class GUI_QuanLy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            if (--OpenFormCount == 0) System.Windows.Forms.Application.Exit();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_QuanLy));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.tab_Main = new DevExpress.XtraBars.TabFormControl();
            this.tabFormDefaultManager1 = new DevExpress.XtraBars.TabFormDefaultManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tabPageBanhang = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit9 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit8 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit10 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.searchControl2 = new DevExpress.XtraEditors.SearchControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnCancePBanHang = new DevExpress.XtraEditors.SimpleButton();
            this.btnSavePBanHang = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreatePBanhang = new DevExpress.XtraEditors.SimpleButton();
            this.tabPageSanPham = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer1 = new DevExpress.XtraBars.TabFormContentContainer();
            this.tabPageKhachhang = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer2 = new DevExpress.XtraBars.TabFormContentContainer();
            this.groupControl9 = new DevExpress.XtraEditors.GroupControl();
            this.grdKhachhang_PKhachHang = new DevExpress.XtraGrid.GridControl();
            this.grdKhachhang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete_PKhachhang = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrefesh_PKhachhang = new DevExpress.XtraEditors.SimpleButton();
            this.sh_PKhachhang = new DevExpress.XtraEditors.SearchControl();
            this.groupControl8 = new DevExpress.XtraEditors.GroupControl();
            this.txtAddress_PKhachHang = new DevExpress.XtraEditors.MemoEdit();
            this.txtPhone_PKhachHang = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtName_PKhachHang = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl7 = new DevExpress.XtraEditors.GroupControl();
            this.btnCance_PKhachHang = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave_PKhachHang = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreate_PKhachHang = new DevExpress.XtraEditors.SimpleButton();
            this.tabPageLoaiDVT = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer3 = new DevExpress.XtraBars.TabFormContentContainer();
            this.tabFormPage1 = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer4 = new DevExpress.XtraBars.TabFormContentContainer();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtidKhachHang = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit10.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.tabFormContentContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl9)).BeginInit();
            this.groupControl9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdKhachhang_PKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdKhachhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sh_PKhachhang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).BeginInit();
            this.groupControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress_PKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone_PKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName_PKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).BeginInit();
            this.groupControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtidKhachHang.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_Main
            // 
            this.tab_Main.Appearance.TabFormControl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Main.Appearance.TabFormControl.Image = ((System.Drawing.Image)(resources.GetObject("tab_Main.Appearance.TabFormControl.Image")));
            this.tab_Main.Appearance.TabFormControl.Options.UseFont = true;
            this.tab_Main.Appearance.TabFormControl.Options.UseImage = true;
            this.tab_Main.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tab_Main.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tab_Main.Location = new System.Drawing.Point(0, 0);
            this.tab_Main.Manager = this.tabFormDefaultManager1;
            this.tab_Main.MinTabWidth = 100;
            this.tab_Main.Name = "tab_Main";
            this.tab_Main.Pages.Add(this.tabPageBanhang);
            this.tab_Main.Pages.Add(this.tabPageSanPham);
            this.tab_Main.Pages.Add(this.tabPageKhachhang);
            this.tab_Main.Pages.Add(this.tabPageLoaiDVT);
            this.tab_Main.Pages.Add(this.tabFormPage1);
            this.tab_Main.SelectedPage = this.tabPageKhachhang;
            this.tab_Main.ShowAddPageButton = false;
            this.tab_Main.ShowTabCloseButtons = false;
            this.tab_Main.ShowTabsInTitleBar = DevExpress.XtraBars.ShowTabsInTitleBar.True;
            this.tab_Main.Size = new System.Drawing.Size(949, 40);
            this.tab_Main.TabForm = this;
            this.tab_Main.TabIndex = 0;
            this.tab_Main.TabStop = false;
            this.tab_Main.OuterFormCreating += new DevExpress.XtraBars.OuterFormCreatingEventHandler(this.OnOuterFormCreating);
            // 
            // tabFormDefaultManager1
            // 
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlTop);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlBottom);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlLeft);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlRight);
            this.tabFormDefaultManager1.DockingEnabled = false;
            this.tabFormDefaultManager1.Form = this;
            this.tabFormDefaultManager1.MaxItemId = 0;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 40);
            this.barDockControlTop.Manager = null;
            this.barDockControlTop.Size = new System.Drawing.Size(949, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 564);
            this.barDockControlBottom.Manager = null;
            this.barDockControlBottom.Size = new System.Drawing.Size(949, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = null;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 524);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(949, 40);
            this.barDockControlRight.Manager = null;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 524);
            // 
            // tabPageBanhang
            // 
            this.tabPageBanhang.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.tabPageBanhang.ContentContainer = this.xtraScrollableControl1;
            this.tabPageBanhang.Image = ((System.Drawing.Image)(resources.GetObject("tabPageBanhang.Image")));
            this.tabPageBanhang.Name = "tabPageBanhang";
            this.tabPageBanhang.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.tabPageBanhang.Text = "Bán Hàng";
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.groupControl6);
            this.xtraScrollableControl1.Controls.Add(this.groupControl4);
            this.xtraScrollableControl1.Controls.Add(this.groupControl5);
            this.xtraScrollableControl1.Controls.Add(this.groupControl3);
            this.xtraScrollableControl1.Controls.Add(this.groupControl2);
            this.xtraScrollableControl1.Controls.Add(this.groupControl1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 40);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(949, 524);
            this.xtraScrollableControl1.TabIndex = 1;
            // 
            // groupControl6
            // 
            this.groupControl6.Controls.Add(this.checkEdit1);
            this.groupControl6.Controls.Add(this.labelControl9);
            this.groupControl6.Controls.Add(this.labelControl8);
            this.groupControl6.Controls.Add(this.textEdit9);
            this.groupControl6.Controls.Add(this.textEdit8);
            this.groupControl6.Controls.Add(this.textEdit10);
            this.groupControl6.Controls.Add(this.textEdit7);
            this.groupControl6.Controls.Add(this.labelControl7);
            this.groupControl6.Location = new System.Drawing.Point(660, 15);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(280, 129);
            this.groupControl6.TabIndex = 3;
            this.groupControl6.Text = "Tiền trên đơn hàng";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(14, 68);
            this.checkEdit1.MenuManager = this.tabFormDefaultManager1;
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Chiết khấu (%)";
            this.checkEdit1.Size = new System.Drawing.Size(100, 19);
            this.checkEdit1.TabIndex = 3;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(153, 71);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(43, 13);
            this.labelControl9.TabIndex = 2;
            this.labelControl9.Text = "Thực thu";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(14, 21);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(51, 13);
            this.labelControl8.TabIndex = 2;
            this.labelControl8.Text = "Thành tiền";
            // 
            // textEdit9
            // 
            this.textEdit9.Location = new System.Drawing.Point(14, 87);
            this.textEdit9.Name = "textEdit9";
            this.textEdit9.Size = new System.Drawing.Size(100, 20);
            this.textEdit9.TabIndex = 1;
            // 
            // textEdit8
            // 
            this.textEdit8.Location = new System.Drawing.Point(14, 40);
            this.textEdit8.Name = "textEdit8";
            this.textEdit8.Size = new System.Drawing.Size(100, 20);
            this.textEdit8.TabIndex = 1;
            // 
            // textEdit10
            // 
            this.textEdit10.Location = new System.Drawing.Point(153, 87);
            this.textEdit10.Name = "textEdit10";
            this.textEdit10.Size = new System.Drawing.Size(100, 20);
            this.textEdit10.TabIndex = 1;
            // 
            // textEdit7
            // 
            this.textEdit7.Location = new System.Drawing.Point(153, 40);
            this.textEdit7.MenuManager = this.tabFormDefaultManager1;
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Size = new System.Drawing.Size(100, 20);
            this.textEdit7.TabIndex = 1;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(153, 21);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(27, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Nợ cũ";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.gridControl3);
            this.groupControl4.Location = new System.Drawing.Point(660, 150);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(282, 366);
            this.groupControl4.TabIndex = 2;
            this.groupControl4.Text = "Danh sách bán";
            // 
            // gridControl3
            // 
            this.gridControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl3.Location = new System.Drawing.Point(2, 21);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.MenuManager = this.tabFormDefaultManager1;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(278, 343);
            this.gridControl3.TabIndex = 0;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tên sản phẩm";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Số lượng";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Đơn giá";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.simpleButton1);
            this.groupControl5.Controls.Add(this.gridControl2);
            this.groupControl5.Controls.Add(this.searchControl2);
            this.groupControl5.Location = new System.Drawing.Point(236, 198);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(416, 318);
            this.groupControl5.TabIndex = 2;
            this.groupControl5.Text = "Chọn sản phẩm";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(243, 22);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(27, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.ToolTip = "Làm mới dữ liệu";
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(5, 51);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.MenuManager = this.tabFormDefaultManager1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(411, 262);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên sản phẩm";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 275;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Quy Cách";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 115;
            // 
            // searchControl2
            // 
            this.searchControl2.Location = new System.Drawing.Point(5, 24);
            this.searchControl2.Name = "searchControl2";
            this.searchControl2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl2.Size = new System.Drawing.Size(232, 20);
            this.searchControl2.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.simpleButton3);
            this.groupControl3.Controls.Add(this.simpleButton2);
            this.groupControl3.Controls.Add(this.textEdit2);
            this.groupControl3.Controls.Add(this.textEdit6);
            this.groupControl3.Controls.Add(this.textEdit5);
            this.groupControl3.Controls.Add(this.textEdit4);
            this.groupControl3.Controls.Add(this.textEdit3);
            this.groupControl3.Controls.Add(this.textEdit1);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Location = new System.Drawing.Point(236, 15);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(416, 177);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Chi tiết đặt hàng";
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton3.Location = new System.Drawing.Point(228, 139);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(83, 26);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "Nhập lại";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton2.Location = new System.Drawing.Point(322, 139);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(83, 26);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Chấp nhận";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(284, 18);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(121, 20);
            this.textEdit2.TabIndex = 1;
            // 
            // textEdit6
            // 
            this.textEdit6.Location = new System.Drawing.Point(284, 109);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Size = new System.Drawing.Size(121, 20);
            this.textEdit6.TabIndex = 1;
            // 
            // textEdit5
            // 
            this.textEdit5.Location = new System.Drawing.Point(68, 109);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Size = new System.Drawing.Size(121, 20);
            this.textEdit5.TabIndex = 1;
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(68, 79);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(337, 20);
            this.textEdit4.TabIndex = 1;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(68, 49);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(337, 20);
            this.textEdit3.TabIndex = 1;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(68, 18);
            this.textEdit1.MenuManager = this.tabFormDefaultManager1;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(121, 20);
            this.textEdit1.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(241, 112);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(37, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Đơn giá";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(228, 21);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Ngày bán:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(11, 112);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(42, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Số lượng";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(11, 82);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Sản phẩm";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 52);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Người mua";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(48, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(14, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Controls.Add(this.searchControl1);
            this.groupControl2.Location = new System.Drawing.Point(13, 127);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(217, 389);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Danh sách khách hàng";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(6, 51);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.tabFormDefaultManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(206, 333);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 309;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Điện Thoại";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 380;
            // 
            // searchControl1
            // 
            this.searchControl1.Location = new System.Drawing.Point(6, 24);
            this.searchControl1.MenuManager = this.tabFormDefaultManager1;
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Size = new System.Drawing.Size(206, 20);
            this.searchControl1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnCancePBanHang);
            this.groupControl1.Controls.Add(this.btnSavePBanHang);
            this.groupControl1.Controls.Add(this.btnCreatePBanhang);
            this.groupControl1.Location = new System.Drawing.Point(12, 15);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(218, 105);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Tác vụ";
            // 
            // btnCancePBanHang
            // 
            this.btnCancePBanHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancePBanHang.ImageOptions.Image")));
            this.btnCancePBanHang.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCancePBanHang.Location = new System.Drawing.Point(146, 24);
            this.btnCancePBanHang.Name = "btnCancePBanHang";
            this.btnCancePBanHang.Size = new System.Drawing.Size(60, 63);
            this.btnCancePBanHang.TabIndex = 0;
            this.btnCancePBanHang.Text = "Hủy";
            // 
            // btnSavePBanHang
            // 
            this.btnSavePBanHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSavePBanHang.ImageOptions.Image")));
            this.btnSavePBanHang.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnSavePBanHang.Location = new System.Drawing.Point(80, 24);
            this.btnSavePBanHang.Name = "btnSavePBanHang";
            this.btnSavePBanHang.Size = new System.Drawing.Size(60, 63);
            this.btnSavePBanHang.TabIndex = 0;
            this.btnSavePBanHang.Text = "Lưu";
            // 
            // btnCreatePBanhang
            // 
            this.btnCreatePBanhang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCreatePBanhang.ImageOptions.Image")));
            this.btnCreatePBanhang.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCreatePBanhang.Location = new System.Drawing.Point(14, 24);
            this.btnCreatePBanhang.Name = "btnCreatePBanhang";
            this.btnCreatePBanhang.Size = new System.Drawing.Size(60, 63);
            this.btnCreatePBanhang.TabIndex = 0;
            this.btnCreatePBanhang.Text = "Tạo mới";
            // 
            // tabPageSanPham
            // 
            this.tabPageSanPham.ContentContainer = this.tabFormContentContainer1;
            this.tabPageSanPham.Image = ((System.Drawing.Image)(resources.GetObject("tabPageSanPham.Image")));
            this.tabPageSanPham.Name = "tabPageSanPham";
            this.tabPageSanPham.Text = "Sản Phẩm";
            // 
            // tabFormContentContainer1
            // 
            this.tabFormContentContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer1.Location = new System.Drawing.Point(0, 40);
            this.tabFormContentContainer1.Name = "tabFormContentContainer1";
            this.tabFormContentContainer1.Size = new System.Drawing.Size(949, 524);
            this.tabFormContentContainer1.TabIndex = 6;
            // 
            // tabPageKhachhang
            // 
            this.tabPageKhachhang.ContentContainer = this.tabFormContentContainer2;
            this.tabPageKhachhang.Image = ((System.Drawing.Image)(resources.GetObject("tabPageKhachhang.Image")));
            this.tabPageKhachhang.Name = "tabPageKhachhang";
            this.tabPageKhachhang.Text = "Khách Hàng";
            // 
            // tabFormContentContainer2
            // 
            this.tabFormContentContainer2.Controls.Add(this.groupControl9);
            this.tabFormContentContainer2.Controls.Add(this.groupControl8);
            this.tabFormContentContainer2.Controls.Add(this.groupControl7);
            this.tabFormContentContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer2.Location = new System.Drawing.Point(0, 40);
            this.tabFormContentContainer2.Name = "tabFormContentContainer2";
            this.tabFormContentContainer2.Size = new System.Drawing.Size(949, 524);
            this.tabFormContentContainer2.TabIndex = 7;
            // 
            // groupControl9
            // 
            this.groupControl9.Controls.Add(this.grdKhachhang_PKhachHang);
            this.groupControl9.Controls.Add(this.btnDelete_PKhachhang);
            this.groupControl9.Controls.Add(this.btnPrefesh_PKhachhang);
            this.groupControl9.Controls.Add(this.sh_PKhachhang);
            this.groupControl9.Location = new System.Drawing.Point(248, 15);
            this.groupControl9.Name = "groupControl9";
            this.groupControl9.Size = new System.Drawing.Size(689, 497);
            this.groupControl9.TabIndex = 10;
            this.groupControl9.Text = "Danh Sách";
            // 
            // grdKhachhang_PKhachHang
            // 
            gridLevelNode1.RelationName = "Level1";
            this.grdKhachhang_PKhachHang.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grdKhachhang_PKhachHang.Location = new System.Drawing.Point(9, 51);
            this.grdKhachhang_PKhachHang.MainView = this.grdKhachhang;
            this.grdKhachhang_PKhachHang.MenuManager = this.tabFormDefaultManager1;
            this.grdKhachhang_PKhachHang.Name = "grdKhachhang_PKhachHang";
            this.grdKhachhang_PKhachHang.Size = new System.Drawing.Size(675, 437);
            this.grdKhachhang_PKhachHang.TabIndex = 2;
            this.grdKhachhang_PKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdKhachhang});
            this.grdKhachhang_PKhachHang.Click += new System.EventHandler(this.grdKhachhang_PKhachHang_Click);
            // 
            // grdKhachhang
            // 
            this.grdKhachhang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10});
            this.grdKhachhang.GridControl = this.grdKhachhang_PKhachHang;
            this.grdKhachhang.Name = "grdKhachhang";
            this.grdKhachhang.OptionsBehavior.Editable = false;
            this.grdKhachhang.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Tên";
            this.gridColumn8.FieldName = "KH_NAME";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            this.gridColumn8.Width = 176;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Điện thoại ";
            this.gridColumn9.FieldName = "KH_PHONE";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 1;
            this.gridColumn9.Width = 185;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Địa chỉ";
            this.gridColumn10.FieldName = "KH_ADDRESS";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 2;
            this.gridColumn10.Width = 293;
            // 
            // btnDelete_PKhachhang
            // 
            this.btnDelete_PKhachhang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete_PKhachhang.ImageOptions.Image")));
            this.btnDelete_PKhachhang.Location = new System.Drawing.Point(388, 21);
            this.btnDelete_PKhachhang.Name = "btnDelete_PKhachhang";
            this.btnDelete_PKhachhang.Size = new System.Drawing.Size(75, 23);
            this.btnDelete_PKhachhang.TabIndex = 1;
            this.btnDelete_PKhachhang.Text = "Xóa";
            this.btnDelete_PKhachhang.Click += new System.EventHandler(this.btnDelete_PKhachhang_Click);
            // 
            // btnPrefesh_PKhachhang
            // 
            this.btnPrefesh_PKhachhang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrefesh_PKhachhang.ImageOptions.Image")));
            this.btnPrefesh_PKhachhang.Location = new System.Drawing.Point(307, 21);
            this.btnPrefesh_PKhachhang.Name = "btnPrefesh_PKhachhang";
            this.btnPrefesh_PKhachhang.Size = new System.Drawing.Size(75, 23);
            this.btnPrefesh_PKhachhang.TabIndex = 1;
            this.btnPrefesh_PKhachhang.Text = "Làm mới";
            this.btnPrefesh_PKhachhang.Click += new System.EventHandler(this.btnPrefesh_PKhachhang_Click);
            // 
            // sh_PKhachhang
            // 
            this.sh_PKhachhang.Client = this.grdKhachhang_PKhachHang;
            this.sh_PKhachhang.Location = new System.Drawing.Point(9, 24);
            this.sh_PKhachhang.MenuManager = this.tabFormDefaultManager1;
            this.sh_PKhachhang.Name = "sh_PKhachhang";
            this.sh_PKhachhang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.sh_PKhachhang.Properties.Client = this.grdKhachhang_PKhachHang;
            this.sh_PKhachhang.Size = new System.Drawing.Size(292, 20);
            this.sh_PKhachhang.TabIndex = 0;
            // 
            // groupControl8
            // 
            this.groupControl8.Controls.Add(this.txtAddress_PKhachHang);
            this.groupControl8.Controls.Add(this.txtPhone_PKhachHang);
            this.groupControl8.Controls.Add(this.labelControl12);
            this.groupControl8.Controls.Add(this.labelControl11);
            this.groupControl8.Controls.Add(this.txtidKhachHang);
            this.groupControl8.Controls.Add(this.txtName_PKhachHang);
            this.groupControl8.Controls.Add(this.labelControl13);
            this.groupControl8.Controls.Add(this.labelControl10);
            this.groupControl8.Location = new System.Drawing.Point(13, 119);
            this.groupControl8.Name = "groupControl8";
            this.groupControl8.Size = new System.Drawing.Size(217, 393);
            this.groupControl8.TabIndex = 9;
            this.groupControl8.Text = "Chi tiết";
            // 
            // txtAddress_PKhachHang
            // 
            this.txtAddress_PKhachHang.Location = new System.Drawing.Point(13, 182);
            this.txtAddress_PKhachHang.MenuManager = this.tabFormDefaultManager1;
            this.txtAddress_PKhachHang.Name = "txtAddress_PKhachHang";
            this.txtAddress_PKhachHang.Size = new System.Drawing.Size(192, 192);
            this.txtAddress_PKhachHang.TabIndex = 3;
            // 
            // txtPhone_PKhachHang
            // 
            this.txtPhone_PKhachHang.Location = new System.Drawing.Point(13, 137);
            this.txtPhone_PKhachHang.Name = "txtPhone_PKhachHang";
            this.txtPhone_PKhachHang.Properties.Mask.BeepOnError = true;
            this.txtPhone_PKhachHang.Properties.Mask.EditMask = "99999999999";
            this.txtPhone_PKhachHang.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtPhone_PKhachHang.Size = new System.Drawing.Size(192, 20);
            this.txtPhone_PKhachHang.TabIndex = 2;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(13, 163);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(32, 13);
            this.labelControl12.TabIndex = 0;
            this.labelControl12.Text = "Địa chỉ";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(13, 118);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(51, 13);
            this.labelControl11.TabIndex = 0;
            this.labelControl11.Text = "Điện Thoại";
            // 
            // txtName_PKhachHang
            // 
            this.txtName_PKhachHang.Location = new System.Drawing.Point(13, 85);
            this.txtName_PKhachHang.MenuManager = this.tabFormDefaultManager1;
            this.txtName_PKhachHang.Name = "txtName_PKhachHang";
            this.txtName_PKhachHang.Size = new System.Drawing.Size(192, 20);
            this.txtName_PKhachHang.TabIndex = 1;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(13, 66);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(18, 13);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "Tên";
            // 
            // groupControl7
            // 
            this.groupControl7.Controls.Add(this.btnCance_PKhachHang);
            this.groupControl7.Controls.Add(this.btnSave_PKhachHang);
            this.groupControl7.Controls.Add(this.btnCreate_PKhachHang);
            this.groupControl7.Location = new System.Drawing.Point(12, 7);
            this.groupControl7.Name = "groupControl7";
            this.groupControl7.Size = new System.Drawing.Size(218, 105);
            this.groupControl7.TabIndex = 8;
            this.groupControl7.Text = "Tác vụ";
            // 
            // btnCance_PKhachHang
            // 
            this.btnCance_PKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCance_PKhachHang.ImageOptions.Image")));
            this.btnCance_PKhachHang.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCance_PKhachHang.Location = new System.Drawing.Point(146, 24);
            this.btnCance_PKhachHang.Name = "btnCance_PKhachHang";
            this.btnCance_PKhachHang.Size = new System.Drawing.Size(60, 63);
            this.btnCance_PKhachHang.TabIndex = 0;
            this.btnCance_PKhachHang.Text = "Hủy";
            // 
            // btnSave_PKhachHang
            // 
            this.btnSave_PKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave_PKhachHang.ImageOptions.Image")));
            this.btnSave_PKhachHang.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnSave_PKhachHang.Location = new System.Drawing.Point(80, 24);
            this.btnSave_PKhachHang.Name = "btnSave_PKhachHang";
            this.btnSave_PKhachHang.Size = new System.Drawing.Size(60, 63);
            this.btnSave_PKhachHang.TabIndex = 0;
            this.btnSave_PKhachHang.Text = "Lưu";
            this.btnSave_PKhachHang.Click += new System.EventHandler(this.btnSave_PKhachHang_Click);
            // 
            // btnCreate_PKhachHang
            // 
            this.btnCreate_PKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate_PKhachHang.ImageOptions.Image")));
            this.btnCreate_PKhachHang.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCreate_PKhachHang.Location = new System.Drawing.Point(14, 24);
            this.btnCreate_PKhachHang.Name = "btnCreate_PKhachHang";
            this.btnCreate_PKhachHang.Size = new System.Drawing.Size(60, 63);
            this.btnCreate_PKhachHang.TabIndex = 0;
            this.btnCreate_PKhachHang.Text = "Tạo mới";
            this.btnCreate_PKhachHang.Click += new System.EventHandler(this.btnCreate_PKhachHang_Click);
            // 
            // tabPageLoaiDVT
            // 
            this.tabPageLoaiDVT.ContentContainer = this.tabFormContentContainer3;
            this.tabPageLoaiDVT.Image = ((System.Drawing.Image)(resources.GetObject("tabPageLoaiDVT.Image")));
            this.tabPageLoaiDVT.Name = "tabPageLoaiDVT";
            this.tabPageLoaiDVT.Text = "Loại & Đơn vị tính";
            // 
            // tabFormContentContainer3
            // 
            this.tabFormContentContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer3.Location = new System.Drawing.Point(0, 40);
            this.tabFormContentContainer3.Name = "tabFormContentContainer3";
            this.tabFormContentContainer3.Size = new System.Drawing.Size(949, 524);
            this.tabFormContentContainer3.TabIndex = 8;
            // 
            // tabFormPage1
            // 
            this.tabFormPage1.ContentContainer = this.tabFormContentContainer4;
            this.tabFormPage1.Name = "tabFormPage1";
            this.tabFormPage1.Text = "Công Nợ";
            this.tabFormPage1.Visible = false;
            // 
            // tabFormContentContainer4
            // 
            this.tabFormContentContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer4.Location = new System.Drawing.Point(0, 27);
            this.tabFormContentContainer4.Name = "tabFormContentContainer4";
            this.tabFormContentContainer4.Size = new System.Drawing.Size(876, 431);
            this.tabFormContentContainer4.TabIndex = 9;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(13, 39);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(18, 13);
            this.labelControl13.TabIndex = 0;
            this.labelControl13.Text = "Mã:";
            // 
            // txtidKhachHang
            // 
            this.txtidKhachHang.Enabled = false;
            this.txtidKhachHang.Location = new System.Drawing.Point(37, 36);
            this.txtidKhachHang.Name = "txtidKhachHang";
            this.txtidKhachHang.Size = new System.Drawing.Size(69, 20);
            this.txtidKhachHang.TabIndex = 1;
            // 
            // GUI_QuanLy
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 564);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.tabFormContentContainer2);
            this.Controls.Add(this.tab_Main);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Name = "GUI_QuanLy";
            this.TabFormControl = this.tab_Main;
            this.Text = "      ";
            this.Load += new System.EventHandler(this.GUI_QuanLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tab_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            this.groupControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit10.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.tabFormContentContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl9)).EndInit();
            this.groupControl9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdKhachhang_PKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdKhachhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sh_PKhachhang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).EndInit();
            this.groupControl8.ResumeLayout(false);
            this.groupControl8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress_PKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone_PKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName_PKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).EndInit();
            this.groupControl7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtidKhachHang.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.TabFormControl tab_Main;
        private DevExpress.XtraBars.TabFormDefaultManager tabFormDefaultManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraBars.TabFormPage tabPageBanhang;
        private DevExpress.XtraBars.TabFormPage tabPageSanPham;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer1;
        private DevExpress.XtraBars.TabFormPage tabPageKhachhang;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer2;
        private DevExpress.XtraBars.TabFormPage tabPageLoaiDVT;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer3;
        private DevExpress.XtraBars.TabFormPage tabFormPage1;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer4;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancePBanHang;
        private DevExpress.XtraEditors.SimpleButton btnSavePBanHang;
        private DevExpress.XtraEditors.SimpleButton btnCreatePBanhang;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SearchControl searchControl2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit textEdit9;
        private DevExpress.XtraEditors.TextEdit textEdit8;
        private DevExpress.XtraEditors.TextEdit textEdit10;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.GroupControl groupControl8;
        private DevExpress.XtraEditors.GroupControl groupControl7;
        private DevExpress.XtraEditors.SimpleButton btnCance_PKhachHang;
        private DevExpress.XtraEditors.SimpleButton btnSave_PKhachHang;
        private DevExpress.XtraEditors.SimpleButton btnCreate_PKhachHang;
        private DevExpress.XtraEditors.GroupControl groupControl9;
        private DevExpress.XtraGrid.GridControl grdKhachhang_PKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView grdKhachhang;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraEditors.SimpleButton btnPrefesh_PKhachhang;
        private DevExpress.XtraEditors.SearchControl sh_PKhachhang;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.MemoEdit txtAddress_PKhachHang;
        private DevExpress.XtraEditors.TextEdit txtPhone_PKhachHang;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtName_PKhachHang;
        private DevExpress.XtraEditors.SimpleButton btnDelete_PKhachhang;
        private DevExpress.XtraEditors.TextEdit txtidKhachHang;
        private DevExpress.XtraEditors.LabelControl labelControl13;
    }
}


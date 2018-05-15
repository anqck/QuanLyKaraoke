namespace GUI.folderKhachHang
{
    partial class LoaiKhachHang
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
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.Columns.GridColumn colLoaiPhong;
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoaiKhachHang));
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions3 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.wbntLoaikhachhang = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinhTrangPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KhachhangPagecontrol = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.tileControl2 = new DevExpress.XtraEditors.TileControl();
            this.grpMacDinh = new DevExpress.XtraEditors.TileGroup();
            this.tileAll = new DevExpress.XtraEditors.TileItem();
            this.tileAvailable = new DevExpress.XtraEditors.TileItem();
            this.tileRented = new DevExpress.XtraEditors.TileItem();
            this.PageKhachhang = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.LoaiKhachHangPagecontrol = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.PageLoaikhachhang = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.labelTitle = new DevExpress.XtraEditors.LabelControl();
            this.PageThemloaikhachhang = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.windowsUIButtonPanel4 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.themLoaiKhachHang2 = new GUI.folderKhachHang.ThemLoaiKhachHang();
            colLoaiPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.wbntLoaikhachhang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhachhangPagecontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoaiKhachHangPagecontrol)).BeginInit();
            this.LoaiKhachHangPagecontrol.SuspendLayout();
            this.PageLoaikhachhang.SuspendLayout();
            this.PageThemloaikhachhang.SuspendLayout();
            this.SuspendLayout();
            // 
            // colLoaiPhong
            // 
            colLoaiPhong.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            colLoaiPhong.AppearanceCell.Options.UseFont = true;
            colLoaiPhong.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            colLoaiPhong.AppearanceHeader.ForeColor = System.Drawing.Color.Gray;
            colLoaiPhong.AppearanceHeader.Options.UseFont = true;
            colLoaiPhong.AppearanceHeader.Options.UseForeColor = true;
            colLoaiPhong.Caption = "Loại phòng";
            colLoaiPhong.FieldName = "TenLoaiPhong";
            colLoaiPhong.Name = "colLoaiPhong";
            colLoaiPhong.Visible = true;
            colLoaiPhong.VisibleIndex = 4;
            // 
            // wbntLoaikhachhang
            // 
            this.wbntLoaikhachhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wbntLoaikhachhang.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thêm", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Hủy", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton()});
            this.wbntLoaikhachhang.Controls.Add(this.searchControl1);
            this.wbntLoaikhachhang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wbntLoaikhachhang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wbntLoaikhachhang.ForeColor = System.Drawing.Color.White;
            this.wbntLoaikhachhang.Location = new System.Drawing.Point(5, 673);
            this.wbntLoaikhachhang.Name = "wbntLoaikhachhang";
            this.wbntLoaikhachhang.Size = new System.Drawing.Size(1150, 80);
            this.wbntLoaikhachhang.TabIndex = 15;
            this.wbntLoaikhachhang.Text = "windowsUIButtonPanel1";
            this.wbntLoaikhachhang.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.wbntLoaikhachhang_ButtonClick);
            // 
            // searchControl1
            // 
            this.searchControl1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchControl1.EditValue = "";
            this.searchControl1.Location = new System.Drawing.Point(881, 23);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchControl1.Properties.Appearance.Options.UseFont = true;
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Size = new System.Drawing.Size(248, 34);
            this.searchControl1.TabIndex = 1;
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gridControl.Location = new System.Drawing.Point(5, 43);
            this.gridControl.MainView = this.gridView1;
            this.gridControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1150, 630);
            this.gridControl.TabIndex = 16;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.ColumnPanelRowHeight = 50;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaPhong,
            this.colTenPhong,
            this.colTinhTrangPhong,
            this.colGhiChu,
            colLoaiPhong});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.RowHeight = 40;
            // 
            // colMaPhong
            // 
            this.colMaPhong.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMaPhong.AppearanceCell.Options.UseFont = true;
            this.colMaPhong.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMaPhong.AppearanceHeader.ForeColor = System.Drawing.Color.Gray;
            this.colMaPhong.AppearanceHeader.Options.UseFont = true;
            this.colMaPhong.AppearanceHeader.Options.UseForeColor = true;
            this.colMaPhong.Caption = "Mã Phòng";
            this.colMaPhong.FieldName = "MaPhong";
            this.colMaPhong.Name = "colMaPhong";
            this.colMaPhong.Visible = true;
            this.colMaPhong.VisibleIndex = 0;
            // 
            // colTenPhong
            // 
            this.colTenPhong.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTenPhong.AppearanceCell.Options.UseFont = true;
            this.colTenPhong.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTenPhong.AppearanceHeader.ForeColor = System.Drawing.Color.Gray;
            this.colTenPhong.AppearanceHeader.Options.UseFont = true;
            this.colTenPhong.AppearanceHeader.Options.UseForeColor = true;
            this.colTenPhong.Caption = "Tên Phòng";
            this.colTenPhong.FieldName = "TenPhong";
            this.colTenPhong.Name = "colTenPhong";
            this.colTenPhong.Visible = true;
            this.colTenPhong.VisibleIndex = 1;
            // 
            // colTinhTrangPhong
            // 
            this.colTinhTrangPhong.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTinhTrangPhong.AppearanceCell.Options.UseFont = true;
            this.colTinhTrangPhong.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTinhTrangPhong.AppearanceHeader.ForeColor = System.Drawing.Color.Gray;
            this.colTinhTrangPhong.AppearanceHeader.Options.UseFont = true;
            this.colTinhTrangPhong.AppearanceHeader.Options.UseForeColor = true;
            this.colTinhTrangPhong.Caption = "Tình trạng phòng";
            this.colTinhTrangPhong.FieldName = "TinhTrangPhong";
            this.colTinhTrangPhong.Name = "colTinhTrangPhong";
            this.colTinhTrangPhong.Visible = true;
            this.colTinhTrangPhong.VisibleIndex = 2;
            // 
            // colGhiChu
            // 
            this.colGhiChu.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colGhiChu.AppearanceCell.Options.UseFont = true;
            this.colGhiChu.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colGhiChu.AppearanceHeader.ForeColor = System.Drawing.Color.Gray;
            this.colGhiChu.AppearanceHeader.Options.UseFont = true;
            this.colGhiChu.AppearanceHeader.Options.UseForeColor = true;
            this.colGhiChu.Caption = "Ghi chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 3;
            // 
            // KhachhangPagecontrol
            // 
            this.KhachhangPagecontrol.Appearance.BackColor = System.Drawing.Color.White;
            this.KhachhangPagecontrol.Appearance.Options.UseBackColor = true;
            this.KhachhangPagecontrol.Location = new System.Drawing.Point(0, 0);
            this.KhachhangPagecontrol.Name = "KhachhangPagecontrol";
            this.KhachhangPagecontrol.SelectedPage = null;
            this.KhachhangPagecontrol.Size = new System.Drawing.Size(0, 0);
            this.KhachhangPagecontrol.TabIndex = 0;
            // 
            // splitContainerControl
            // 
            this.splitContainerControl.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1;
            this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl.IsSplitterFixed = true;
            this.splitContainerControl.Location = new System.Drawing.Point(0, 37);
            this.splitContainerControl.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.splitContainerControl.Name = "splitContainerControl";
            this.splitContainerControl.Size = new System.Drawing.Size(200, 100);
            this.splitContainerControl.TabIndex = 0;
            // 
            // tileControl2
            // 
            this.tileControl2.AllowDrag = false;
            this.tileControl2.AllowDragTilesBetweenGroups = false;
            this.tileControl2.AllowDrop = true;
            this.tileControl2.AllowItemHover = true;
            this.tileControl2.AllowSelectedItem = true;
            this.tileControl2.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileControl2.AppearanceItem.Normal.Options.UseFont = true;
            this.tileControl2.AppearanceItem.Selected.ForeColor = System.Drawing.Color.Teal;
            this.tileControl2.AppearanceItem.Selected.Options.UseForeColor = true;
            this.tileControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl2.EnableItemDoubleClickEvent = false;
            this.tileControl2.Groups.Add(this.grpMacDinh);
            this.tileControl2.Location = new System.Drawing.Point(0, 0);
            this.tileControl2.Name = "tileControl2";
            this.tileControl2.Size = new System.Drawing.Size(240, 150);
            this.tileControl2.TabIndex = 0;
            // 
            // grpMacDinh
            // 
            this.grpMacDinh.Items.Add(this.tileAll);
            this.grpMacDinh.Items.Add(this.tileAvailable);
            this.grpMacDinh.Items.Add(this.tileRented);
            this.grpMacDinh.Name = "grpMacDinh";
            this.grpMacDinh.Text = "Mặc định";
            // 
            // tileAll
            // 
            this.tileAll.AppearanceItem.Normal.BackColor = System.Drawing.Color.White;
            this.tileAll.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Gray;
            this.tileAll.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileAll.AppearanceItem.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tileAll.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileAll.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileAll.AppearanceItem.Normal.Options.UseFont = true;
            this.tileAll.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tileAll.AppearanceItem.Selected.BackColor = System.Drawing.Color.White;
            this.tileAll.AppearanceItem.Selected.BorderColor = System.Drawing.Color.Teal;
            this.tileAll.AppearanceItem.Selected.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileAll.AppearanceItem.Selected.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.tileAll.AppearanceItem.Selected.Options.UseBackColor = true;
            this.tileAll.AppearanceItem.Selected.Options.UseBorderColor = true;
            this.tileAll.AppearanceItem.Selected.Options.UseFont = true;
            this.tileAll.AppearanceItem.Selected.Options.UseForeColor = true;
            tileItemElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            tileItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileItemElement1.Text = "";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomRight;
            tileItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement2.Appearance.Normal.Options.UseFont = true;
            tileItemElement2.Appearance.Selected.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement2.Appearance.Selected.Options.UseFont = true;
            tileItemElement2.Text = "SL";
            tileItemElement3.Text = "Tất cả";
            this.tileAll.Elements.Add(tileItemElement1);
            this.tileAll.Elements.Add(tileItemElement2);
            this.tileAll.Elements.Add(tileItemElement3);
            this.tileAll.Id = 5;
            this.tileAll.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileAll.Name = "tileAll";
            // 
            // tileAvailable
            // 
            this.tileAvailable.AppearanceItem.Normal.BackColor = System.Drawing.Color.White;
            this.tileAvailable.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Gray;
            this.tileAvailable.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileAvailable.AppearanceItem.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tileAvailable.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileAvailable.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileAvailable.AppearanceItem.Normal.Options.UseFont = true;
            this.tileAvailable.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tileAvailable.AppearanceItem.Selected.BackColor = System.Drawing.Color.White;
            this.tileAvailable.AppearanceItem.Selected.BorderColor = System.Drawing.Color.Teal;
            this.tileAvailable.AppearanceItem.Selected.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileAvailable.AppearanceItem.Selected.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.tileAvailable.AppearanceItem.Selected.Options.UseBackColor = true;
            this.tileAvailable.AppearanceItem.Selected.Options.UseBorderColor = true;
            this.tileAvailable.AppearanceItem.Selected.Options.UseFont = true;
            this.tileAvailable.AppearanceItem.Selected.Options.UseForeColor = true;
            tileItemElement4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            tileItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileItemElement4.Text = "Phòng trống";
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            tileItemElement5.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement5.Appearance.Normal.Options.UseFont = true;
            tileItemElement5.Appearance.Selected.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement5.Appearance.Selected.Options.UseFont = true;
            tileItemElement5.Text = "SL";
            this.tileAvailable.Elements.Add(tileItemElement4);
            this.tileAvailable.Elements.Add(tileItemElement5);
            this.tileAvailable.Id = 7;
            this.tileAvailable.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileAvailable.Name = "tileAvailable";
            // 
            // tileRented
            // 
            this.tileRented.AppearanceItem.Normal.BackColor = System.Drawing.Color.White;
            this.tileRented.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Gray;
            this.tileRented.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileRented.AppearanceItem.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tileRented.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileRented.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileRented.AppearanceItem.Normal.Options.UseFont = true;
            this.tileRented.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tileRented.AppearanceItem.Selected.BackColor = System.Drawing.Color.White;
            this.tileRented.AppearanceItem.Selected.BorderColor = System.Drawing.Color.Teal;
            this.tileRented.AppearanceItem.Selected.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileRented.AppearanceItem.Selected.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.tileRented.AppearanceItem.Selected.Options.UseBackColor = true;
            this.tileRented.AppearanceItem.Selected.Options.UseBorderColor = true;
            this.tileRented.AppearanceItem.Selected.Options.UseFont = true;
            this.tileRented.AppearanceItem.Selected.Options.UseForeColor = true;
            tileItemElement6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            tileItemElement6.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileItemElement6.Text = "Phòng bận";
            tileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            tileItemElement7.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement7.Appearance.Normal.Options.UseFont = true;
            tileItemElement7.Appearance.Selected.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement7.Appearance.Selected.Options.UseFont = true;
            tileItemElement7.Text = "SL";
            this.tileRented.Elements.Add(tileItemElement6);
            this.tileRented.Elements.Add(tileItemElement7);
            this.tileRented.Id = 8;
            this.tileRented.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileRented.Name = "tileRented";
            // 
            // PageKhachhang
            // 
            this.PageKhachhang.Caption = "PageKhachhang";
            this.PageKhachhang.Name = "PageKhachhang";
            this.PageKhachhang.Size = new System.Drawing.Size(200, 100);
            // 
            // LoaiKhachHangPagecontrol
            // 
            this.LoaiKhachHangPagecontrol.Appearance.BackColor = System.Drawing.Color.White;
            this.LoaiKhachHangPagecontrol.Appearance.Options.UseBackColor = true;
            this.LoaiKhachHangPagecontrol.Controls.Add(this.PageLoaikhachhang);
            this.LoaiKhachHangPagecontrol.Controls.Add(this.PageThemloaikhachhang);
            this.LoaiKhachHangPagecontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoaiKhachHangPagecontrol.Location = new System.Drawing.Point(0, 0);
            this.LoaiKhachHangPagecontrol.Name = "LoaiKhachHangPagecontrol";
            this.LoaiKhachHangPagecontrol.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.PageLoaikhachhang,
            this.PageThemloaikhachhang});
            this.LoaiKhachHangPagecontrol.SelectedPage = this.PageLoaikhachhang;
            this.LoaiKhachHangPagecontrol.Size = new System.Drawing.Size(1160, 758);
            this.LoaiKhachHangPagecontrol.TabIndex = 5;
            this.LoaiKhachHangPagecontrol.Text = "navigationFrame1";
            // 
            // PageLoaikhachhang
            // 
            this.PageLoaikhachhang.Caption = "PageLoaikhachhang";
            this.PageLoaikhachhang.Controls.Add(this.gridControl);
            this.PageLoaikhachhang.Controls.Add(this.labelTitle);
            this.PageLoaikhachhang.Controls.Add(this.wbntLoaikhachhang);
            this.PageLoaikhachhang.Name = "PageLoaikhachhang";
            this.PageLoaikhachhang.Padding = new System.Windows.Forms.Padding(5);
            this.PageLoaikhachhang.Size = new System.Drawing.Size(1160, 758);
            // 
            // labelTitle
            // 
            this.labelTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelTitle.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelTitle.Appearance.Options.UseFont = true;
            this.labelTitle.Appearance.Options.UseForeColor = true;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Location = new System.Drawing.Point(5, 5);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(5);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Padding = new System.Windows.Forms.Padding(3);
            this.labelTitle.Size = new System.Drawing.Size(213, 38);
            this.labelTitle.TabIndex = 17;
            this.labelTitle.Text = "LOẠI KHÁCH HÀNG";
            // 
            // PageThemloaikhachhang
            // 
            this.PageThemloaikhachhang.Caption = "PageThemloaikhachhang";
            this.PageThemloaikhachhang.Controls.Add(this.windowsUIButtonPanel4);
            this.PageThemloaikhachhang.Controls.Add(this.themLoaiKhachHang2);
            this.PageThemloaikhachhang.Name = "PageThemloaikhachhang";
            this.PageThemloaikhachhang.Size = new System.Drawing.Size(1160, 758);
            // 
            // windowsUIButtonPanel4
            // 
            this.windowsUIButtonPanel4.BackColor = System.Drawing.Color.White;
            windowsUIButtonImageOptions3.ImageUri.Uri = "hybriddemo_back%20button;Svg";
            this.windowsUIButtonPanel4.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("", true, windowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.windowsUIButtonPanel4.Location = new System.Drawing.Point(3, 3);
            this.windowsUIButtonPanel4.Name = "windowsUIButtonPanel4";
            this.windowsUIButtonPanel4.Size = new System.Drawing.Size(56, 58);
            this.windowsUIButtonPanel4.TabIndex = 3;
            this.windowsUIButtonPanel4.Text = "windowsUIButtonPanel2";
            this.windowsUIButtonPanel4.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanel4_ButtonClick);
            // 
            // themLoaiKhachHang2
            // 
            this.themLoaiKhachHang2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themLoaiKhachHang2.Location = new System.Drawing.Point(0, 0);
            this.themLoaiKhachHang2.Name = "themLoaiKhachHang2";
            this.themLoaiKhachHang2.Size = new System.Drawing.Size(1160, 758);
            this.themLoaiKhachHang2.TabIndex = 4;
            // 
            // LoaiKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LoaiKhachHangPagecontrol);
            this.Name = "LoaiKhachHang";
            this.Size = new System.Drawing.Size(1160, 758);
            this.wbntLoaikhachhang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhachhangPagecontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LoaiKhachHangPagecontrol)).EndInit();
            this.LoaiKhachHangPagecontrol.ResumeLayout(false);
            this.PageLoaikhachhang.ResumeLayout(false);
            this.PageLoaikhachhang.PerformLayout();
            this.PageThemloaikhachhang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel wbntLoaikhachhang;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colTenPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhTrangPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraBars.Navigation.NavigationFrame KhachhangPagecontrol;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl;
        private DevExpress.XtraEditors.TileControl tileControl2;
        private DevExpress.XtraEditors.TileGroup grpMacDinh;
        private DevExpress.XtraEditors.TileItem tileAll;
        private DevExpress.XtraEditors.TileItem tileAvailable;
        private DevExpress.XtraEditors.TileItem tileRented;
        private DevExpress.XtraBars.Navigation.NavigationPage PageKhachhang;
        private DevExpress.XtraBars.Navigation.NavigationFrame LoaiKhachHangPagecontrol;
        private DevExpress.XtraBars.Navigation.NavigationPage PageLoaikhachhang;
        private DevExpress.XtraBars.Navigation.NavigationPage PageThemloaikhachhang;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel4;
        private ThemLoaiKhachHang themLoaiKhachHang2;
        private DevExpress.XtraEditors.LabelControl labelTitle;
    }
}

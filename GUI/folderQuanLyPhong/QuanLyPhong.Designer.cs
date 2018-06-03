namespace GUI.folderQuanLyPhong
{
    partial class QuanLyPhong
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyPhong));
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.QuanlyPagecontrol = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.PageQuanly = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.tileControl2 = new DevExpress.XtraEditors.TileControl();
            this.grpMacDinh = new DevExpress.XtraEditors.TileGroup();
            this.tileAll = new DevExpress.XtraEditors.TileItem();
            this.tileAvailable = new DevExpress.XtraEditors.TileItem();
            this.tileRented = new DevExpress.XtraEditors.TileItem();
            this.grpLoaiPhong = new DevExpress.XtraEditors.TileGroup();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinhTrangPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelTitle = new DevExpress.XtraEditors.LabelControl();
            this.wbntQuanlyphong = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.PageThemphongmoi = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.themPhongMoi1 = new GUI.folderQuanLyPhong.ThemPhongMoi();
            this.PageSuaphong = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.suaPhong1 = new GUI.folderQuanLyPhong.SuaPhong();
            colLoaiPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.QuanlyPagecontrol)).BeginInit();
            this.QuanlyPagecontrol.SuspendLayout();
            this.PageQuanly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.PageThemphongmoi.SuspendLayout();
            this.PageSuaphong.SuspendLayout();
            this.SuspendLayout();
            // 
            // colLoaiPhong
            // 
            colLoaiPhong.Caption = "Loại phòng";
            colLoaiPhong.FieldName = "TenLoaiPhong";
            colLoaiPhong.Name = "colLoaiPhong";
            colLoaiPhong.Visible = true;
            colLoaiPhong.VisibleIndex = 4;
            colLoaiPhong.Width = 190;
            // 
            // QuanlyPagecontrol
            // 
            this.QuanlyPagecontrol.Appearance.BackColor = System.Drawing.Color.White;
            this.QuanlyPagecontrol.Appearance.Options.UseBackColor = true;
            this.QuanlyPagecontrol.Controls.Add(this.PageQuanly);
            this.QuanlyPagecontrol.Controls.Add(this.PageThemphongmoi);
            this.QuanlyPagecontrol.Controls.Add(this.PageSuaphong);
            this.QuanlyPagecontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuanlyPagecontrol.Location = new System.Drawing.Point(0, 0);
            this.QuanlyPagecontrol.Name = "QuanlyPagecontrol";
            this.QuanlyPagecontrol.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.PageQuanly,
            this.PageThemphongmoi,
            this.PageSuaphong});
            this.QuanlyPagecontrol.SelectedPage = this.PageQuanly;
            this.QuanlyPagecontrol.Size = new System.Drawing.Size(1280, 820);
            this.QuanlyPagecontrol.TabIndex = 3;
            this.QuanlyPagecontrol.Text = "navigationFrame1";
            this.QuanlyPagecontrol.SelectedPageChanging += new DevExpress.XtraBars.Navigation.SelectedPageChangingEventHandler(this.QuanlyPagecontrol_SelectedPageChanging);
            // 
            // PageQuanly
            // 
            this.PageQuanly.Caption = "PageQuanly";
            this.PageQuanly.Controls.Add(this.splitContainerControl);
            this.PageQuanly.Controls.Add(this.labelTitle);
            this.PageQuanly.Controls.Add(this.wbntQuanlyphong);
            this.PageQuanly.Name = "PageQuanly";
            this.PageQuanly.Size = new System.Drawing.Size(1280, 820);
            // 
            // splitContainerControl
            // 
            this.splitContainerControl.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1;
            this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl.IsSplitterFixed = true;
            this.splitContainerControl.Location = new System.Drawing.Point(0, 38);
            this.splitContainerControl.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.splitContainerControl.Name = "splitContainerControl";
            this.splitContainerControl.Panel1.Controls.Add(this.tileControl2);
            this.splitContainerControl.Panel1.MinSize = 300;
            this.splitContainerControl.Panel1.Text = "Panel1";
            this.splitContainerControl.Panel2.Appearance.BackColor = System.Drawing.Color.White;
            this.splitContainerControl.Panel2.Appearance.BackColor2 = System.Drawing.Color.White;
            this.splitContainerControl.Panel2.Appearance.BorderColor = System.Drawing.Color.White;
            this.splitContainerControl.Panel2.Appearance.Options.UseBackColor = true;
            this.splitContainerControl.Panel2.Appearance.Options.UseBorderColor = true;
            this.splitContainerControl.Panel2.Controls.Add(this.gridControl);
            this.splitContainerControl.Panel2.Text = "Panel2";
            this.splitContainerControl.Size = new System.Drawing.Size(1280, 702);
            this.splitContainerControl.SplitterPosition = 125;
            this.splitContainerControl.TabIndex = 8;
            this.splitContainerControl.Text = "splitContainerControl1";
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
            this.tileControl2.Groups.Add(this.grpLoaiPhong);
            this.tileControl2.ItemPadding = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.tileControl2.Location = new System.Drawing.Point(0, 0);
            this.tileControl2.MaxId = 11;
            this.tileControl2.Name = "tileControl2";
            this.tileControl2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileControl2.RowCount = 10;
            this.tileControl2.SelectedItem = this.tileAll;
            this.tileControl2.Size = new System.Drawing.Size(300, 702);
            this.tileControl2.TabIndex = 4;
            this.tileControl2.Text = "tileControl2";
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
            this.tileAll.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
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
            // grpLoaiPhong
            // 
            this.grpLoaiPhong.Name = "grpLoaiPhong";
            this.grpLoaiPhong.Text = "tileGroup1";
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gridControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.gridView1;
            this.gridControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(974, 702);
            this.gridControl.TabIndex = 4;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.ColumnPanelRowHeight = 50;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaPhong,
            this.colTenPhong,
            this.colTang,
            this.colTinhTrangPhong,
            colLoaiPhong,
            this.colGhiChu});
            this.gridView1.DetailHeight = 50;
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsHint.ShowCellHints = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.RowHeight = 40;
            // 
            // colMaPhong
            // 
            this.colMaPhong.AppearanceCell.Options.UseTextOptions = true;
            this.colMaPhong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaPhong.Caption = "Mã Phòng";
            this.colMaPhong.FieldName = "MaPhong";
            this.colMaPhong.MaxWidth = 110;
            this.colMaPhong.Name = "colMaPhong";
            this.colMaPhong.Visible = true;
            this.colMaPhong.VisibleIndex = 0;
            this.colMaPhong.Width = 110;
            // 
            // colTenPhong
            // 
            this.colTenPhong.Caption = "Tên Phòng";
            this.colTenPhong.FieldName = "TenPhong";
            this.colTenPhong.Name = "colTenPhong";
            this.colTenPhong.Visible = true;
            this.colTenPhong.VisibleIndex = 1;
            this.colTenPhong.Width = 200;
            // 
            // colTang
            // 
            this.colTang.Caption = "Tầng";
            this.colTang.FieldName = "Tang";
            this.colTang.Name = "colTang";
            this.colTang.Visible = true;
            this.colTang.VisibleIndex = 2;
            // 
            // colTinhTrangPhong
            // 
            this.colTinhTrangPhong.Caption = "Tình trạng phòng";
            this.colTinhTrangPhong.FieldName = "TinhTrangPhong";
            this.colTinhTrangPhong.Name = "colTinhTrangPhong";
            this.colTinhTrangPhong.Visible = true;
            this.colTinhTrangPhong.VisibleIndex = 3;
            this.colTinhTrangPhong.Width = 177;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 5;
            this.colGhiChu.Width = 277;
            // 
            // labelTitle
            // 
            this.labelTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelTitle.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelTitle.Appearance.Options.UseFont = true;
            this.labelTitle.Appearance.Options.UseForeColor = true;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(5);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Padding = new System.Windows.Forms.Padding(3);
            this.labelTitle.Size = new System.Drawing.Size(192, 38);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "QUẢN LÝ PHÒNG";
            // 
            // wbntQuanlyphong
            // 
            this.wbntQuanlyphong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wbntQuanlyphong.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thêm phòng", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Thêm phòng", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Sửa phòng", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Sửa phòng", -1, false)});
            this.wbntQuanlyphong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wbntQuanlyphong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wbntQuanlyphong.ForeColor = System.Drawing.Color.White;
            this.wbntQuanlyphong.Location = new System.Drawing.Point(0, 740);
            this.wbntQuanlyphong.Name = "wbntQuanlyphong";
            this.wbntQuanlyphong.Size = new System.Drawing.Size(1280, 80);
            this.wbntQuanlyphong.TabIndex = 9;
            this.wbntQuanlyphong.Text = "windowsUIButtonPanel1";
            this.wbntQuanlyphong.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.wbntTinhtrangphong_ButtonClick);
            // 
            // PageThemphongmoi
            // 
            this.PageThemphongmoi.Caption = "PageThemphongmoi";
            this.PageThemphongmoi.Controls.Add(this.themPhongMoi1);
            this.PageThemphongmoi.Name = "PageThemphongmoi";
            this.PageThemphongmoi.Size = new System.Drawing.Size(1280, 820);
            // 
            // themPhongMoi1
            // 
            this.themPhongMoi1.actionBack = null;
            this.themPhongMoi1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themPhongMoi1.Location = new System.Drawing.Point(0, 0);
            this.themPhongMoi1.Name = "themPhongMoi1";
            this.themPhongMoi1.Size = new System.Drawing.Size(1280, 820);
            this.themPhongMoi1.TabIndex = 5;
            // 
            // PageSuaphong
            // 
            this.PageSuaphong.Caption = "PageSuaphong";
            this.PageSuaphong.Controls.Add(this.suaPhong1);
            this.PageSuaphong.Name = "PageSuaphong";
            this.PageSuaphong.Size = new System.Drawing.Size(1280, 820);
            // 
            // suaPhong1
            // 
            this.suaPhong1.actionBack = null;
            this.suaPhong1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suaPhong1.Location = new System.Drawing.Point(0, 0);
            this.suaPhong1.Name = "suaPhong1";
            this.suaPhong1.Size = new System.Drawing.Size(1280, 820);
            this.suaPhong1.TabIndex = 5;
            // 
            // QuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.QuanlyPagecontrol);
            this.Name = "QuanLyPhong";
            this.Size = new System.Drawing.Size(1280, 820);
            ((System.ComponentModel.ISupportInitialize)(this.QuanlyPagecontrol)).EndInit();
            this.QuanlyPagecontrol.ResumeLayout(false);
            this.PageQuanly.ResumeLayout(false);
            this.PageQuanly.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.PageThemphongmoi.ResumeLayout(false);
            this.PageSuaphong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationFrame QuanlyPagecontrol;
        private DevExpress.XtraBars.Navigation.NavigationPage PageQuanly;
        protected DevExpress.XtraEditors.SplitContainerControl splitContainerControl;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraEditors.LabelControl labelTitle;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel wbntQuanlyphong;
        private DevExpress.XtraBars.Navigation.NavigationPage PageThemphongmoi;
        private ThemPhongMoi themPhongMoi1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colTenPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhTrangPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraEditors.TileControl tileControl2;
        private DevExpress.XtraEditors.TileGroup grpMacDinh;
        private DevExpress.XtraEditors.TileItem tileAll;
        private DevExpress.XtraEditors.TileItem tileAvailable;
        private DevExpress.XtraEditors.TileItem tileRented;
        private DevExpress.XtraEditors.TileGroup grpLoaiPhong;
        private DevExpress.XtraBars.Navigation.NavigationPage PageSuaphong;
        private SuaPhong suaPhong1;
        private DevExpress.XtraGrid.Columns.GridColumn colTang;
    }
}

﻿namespace GUI.folderDichVu
{
    partial class DichVu
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions3 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions4 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions5 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions6 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions7 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.DichVuPagecontrol = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.PageDichvu = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.tileControl2 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup1 = new DevExpress.XtraEditors.TileGroup();
            this.tileAll = new DevExpress.XtraEditors.TileItem();
            this.grpLoaiDichVu = new DevExpress.XtraEditors.TileGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaDichVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHinhAnhDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelTitle = new DevExpress.XtraEditors.LabelControl();
            this.wbntDichvu = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.PageThemdichvu = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.themDichVu1 = new GUI.folderDichVu.ThemDichVu();
            this.PageSuadichvu = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.windowsUIButtonPanel2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.suaDichVu1 = new GUI.folderDichVu.SuaDichVu();
            this.PageLoaidichvu = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.loaiDichVu1 = new GUI.folderDichVu.LoaiDichVu();
            this.PageThemloaidichvu = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.windowsUIButtonPanel4 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.themLoaiDichVu1 = new GUI.folderDichVu.ThemLoaiDichVu();
            ((System.ComponentModel.ISupportInitialize)(this.DichVuPagecontrol)).BeginInit();
            this.DichVuPagecontrol.SuspendLayout();
            this.PageDichvu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.wbntDichvu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            this.PageThemdichvu.SuspendLayout();
            this.PageSuadichvu.SuspendLayout();
            this.PageLoaidichvu.SuspendLayout();
            this.PageThemloaidichvu.SuspendLayout();
            this.SuspendLayout();
            // 
            // DichVuPagecontrol
            // 
            this.DichVuPagecontrol.Appearance.BackColor = System.Drawing.Color.White;
            this.DichVuPagecontrol.Appearance.Options.UseBackColor = true;
            this.DichVuPagecontrol.Controls.Add(this.PageDichvu);
            this.DichVuPagecontrol.Controls.Add(this.PageThemdichvu);
            this.DichVuPagecontrol.Controls.Add(this.PageSuadichvu);
            this.DichVuPagecontrol.Controls.Add(this.PageLoaidichvu);
            this.DichVuPagecontrol.Controls.Add(this.PageThemloaidichvu);
            this.DichVuPagecontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DichVuPagecontrol.Location = new System.Drawing.Point(0, 0);
            this.DichVuPagecontrol.Name = "DichVuPagecontrol";
            this.DichVuPagecontrol.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.PageDichvu,
            this.PageThemdichvu,
            this.PageSuadichvu,
            this.PageLoaidichvu,
            this.PageThemloaidichvu});
            this.DichVuPagecontrol.SelectedPage = this.PageDichvu;
            this.DichVuPagecontrol.Size = new System.Drawing.Size(1062, 671);
            this.DichVuPagecontrol.TabIndex = 5;
            this.DichVuPagecontrol.Text = "navigationFrame1";
            this.DichVuPagecontrol.SelectedPageChanging += new DevExpress.XtraBars.Navigation.SelectedPageChangingEventHandler(this.DichVuPagecontrol_SelectedPageChanging);
            // 
            // PageDichvu
            // 
            this.PageDichvu.Caption = "PageDichvu";
            this.PageDichvu.Controls.Add(this.splitContainerControl);
            this.PageDichvu.Controls.Add(this.labelTitle);
            this.PageDichvu.Controls.Add(this.wbntDichvu);
            this.PageDichvu.Name = "PageDichvu";
            this.PageDichvu.Size = new System.Drawing.Size(1062, 671);
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
            this.splitContainerControl.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl.Panel2.Text = "Panel2";
            this.splitContainerControl.Size = new System.Drawing.Size(1062, 553);
            this.splitContainerControl.SplitterPosition = 125;
            this.splitContainerControl.TabIndex = 8;
            this.splitContainerControl.Text = "splitContainerControl1";
            // 
            // tileControl2
            // 
            this.tileControl2.AllowDrag = false;
            this.tileControl2.AllowDragTilesBetweenGroups = false;
            this.tileControl2.AllowSelectedItem = true;
            this.tileControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl2.Groups.Add(this.tileGroup1);
            this.tileControl2.Groups.Add(this.grpLoaiDichVu);
            this.tileControl2.IndentBetweenGroups = 30;
            this.tileControl2.ItemPadding = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.tileControl2.Location = new System.Drawing.Point(0, 0);
            this.tileControl2.MaxId = 9;
            this.tileControl2.Name = "tileControl2";
            this.tileControl2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileControl2.RowCount = 10;
            this.tileControl2.SelectedItem = this.tileAll;
            this.tileControl2.Size = new System.Drawing.Size(300, 553);
            this.tileControl2.TabIndex = 2;
            this.tileControl2.Text = "tileControl2";
            this.tileControl2.SelectedItemChanged += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileControl2_SelectedItemChanged);
            this.tileControl2.ItemPress += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileControl2_ItemPress);
            // 
            // tileGroup1
            // 
            this.tileGroup1.Items.Add(this.tileAll);
            this.tileGroup1.Name = "tileGroup1";
            this.tileGroup1.Text = "tileGroup1";
            // 
            // tileAll
            // 
            this.tileAll.AppearanceItem.Normal.BackColor = System.Drawing.Color.White;
            this.tileAll.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Gray;
            this.tileAll.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileAll.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Gray;
            this.tileAll.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileAll.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileAll.AppearanceItem.Normal.Options.UseFont = true;
            this.tileAll.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tileAll.AppearanceItem.Selected.BackColor = System.Drawing.Color.RoyalBlue;
            this.tileAll.AppearanceItem.Selected.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileAll.AppearanceItem.Selected.ForeColor = System.Drawing.Color.White;
            this.tileAll.AppearanceItem.Selected.Options.UseBackColor = true;
            this.tileAll.AppearanceItem.Selected.Options.UseFont = true;
            this.tileAll.AppearanceItem.Selected.Options.UseForeColor = true;
            tileItemElement1.Text = "Tất cả";
            this.tileAll.Elements.Add(tileItemElement1);
            this.tileAll.Id = 5;
            this.tileAll.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileAll.Name = "tileAll";
            this.tileAll.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem2_ItemClick);
            // 
            // grpLoaiDichVu
            // 
            this.grpLoaiDichVu.Name = "grpLoaiDichVu";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(756, 553);
            this.gridControl1.TabIndex = 13;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.ColumnPanelRowHeight = 50;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaDichVu,
            this.colTenDV,
            this.colDonGia,
            this.colDonVi,
            this.colLoaiDV,
            this.colHinhAnhDV});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsHint.ShowCellHints = false;
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.RowHeight = 80;
            // 
            // colMaDichVu
            // 
            this.colMaDichVu.Caption = "Mã dịch vụ";
            this.colMaDichVu.FieldName = "MaDV";
            this.colMaDichVu.Name = "colMaDichVu";
            this.colMaDichVu.Visible = true;
            this.colMaDichVu.VisibleIndex = 0;
            // 
            // colTenDV
            // 
            this.colTenDV.Caption = "Tên dịch vụ";
            this.colTenDV.FieldName = "TenDV";
            this.colTenDV.Name = "colTenDV";
            this.colTenDV.Visible = true;
            this.colTenDV.VisibleIndex = 1;
            // 
            // colDonGia
            // 
            this.colDonGia.Caption = "Đơn giá";
            this.colDonGia.DisplayFormat.FormatString = "###,###,##0 VNĐ";
            this.colDonGia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDonGia.FieldName = "DonGia";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.Visible = true;
            this.colDonGia.VisibleIndex = 2;
            // 
            // colDonVi
            // 
            this.colDonVi.Caption = "Đơn vị";
            this.colDonVi.FieldName = "DonVi";
            this.colDonVi.Name = "colDonVi";
            this.colDonVi.Visible = true;
            this.colDonVi.VisibleIndex = 3;
            // 
            // colLoaiDV
            // 
            this.colLoaiDV.Caption = "Loại dịch vụ";
            this.colLoaiDV.FieldName = "TenLDV";
            this.colLoaiDV.Name = "colLoaiDV";
            this.colLoaiDV.Visible = true;
            this.colLoaiDV.VisibleIndex = 4;
            // 
            // colHinhAnhDV
            // 
            this.colHinhAnhDV.Caption = "Hình ảnh";
            this.colHinhAnhDV.FieldName = "HinhAnhDV";
            this.colHinhAnhDV.Name = "colHinhAnhDV";
            this.colHinhAnhDV.Visible = true;
            this.colHinhAnhDV.VisibleIndex = 5;
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
            this.labelTitle.Size = new System.Drawing.Size(99, 38);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "DỊCH VỤ";
            // 
            // wbntDichvu
            // 
            this.wbntDichvu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wbntDichvu.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thêm Dịch Vụ", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Thêm Dịch Vụ", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Sửa Dịch Vụ", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Sửa Dịch Vụ", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Button", true, windowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Button", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Quản Lý Loại Dịch Vụ", true, windowsUIButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Quản Lý Loại Dịch Vụ", -1, false)});
            this.wbntDichvu.Controls.Add(this.searchControl1);
            this.wbntDichvu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wbntDichvu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wbntDichvu.ForeColor = System.Drawing.Color.White;
            this.wbntDichvu.Location = new System.Drawing.Point(0, 591);
            this.wbntDichvu.Name = "wbntDichvu";
            this.wbntDichvu.Size = new System.Drawing.Size(1062, 80);
            this.wbntDichvu.TabIndex = 9;
            this.wbntDichvu.Text = "windowsUIButtonPanel1";
            this.wbntDichvu.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.wbntDichvu_ButtonClick);
            // 
            // searchControl1
            // 
            this.searchControl1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchControl1.EditValue = "";
            this.searchControl1.Location = new System.Drawing.Point(791, 22);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchControl1.Properties.Appearance.Options.UseFont = true;
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Size = new System.Drawing.Size(248, 34);
            this.searchControl1.TabIndex = 0;
            // 
            // PageThemdichvu
            // 
            this.PageThemdichvu.Caption = "PageThemdichvu";
            this.PageThemdichvu.Controls.Add(this.themDichVu1);
            this.PageThemdichvu.Name = "PageThemdichvu";
            this.PageThemdichvu.Size = new System.Drawing.Size(1062, 671);
            // 
            // themDichVu1
            // 
            this.themDichVu1.actionBack = null;
            this.themDichVu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themDichVu1.Location = new System.Drawing.Point(0, 0);
            this.themDichVu1.Name = "themDichVu1";
            this.themDichVu1.Size = new System.Drawing.Size(1062, 671);
            this.themDichVu1.TabIndex = 5;
            // 
            // PageSuadichvu
            // 
            this.PageSuadichvu.Caption = "PageSuadichvu";
            this.PageSuadichvu.Controls.Add(this.windowsUIButtonPanel2);
            this.PageSuadichvu.Controls.Add(this.suaDichVu1);
            this.PageSuadichvu.Name = "PageSuadichvu";
            this.PageSuadichvu.Size = new System.Drawing.Size(1062, 671);
            // 
            // windowsUIButtonPanel2
            // 
            this.windowsUIButtonPanel2.BackColor = System.Drawing.Color.White;
            windowsUIButtonImageOptions5.ImageUri.Uri = "hybriddemo_back%20button;Svg";
            this.windowsUIButtonPanel2.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("", true, windowsUIButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.windowsUIButtonPanel2.Location = new System.Drawing.Point(3, 3);
            this.windowsUIButtonPanel2.Name = "windowsUIButtonPanel2";
            this.windowsUIButtonPanel2.Size = new System.Drawing.Size(56, 58);
            this.windowsUIButtonPanel2.TabIndex = 3;
            this.windowsUIButtonPanel2.Text = "windowsUIButtonPanel2";
            this.windowsUIButtonPanel2.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.wbntBack_ButtonClick);
            // 
            // suaDichVu1
            // 
            this.suaDichVu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suaDichVu1.Location = new System.Drawing.Point(0, 0);
            this.suaDichVu1.Name = "suaDichVu1";
            this.suaDichVu1.Size = new System.Drawing.Size(1062, 671);
            this.suaDichVu1.TabIndex = 4;
            // 
            // PageLoaidichvu
            // 
            this.PageLoaidichvu.Caption = "PageLoaidichvu";
            this.PageLoaidichvu.Controls.Add(this.windowsUIButtonPanel1);
            this.PageLoaidichvu.Controls.Add(this.loaiDichVu1);
            this.PageLoaidichvu.Name = "PageLoaidichvu";
            this.PageLoaidichvu.Size = new System.Drawing.Size(1062, 671);
            // 
            // windowsUIButtonPanel1
            // 
            this.windowsUIButtonPanel1.BackColor = System.Drawing.Color.White;
            windowsUIButtonImageOptions6.ImageUri.Uri = "hybriddemo_back%20button;Svg";
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("", true, windowsUIButtonImageOptions6, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.windowsUIButtonPanel1.Location = new System.Drawing.Point(3, 3);
            this.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(56, 58);
            this.windowsUIButtonPanel1.TabIndex = 2;
            this.windowsUIButtonPanel1.Text = "windowsUIButtonPanel2";
            this.windowsUIButtonPanel1.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.wbntBack_ButtonClick);
            // 
            // loaiDichVu1
            // 
            this.loaiDichVu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loaiDichVu1.Location = new System.Drawing.Point(0, 0);
            this.loaiDichVu1.Name = "loaiDichVu1";
            this.loaiDichVu1.Size = new System.Drawing.Size(1062, 671);
            this.loaiDichVu1.TabIndex = 3;
            // 
            // PageThemloaidichvu
            // 
            this.PageThemloaidichvu.Caption = "PageThemloaidichvu";
            this.PageThemloaidichvu.Controls.Add(this.windowsUIButtonPanel4);
            this.PageThemloaidichvu.Controls.Add(this.themLoaiDichVu1);
            this.PageThemloaidichvu.Name = "PageThemloaidichvu";
            this.PageThemloaidichvu.Size = new System.Drawing.Size(1062, 671);
            // 
            // windowsUIButtonPanel4
            // 
            this.windowsUIButtonPanel4.BackColor = System.Drawing.Color.White;
            windowsUIButtonImageOptions7.ImageUri.Uri = "hybriddemo_back%20button;Svg";
            this.windowsUIButtonPanel4.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("", true, windowsUIButtonImageOptions7, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.windowsUIButtonPanel4.Location = new System.Drawing.Point(3, 3);
            this.windowsUIButtonPanel4.Name = "windowsUIButtonPanel4";
            this.windowsUIButtonPanel4.Size = new System.Drawing.Size(56, 58);
            this.windowsUIButtonPanel4.TabIndex = 3;
            this.windowsUIButtonPanel4.Text = "windowsUIButtonPanel2";
            this.windowsUIButtonPanel4.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.wbntBack_ButtonClick);
            // 
            // themLoaiDichVu1
            // 
            this.themLoaiDichVu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themLoaiDichVu1.Location = new System.Drawing.Point(0, 0);
            this.themLoaiDichVu1.Name = "themLoaiDichVu1";
            this.themLoaiDichVu1.Size = new System.Drawing.Size(1062, 671);
            this.themLoaiDichVu1.TabIndex = 4;
            // 
            // DichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DichVuPagecontrol);
            this.Name = "DichVu";
            this.Size = new System.Drawing.Size(1062, 671);
            ((System.ComponentModel.ISupportInitialize)(this.DichVuPagecontrol)).EndInit();
            this.DichVuPagecontrol.ResumeLayout(false);
            this.PageDichvu.ResumeLayout(false);
            this.PageDichvu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.wbntDichvu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            this.PageThemdichvu.ResumeLayout(false);
            this.PageSuadichvu.ResumeLayout(false);
            this.PageLoaidichvu.ResumeLayout(false);
            this.PageThemloaidichvu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationFrame DichVuPagecontrol;
        private DevExpress.XtraBars.Navigation.NavigationPage PageDichvu;
        protected DevExpress.XtraEditors.SplitContainerControl splitContainerControl;
        private DevExpress.XtraEditors.TileControl tileControl2;
        private DevExpress.XtraEditors.TileGroup tileGroup1;
        private DevExpress.XtraEditors.TileItem tileAll;
        private DevExpress.XtraEditors.LabelControl labelTitle;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel wbntDichvu;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraBars.Navigation.NavigationPage PageThemdichvu;
        private DevExpress.XtraBars.Navigation.NavigationPage PageSuadichvu;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel2;
        private DevExpress.XtraBars.Navigation.NavigationPage PageLoaidichvu;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;
        private DevExpress.XtraBars.Navigation.NavigationPage PageThemloaidichvu;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel4;
        private ThemDichVu themDichVu1;
        private SuaDichVu suaDichVu1;
        private LoaiDichVu loaiDichVu1;
        private ThemLoaiDichVu themLoaiDichVu1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDichVu;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDV;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn colDonVi;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiDV;
        private DevExpress.XtraGrid.Columns.GridColumn colHinhAnhDV;
        private DevExpress.XtraEditors.TileGroup grpLoaiDichVu;
    }
}

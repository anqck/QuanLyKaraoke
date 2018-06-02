namespace GUI.folderDichVu
{
    partial class ChonDichVu
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
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement9 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement10 = new DevExpress.XtraEditors.TileItemElement();
            this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSelect = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colMaDichVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHinhAnh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colDonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tileControl2 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup1 = new DevExpress.XtraEditors.TileGroup();
            this.tileAll = new DevExpress.XtraEditors.TileItem();
            this.tileSelected = new DevExpress.XtraEditors.TileItem();
            this.grpLoaiDichVu = new DevExpress.XtraEditors.TileGroup();
            this.tileDichVu = new DevExpress.XtraEditors.TileItem();
            this.tileKhuyenMai = new DevExpress.XtraEditors.TileItem();
            this.tileItem1 = new DevExpress.XtraEditors.TileItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl
            // 
            this.splitContainerControl.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1;
            this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl.IsSplitterFixed = true;
            this.splitContainerControl.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.splitContainerControl.Name = "splitContainerControl";
            this.splitContainerControl.Panel1.Controls.Add(this.searchControl1);
            this.splitContainerControl.Panel1.Controls.Add(this.tileControl2);
            this.splitContainerControl.Panel1.MinSize = 300;
            this.splitContainerControl.Panel1.Text = "Panel1";
            this.splitContainerControl.Panel2.Appearance.BackColor = System.Drawing.Color.White;
            this.splitContainerControl.Panel2.Appearance.BackColor2 = System.Drawing.Color.White;
            this.splitContainerControl.Panel2.Appearance.BorderColor = System.Drawing.Color.White;
            this.splitContainerControl.Panel2.Appearance.Options.UseBackColor = true;
            this.splitContainerControl.Panel2.Appearance.Options.UseBorderColor = true;
            this.splitContainerControl.Panel2.Controls.Add(this.gridControl2);
            this.splitContainerControl.Panel2.Text = "Panel2";
            this.splitContainerControl.Size = new System.Drawing.Size(1052, 596);
            this.splitContainerControl.SplitterPosition = 125;
            this.splitContainerControl.TabIndex = 9;
            this.splitContainerControl.Text = "splitContainerControl1";
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.gridControl2;
            this.searchControl1.Location = new System.Drawing.Point(21, 560);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.gridControl2;
            this.searchControl1.Size = new System.Drawing.Size(246, 22);
            this.searchControl1.TabIndex = 15;
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Margin = new System.Windows.Forms.Padding(5);
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Padding = new System.Windows.Forms.Padding(5);
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1,
            this.repositoryItemCheckEdit1});
            this.gridControl2.Size = new System.Drawing.Size(746, 596);
            this.gridControl2.TabIndex = 14;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Gray;
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.ColumnPanelRowHeight = 50;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSelect,
            this.colMaDichVu,
            this.colTenDV,
            this.colLoaiDV,
            this.colHinhAnh,
            this.colDonGia,
            this.colSoLuong,
            this.colDonVi});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.gridView2.OptionsCustomization.AllowSort = false;
            this.gridView2.OptionsFilter.AllowFilterEditor = false;
            this.gridView2.OptionsHint.ShowCellHints = false;
            this.gridView2.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowIndicator = false;
            this.gridView2.RowHeight = 40;
            this.gridView2.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView2_SelectionChanged);
            this.gridView2.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridView2_ShowingEditor);
            this.gridView2.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridView2_CustomUnboundColumnData);
            this.gridView2.CustomRowFilter += new DevExpress.XtraGrid.Views.Base.RowFilterEventHandler(this.gridView2_CustomRowFilter);
            this.gridView2.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridView2_ValidatingEditor);
            // 
            // colSelect
            // 
            this.colSelect.Caption = "Chọn";
            this.colSelect.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colSelect.FieldName = "colSelect";
            this.colSelect.Name = "colSelect";
            this.colSelect.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.colSelect.Visible = true;
            this.colSelect.VisibleIndex = 0;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // colMaDichVu
            // 
            this.colMaDichVu.Caption = "Mã dịch vụ";
            this.colMaDichVu.FieldName = "MaDV";
            this.colMaDichVu.Name = "colMaDichVu";
            this.colMaDichVu.Visible = true;
            this.colMaDichVu.VisibleIndex = 6;
            // 
            // colTenDV
            // 
            this.colTenDV.Caption = "Tên dịch vụ";
            this.colTenDV.FieldName = "TenDV";
            this.colTenDV.Name = "colTenDV";
            this.colTenDV.OptionsColumn.AllowEdit = false;
            this.colTenDV.OptionsColumn.ReadOnly = true;
            this.colTenDV.Visible = true;
            this.colTenDV.VisibleIndex = 1;
            // 
            // colLoaiDV
            // 
            this.colLoaiDV.Caption = "Loại dịch vụ";
            this.colLoaiDV.FieldName = "TenLDV";
            this.colLoaiDV.Name = "colLoaiDV";
            this.colLoaiDV.OptionsColumn.AllowEdit = false;
            this.colLoaiDV.OptionsColumn.ReadOnly = true;
            this.colLoaiDV.Visible = true;
            this.colLoaiDV.VisibleIndex = 3;
            // 
            // colHinhAnh
            // 
            this.colHinhAnh.Caption = "Hình Ảnh";
            this.colHinhAnh.FieldName = "HinhAnhDV";
            this.colHinhAnh.Name = "colHinhAnh";
            this.colHinhAnh.Visible = true;
            this.colHinhAnh.VisibleIndex = 4;
            // 
            // colDonGia
            // 
            this.colDonGia.Caption = "Đơn giá";
            this.colDonGia.DisplayFormat.FormatString = "###,###,##0 VNĐ";
            this.colDonGia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDonGia.FieldName = "DonGia";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.OptionsColumn.AllowEdit = false;
            this.colDonGia.OptionsColumn.ReadOnly = true;
            this.colDonGia.Visible = true;
            this.colDonGia.VisibleIndex = 7;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "Số lượng";
            this.colSoLuong.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colSoLuong.FieldName = "colSoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 5;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.DisplayFormat.FormatString = "##0";
            this.repositoryItemSpinEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit1.EditFormat.FormatString = "##0";
            this.repositoryItemSpinEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit1.Mask.EditMask = "##0";
            this.repositoryItemSpinEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // colDonVi
            // 
            this.colDonVi.Caption = "Đơn vị";
            this.colDonVi.FieldName = "DonVi";
            this.colDonVi.Name = "colDonVi";
            this.colDonVi.OptionsColumn.AllowEdit = false;
            this.colDonVi.OptionsColumn.ReadOnly = true;
            this.colDonVi.Visible = true;
            this.colDonVi.VisibleIndex = 2;
            // 
            // tileControl2
            // 
            this.tileControl2.AllowDrag = false;
            this.tileControl2.AllowDragTilesBetweenGroups = false;
            this.tileControl2.AllowSelectedItem = true;
            this.tileControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl2.Groups.Add(this.tileGroup1);
            this.tileControl2.Groups.Add(this.grpLoaiDichVu);
            this.tileControl2.IndentBetweenGroups = 20;
            this.tileControl2.ItemPadding = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.tileControl2.Location = new System.Drawing.Point(0, 0);
            this.tileControl2.MaxId = 14;
            this.tileControl2.Name = "tileControl2";
            this.tileControl2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileControl2.RowCount = 10;
            this.tileControl2.SelectedItem = this.tileAll;
            this.tileControl2.Size = new System.Drawing.Size(300, 596);
            this.tileControl2.TabIndex = 2;
            this.tileControl2.Text = "tileControl2";
            // 
            // tileGroup1
            // 
            this.tileGroup1.Items.Add(this.tileAll);
            this.tileGroup1.Items.Add(this.tileSelected);
            this.tileGroup1.Name = "tileGroup1";
            this.tileGroup1.Text = "Đã chọn";
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
            tileItemElement6.Text = "Tất cả";
            this.tileAll.Elements.Add(tileItemElement6);
            this.tileAll.Id = 5;
            this.tileAll.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileAll.Name = "tileAll";
            this.tileAll.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileAll_ItemClick);
            // 
            // tileSelected
            // 
            this.tileSelected.AppearanceItem.Normal.BackColor = System.Drawing.Color.White;
            this.tileSelected.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Gray;
            this.tileSelected.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileSelected.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Gray;
            this.tileSelected.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileSelected.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileSelected.AppearanceItem.Normal.Options.UseFont = true;
            this.tileSelected.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tileSelected.AppearanceItem.Selected.BackColor = System.Drawing.Color.RoyalBlue;
            this.tileSelected.AppearanceItem.Selected.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileSelected.AppearanceItem.Selected.ForeColor = System.Drawing.Color.White;
            this.tileSelected.AppearanceItem.Selected.Options.UseBackColor = true;
            this.tileSelected.AppearanceItem.Selected.Options.UseFont = true;
            this.tileSelected.AppearanceItem.Selected.Options.UseForeColor = true;
            tileItemElement7.Text = "Đã chọn";
            this.tileSelected.Elements.Add(tileItemElement7);
            this.tileSelected.Id = 9;
            this.tileSelected.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileSelected.Name = "tileSelected";
            this.tileSelected.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileSelected_ItemClick);
            // 
            // grpLoaiDichVu
            // 
            this.grpLoaiDichVu.Items.Add(this.tileDichVu);
            this.grpLoaiDichVu.Items.Add(this.tileKhuyenMai);
            this.grpLoaiDichVu.Name = "grpLoaiDichVu";
            this.grpLoaiDichVu.Text = "Khuyến mãi";
            // 
            // tileDichVu
            // 
            this.tileDichVu.AppearanceItem.Normal.BackColor = System.Drawing.Color.White;
            this.tileDichVu.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Gray;
            this.tileDichVu.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileDichVu.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Gray;
            this.tileDichVu.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileDichVu.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileDichVu.AppearanceItem.Normal.Options.UseFont = true;
            this.tileDichVu.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tileDichVu.AppearanceItem.Selected.BackColor = System.Drawing.Color.RoyalBlue;
            this.tileDichVu.AppearanceItem.Selected.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileDichVu.AppearanceItem.Selected.ForeColor = System.Drawing.Color.White;
            this.tileDichVu.AppearanceItem.Selected.Options.UseBackColor = true;
            this.tileDichVu.AppearanceItem.Selected.Options.UseFont = true;
            this.tileDichVu.AppearanceItem.Selected.Options.UseForeColor = true;
            tileItemElement8.Text = "Dịch vụ";
            this.tileDichVu.Elements.Add(tileItemElement8);
            this.tileDichVu.Id = 12;
            this.tileDichVu.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileDichVu.Name = "tileDichVu";
            this.tileDichVu.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileDichVu_ItemClick);
            // 
            // tileKhuyenMai
            // 
            this.tileKhuyenMai.AppearanceItem.Normal.BackColor = System.Drawing.Color.White;
            this.tileKhuyenMai.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Gray;
            this.tileKhuyenMai.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileKhuyenMai.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Gray;
            this.tileKhuyenMai.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileKhuyenMai.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileKhuyenMai.AppearanceItem.Normal.Options.UseFont = true;
            this.tileKhuyenMai.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tileKhuyenMai.AppearanceItem.Selected.BackColor = System.Drawing.Color.RoyalBlue;
            this.tileKhuyenMai.AppearanceItem.Selected.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileKhuyenMai.AppearanceItem.Selected.ForeColor = System.Drawing.Color.White;
            this.tileKhuyenMai.AppearanceItem.Selected.Options.UseBackColor = true;
            this.tileKhuyenMai.AppearanceItem.Selected.Options.UseFont = true;
            this.tileKhuyenMai.AppearanceItem.Selected.Options.UseForeColor = true;
            tileItemElement9.Text = "Khuyến mãi";
            this.tileKhuyenMai.Elements.Add(tileItemElement9);
            this.tileKhuyenMai.Id = 13;
            this.tileKhuyenMai.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileKhuyenMai.Name = "tileKhuyenMai";
            this.tileKhuyenMai.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileKhuyenMai_ItemClick);
            // 
            // tileItem1
            // 
            this.tileItem1.AppearanceItem.Normal.BackColor = System.Drawing.Color.White;
            this.tileItem1.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Gray;
            this.tileItem1.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItem1.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Gray;
            this.tileItem1.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem1.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItem1.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItem1.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tileItem1.AppearanceItem.Selected.BackColor = System.Drawing.Color.RoyalBlue;
            this.tileItem1.AppearanceItem.Selected.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItem1.AppearanceItem.Selected.ForeColor = System.Drawing.Color.White;
            this.tileItem1.AppearanceItem.Selected.Options.UseBackColor = true;
            this.tileItem1.AppearanceItem.Selected.Options.UseFont = true;
            this.tileItem1.AppearanceItem.Selected.Options.UseForeColor = true;
            tileItemElement10.Text = "Đã chọn";
            this.tileItem1.Elements.Add(tileItemElement10);
            this.tileItem1.Id = 9;
            this.tileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem1.Name = "tileItem1";
            // 
            // ChonDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl);
            this.Name = "ChonDichVu";
            this.Size = new System.Drawing.Size(1052, 596);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraEditors.SplitContainerControl splitContainerControl;
        private DevExpress.XtraEditors.TileControl tileControl2;
        private DevExpress.XtraEditors.TileGroup tileGroup1;
        private DevExpress.XtraEditors.TileItem tileAll;
        private DevExpress.XtraEditors.TileGroup grpLoaiDichVu;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDV;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiDV;
        private DevExpress.XtraGrid.Columns.GridColumn colDonVi;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.TileItem tileSelected;
        private DevExpress.XtraGrid.Columns.GridColumn colHinhAnh;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDichVu;
        private DevExpress.XtraGrid.Columns.GridColumn colSelect;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.TileItem tileDichVu;
        private DevExpress.XtraEditors.TileItem tileKhuyenMai;
        private DevExpress.XtraEditors.TileItem tileItem1;
    }
}

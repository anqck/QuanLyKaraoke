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
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.QuanlyPagecontrol = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.PageQuanly = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.tileControl2 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup1 = new DevExpress.XtraEditors.TileGroup();
            this.itemTrong = new DevExpress.XtraEditors.TileItem();
            this.tileItem2 = new DevExpress.XtraEditors.TileItem();
            this.tileItem3 = new DevExpress.XtraEditors.TileItem();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinhTrangPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelTitle = new DevExpress.XtraEditors.LabelControl();
            this.wbntQuanlyphong = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.PageThemphongmoi = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.wbntThemphong = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.themPhongMoi1 = new GUI.folderQuanLyPhong.ThemPhongMoi();
            colLoaiPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.QuanlyPagecontrol)).BeginInit();
            this.QuanlyPagecontrol.SuspendLayout();
            this.PageQuanly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.PageThemphongmoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // colLoaiPhong
            // 
            colLoaiPhong.Caption = "Loại phòng";
            colLoaiPhong.FieldName = "TenLoaiPhong";
            colLoaiPhong.Name = "colLoaiPhong";
            colLoaiPhong.Visible = true;
            colLoaiPhong.VisibleIndex = 4;
            // 
            // QuanlyPagecontrol
            // 
            this.QuanlyPagecontrol.Appearance.BackColor = System.Drawing.Color.White;
            this.QuanlyPagecontrol.Appearance.Options.UseBackColor = true;
            this.QuanlyPagecontrol.Controls.Add(this.PageQuanly);
            this.QuanlyPagecontrol.Controls.Add(this.PageThemphongmoi);
            this.QuanlyPagecontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuanlyPagecontrol.Location = new System.Drawing.Point(0, 0);
            this.QuanlyPagecontrol.Name = "QuanlyPagecontrol";
            this.QuanlyPagecontrol.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.PageQuanly,
            this.PageThemphongmoi});
            this.QuanlyPagecontrol.SelectedPage = this.PageQuanly;
            this.QuanlyPagecontrol.Size = new System.Drawing.Size(1040, 617);
            this.QuanlyPagecontrol.TabIndex = 6;
            this.QuanlyPagecontrol.Text = "navigationFrame1";
            // 
            // PageQuanly
            // 
            this.PageQuanly.Caption = "PageQuanly";
            this.PageQuanly.Controls.Add(this.splitContainerControl);
            this.PageQuanly.Controls.Add(this.labelTitle);
            this.PageQuanly.Controls.Add(this.wbntQuanlyphong);
            this.PageQuanly.Name = "PageQuanly";
            this.PageQuanly.Size = new System.Drawing.Size(1040, 617);
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
            this.splitContainerControl.Size = new System.Drawing.Size(1040, 499);
            this.splitContainerControl.SplitterPosition = 125;
            this.splitContainerControl.TabIndex = 8;
            this.splitContainerControl.Text = "splitContainerControl1";
            // 
            // tileControl2
            // 
            this.tileControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl2.Groups.Add(this.tileGroup1);
            this.tileControl2.ItemPadding = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.tileControl2.Location = new System.Drawing.Point(0, 0);
            this.tileControl2.MaxId = 4;
            this.tileControl2.Name = "tileControl2";
            this.tileControl2.Size = new System.Drawing.Size(300, 499);
            this.tileControl2.TabIndex = 1;
            this.tileControl2.Text = "tileControl2";
            // 
            // tileGroup1
            // 
            this.tileGroup1.Items.Add(this.itemTrong);
            this.tileGroup1.Items.Add(this.tileItem2);
            this.tileGroup1.Items.Add(this.tileItem3);
            this.tileGroup1.Name = "tileGroup1";
            this.tileGroup1.Text = "tileGroup1";
            // 
            // itemTrong
            // 
            this.itemTrong.AppearanceItem.Normal.BackColor = System.Drawing.Color.White;
            this.itemTrong.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTrong.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Gray;
            this.itemTrong.AppearanceItem.Normal.Options.UseBackColor = true;
            this.itemTrong.AppearanceItem.Normal.Options.UseFont = true;
            this.itemTrong.AppearanceItem.Normal.Options.UseForeColor = true;
            this.itemTrong.AppearanceItem.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.itemTrong.AppearanceItem.Pressed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTrong.AppearanceItem.Pressed.ForeColor = System.Drawing.Color.Gray;
            this.itemTrong.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.itemTrong.AppearanceItem.Pressed.Options.UseFont = true;
            this.itemTrong.AppearanceItem.Pressed.Options.UseForeColor = true;
            this.itemTrong.AppearanceItem.Selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.itemTrong.AppearanceItem.Selected.Options.UseBackColor = true;
            tileItemElement1.Text = "Còn trống";
            this.itemTrong.Elements.Add(tileItemElement1);
            this.itemTrong.Id = 0;
            this.itemTrong.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.itemTrong.Name = "itemTrong";
            // 
            // tileItem2
            // 
            this.tileItem2.AppearanceItem.Normal.BackColor = System.Drawing.Color.White;
            this.tileItem2.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItem2.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Gray;
            this.tileItem2.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem2.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItem2.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tileItem2.AppearanceItem.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tileItem2.AppearanceItem.Pressed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItem2.AppearanceItem.Pressed.ForeColor = System.Drawing.Color.Gray;
            this.tileItem2.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tileItem2.AppearanceItem.Pressed.Options.UseFont = true;
            this.tileItem2.AppearanceItem.Pressed.Options.UseForeColor = true;
            tileItemElement2.Text = "Đã đặt";
            this.tileItem2.Elements.Add(tileItemElement2);
            this.tileItem2.Id = 1;
            this.tileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem2.Name = "tileItem2";
            // 
            // tileItem3
            // 
            this.tileItem3.AppearanceItem.Normal.BackColor = System.Drawing.Color.White;
            this.tileItem3.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItem3.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Gray;
            this.tileItem3.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem3.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItem3.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tileItem3.AppearanceItem.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tileItem3.AppearanceItem.Pressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItem3.AppearanceItem.Pressed.ForeColor = System.Drawing.Color.Gray;
            this.tileItem3.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tileItem3.AppearanceItem.Pressed.Options.UseFont = true;
            this.tileItem3.AppearanceItem.Pressed.Options.UseForeColor = true;
            tileItemElement3.Text = "Đã sử dụng";
            this.tileItem3.Elements.Add(tileItemElement3);
            this.tileItem3.Id = 2;
            this.tileItem3.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem3.Name = "tileItem3";
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.gridView1;
            this.gridControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(734, 499);
            this.gridControl.TabIndex = 4;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaPhong,
            this.colTenPhong,
            this.colTinhTrangPhong,
            this.colGhiChu,
            colLoaiPhong});
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMaPhong
            // 
            this.colMaPhong.Caption = "Mã Phòng";
            this.colMaPhong.FieldName = "MaPhong";
            this.colMaPhong.Name = "colMaPhong";
            this.colMaPhong.Visible = true;
            this.colMaPhong.VisibleIndex = 0;
            // 
            // colTenPhong
            // 
            this.colTenPhong.Caption = "Tên Phòng";
            this.colTenPhong.FieldName = "TenPhong";
            this.colTenPhong.Name = "colTenPhong";
            this.colTenPhong.Visible = true;
            this.colTenPhong.VisibleIndex = 1;
            // 
            // colTinhTrangPhong
            // 
            this.colTinhTrangPhong.Caption = "Tình trạng phòng";
            this.colTinhTrangPhong.FieldName = "TinhTrangPhong";
            this.colTinhTrangPhong.Name = "colTinhTrangPhong";
            this.colTinhTrangPhong.Visible = true;
            this.colTinhTrangPhong.VisibleIndex = 2;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 3;
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
            this.wbntQuanlyphong.BackColor = System.Drawing.Color.DimGray;
            this.wbntQuanlyphong.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thêm phòng", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton()});
            this.wbntQuanlyphong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wbntQuanlyphong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wbntQuanlyphong.ForeColor = System.Drawing.Color.White;
            this.wbntQuanlyphong.Location = new System.Drawing.Point(0, 537);
            this.wbntQuanlyphong.Name = "wbntQuanlyphong";
            this.wbntQuanlyphong.Size = new System.Drawing.Size(1040, 80);
            this.wbntQuanlyphong.TabIndex = 9;
            this.wbntQuanlyphong.Text = "windowsUIButtonPanel1";
            this.wbntQuanlyphong.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.wbntTinhtrangphong_ButtonClick);
            // 
            // PageThemphongmoi
            // 
            this.PageThemphongmoi.Caption = "PageThemphongmoi";
            this.PageThemphongmoi.Controls.Add(this.wbntThemphong);
            this.PageThemphongmoi.Controls.Add(this.themPhongMoi1);
            this.PageThemphongmoi.Name = "PageThemphongmoi";
            this.PageThemphongmoi.Size = new System.Drawing.Size(1040, 617);
            // 
            // wbntThemphong
            // 
            this.wbntThemphong.BackColor = System.Drawing.Color.White;
            windowsUIButtonImageOptions2.ImageUri.Uri = "hybriddemo_back%20button;Svg";
            this.wbntThemphong.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.wbntThemphong.Location = new System.Drawing.Point(3, 3);
            this.wbntThemphong.Name = "wbntThemphong";
            this.wbntThemphong.Size = new System.Drawing.Size(56, 58);
            this.wbntThemphong.TabIndex = 0;
            this.wbntThemphong.Text = "windowsUIButtonPanel2";
            this.wbntThemphong.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.wbntThemphong_ButtonClick);
            // 
            // themPhongMoi1
            // 
            this.themPhongMoi1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themPhongMoi1.Location = new System.Drawing.Point(0, 0);
            this.themPhongMoi1.Name = "themPhongMoi1";
            this.themPhongMoi1.Size = new System.Drawing.Size(1040, 617);
            this.themPhongMoi1.TabIndex = 5;
            // 
            // QuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.QuanlyPagecontrol);
            this.Name = "QuanLyPhong";
            this.Size = new System.Drawing.Size(1040, 617);
            ((System.ComponentModel.ISupportInitialize)(this.QuanlyPagecontrol)).EndInit();
            this.QuanlyPagecontrol.ResumeLayout(false);
            this.PageQuanly.ResumeLayout(false);
            this.PageQuanly.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.PageThemphongmoi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationFrame QuanlyPagecontrol;
        private DevExpress.XtraBars.Navigation.NavigationPage PageQuanly;
        protected DevExpress.XtraEditors.SplitContainerControl splitContainerControl;
        private DevExpress.XtraEditors.TileControl tileControl2;
        private DevExpress.XtraEditors.TileGroup tileGroup1;
        private DevExpress.XtraEditors.TileItem itemTrong;
        private DevExpress.XtraEditors.TileItem tileItem2;
        private DevExpress.XtraEditors.TileItem tileItem3;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraEditors.LabelControl labelTitle;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel wbntQuanlyphong;
        private DevExpress.XtraBars.Navigation.NavigationPage PageThemphongmoi;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel wbntThemphong;
        private ThemPhongMoi themPhongMoi1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colTenPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhTrangPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
    }
}

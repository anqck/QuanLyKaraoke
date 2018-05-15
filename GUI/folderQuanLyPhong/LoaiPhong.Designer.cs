namespace GUI.folderQuanLyPhong
{
    partial class LoaiPhong
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
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions6 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions7 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions8 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions9 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions10 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaLDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenLDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiPhongPagecontrol = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.PageLoaiphong = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.wbntLoaiphong = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.labelTitle = new DevExpress.XtraEditors.LabelControl();
            this.PageThemloaiphong = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.wbntBack_themloaiphong = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.PageSualoaiphong = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.wbntBack_sualoaiphong = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.suaLoaiPhong1 = new GUI.folderQuanLyPhong.SuaLoaiPhong();
            this.themLoaiPhong1 = new GUI.folderQuanLyPhong.ThemLoaiPhong();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoaiPhongPagecontrol)).BeginInit();
            this.LoaiPhongPagecontrol.SuspendLayout();
            this.PageLoaiphong.SuspendLayout();
            this.PageThemloaiphong.SuspendLayout();
            this.PageSualoaiphong.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(5, 43);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(967, 553);
            this.gridControl1.TabIndex = 17;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.ColumnPanelRowHeight = 50;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaLDV,
            this.colTenLDV,
            this.gridColumn1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.RowHeight = 40;
            // 
            // colMaLDV
            // 
            this.colMaLDV.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMaLDV.AppearanceCell.Options.UseFont = true;
            this.colMaLDV.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMaLDV.AppearanceHeader.ForeColor = System.Drawing.Color.Gray;
            this.colMaLDV.AppearanceHeader.Options.UseFont = true;
            this.colMaLDV.AppearanceHeader.Options.UseForeColor = true;
            this.colMaLDV.Caption = "Mã Loại Phòng";
            this.colMaLDV.FieldName = "MaLDV";
            this.colMaLDV.Name = "colMaLDV";
            this.colMaLDV.Visible = true;
            this.colMaLDV.VisibleIndex = 0;
            // 
            // colTenLDV
            // 
            this.colTenLDV.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTenLDV.AppearanceCell.Options.UseFont = true;
            this.colTenLDV.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTenLDV.AppearanceHeader.ForeColor = System.Drawing.Color.Gray;
            this.colTenLDV.AppearanceHeader.Options.UseFont = true;
            this.colTenLDV.AppearanceHeader.Options.UseForeColor = true;
            this.colTenLDV.Caption = "Tên Loại Phòng";
            this.colTenLDV.FieldName = "TenLDV";
            this.colTenLDV.Name = "colTenLDV";
            this.colTenLDV.Visible = true;
            this.colTenLDV.VisibleIndex = 1;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Giá để thế nào?";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // LoaiPhongPagecontrol
            // 
            this.LoaiPhongPagecontrol.Appearance.BackColor = System.Drawing.Color.White;
            this.LoaiPhongPagecontrol.Appearance.Options.UseBackColor = true;
            this.LoaiPhongPagecontrol.Controls.Add(this.PageLoaiphong);
            this.LoaiPhongPagecontrol.Controls.Add(this.PageThemloaiphong);
            this.LoaiPhongPagecontrol.Controls.Add(this.PageSualoaiphong);
            this.LoaiPhongPagecontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoaiPhongPagecontrol.Location = new System.Drawing.Point(0, 0);
            this.LoaiPhongPagecontrol.Name = "LoaiPhongPagecontrol";
            this.LoaiPhongPagecontrol.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.PageLoaiphong,
            this.PageThemloaiphong,
            this.PageSualoaiphong});
            this.LoaiPhongPagecontrol.SelectedPage = this.PageLoaiphong;
            this.LoaiPhongPagecontrol.Size = new System.Drawing.Size(977, 601);
            this.LoaiPhongPagecontrol.TabIndex = 19;
            this.LoaiPhongPagecontrol.Text = "navigationFrame1";
            // 
            // PageLoaiphong
            // 
            this.PageLoaiphong.Caption = "PageLoaiphong";
            this.PageLoaiphong.Controls.Add(this.wbntLoaiphong);
            this.PageLoaiphong.Controls.Add(this.gridControl1);
            this.PageLoaiphong.Controls.Add(this.labelTitle);
            this.PageLoaiphong.Name = "PageLoaiphong";
            this.PageLoaiphong.Padding = new System.Windows.Forms.Padding(5);
            this.PageLoaiphong.Size = new System.Drawing.Size(977, 601);
            // 
            // wbntLoaiphong
            // 
            this.wbntLoaiphong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wbntLoaiphong.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thêm Loại Phòng", true, windowsUIButtonImageOptions6, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Thêm Loại Dịch Vụ", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Sửa Loại Phòng", true, windowsUIButtonImageOptions7, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Sửa Loại Dịch Vụ", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Xóa Loại Phòng", true, windowsUIButtonImageOptions8, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Xóa Loại Dịch Vụ", -1, false)});
            this.wbntLoaiphong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wbntLoaiphong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wbntLoaiphong.ForeColor = System.Drawing.Color.White;
            this.wbntLoaiphong.Location = new System.Drawing.Point(5, 516);
            this.wbntLoaiphong.Name = "wbntLoaiphong";
            this.wbntLoaiphong.Size = new System.Drawing.Size(967, 80);
            this.wbntLoaiphong.TabIndex = 14;
            this.wbntLoaiphong.Text = "windowsUIButtonPanel1";
            this.wbntLoaiphong.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.wbntLoaiphong_ButtonClick);
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
            this.labelTitle.Size = new System.Drawing.Size(144, 38);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "LOẠI PHÒNG";
            // 
            // PageThemloaiphong
            // 
            this.PageThemloaiphong.Caption = "PageThemloaiphong";
            this.PageThemloaiphong.Controls.Add(this.wbntBack_themloaiphong);
            this.PageThemloaiphong.Controls.Add(this.themLoaiPhong1);
            this.PageThemloaiphong.Name = "PageThemloaiphong";
            this.PageThemloaiphong.Size = new System.Drawing.Size(977, 601);
            // 
            // wbntBack_themloaiphong
            // 
            this.wbntBack_themloaiphong.BackColor = System.Drawing.Color.White;
            windowsUIButtonImageOptions9.ImageUri.Uri = "hybriddemo_back%20button;Svg";
            this.wbntBack_themloaiphong.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("", true, windowsUIButtonImageOptions9, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.wbntBack_themloaiphong.Location = new System.Drawing.Point(3, 3);
            this.wbntBack_themloaiphong.Name = "wbntBack_themloaiphong";
            this.wbntBack_themloaiphong.Size = new System.Drawing.Size(56, 58);
            this.wbntBack_themloaiphong.TabIndex = 3;
            this.wbntBack_themloaiphong.Text = "windowsUIButtonPanel2";
            this.wbntBack_themloaiphong.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.wbntBack_themloaiphong_ButtonClick);
            // 
            // PageSualoaiphong
            // 
            this.PageSualoaiphong.Caption = "PageSualoaiphong";
            this.PageSualoaiphong.Controls.Add(this.wbntBack_sualoaiphong);
            this.PageSualoaiphong.Controls.Add(this.suaLoaiPhong1);
            this.PageSualoaiphong.Name = "PageSualoaiphong";
            this.PageSualoaiphong.Size = new System.Drawing.Size(977, 601);
            // 
            // wbntBack_sualoaiphong
            // 
            this.wbntBack_sualoaiphong.BackColor = System.Drawing.Color.White;
            windowsUIButtonImageOptions10.ImageUri.Uri = "hybriddemo_back%20button;Svg";
            this.wbntBack_sualoaiphong.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("", true, windowsUIButtonImageOptions10, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.wbntBack_sualoaiphong.Location = new System.Drawing.Point(3, 3);
            this.wbntBack_sualoaiphong.Name = "wbntBack_sualoaiphong";
            this.wbntBack_sualoaiphong.Size = new System.Drawing.Size(56, 58);
            this.wbntBack_sualoaiphong.TabIndex = 3;
            this.wbntBack_sualoaiphong.Text = "windowsUIButtonPanel2";
            this.wbntBack_sualoaiphong.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.wbntBack_sualoaiphong_ButtonClick);
            // 
            // suaLoaiPhong1
            // 
            this.suaLoaiPhong1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suaLoaiPhong1.Location = new System.Drawing.Point(0, 0);
            this.suaLoaiPhong1.Name = "suaLoaiPhong1";
            this.suaLoaiPhong1.Size = new System.Drawing.Size(977, 601);
            this.suaLoaiPhong1.TabIndex = 18;
            // 
            // themLoaiPhong1
            // 
            this.themLoaiPhong1.Appearance.BackColor = System.Drawing.Color.White;
            this.themLoaiPhong1.Appearance.Options.UseBackColor = true;
            this.themLoaiPhong1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themLoaiPhong1.Location = new System.Drawing.Point(0, 0);
            this.themLoaiPhong1.Name = "themLoaiPhong1";
            this.themLoaiPhong1.Size = new System.Drawing.Size(977, 601);
            this.themLoaiPhong1.TabIndex = 4;
            // 
            // LoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LoaiPhongPagecontrol);
            this.Name = "LoaiPhong";
            this.Size = new System.Drawing.Size(977, 601);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoaiPhongPagecontrol)).EndInit();
            this.LoaiPhongPagecontrol.ResumeLayout(false);
            this.PageLoaiphong.ResumeLayout(false);
            this.PageLoaiphong.PerformLayout();
            this.PageThemloaiphong.ResumeLayout(false);
            this.PageSualoaiphong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationFrame LoaiPhongPagecontrol;
        private DevExpress.XtraBars.Navigation.NavigationPage PageLoaiphong;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel wbntLoaiphong;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLDV;
        private DevExpress.XtraGrid.Columns.GridColumn colTenLDV;
        private DevExpress.XtraEditors.LabelControl labelTitle;
        private DevExpress.XtraBars.Navigation.NavigationPage PageThemloaiphong;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel wbntBack_themloaiphong;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel wbntBack_sualoaiphong;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraBars.Navigation.NavigationPage PageSualoaiphong;
        private SuaLoaiPhong suaLoaiPhong1;
        private ThemLoaiPhong themLoaiPhong1;
    }
}

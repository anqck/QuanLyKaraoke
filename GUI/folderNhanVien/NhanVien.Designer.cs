namespace GUI.folderNhanVien
{
    partial class NhanVien
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
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions4 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions5 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions6 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.NhanVienPagecontrol = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.PageNhanvien = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelTitle = new DevExpress.XtraEditors.LabelControl();
            this.wbntNhanvien = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.PageThemnhanvien = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.themNhanVien1 = new GUI.folderNhanVien.ThemNhanVien();
            this.PageSuanhanvien = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.suaNhanVien1 = new GUI.folderNhanVien.SuaNhanVien();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienPagecontrol)).BeginInit();
            this.NhanVienPagecontrol.SuspendLayout();
            this.PageNhanvien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.PageThemnhanvien.SuspendLayout();
            this.PageSuanhanvien.SuspendLayout();
            this.SuspendLayout();
            // 
            // NhanVienPagecontrol
            // 
            this.NhanVienPagecontrol.Appearance.BackColor = System.Drawing.Color.White;
            this.NhanVienPagecontrol.Appearance.Options.UseBackColor = true;
            this.NhanVienPagecontrol.Controls.Add(this.PageNhanvien);
            this.NhanVienPagecontrol.Controls.Add(this.PageThemnhanvien);
            this.NhanVienPagecontrol.Controls.Add(this.PageSuanhanvien);
            this.NhanVienPagecontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NhanVienPagecontrol.Location = new System.Drawing.Point(0, 0);
            this.NhanVienPagecontrol.Name = "NhanVienPagecontrol";
            this.NhanVienPagecontrol.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.PageNhanvien,
            this.PageThemnhanvien,
            this.PageSuanhanvien});
            this.NhanVienPagecontrol.SelectedPage = this.PageNhanvien;
            this.NhanVienPagecontrol.Size = new System.Drawing.Size(980, 617);
            this.NhanVienPagecontrol.TabIndex = 6;
            this.NhanVienPagecontrol.Text = "navigationFrame1";
            this.NhanVienPagecontrol.SelectedPageChanging += new DevExpress.XtraBars.Navigation.SelectedPageChangingEventHandler(this.NhanVienPagecontrol_SelectedPageChanging);
            // 
            // PageNhanvien
            // 
            this.PageNhanvien.Caption = "PageNhanvien";
            this.PageNhanvien.Controls.Add(this.gridControl1);
            this.PageNhanvien.Controls.Add(this.labelTitle);
            this.PageNhanvien.Controls.Add(this.wbntNhanvien);
            this.PageNhanvien.Name = "PageNhanvien";
            this.PageNhanvien.Size = new System.Drawing.Size(980, 617);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 37);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(980, 500);
            this.gridControl1.TabIndex = 13;
            this.gridControl1.Tag = "gridNhanVien";
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.ColumnPanelRowHeight = 50;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsHint.ShowCellHints = false;
            this.gridView1.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.RowHeight = 100;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã nhân viên";
            this.gridColumn1.FieldName = "MaNhanVien";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 129;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên nhân viên";
            this.gridColumn2.FieldName = "TenNhanVien";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 135;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Địa chỉ";
            this.gridColumn3.FieldName = "DiaChi";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 127;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Số điện thoại";
            this.gridColumn4.FieldName = "SDT";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 127;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tên đăng nhập";
            this.gridColumn5.FieldName = "TenDangNhap";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 142;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Mật khẩu";
            this.gridColumn6.FieldName = "MatKhau";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 103;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Loại tài khoản";
            this.gridColumn7.FieldName = "TenLoaiTaiKhoan";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 146;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Hình ảnh";
            this.gridColumn8.FieldName = "HinhAnh";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
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
            this.labelTitle.Size = new System.Drawing.Size(126, 37);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "NHÂN VIÊN";
            // 
            // wbntNhanvien
            // 
            this.wbntNhanvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wbntNhanvien.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thêm nhân viên", true, windowsUIButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Thêm nhân viên", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Sửa nhân viên", true, windowsUIButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Sửa nhân viên", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Bộ Lọc", true, windowsUIButtonImageOptions6, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Bộ Lọc", -1, false)});
            this.wbntNhanvien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wbntNhanvien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wbntNhanvien.ForeColor = System.Drawing.Color.White;
            this.wbntNhanvien.Location = new System.Drawing.Point(0, 537);
            this.wbntNhanvien.Name = "wbntNhanvien";
            this.wbntNhanvien.Size = new System.Drawing.Size(980, 80);
            this.wbntNhanvien.TabIndex = 9;
            this.wbntNhanvien.Text = "windowsUIButtonPanel1";
            this.wbntNhanvien.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.wbntDichvu_ButtonClick);
            // 
            // PageThemnhanvien
            // 
            this.PageThemnhanvien.Caption = "PageThemnhanvien";
            this.PageThemnhanvien.Controls.Add(this.themNhanVien1);
            this.PageThemnhanvien.Name = "PageThemnhanvien";
            this.PageThemnhanvien.Size = new System.Drawing.Size(980, 617);
            // 
            // themNhanVien1
            // 
            this.themNhanVien1.actionBack = null;
            this.themNhanVien1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themNhanVien1.Location = new System.Drawing.Point(0, 0);
            this.themNhanVien1.Name = "themNhanVien1";
            this.themNhanVien1.Size = new System.Drawing.Size(980, 617);
            this.themNhanVien1.TabIndex = 4;
            // 
            // PageSuanhanvien
            // 
            this.PageSuanhanvien.Caption = "PageSuanhanvien";
            this.PageSuanhanvien.Controls.Add(this.suaNhanVien1);
            this.PageSuanhanvien.Name = "PageSuanhanvien";
            this.PageSuanhanvien.Size = new System.Drawing.Size(980, 617);
            // 
            // suaNhanVien1
            // 
            this.suaNhanVien1.actionBack = null;
            this.suaNhanVien1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suaNhanVien1.Location = new System.Drawing.Point(0, 0);
            this.suaNhanVien1.Name = "suaNhanVien1";
            this.suaNhanVien1.Size = new System.Drawing.Size(980, 617);
            this.suaNhanVien1.TabIndex = 4;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NhanVienPagecontrol);
            this.Name = "NhanVien";
            this.Size = new System.Drawing.Size(980, 617);
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienPagecontrol)).EndInit();
            this.NhanVienPagecontrol.ResumeLayout(false);
            this.PageNhanvien.ResumeLayout(false);
            this.PageNhanvien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.PageThemnhanvien.ResumeLayout(false);
            this.PageSuanhanvien.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationFrame NhanVienPagecontrol;
        private DevExpress.XtraBars.Navigation.NavigationPage PageNhanvien;
        private DevExpress.XtraEditors.LabelControl labelTitle;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel wbntNhanvien;
        private DevExpress.XtraBars.Navigation.NavigationPage PageThemnhanvien;
        private DevExpress.XtraBars.Navigation.NavigationPage PageSuanhanvien;
        private ThemNhanVien themNhanVien1;
        private SuaNhanVien suaNhanVien1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}

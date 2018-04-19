namespace GUI.folderKhachHang
{
    partial class ThemLoaiKhachHang
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
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.LoaikhachhangPagecontrol = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.PageLoaikhachhang = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.wbntLoaiKhachhang = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.PageThemLoaikhachang = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.wbntThemloaikhachhang = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.LoaikhachhangPagecontrol)).BeginInit();
            this.LoaikhachhangPagecontrol.SuspendLayout();
            this.PageLoaikhachhang.SuspendLayout();
            this.PageThemLoaikhachang.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoaikhachhangPagecontrol
            // 
            this.LoaikhachhangPagecontrol.Appearance.BackColor = System.Drawing.Color.White;
            this.LoaikhachhangPagecontrol.Appearance.Options.UseBackColor = true;
            this.LoaikhachhangPagecontrol.Controls.Add(this.PageLoaikhachhang);
            this.LoaikhachhangPagecontrol.Controls.Add(this.PageThemLoaikhachang);
            this.LoaikhachhangPagecontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoaikhachhangPagecontrol.Location = new System.Drawing.Point(0, 0);
            this.LoaikhachhangPagecontrol.Name = "LoaikhachhangPagecontrol";
            this.LoaikhachhangPagecontrol.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.PageLoaikhachhang,
            this.PageThemLoaikhachang});
            this.LoaikhachhangPagecontrol.SelectedPage = null;
            this.LoaikhachhangPagecontrol.Size = new System.Drawing.Size(1040, 604);
            this.LoaikhachhangPagecontrol.TabIndex = 5;
            this.LoaikhachhangPagecontrol.Text = "navigationFrame1";
            // 
            // PageLoaikhachhang
            // 
            this.PageLoaikhachhang.Controls.Add(this.wbntLoaiKhachhang);
            this.PageLoaikhachhang.Name = "PageLoaikhachhang";
            this.PageLoaikhachhang.Size = new System.Drawing.Size(1040, 604);
            // 
            // wbntLoaiKhachhang
            // 
            this.wbntLoaiKhachhang.BackColor = System.Drawing.Color.White;
            windowsUIButtonImageOptions1.ImageUri.Uri = "hybriddemo_back%20button;Svg";
            this.wbntLoaiKhachhang.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.wbntLoaiKhachhang.Location = new System.Drawing.Point(3, 3);
            this.wbntLoaiKhachhang.Name = "wbntLoaiKhachhang";
            this.wbntLoaiKhachhang.Size = new System.Drawing.Size(56, 58);
            this.wbntLoaiKhachhang.TabIndex = 0;
            this.wbntLoaiKhachhang.Text = "windowsUIButtonPanel2";
            // 
            // PageThemLoaikhachang
            // 
            this.PageThemLoaikhachang.Controls.Add(this.wbntThemloaikhachhang);
            this.PageThemLoaikhachang.Name = "PageThemLoaikhachang";
            this.PageThemLoaikhachang.Size = new System.Drawing.Size(1040, 604);
            // 
            // wbntThemloaikhachhang
            // 
            this.wbntThemloaikhachhang.BackColor = System.Drawing.Color.White;
            windowsUIButtonImageOptions2.ImageUri.Uri = "hybriddemo_back%20button;Svg";
            this.wbntThemloaikhachhang.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.wbntThemloaikhachhang.Location = new System.Drawing.Point(3, 3);
            this.wbntThemloaikhachhang.Name = "wbntThemloaikhachhang";
            this.wbntThemloaikhachhang.Size = new System.Drawing.Size(56, 58);
            this.wbntThemloaikhachhang.TabIndex = 1;
            this.wbntThemloaikhachhang.Text = "windowsUIButtonPanel2";
            // 
            // ThemLoaiKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LoaikhachhangPagecontrol);
            this.Name = "ThemLoaiKhachHang";
            this.Size = new System.Drawing.Size(1040, 604);
            ((System.ComponentModel.ISupportInitialize)(this.LoaikhachhangPagecontrol)).EndInit();
            this.LoaikhachhangPagecontrol.ResumeLayout(false);
            this.PageLoaikhachhang.ResumeLayout(false);
            this.PageThemLoaikhachang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationFrame LoaikhachhangPagecontrol;
        private DevExpress.XtraBars.Navigation.NavigationPage PageLoaikhachhang;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel wbntLoaiKhachhang;
        private DevExpress.XtraBars.Navigation.NavigationPage PageThemLoaikhachang;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel wbntThemloaikhachhang;
    }
}

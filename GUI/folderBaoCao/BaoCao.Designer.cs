namespace GUI.folderBaoCao
{
    partial class BaoCao
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
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions3 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.wbntBaoCao = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.BaoCaoPageControl = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.PageDoanhThuThang = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.PageDoanhThuNam = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.PageDoanhthuDV = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.doanhThuThang1 = new GUI.folderBaoCao.DoanhThuThang();
            this.doanhThuNam1 = new GUI.folderBaoCao.DoanhThuNam();
            this.doanhThuDichVuTheoNam1 = new GUI.folderBaoCao.DoanhThuDichVuTheoNam();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoPageControl)).BeginInit();
            this.BaoCaoPageControl.SuspendLayout();
            this.PageDoanhThuThang.SuspendLayout();
            this.PageDoanhThuNam.SuspendLayout();
            this.PageDoanhthuDV.SuspendLayout();
            this.SuspendLayout();
            // 
            // wbntBaoCao
            // 
            this.wbntBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wbntBaoCao.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Doanh thu tháng", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Doanh thu tháng", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Doanh thu năm", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Doanh thu năm", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Doanh thu dịch vụ", true, windowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Doanh thu dịch vụ", -1, false)});
            this.wbntBaoCao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wbntBaoCao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wbntBaoCao.ForeColor = System.Drawing.Color.White;
            this.wbntBaoCao.Location = new System.Drawing.Point(0, 488);
            this.wbntBaoCao.Name = "wbntBaoCao";
            this.wbntBaoCao.Size = new System.Drawing.Size(977, 80);
            this.wbntBaoCao.TabIndex = 10;
            this.wbntBaoCao.Text = "wbntBaocao";
            this.wbntBaoCao.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.wbntBaoCao_ButtonClick);
            // 
            // BaoCaoPageControl
            // 
            this.BaoCaoPageControl.Controls.Add(this.PageDoanhThuThang);
            this.BaoCaoPageControl.Controls.Add(this.PageDoanhThuNam);
            this.BaoCaoPageControl.Controls.Add(this.PageDoanhthuDV);
            this.BaoCaoPageControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaoCaoPageControl.Location = new System.Drawing.Point(0, 0);
            this.BaoCaoPageControl.Name = "BaoCaoPageControl";
            this.BaoCaoPageControl.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.PageDoanhThuThang,
            this.PageDoanhThuNam,
            this.PageDoanhthuDV});
            this.BaoCaoPageControl.SelectedPage = this.PageDoanhThuThang;
            this.BaoCaoPageControl.Size = new System.Drawing.Size(977, 488);
            this.BaoCaoPageControl.TabIndex = 11;
            this.BaoCaoPageControl.Text = "navigationFrame1";
            this.BaoCaoPageControl.SelectedPageChanging += new DevExpress.XtraBars.Navigation.SelectedPageChangingEventHandler(this.BaoCaoPageControl_SelectedPageChanging);
            // 
            // PageDoanhThuThang
            // 
            this.PageDoanhThuThang.Caption = "PageDoanhThuThang";
            this.PageDoanhThuThang.Controls.Add(this.doanhThuThang1);
            this.PageDoanhThuThang.Name = "PageDoanhThuThang";
            this.PageDoanhThuThang.Size = new System.Drawing.Size(977, 488);
            // 
            // PageDoanhThuNam
            // 
            this.PageDoanhThuNam.Caption = "PageDoanhThuNam";
            this.PageDoanhThuNam.Controls.Add(this.doanhThuNam1);
            this.PageDoanhThuNam.Name = "PageDoanhThuNam";
            this.PageDoanhThuNam.Size = new System.Drawing.Size(977, 488);
            // 
            // PageDoanhthuDV
            // 
            this.PageDoanhthuDV.Caption = "PageDoanhthuDV";
            this.PageDoanhthuDV.Controls.Add(this.doanhThuDichVuTheoNam1);
            this.PageDoanhthuDV.Name = "PageDoanhthuDV";
            this.PageDoanhthuDV.Size = new System.Drawing.Size(977, 488);
            // 
            // doanhThuThang1
            // 
            this.doanhThuThang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doanhThuThang1.Location = new System.Drawing.Point(0, 0);
            this.doanhThuThang1.Name = "doanhThuThang1";
            this.doanhThuThang1.Size = new System.Drawing.Size(977, 488);
            this.doanhThuThang1.TabIndex = 0;
            // 
            // doanhThuNam1
            // 
            this.doanhThuNam1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doanhThuNam1.Location = new System.Drawing.Point(0, 0);
            this.doanhThuNam1.Name = "doanhThuNam1";
            this.doanhThuNam1.Size = new System.Drawing.Size(977, 488);
            this.doanhThuNam1.TabIndex = 0;
            // 
            // doanhThuDichVuTheoNam1
            // 
            this.doanhThuDichVuTheoNam1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doanhThuDichVuTheoNam1.Location = new System.Drawing.Point(0, 0);
            this.doanhThuDichVuTheoNam1.Name = "doanhThuDichVuTheoNam1";
            this.doanhThuDichVuTheoNam1.Size = new System.Drawing.Size(977, 488);
            this.doanhThuDichVuTheoNam1.TabIndex = 0;
            // 
            // BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BaoCaoPageControl);
            this.Controls.Add(this.wbntBaoCao);
            this.Name = "BaoCao";
            this.Size = new System.Drawing.Size(977, 568);
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoPageControl)).EndInit();
            this.BaoCaoPageControl.ResumeLayout(false);
            this.PageDoanhThuThang.ResumeLayout(false);
            this.PageDoanhThuNam.ResumeLayout(false);
            this.PageDoanhthuDV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel wbntBaoCao;
        private DevExpress.XtraBars.Navigation.NavigationFrame BaoCaoPageControl;
        private DevExpress.XtraBars.Navigation.NavigationPage PageDoanhThuThang;
        private DevExpress.XtraBars.Navigation.NavigationPage PageDoanhThuNam;
        private DoanhThuThang doanhThuThang1;
        private DoanhThuNam doanhThuNam1;
        private DevExpress.XtraBars.Navigation.NavigationPage PageDoanhthuDV;
        private DoanhThuDichVuTheoNam doanhThuDichVuTheoNam1;
    }
}

namespace GUI.folderTinhTrangPhong
{
    partial class ThongTinChiTietNhieuPhong
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
            this.ChiTietPhong1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietPhong1)).BeginInit();
            this.ChiTietPhong1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChiTietPhong1
            // 
            this.ChiTietPhong1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChiTietPhong1.Appearance.Options.UseFont = true;
            this.ChiTietPhong1.Controls.Add(this.tabNavigationPage1);
            this.ChiTietPhong1.Controls.Add(this.tabNavigationPage2);
            this.ChiTietPhong1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChiTietPhong1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChiTietPhong1.Location = new System.Drawing.Point(0, 0);
            this.ChiTietPhong1.Name = "ChiTietPhong1";
            this.ChiTietPhong1.PageProperties.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChiTietPhong1.PageProperties.AppearanceCaption.Options.UseFont = true;
            this.ChiTietPhong1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.ChiTietPhong1.RegularSize = new System.Drawing.Size(1064, 625);
            this.ChiTietPhong1.SelectedPage = this.tabNavigationPage2;
            this.ChiTietPhong1.Size = new System.Drawing.Size(1064, 625);
            this.ChiTietPhong1.TabIndex = 0;
            this.ChiTietPhong1.Text = "tabControl";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavigationPage1.Appearance.Options.UseFont = true;
            this.tabNavigationPage1.Caption = "Phòng 1";
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(1042, 569);
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavigationPage2.Appearance.Options.UseFont = true;
            this.tabNavigationPage2.Caption = "Phòng 2";
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(1042, 569);
            // 
            // ThongTinChiTietNhieuPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ChiTietPhong1);
            this.Name = "ThongTinChiTietNhieuPhong";
            this.Size = new System.Drawing.Size(1064, 625);
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietPhong1)).EndInit();
            this.ChiTietPhong1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane ChiTietPhong1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
    }
}

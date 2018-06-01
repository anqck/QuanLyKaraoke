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
            this.wbntEmpty = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.wbntQuanlyphong = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.thongTinChiTietPhong1 = new GUI.folderTinhTrangPhong.ThongTinChiTietPhong();
            this.TabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tab1 = new DevExpress.XtraTab.XtraTabPage();
            this.wbntEmpty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).BeginInit();
            this.TabControl.SuspendLayout();
            this.tab1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wbntEmpty
            // 
            this.wbntEmpty.BackColor = System.Drawing.Color.White;
            this.wbntEmpty.ContentAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.wbntEmpty.Controls.Add(this.wbntQuanlyphong);
            this.wbntEmpty.Dock = System.Windows.Forms.DockStyle.Left;
            this.wbntEmpty.Location = new System.Drawing.Point(0, 0);
            this.wbntEmpty.Name = "wbntEmpty";
            this.wbntEmpty.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.wbntEmpty.Size = new System.Drawing.Size(68, 625);
            this.wbntEmpty.TabIndex = 8;
            this.wbntEmpty.Text = "windowsUIButtonPanel1";
            // 
            // wbntQuanlyphong
            // 
            this.wbntQuanlyphong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbntQuanlyphong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wbntQuanlyphong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wbntQuanlyphong.ForeColor = System.Drawing.Color.White;
            this.wbntQuanlyphong.Location = new System.Drawing.Point(0, 552);
            this.wbntQuanlyphong.Name = "wbntQuanlyphong";
            this.wbntQuanlyphong.Size = new System.Drawing.Size(68, 67);
            this.wbntQuanlyphong.TabIndex = 22;
            this.wbntQuanlyphong.Text = "windowsUIButtonPanel1";
            // 
            // thongTinChiTietPhong1
            // 
            this.thongTinChiTietPhong1.Appearance.BackColor = System.Drawing.Color.White;
            this.thongTinChiTietPhong1.Appearance.Options.UseBackColor = true;
            this.thongTinChiTietPhong1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thongTinChiTietPhong1.Location = new System.Drawing.Point(0, 0);
            this.thongTinChiTietPhong1.Name = "thongTinChiTietPhong1";
            this.thongTinChiTietPhong1.Size = new System.Drawing.Size(989, 591);
            this.thongTinChiTietPhong1.TabIndex = 0;
            // 
            // TabControl
            // 
            this.TabControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TabControl.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(68, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedTabPage = this.tab1;
            this.TabControl.Size = new System.Drawing.Size(996, 625);
            this.TabControl.TabIndex = 1;
            this.TabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tab1});
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.thongTinChiTietPhong1);
            this.tab1.Name = "tab1";
            this.tab1.Size = new System.Drawing.Size(989, 591);
            this.tab1.Text = "Phòng 1";
            // 
            // ThongTinChiTietNhieuPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.wbntEmpty);
            this.Name = "ThongTinChiTietNhieuPhong";
            this.Size = new System.Drawing.Size(1064, 625);
            this.wbntEmpty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ThongTinChiTietPhong thongTinChiTietPhong1;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel wbntEmpty;
        private DevExpress.XtraTab.XtraTabControl TabControl;
        private DevExpress.XtraTab.XtraTabPage tab1;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel wbntQuanlyphong;
    }
}

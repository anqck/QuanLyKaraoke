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
            this.TabControl = new DevExpress.XtraTab.XtraTabControl();
            this.wbntEmpty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).BeginInit();
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
            // TabControl
            // 
            this.TabControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TabControl.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(68, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.Size = new System.Drawing.Size(996, 625);
            this.TabControl.TabIndex = 1;
            this.TabControl.SelectedPageChanging += new DevExpress.XtraTab.TabPageChangingEventHandler(this.TabControl_SelectedPageChanging);
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
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel wbntEmpty;
        private DevExpress.XtraTab.XtraTabControl TabControl;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel wbntQuanlyphong;
    }
}

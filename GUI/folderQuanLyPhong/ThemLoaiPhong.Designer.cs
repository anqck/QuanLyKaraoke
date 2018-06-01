namespace GUI.folderQuanLyPhong
{
    partial class ThemLoaiPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemLoaiPhong));
            this.wbntEmpty = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.wbntThemphong = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.txtTenLoaiPhong = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.simpleLabelItem2 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoaiPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // wbntEmpty
            // 
            this.wbntEmpty.BackColor = System.Drawing.Color.White;
            this.wbntEmpty.ContentAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.wbntEmpty.Dock = System.Windows.Forms.DockStyle.Left;
            this.wbntEmpty.Location = new System.Drawing.Point(0, 0);
            this.wbntEmpty.Name = "wbntEmpty";
            this.wbntEmpty.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.wbntEmpty.Size = new System.Drawing.Size(66, 606);
            this.wbntEmpty.TabIndex = 3;
            this.wbntEmpty.Text = "windowsUIButtonPanel1";
            // 
            // wbntThemphong
            // 
            this.wbntThemphong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wbntThemphong.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thêm", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Thêm", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Hủy", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Hủy", -1, false)});
            this.wbntThemphong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wbntThemphong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wbntThemphong.ForeColor = System.Drawing.Color.White;
            this.wbntThemphong.Location = new System.Drawing.Point(0, 606);
            this.wbntThemphong.Name = "wbntThemphong";
            this.wbntThemphong.Size = new System.Drawing.Size(1092, 80);
            this.wbntThemphong.TabIndex = 11;
            this.wbntThemphong.Text = "windowsUIButtonPanel1";
            this.wbntThemphong.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.wbntThemphong_ButtonClick);
            // 
            // layoutControl1
            // 
            this.layoutControl1.BackColor = System.Drawing.Color.White;
            this.layoutControl1.Controls.Add(this.textEdit2);
            this.layoutControl1.Controls.Add(this.txtTenLoaiPhong);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(66, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(538, 457, 812, 500);
            this.layoutControl1.Root = this.layoutControlGroup2;
            this.layoutControl1.Size = new System.Drawing.Size(1026, 267);
            this.layoutControl1.TabIndex = 12;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // textEdit2
            // 
            this.textEdit2.Enabled = false;
            this.textEdit2.Location = new System.Drawing.Point(19, 109);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.textEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.textEdit2.Size = new System.Drawing.Size(988, 40);
            this.textEdit2.StyleController = this.layoutControl1;
            this.textEdit2.TabIndex = 5;
            // 
            // txtTenLoaiPhong
            // 
            this.txtTenLoaiPhong.Location = new System.Drawing.Point(19, 197);
            this.txtTenLoaiPhong.Name = "txtTenLoaiPhong";
            this.txtTenLoaiPhong.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiPhong.Properties.Appearance.Options.UseFont = true;
            this.txtTenLoaiPhong.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtTenLoaiPhong.Properties.Validating += new System.ComponentModel.CancelEventHandler(this.textEdit1_Properties_Validating);
            this.txtTenLoaiPhong.Size = new System.Drawing.Size(988, 40);
            this.txtTenLoaiPhong.StyleController = this.layoutControl1;
            this.txtTenLoaiPhong.TabIndex = 6;
            this.txtTenLoaiPhong.TextChanged += new System.EventHandler(this.txtTenLoaiPhong_TextChanged);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.simpleLabelItem2,
            this.layoutControlItem2,
            this.layoutControlItem1});
            this.layoutControlGroup2.Name = "Root";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup2.Size = new System.Drawing.Size(1026, 267);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // simpleLabelItem2
            // 
            this.simpleLabelItem2.AllowHotTrack = false;
            this.simpleLabelItem2.AppearanceItemCaption.BackColor = System.Drawing.Color.Transparent;
            this.simpleLabelItem2.AppearanceItemCaption.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            this.simpleLabelItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleLabelItem2.AppearanceItemCaption.ForeColor = System.Drawing.SystemColors.Highlight;
            this.simpleLabelItem2.AppearanceItemCaption.Options.UseBackColor = true;
            this.simpleLabelItem2.AppearanceItemCaption.Options.UseFont = true;
            this.simpleLabelItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.simpleLabelItem2.Location = new System.Drawing.Point(0, 0);
            this.simpleLabelItem2.Name = "simpleLabelItem2";
            this.simpleLabelItem2.Size = new System.Drawing.Size(1000, 54);
            this.simpleLabelItem2.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.simpleLabelItem2.Text = "THÊM LOẠI PHÒNG MỚI";
            this.simpleLabelItem2.TextSize = new System.Drawing.Size(325, 38);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.DimGray;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.textEdit2;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 54);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1000, 88);
            this.layoutControlItem2.Spacing = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlItem2.Text = "Mã loại phòng";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(325, 32);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.DimGray;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtTenLoaiPhong;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 142);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1000, 99);
            this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlItem1.Text = "Tên loại phòng";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(325, 32);
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.spreadsheetControl1.Cursor = System.Windows.Forms.Cursors.No;
            this.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetControl1.Location = new System.Drawing.Point(66, 267);
            this.spreadsheetControl1.Margin = new System.Windows.Forms.Padding(5);
            this.spreadsheetControl1.Name = "spreadsheetControl1";
            this.spreadsheetControl1.Options.Behavior.Column.Delete = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled;
            this.spreadsheetControl1.Options.Behavior.Column.Hide = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled;
            this.spreadsheetControl1.Options.Behavior.Column.Insert = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled;
            this.spreadsheetControl1.Options.Behavior.Column.Resize = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled;
            this.spreadsheetControl1.Options.Behavior.Column.Unhide = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled;
            this.spreadsheetControl1.Options.Behavior.Comment.Delete = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled;
            this.spreadsheetControl1.Options.Behavior.Comment.Edit = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled;
            this.spreadsheetControl1.Options.Behavior.Comment.Insert = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled;
            this.spreadsheetControl1.Options.Behavior.Comment.Move = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled;
            this.spreadsheetControl1.Options.Behavior.Comment.Resize = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled;
            this.spreadsheetControl1.Options.Behavior.Comment.ShowHide = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled;
            this.spreadsheetControl1.Options.Behavior.Row.Delete = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled;
            this.spreadsheetControl1.Options.Behavior.Row.Hide = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;
            this.spreadsheetControl1.Options.Behavior.Row.Insert = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled;
            this.spreadsheetControl1.Options.Behavior.Row.Resize = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled;
            this.spreadsheetControl1.Options.Behavior.Row.Unhide = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled;
            this.spreadsheetControl1.Options.Behavior.Worksheet.Delete = DevExpress.XtraSpreadsheet.DocumentCapability.Hidden;
            this.spreadsheetControl1.Options.Behavior.Worksheet.Hide = DevExpress.XtraSpreadsheet.DocumentCapability.Hidden;
            this.spreadsheetControl1.Options.Behavior.Worksheet.Insert = DevExpress.XtraSpreadsheet.DocumentCapability.Hidden;
            this.spreadsheetControl1.Options.Behavior.Worksheet.Rename = DevExpress.XtraSpreadsheet.DocumentCapability.Hidden;
            this.spreadsheetControl1.Options.Behavior.Worksheet.TabColor = DevExpress.XtraSpreadsheet.DocumentCapability.Hidden;
            this.spreadsheetControl1.Options.Behavior.Worksheet.Unhide = DevExpress.XtraSpreadsheet.DocumentCapability.Hidden;
            this.spreadsheetControl1.Options.HorizontalScrollbar.Visibility = DevExpress.XtraSpreadsheet.SpreadsheetScrollbarVisibility.Hidden;
            this.spreadsheetControl1.Options.Import.Csv.Encoding = ((System.Text.Encoding)(resources.GetObject("spreadsheetControl1.Options.Import.Csv.Encoding")));
            this.spreadsheetControl1.Options.Import.Txt.Encoding = ((System.Text.Encoding)(resources.GetObject("spreadsheetControl1.Options.Import.Txt.Encoding")));
            this.spreadsheetControl1.Options.TabSelector.Visibility = DevExpress.XtraSpreadsheet.SpreadsheetElementVisibility.Hidden;
            this.spreadsheetControl1.Options.View.ColumnHeaderHeight = 40;
            this.spreadsheetControl1.Options.View.RowHeaderWidth = 100;
            this.spreadsheetControl1.Padding = new System.Windows.Forms.Padding(5);
            this.spreadsheetControl1.Size = new System.Drawing.Size(1026, 339);
            this.spreadsheetControl1.TabIndex = 13;
            this.spreadsheetControl1.Text = "spreadsheetControl1";
            this.spreadsheetControl1.CustomDrawColumnHeader += new DevExpress.XtraSpreadsheet.CustomDrawColumnHeaderEventHandler(this.spreadsheetControl1_CustomDrawColumnHeader);
            this.spreadsheetControl1.CustomDrawRowHeader += new DevExpress.XtraSpreadsheet.CustomDrawRowHeaderEventHandler(this.spreadsheetControl1_CustomDrawRowHeader);
            // 
            // ThemLoaiPhong
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spreadsheetControl1);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.wbntEmpty);
            this.Controls.Add(this.wbntThemphong);
            this.Name = "ThemLoaiPhong";
            this.Size = new System.Drawing.Size(1092, 686);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoaiPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel wbntEmpty;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel wbntThemphong;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit txtTenLoaiPhong;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl1;
    }
}

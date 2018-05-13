namespace GUI.folderDichVu
{
    partial class LoaiDichVu
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.wbntSuadichvu = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.wbntEmpty = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaLDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenLDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            this.SuspendLayout();
            // 
            // wbntSuadichvu
            // 
            this.wbntSuadichvu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wbntSuadichvu.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thêm Loại Dịch Vụ", true, windowsUIButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Thêm Loại Dịch Vụ", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Sửa Loại Dịch Vụ", true, windowsUIButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Sửa Loại Dịch Vụ", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Xóa Loại Dịch Vụ", true, windowsUIButtonImageOptions6, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Xóa Loại Dịch Vụ", -1, false)});
            this.wbntSuadichvu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wbntSuadichvu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wbntSuadichvu.ForeColor = System.Drawing.Color.White;
            this.wbntSuadichvu.Location = new System.Drawing.Point(0, 383);
            this.wbntSuadichvu.Name = "wbntSuadichvu";
            this.wbntSuadichvu.Size = new System.Drawing.Size(609, 80);
            this.wbntSuadichvu.TabIndex = 14;
            this.wbntSuadichvu.Text = "windowsUIButtonPanel1";
            this.wbntSuadichvu.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.wbntSuadichvu_ButtonClick);
            // 
            // wbntEmpty
            // 
            this.wbntEmpty.BackColor = System.Drawing.Color.White;
            this.wbntEmpty.ContentAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.wbntEmpty.Dock = System.Windows.Forms.DockStyle.Left;
            this.wbntEmpty.Location = new System.Drawing.Point(0, 0);
            this.wbntEmpty.Name = "wbntEmpty";
            this.wbntEmpty.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.wbntEmpty.Size = new System.Drawing.Size(68, 383);
            this.wbntEmpty.TabIndex = 15;
            this.wbntEmpty.Text = "windowsUIButtonPanel1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.BackColor = System.Drawing.Color.White;
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(68, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(450, 525, 812, 500);
            this.layoutControl1.Root = this.layoutControlGroup2;
            this.layoutControl1.Size = new System.Drawing.Size(541, 81);
            this.layoutControl1.TabIndex = 16;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.simpleLabelItem1});
            this.layoutControlGroup2.Name = "Root";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup2.Size = new System.Drawing.Size(541, 81);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.AppearanceItemCaption.BackColor = System.Drawing.Color.Transparent;
            this.simpleLabelItem1.AppearanceItemCaption.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            this.simpleLabelItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleLabelItem1.AppearanceItemCaption.ForeColor = System.Drawing.SystemColors.Highlight;
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseBackColor = true;
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseFont = true;
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 0);
            this.simpleLabelItem1.Name = "simpleLabelItem2";
            this.simpleLabelItem1.Size = new System.Drawing.Size(515, 55);
            this.simpleLabelItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.simpleLabelItem1.Text = "LOẠI DỊCH VỤ";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(186, 38);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.cardView1;
            gridLevelNode1.RelationName = "chiTietDichVu";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(68, 81);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(541, 302);
            this.gridControl1.TabIndex = 17;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.cardView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaLDV,
            this.colTenLDV});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colMaLDV
            // 
            this.colMaLDV.Caption = "Mã Loại Dịch Vụ";
            this.colMaLDV.FieldName = "MaLDV";
            this.colMaLDV.Name = "colMaLDV";
            this.colMaLDV.Visible = true;
            this.colMaLDV.VisibleIndex = 0;
            // 
            // colTenLDV
            // 
            this.colTenLDV.Caption = "Tên Loại Dịch Vụ";
            this.colTenLDV.FieldName = "TenLDV";
            this.colTenLDV.Name = "colTenLDV";
            this.colTenLDV.Visible = true;
            this.colTenLDV.VisibleIndex = 1;
            // 
            // cardView1
            // 
            this.cardView1.FocusedCardTopFieldIndex = 0;
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            // 
            // LoaiDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.wbntEmpty);
            this.Controls.Add(this.wbntSuadichvu);
            this.Name = "LoaiDichVu";
            this.Size = new System.Drawing.Size(609, 463);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel wbntSuadichvu;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel wbntEmpty;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLDV;
        private DevExpress.XtraGrid.Columns.GridColumn colTenLDV;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
    }
}

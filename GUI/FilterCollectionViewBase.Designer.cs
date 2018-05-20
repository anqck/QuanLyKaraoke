namespace GUI
{
    partial class FilterCollectionViewBase
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
            this.labelControl = new DevExpress.XtraEditors.LabelControl();
            this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.filterEditorControl1 = new DevExpress.XtraFilterEditor.FilterEditorControl();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.filterControl2 = new DevExpress.XtraEditors.FilterControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl
            // 
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.Options.UseFont = true;
            this.labelControl.Appearance.Options.UseForeColor = true;
            this.labelControl.Appearance.Options.UseTextOptions = true;
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Location = new System.Drawing.Point(0, 0);
            this.labelControl.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl.Name = "labelControl";
            this.labelControl.Size = new System.Drawing.Size(1149, 32);
            this.labelControl.TabIndex = 8;
            this.labelControl.Text = "CAPTION";
            // 
            // splitContainerControl
            // 
            this.splitContainerControl.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1;
            this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl.IsSplitterFixed = true;
            this.splitContainerControl.Location = new System.Drawing.Point(0, 32);
            this.splitContainerControl.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.splitContainerControl.Name = "splitContainerControl";
            this.splitContainerControl.Panel1.MinSize = 260;
            this.splitContainerControl.Panel1.Text = "Panel1";
            this.splitContainerControl.Panel2.Controls.Add(this.filterControl2);
            this.splitContainerControl.Panel2.Controls.Add(this.filterControl1);
            this.splitContainerControl.Panel2.Controls.Add(this.filterEditorControl1);
            this.splitContainerControl.Panel2.Text = "Panel2";
            this.splitContainerControl.Size = new System.Drawing.Size(1149, 516);
            this.splitContainerControl.SplitterPosition = 246;
            this.splitContainerControl.TabIndex = 9;
            this.splitContainerControl.Text = "splitContainerControl1";
            // 
            // filterEditorControl1
            // 
            this.filterEditorControl1.AllowAggregateEditing = DevExpress.XtraEditors.FilterControlAllowAggregateEditing.Aggregate;
            this.filterEditorControl1.AppearanceEmptyValueColor = System.Drawing.Color.Empty;
            this.filterEditorControl1.AppearanceFieldNameColor = System.Drawing.Color.Empty;
            this.filterEditorControl1.AppearanceGroupOperatorColor = System.Drawing.Color.Empty;
            this.filterEditorControl1.AppearanceOperatorColor = System.Drawing.Color.Empty;
            this.filterEditorControl1.AppearanceValueColor = System.Drawing.Color.Empty;
            this.filterEditorControl1.Location = new System.Drawing.Point(1, 137);
            this.filterEditorControl1.Name = "filterEditorControl1";
            this.filterEditorControl1.ShowGroupCommandsIcon = true;
            this.filterEditorControl1.Size = new System.Drawing.Size(542, 285);
            this.filterEditorControl1.TabIndex = 0;
            this.filterEditorControl1.Text = "filterEditorControl1";
            // 
            // filterControl1
            // 
            this.filterControl1.AllowAggregateEditing = DevExpress.XtraEditors.FilterControlAllowAggregateEditing.Aggregate;
            this.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filterControl1.Location = new System.Drawing.Point(558, 137);
            this.filterControl1.Name = "filterControl1";
            this.filterControl1.Size = new System.Drawing.Size(298, 285);
            this.filterControl1.TabIndex = 1;
            this.filterControl1.Text = "filterControl1";
            this.filterControl1.PopupMenuShowing += new DevExpress.XtraEditors.Filtering.PopupMenuShowingEventHandler(this.filterControl1_PopupMenuShowing);
            // 
            // filterControl2
            // 
            this.filterControl2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filterControl2.Location = new System.Drawing.Point(212, 27);
            this.filterControl2.Name = "filterControl2";
            this.filterControl2.Size = new System.Drawing.Size(200, 100);
            this.filterControl2.TabIndex = 2;
            this.filterControl2.Text = "filterControl2";
            // 
            // FilterCollectionViewBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl);
            this.Controls.Add(this.labelControl);
            this.Name = "FilterCollectionViewBase";
            this.Size = new System.Drawing.Size(1149, 548);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraEditors.LabelControl labelControl;
        protected DevExpress.XtraEditors.SplitContainerControl splitContainerControl;
        private DevExpress.XtraEditors.FilterControl filterControl1;
        private DevExpress.XtraFilterEditor.FilterEditorControl filterEditorControl1;
        private DevExpress.XtraEditors.FilterControl filterControl2;
    }
}

namespace GUI
{
    partial class FilterControlDialog
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
            this.filterEditorControl1 = new DevExpress.XtraFilterEditor.FilterEditorControl();
            this.SuspendLayout();
            // 
            // filterEditorControl1
            // 
            this.filterEditorControl1.AppearanceEmptyValueColor = System.Drawing.Color.Empty;
            this.filterEditorControl1.AppearanceFieldNameColor = System.Drawing.Color.Empty;
            this.filterEditorControl1.AppearanceGroupOperatorColor = System.Drawing.Color.Empty;
            this.filterEditorControl1.AppearanceOperatorColor = System.Drawing.Color.Empty;
            this.filterEditorControl1.AppearanceValueColor = System.Drawing.Color.Empty;
            this.filterEditorControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterEditorControl1.Location = new System.Drawing.Point(0, 0);
            this.filterEditorControl1.Name = "filterEditorControl1";
            this.filterEditorControl1.Size = new System.Drawing.Size(633, 366);
            this.filterEditorControl1.TabIndex = 0;
            this.filterEditorControl1.Text = "filterEditorControl1";
            this.filterEditorControl1.UseMenuForOperandsAndOperators = false;
            // 
            // FilterControlDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.filterEditorControl1);
            this.Name = "FilterControlDialog";
            this.Size = new System.Drawing.Size(633, 366);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraFilterEditor.FilterEditorControl filterEditorControl1;
    }
}

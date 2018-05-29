using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DTO;
using DevExpress.XtraEditors.Repository;

namespace GUI
{
    public partial class FilterControlDialog : DevExpress.XtraEditors.XtraUserControl
    {
        RepositoryItemComboBox cmbLoaiDV;
        

        public FilterControlDialog()
        {
            InitializeComponent();

          
        }

        public FilterControlDialog(GridControl source,string ActiveFilterString) :this()
        {
            

            filterEditorControl1.SourceControl = source;
            filterEditorControl1.FilterString = ActiveFilterString;

            switch(source.Tag.ToString() )
            {
                case "GridDichVu":
                    //Lấy tất cả loại phòng vào cmb
                    List<LoaiDichVuDTO> listLoaiDichVu = BUS.LoaiDichVuBUS.LayTatCaLoaiDichVu_List();
                    cmbLoaiDV = new RepositoryItemComboBox();
                    cmbLoaiDV.AppearanceDropDown.Font = new System.Drawing.Font("Segoe UI", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    cmbLoaiDV.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); 
                    foreach (LoaiDichVuDTO loaiDV in listLoaiDichVu)
                    {
                        cmbLoaiDV.Items.Add(new MyComboBoxItem(loaiDV.TenDV, loaiDV.MaLoaiDV));
                    }

                    break;
            }
        }

        private void filterEditorControl1_BeforeShowValueEditor(object sender, DevExpress.XtraEditors.Filtering.ShowValueEditorEventArgs e)
        {
            if (e.CurrentNode.FirstOperand.PropertyName == "TenLDV")
            {                         

                e.CustomRepositoryItem = cmbLoaiDV;
            }

        }

        internal string GetFilterString()
        {
            return filterEditorControl1.FilterString;
        }
    }
}

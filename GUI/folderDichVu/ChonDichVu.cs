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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Data.Filtering;

namespace GUI.folderDichVu
{
    public partial class ChonDichVu : DevExpress.XtraEditors.XtraUserControl
    {
        DataTable dataSource;
        List<int> listSoLuong;
        Dictionary<int,int> listSelectedRow;
        bool showOnlySelected;

        public ChonDichVu()
        {
            InitializeComponent();
            showOnlySelected = false;

            gridControl2.DataSource = dataSource = BUS.DichVuBUS.LayTatCaDichVu_LoaiDichVu_ExceptHuyVaKM();

            listSelectedRow = new Dictionary<int, int>();
            listSoLuong = new List<int>();
            for (int i = 0; i < gridView2.DataRowCount; i++)
            {
                listSoLuong.Add(0);
               
            }

          
        }

        private void gridView2_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "colSoLuong")
            {
                if (e.IsGetData)
                {
                    if (listSelectedRow.ContainsKey((int)dataSource.Rows[e.ListSourceRowIndex]["MaDV"]))
                        e.Value = listSelectedRow[(int)dataSource.Rows[e.ListSourceRowIndex]["MaDV"]];
                    else
                        e.Value = 0;
                }             
                //if (e.IsSetData)
                //    e.Value = 0;
            }
            else if (e.Column.FieldName == "colSelect")
            {
                if (e.IsGetData)
                {
                    if (listSelectedRow.ContainsKey((int)dataSource.Rows[e.ListSourceRowIndex]["MaDV"]))
                        e.Value = true;
                    else
                        e.Value = false;
                }
                //if (e.IsSetData)
                //    e.Value = 0;
            }
        }

        private void gridView2_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (gridView2.FocusedColumn.FieldName == "colSoLuong" && !gridView2.GetSelectedRows().Contains(gridView2.FocusedRowHandle))
                e.Cancel = true;
        }

        private void gridView2_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
           
                
        }

        private void gridView2_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gridView2.FocusedColumn.FieldName == "colSoLuong")
            {
                if (gridView2.GetSelectedRows().Contains(gridView2.FocusedRowHandle) && Convert.ToInt32(e.Value) <= 0)
                {
                    e.ErrorText = "Giá trị không hợp lệ";
                    e.Valid = false;
                }
                else
                {
                    listSelectedRow[(int)gridView2.GetFocusedRowCellValue(colMaDichVu)] = Convert.ToInt32(e.Value);

                }
            }
            else if (gridView2.FocusedColumn.FieldName == "colSelect")
            {
                if((bool)e.Value)
                {
                    listSelectedRow.Add((int)gridView2.GetFocusedRowCellValue(colMaDichVu), 1);
                    gridView2.RefreshData();
                }
                else
                {
                    listSelectedRow.Remove((int)gridView2.GetFocusedRowCellValue(colMaDichVu));
                    gridView2.RefreshData();
                }
        
            }

        }

        private void tileSelected_ItemClick(object sender, TileItemEventArgs e)
        {
            showOnlySelected = true;
            gridView2.RefreshData();

        }

        private void tileAll_ItemClick(object sender, TileItemEventArgs e)
        {
            showOnlySelected = false;
            gridView2.RefreshData();
        }

        private void gridView2_CustomRowFilter(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e)
        {
            if (showOnlySelected)
            {
                if (!e.Visible&& searchControl1.Text !="")
                    return;

                 e.Visible = listSelectedRow.ContainsKey((int)gridView2.GetRowCellValue(e.ListSourceRow, colMaDichVu));
                  e.Handled = true;
                

                   
            }
        }

        public Dictionary<int, int> GetSelectedDichVu()
        {
            return listSelectedRow;
        }
    }
}

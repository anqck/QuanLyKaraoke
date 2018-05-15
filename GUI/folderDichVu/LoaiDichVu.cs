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

namespace GUI.folderDichVu
{
    public partial class LoaiDichVu : DevExpress.XtraEditors.XtraUserControl
    {
        DataSet dataset;
        DataTable dtLoaiDichVu;
        DataTable dtDichVu;

        Action themLoaiDichVu;

        public LoaiDichVu()
        {
            InitializeComponent();            
        }

        public void SetActionThemLoaiDichVu(Action action)
        {
            themLoaiDichVu = action;
        }
        public void RefreshDataBinding()
        {
            //try
            //{
                dtLoaiDichVu = BUS.LoaiDichVuBUS.LayTatCaLoaiDichVu_DataTable();
                dtDichVu = BUS.DichVuBUS.LayTatCaDichVu_DataTable();

                dataset = new DataSet();
                dataset.Tables.Add(dtLoaiDichVu);
                dataset.Tables.Add(dtDichVu);

                dataset.Relations.Add("Thông tin chi tiết dịch vụ", dataset.Tables["loaidichvu"].Columns["MaLDV"], dataset.Tables["dichvu"].Columns["MaLDV"]);

                gridControl1.DataSource = dataset.Tables["loaidichvu"];
                gridControl1.LevelTree.Nodes.Add("Thông tin chi tiết dịch vụ", tileView1);


            //}
            //catch (Exception x)
            //{

            //}
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle == 0 || e.FocusedRowHandle == 1)
            {
                wbntSuadichvu.Buttons[1].Properties.Enabled = false;
                wbntSuadichvu.Buttons[2].Properties.Enabled = false;
            }
            else
            {
                wbntSuadichvu.Buttons[2].Properties.Enabled = true;
                wbntSuadichvu.Buttons[2].Properties.Enabled = false;
            }
        }

        private void wbntSuadichvu_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch(e.Button.Properties.Tag.ToString())
            {
                case "Thêm Loại Dịch Vụ":
                    LoaiDichVuPagecontrol.SelectedPage = PageThemloaidichvu;
                    break;
                case "Sửa Loại Dịch Vụ":
                    LoaiDichVuPagecontrol.SelectedPage = PageSualoaidichvu;
                    break;
                case "Xóa Loại Dịch Vụ":
                    //Kiểm tra xem có chọn dòng nào không
                    if(gridView1.GetFocusedRow() == null)
                    {
                        //BÌNH

                        return;
                    }

                    //Kiểm tra xem loại dịch vụ đó còn dịch vụ nào không
                    if (BUS.DichVuBUS.DemSoLuongDichVu((int)gridView1.GetFocusedRowCellValue(colMaLDV) )!= 0)
                    {
                        XtraMessageBox.Show("Chỉ có thể xóa những loại dịch vụ không có dịch vụ nào!", "Lỗi", MessageBoxButtons.OK);
                        return;
                    }
                    //Thông báo xác nhận
                    if (XtraMessageBox.Show("Bạn có chắc xóa loại dịch vụ '" + gridView1.GetFocusedRowCellValue(colTenLDV).ToString() +"' ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        BUS.LoaiDichVuBUS.XoaLoaiDichVu((int)gridView1.GetFocusedRowCellValue(colMaLDV));

                        //Thông báo thành công/thất bại
                        XtraMessageBox.Show("Xóa loại dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK);
                        RefreshDataBinding();
                    }


                    break;
            }
        }

        private void wbntBack_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            LoaiDichVuPagecontrol.SelectedPage = PageLoaidichvu;
        }

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            LoaiDichVuPagecontrol.SelectedPage = PageLoaidichvu;
        }
    }
}

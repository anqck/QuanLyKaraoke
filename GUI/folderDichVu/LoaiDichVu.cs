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

        Action GoToDichVu;
        public LoaiDichVu()
        {
            InitializeComponent();

            themLoaiDichVu1.actionBack = GoToHomePageWithAnimation;
            suaLoaiDichVu1.actionBack = GoToHomePageWithAnimation;
        }


        internal void AddGoToDichVu(Action goToHomeDichVu)
        {
            GoToDichVu = goToHomeDichVu;
        } 

        public void GoToHomePageWithoutAnimation()
        {
            RefreshDataBinding();
            LoaiDichVuPagecontrol.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            LoaiDichVuPagecontrol.SelectedPageIndex = 0;
            LoaiDichVuPagecontrol.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.True;
        }

        public void GoToHomePageWithAnimation()
        {
            RefreshDataBinding();
             LoaiDichVuPagecontrol.SelectedPageIndex = 0;            
        }

        public void RefreshDataBinding()
        {
            try
            {
                dtLoaiDichVu = BUS.LoaiDichVuBUS.LayTatCaLoaiDichVu_DataTable();
                dtDichVu = BUS.DichVuBUS.LayTatCaDichVu_DataTable();

                dataset = new DataSet();
                dataset.Tables.Add(dtLoaiDichVu);
                dataset.Tables.Add(dtDichVu);

                dataset.Relations.Add("Thông tin chi tiết dịch vụ", dataset.Tables["loaidichvu"].Columns["MaLDV"], dataset.Tables["dichvu"].Columns["MaLDV"]);

                gridControl1.DataSource = dataset.Tables["loaidichvu"];
                gridControl1.LevelTree.Nodes.Add("Thông tin chi tiết dịch vụ", tileView1);


            }
            catch (Exception x)
            {

            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(gridView1.RowCount == 0 )
            {
                wbntSuadichvu.Buttons[1].Properties.Enabled = false;
                wbntSuadichvu.Buttons[2].Properties.Enabled = false;
                return;
            }

            if (e.FocusedRowHandle == 0 || e.FocusedRowHandle == 1 || e.FocusedRowHandle == 2)
            {
                wbntSuadichvu.Buttons[1].Properties.Enabled = false;
                wbntSuadichvu.Buttons[2].Properties.Enabled = false;
            }
            else
            {
                wbntSuadichvu.Buttons[1].Properties.Enabled = true;
                wbntSuadichvu.Buttons[2].Properties.Enabled = true;
                
            
            }
        }

        private void wbntSuadichvu_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch(e.Button.Properties.Tag.ToString())
            {
                case "Quản Lý Dịch Vụ":
                    GoToDichVu();
                    break;
                    
                case "Thêm Loại Dịch Vụ":
                   
                    LoaiDichVuPagecontrol.SelectedPage = PageThemloaidichvu;
                    break;
                case "Sửa Loại Dịch Vụ":
                    suaLoaiDichVu1.RefreshDataBinding(new DTO.LoaiDichVuDTO((int)dtLoaiDichVu.Rows[gridView1.GetFocusedDataSourceRowIndex()]["MaLDV"], dtLoaiDichVu.Rows[gridView1.GetFocusedDataSourceRowIndex()]["TenLDV"].ToString()));
                    LoaiDichVuPagecontrol.SelectedPage = PageSualoaidichvu;


                    break;
                case "Xóa Loại Dịch Vụ":
                    //Kiểm tra xem có chọn dòng nào không
                    if(gridView1.GetFocusedRow() == null)
                    {
                 

                        return;
                    }

                    //Kiểm tra xem loại dịch vụ đó còn dịch vụ nào không
                    DataRowView rowView = gridView1.GetRow(gridView1.FocusedRowHandle) as DataRowView;
                    DataView view = rowView.CreateChildView("Thông tin chi tiết dịch vụ");
                    if (view.Count != 0)
                    {
                        XtraMessageBox.Show("Chỉ có thể xóa những loại dịch vụ không tồn tại dịch vụ nào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                

                    //Thông báo xác nhận
                    if (XtraMessageBox.Show("Bạn có chắc xóa loại dịch vụ '" + gridView1.GetFocusedRowCellValue(colTenLDV).ToString() +"' ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        BUS.LoaiDichVuBUS.XoaLoaiDichVu((int)gridView1.GetFocusedRowCellValue(colMaLDV));

                        //Thông báo thành công/thất bại
                        XtraMessageBox.Show("Xóa loại dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDataBinding();
                    }


                    break;
            }
        }


        private void LoaiDichVuPagecontrol_SelectedPageChanging(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangingEventArgs e)
        {
            if(e.Page == PageLoaidichvu)
            {
                RefreshDataBinding();
            }
            else if(e.Page == PageThemloaidichvu)
            {
                themLoaiDichVu1.Initialize();
            }
        }
    }
}

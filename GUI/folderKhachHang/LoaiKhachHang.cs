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

namespace GUI.folderKhachHang
{
    public partial class LoaiKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        public Action goToKhachHang { get; set; }

        DataSet dataset;
        DataTable dtLoaiKhachHang;
        DataTable dtKhachHang;

        public LoaiKhachHang()
        {
            InitializeComponent();

            themLoaiKhachHang2.actionBack = GoToHomeLoaiKhachHang;
            suaLoaiKhachHang1.actionBack = GoToHomeLoaiKhachHang;
        }

        public void RefreshDataBinding()
        {
            dtLoaiKhachHang = BUS.LoaiKhachHangBUS.LayTatCaLoaiKhachHang_DataTable();
            dtKhachHang = BUS.KhachHangBUS.LayTatCaKhachHang_DataTable();

            dataset = new DataSet();
            dataset.Tables.Add(dtLoaiKhachHang);
            dataset.Tables.Add(dtKhachHang);

            dataset.Relations.Add("Thông tin khách hàng", dataset.Tables["loaikhachhang"].Columns["MaLoaiKH"], dataset.Tables["khachhang"].Columns["MaLoaiKH"]);

            gridControl.DataSource = dataset.Tables["loaikhachhang"];
            gridControl.LevelTree.Nodes.Add("Thông tin khách hàng", gridViewKhachHang);
        }

        private void wbntLoaikhachhang_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch(e.Button.Properties.Tag.ToString())
            {
                case "Thêm loại khách hàng":
                    this.LoaiKhachHangPagecontrol.SelectedPage = PageThemloaikhachhang;
                    themLoaiKhachHang2.RefreshDataBinding();
                    break;
                case "Sửa loại khách hàng":
                    DataRow row = dtLoaiKhachHang.Rows[gridViewLoaiKhachHang.GetFocusedDataSourceRowIndex()];
                    suaLoaiKhachHang1.RefreshDataBinding((int)row["MaLoaiKH"]);
                    LoaiKhachHangPagecontrol.SelectedPage = PageSualoaikhachhang;


                    break;
                case "Quản lý khách hàng":
                    goToKhachHang();
                    break;
                case "Xóa loại khách hàng":
                    //Kiểm tra xem có chọn dòng nào không
                    if (gridViewLoaiKhachHang.GetFocusedRow() == null)
                    {


                        return;
                    }

                    //Kiểm tra xem loại dịch vụ đó còn dịch vụ nào không
                    DataRowView rowView = gridViewLoaiKhachHang.GetRow(gridViewLoaiKhachHang.FocusedRowHandle) as DataRowView;
                    DataView view = rowView.CreateChildView("Thông tin khách hàng");
                    if (view.Count != 0)
                    {
                        XtraMessageBox.Show("Chỉ có thể xóa những loại khách hàng không tồn tại khách hàng nào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }


                    //Thông báo xác nhận
                    if (XtraMessageBox.Show("Bạn có chắc xóa loại khách hàng '" + dtLoaiKhachHang.Rows[gridViewLoaiKhachHang.GetFocusedDataSourceRowIndex()]["TenLoaiKH"].ToString() + "' ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        BUS.LoaiKhachHangBUS.XoaLoaiKhachHang((int)gridViewLoaiKhachHang.GetFocusedRowCellValue(colMaLoaiKH));

                        //Thông báo thành công/thất bại
                        XtraMessageBox.Show("Xóa loại khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDataBinding();
                    }


                    break;
            }
        
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridViewLoaiKhachHang.RowCount == 0)
            {
                wbntLoaikhachhang.Buttons[1].Properties.Enabled = false;
                wbntLoaikhachhang.Buttons[2].Properties.Enabled = false;
                return;
            }

            if (e.FocusedRowHandle == 0 )
            {
                wbntLoaikhachhang.Buttons[1].Properties.Enabled = false;
                wbntLoaikhachhang.Buttons[2].Properties.Enabled = false;
            }
            else
            {
                wbntLoaikhachhang.Buttons[1].Properties.Enabled = true;
                wbntLoaikhachhang.Buttons[2].Properties.Enabled = true;


            }
        }

        private void GoToHomeLoaiKhachHang()
        {
            RefreshDataBinding();
            LoaiKhachHangPagecontrol.SelectedPage = PageLoaikhachhang;
        }
        
        public void GoToHomePageWithoutAnimation()
        {
            KhachhangPagecontrol.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            KhachhangPagecontrol.SelectedPageIndex = 0;
            KhachhangPagecontrol.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.True;
        }
    }
}

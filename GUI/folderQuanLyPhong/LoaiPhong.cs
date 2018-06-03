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
using BUS;

namespace GUI.folderQuanLyPhong
{
    public partial class LoaiPhong : DevExpress.XtraEditors.XtraUserControl
    {
        DataSet dataSet;
        DataTable dtLoaiPhong;
        DataTable dtDonGiaPhong;
        DataTable dtPhong;

        public Action goToQuanLyPhong { get; set; }

        public LoaiPhong()
        {
            InitializeComponent();

            themLoaiPhong1.goToHomeLoaiPhong = GoToHomePage_WithAnimation;
            suaLoaiPhong1.goToHomeLoaiPhong = GoToHomePage_WithAnimation;
        }

        private void wbntBack_themloaiphong_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            LoaiPhongPagecontrol.SelectedPage = PageLoaiphong;
        }

        private void wbntBack_sualoaiphong_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            LoaiPhongPagecontrol.SelectedPage = PageLoaiphong;
        }

        private void wbntLoaiphong_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Caption.ToString())
            {
                case "Thêm Loại Phòng":
                    themLoaiPhong1.Initialize();
                    LoaiPhongPagecontrol.SelectedPage = PageThemloaiphong;
                    break;
                case "Sửa Loại Phòng":
                    suaLoaiPhong1.RefreshDataBinding(new DTO.LoaiPhongDTO((int)dtLoaiPhong.Rows[gridViewLoaiPhong.GetFocusedDataSourceRowIndex()]["MaLP"], dtLoaiPhong.Rows[gridViewLoaiPhong.GetFocusedDataSourceRowIndex()]["TenLoaiPhong"].ToString()));
                    LoaiPhongPagecontrol.SelectedPage = PageSualoaiphong;
                    break;
                case "Xóa Loại Phòng":
                    //Xác nhận xóa?
                    if (XtraMessageBox.Show("Bạn có chắc muốn xóa loại phòng '" + dtLoaiPhong.Rows[gridViewLoaiPhong.GetFocusedDataSourceRowIndex()]["TenLoaiPhong"].ToString() + "' ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                        return;

                    //Kiểm tra xem loại phòng có phòng nào không

                    DataRowView rowView = gridViewLoaiPhong.GetRow(gridViewLoaiPhong.FocusedRowHandle) as DataRowView;
                    DataView view = rowView.CreateChildView("Thông tin phòng");         
                    if (view.Count == 0)
                    {
                        LoaiPhongBUS.XoaDonGiaPhong((int)dtLoaiPhong.Rows[gridViewLoaiPhong.GetFocusedDataSourceRowIndex()]["MaLP"]);
                        LoaiPhongBUS.XoaLoaiPhong(new DTO.LoaiPhongDTO((int)dtLoaiPhong.Rows[gridViewLoaiPhong.GetFocusedDataSourceRowIndex()]["MaLP"], dtLoaiPhong.Rows[gridViewLoaiPhong.GetFocusedDataSourceRowIndex()]["TenLoaiPhong"].ToString()));
                        //Thông báo xóa loại phòng thành công
                        XtraMessageBox.Show("Xóa loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDataBinding();
                    }
                    else
                    {
                        //Thông báo không thể xóa loại phòng do có phòng có loại phòng đó
                        XtraMessageBox.Show("Không thể xóa loại phòng do tồn tại phòng chứa mã phòng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return;
                    }
                    break;
                case "Quản Lý Phòng":
                    goToQuanLyPhong();
                    break;
            }
        }
        public void RefreshDataBinding()
        {
            dataSet = new DataSet();
            dtLoaiPhong = LoaiPhongBUS.LayTatCaLoaiPhong_DataTable();
            dtDonGiaPhong = DonGia_LoaiPhongBUS.LayTatCaDonGia_DataTable();
            dtPhong = PhongBUS.LayTatCaPhong_TinhTrangPhong_LoaiPhong();
            dtPhong.TableName = "phong";

            dataSet.Tables.Add(dtLoaiPhong);
            dataSet.Tables.Add(dtDonGiaPhong);
            dataSet.Tables.Add(dtPhong);

            dataSet.Relations.Add("Đơn giá phòng",  dataSet.Tables["loaiphong"].Columns["MaLP"], dataSet.Tables["dongia_loaiphong"].Columns["MaLoaiPhong"]);
            dataSet.Relations.Add("Thông tin phòng", dataSet.Tables["loaiphong"].Columns["MaLP"], dataSet.Tables["phong"].Columns["MaLoaiPhong"] );

            gridControl1.DataSource = dataSet.Tables["loaiphong"];
            gridControl1.LevelTree.Nodes.Add("Đơn giá phòng", gridViewDonGiaPhong);
            gridControl1.LevelTree.Nodes.Add("Thông tin phòng", gridViewPhong);

            if(gridViewLoaiPhong.RowCount == 0)
            {
                wbntLoaiphong.Buttons[1].Properties.Visible = false;
                wbntLoaiphong.Buttons[2].Properties.Visible = false;
            }

        }

        private void gridViewDonGiaPhong_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if(e.Column.FieldName == "colGioKetThuc")
            {
                if (e.IsGetData)
                    e.Value = TimeSpanToString(((TimeSpan)dtDonGiaPhong.Rows[e.ListSourceRowIndex]["GioKetThuc"]));


             }
        }
        public string TimeSpanToString(TimeSpan t)
        {

            return t.TotalHours.ToString("00") + ":" + t.Minutes.ToString("00") + ":" + t.Seconds.ToString("00");
        }

        private void gridViewLoaiPhong_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(e.FocusedRowHandle >= 0)
            {
                wbntLoaiphong.Buttons[1].Properties.Visible = true;
                wbntLoaiphong.Buttons[2].Properties.Visible = true;
            }
        }
        public void GoToPage_WithoutAnimation(int v)
        {
            LoaiPhongPagecontrol.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            LoaiPhongPagecontrol.SelectedPageIndex = v;
            LoaiPhongPagecontrol.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.True;
        }

        public void GoToHomePage_WithAnimation()
        {

            RefreshDataBinding();
            LoaiPhongPagecontrol.SelectedPageIndex = 0;
        
        }


    }
}

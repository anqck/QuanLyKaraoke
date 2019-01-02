using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
using BUS;
using GUI.folderTinhTrangPhong;
using DevExpress.XtraBars.Docking2010.Customization;

namespace GUI.folderDatPhong
{
    public partial class ThongTinChiTietDatPhong : XtraUserControl
    {
        public ChiTietDatPhongDTO chiTietDatPhong;
        public PhongDTO phong { get; set; }
        DataTable dichVuPhong;

        public ThongTinChiTietDatPhong()
        {
            InitializeComponent();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(e.FocusedRowHandle >= 0)
            {

            }
        }

        private void gridView2_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "colSoLuong")
            {
                if (e.IsGetData)
                {
                    e.Value = dichVuPhong.Rows[e.ListSourceRowIndex]["SoLuong"];
                }
                if (e.IsSetData)
                {
                    DichVuDatPhongBUS.UpdateDichVuDatPhong(new DichVuDatPhongDTO((int)dichVuPhong.Rows[e.ListSourceRowIndex]["MaDichVuDatPhong"], (int)dichVuPhong.Rows[e.ListSourceRowIndex]["MaDichVu"],Convert.ToDouble(e.Value), (double)dichVuPhong.Rows[e.ListSourceRowIndex]["Gia"],chiTietDatPhong.MaChiTietDatPhong));
                    RefreshDataBindingDichVuPhong();
                }

            }
            else if (e.Column.FieldName == "colDonGia")
            {
                if (e.IsGetData)
                {
                    e.Value = Convert.ToInt32(dichVuPhong.Rows[e.ListSourceRowIndex]["Gia"]);
                }
                if (e.IsSetData)
                {
                    DichVuDatPhongBUS.UpdateDichVuDatPhong(new DichVuDatPhongDTO((int)dichVuPhong.Rows[e.ListSourceRowIndex]["MaDichVuDatPhong"], (int)dichVuPhong.Rows[e.ListSourceRowIndex]["MaDichVu"], (double)dichVuPhong.Rows[e.ListSourceRowIndex]["SoLuong"], Convert.ToDouble(e.Value), chiTietDatPhong.MaChiTietDatPhong));
                    RefreshDataBindingDichVuPhong();
                }

            }
            else if (e.Column.FieldName == "colThanhTien")
            {
                if (e.IsGetData)
                {
                    e.Value = Convert.ToInt32(dichVuPhong.Rows[e.ListSourceRowIndex]["SoLuong"]) * (double)dichVuPhong.Rows[e.ListSourceRowIndex]["Gia"];
                }


            }

        }
        internal void RefreshDataBinding(ChiTietDatPhongDTO chiTiet)
        {
            chiTietDatPhong = chiTiet;

            phong = PhongBUS.LayThongTinPhong(chiTiet.MaPhong);
            txtMaPhong.EditValue = phong.MaPhong;
            txtTenPhong.EditValue = phong.TenPhong;
            txtLoaiPhong.EditValue = LoaiPhongBUS.LayLoaiPhong(phong).TenLoaiPhong;
            txtTang.EditValue = phong.Tang;
            txtTinhTrangPhong.EditValue = PhongBUS.LayTinhTrangPhong(phong.MaTinhTrangPhong).TinhTrangPhong;
            txtGhiChu.EditValue = phong.GhiChu;

            RefreshDataBindingDichVuPhong();

        }
        void RefreshDataBindingDichVuPhong()
        {
            dichVuPhong = DichVuDatPhongBUS.LayTatCaDichVuDatPhong_DichVu_LoaiDV(chiTietDatPhong);
            gridControl1.DataSource = dichVuPhong;

            if (gridView1.RowCount == 0)
                wbntQuanlyphong.Buttons[1].Properties.Visible = false;
            else
                wbntQuanlyphong.Buttons[1].Properties.Visible = true;
        }

        private void wbntQuanlyphong_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Tag.ToString())
            {
                case "Thêm Dịch Vụ":
                    folderDichVu.ChonDichVu chonDichVu = new folderDichVu.ChonDichVu(false);

                    XtraDialogArgs args = new XtraDialogArgs(caption: "Chọn dịch vụ", content: chonDichVu, buttons: new DialogResult[] { DialogResult.OK, DialogResult.Cancel });
                    args.Showing += Args_Showing;


                    if (XtraDialog.Show(args) == DialogResult.OK)
                    {
                        foreach (int dichVu_Key in chonDichVu.GetSelectedDichVu().Keys)
                        {
                            DichVuDatPhongBUS.LuuThongTinDichVuDatPhong(new DichVuDatPhongDTO(DichVuDatPhongBUS.PhatSinhMaDichVuPhong(),  dichVu_Key,  chonDichVu.GetSelectedDichVu()[dichVu_Key], DichVuBUS.LayThongTinDichVu(dichVu_Key).DonGia,chiTietDatPhong.MaChiTietDatPhong));
                            //DichVuBUS.LayThongTinDichVu(dichVu_Key);
                        }

                        RefreshDataBindingDichVuPhong();
                    }
                    break;
                case "Chuyển Phòng":
                    ChuyenPhong formChuyenPhong = new ChuyenPhong(chiTietDatPhong);


                    if (FlyoutDialog.Show(this.FindForm(), formChuyenPhong) == DialogResult.OK)
                    {
                        XtraMessageBox.Show("Chuyển phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        (Parent.Parent.Parent as ThongTinChiTietDatNhieuPhong).RefreshData();
                    }

                    break;
                case "Xóa Dịch Vụ":
                    if (XtraMessageBox.Show("Bạn có chắc muốn xóa dịch vụ '" + dichVuPhong.Rows[gridView1.GetFocusedDataSourceRowIndex()]["TenDV"] + "' ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        DichVuDatPhongBUS.XoaDichVuDatPhong((int)dichVuPhong.Rows[gridView1.GetFocusedDataSourceRowIndex()]["MaDichVuDatPhong"]);


                        RefreshDataBindingDichVuPhong();
                    }

                    break;
                case "Nhận Phòng":

                    //Thông báo xác nhận
                    if (XtraMessageBox.Show("Xác nhận nhận đặt phòng?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }

                        (Parent.Parent.Parent as ThongTinChiTietDatNhieuPhong).NhanPhong();
                    break;
                case "Hủy Phòng":

                    //Thông báo xác nhận
                    if (XtraMessageBox.Show("Bạn có chắc hủy phòng đã đặt này ?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }

                    if (PhongBUS.LayThongTinPhong(chiTietDatPhong.MaPhong).MaTinhTrangPhong == 4)
                    {
                        PhongBUS.CapNhatTinhTrangPhong(chiTietDatPhong.MaPhong, 0);
                    }



                    DatPhongBUS.XoaCacDichVuDatPhong(chiTietDatPhong);
                    DatPhongBUS.XoaDatChiTietDatPhong(chiTietDatPhong);
                    if (DatPhongBUS.DemSoLuongChiTietDatPhong(chiTietDatPhong.MaDatPhong) == 0)
                    {
                        DatPhongBUS.XoaDatPhong(chiTietDatPhong.MaDatPhong);
                    }
                    XtraMessageBox.Show("Xóa đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    (Parent.Parent.Parent as ThongTinChiTietDatNhieuPhong).RefreshData();

                    //ThuePhongBUS.XoaThuePhong(thuePhong);
                    //PhongBUS.CapNhatTinhTrangPhong(thuePhong.MaPhong, 0);
                    //if (HoaDonBUS.DemSoLuongThuePhong(hoaDon.MaHoaDon) == 0)
                    //{
                    //    HoaDonBUS.XoaHoaDon(hoaDon);
                    //}

                    //((ThongTinChiTietNhieuPhong)Parent.Parent.Parent).OnXoaPhong();

                    break;
                case "Hủy Đặt Phòng":

                    //Thông báo xác nhận
                    if (XtraMessageBox.Show("Bạn có chắc hủy đặt phòng này ?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }

                    //BUS.PhongBUS.CapNhatTinhTrangPhong(chiTiet.MaPhong, 0);

                    DatPhongBUS.CapNhatTinhTrangDatPhong(3,chiTietDatPhong.MaDatPhong);

                    foreach(ChiTietDatPhongDTO dp in DatPhongBUS.LayTatCaCacChiTietDatPhong(chiTietDatPhong.MaDatPhong))
                    {
                        PhongBUS.CapNhatTinhTrangPhong(dp.MaPhong, 0);
                    }
                    (Parent.Parent.Parent as ThongTinChiTietDatNhieuPhong).RefreshData();
                    break;

            }
        }
        private void Args_Showing(object sender, XtraMessageShowingArgs e)
        {
            e.Buttons[DialogResult.OK].Text = "Chọn";
            e.Buttons[DialogResult.Cancel].Text = "Hủy bỏ";
        }
   
        public void LuuThongTinDichVuPhong(ThuePhongDTO tp)
        {
            foreach (DataRow dr in dichVuPhong.Rows)
            {
                DichVuPhongBUS.LuuThongTinDichVuPhong(new DichVuPhongDTO(DichVuPhongBUS.PhatSinhMaDichVuPhong(), tp.MaThuePhong, (int)dr["MaDichVu"], DateTime.Now, (double)dr["SoLuong"],(double) dr["Gia"]));

            }
        }
    }
}

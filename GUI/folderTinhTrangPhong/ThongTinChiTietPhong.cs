using BUS;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors;
using DTO;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GUI.folderTinhTrangPhong
{
    public partial class ThongTinChiTietPhong : DevExpress.XtraEditors.XtraUserControl
    {
        public PhongDTO phong { get; set; }
        private KhachHangDTO khachHang;
        private HoaDonDTO hoaDon;
        private ThuePhongDTO thuePhong;

        DataTable dichVuPhong;
        //Dictionary<DichVuPhongDTO> listDichVuPhong;



        public ThongTinChiTietPhong()
        {
            InitializeComponent();

            phong = null;
            khachHang = null;
            thuePhong = null;

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }


        public void InitializeControl()
        {


        }
        void RefreshDataBindingDichVuPhong()
        {
            dichVuPhong = DichVuPhongBUS.LayTatCaDichVuPhong_DichVu(thuePhong);
            gridControl1.DataSource = dichVuPhong;

            if (gridView1.RowCount == 0)
                wbntQuanlyphong.Buttons[1].Properties.Visible = false;
            else
                wbntQuanlyphong.Buttons[1].Properties.Visible = true;
        }
        public void RefreshDataBinding(PhongDTO phongDTO)
        {
            phong = phongDTO;

            txtMaPhong.EditValue = phongDTO.MaPhong;
            txtTenPhong.EditValue = phongDTO.TenPhong;
            txtLoaiPhong.EditValue = BUS.LoaiPhongBUS.LayLoaiPhong(phongDTO).TenLoaiPhong;
            txtTang.EditValue = phongDTO.Tang;

            //Dictionary<int, ThuePhongDTO> listPhongDangThue = BUS.ThuePhongBUS.LayThongTinCacPhongDangDuocThue();
            if (phongDTO.MaTinhTrangPhong == 1)
            {
                DisplayControlForRented(true);

                thuePhong = BUS.ThuePhongBUS.LayThongTinPhongDangThue(phongDTO);
                hoaDon = BUS.HoaDonBUS.LayThongTinHoaDonDangThue(thuePhong.MaHoaDon);
                khachHang = BUS.KhachHangBUS.LayKhachHang(hoaDon.MaKH);

                txtMaKH.EditValue = khachHang.MaKH;
                txtTenKH.EditValue = khachHang.TenKH;
                txtLoaiKH.EditValue = BUS.LoaiKhachHangBUS.LayLoaiKhachHang(khachHang).TenKH;
                txtSDT.EditValue = khachHang.SDT;
                txtDiemTichLuy.EditValue = khachHang.DiemTichLuy;

                txtNgayGioVao.EditValue = thuePhong.GioThuePhong.ToString("dd-MM-yyyy hh:mm:ss");
                txtGioTraPhong.EditValue = (thuePhong.GioTraPhong == DateTime.MinValue)?"Chưa có": thuePhong.GioTraPhong.ToString("dd-MM-yyyy hh:mm:ss");
                txtTienTraTruoc.EditValue = hoaDon.TienTraTruoc;

                txtSoGio.EditValue = ToCustomString((DateTime.Now - thuePhong.GioThuePhong));

                RefreshDataBindingDichVuPhong();
            }
            else
            {
                DisplayControlForRented(false);
            }
        }

        private void DisplayControlForRented(bool dangDuocThue)
        {
            if (dangDuocThue)
            {
                tabbedControlGroup1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                grpKhachHang.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                grpThuePhong.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                gridControl1.Visible = true;

            }

            else
            {
                tabbedControlGroup1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                grpKhachHang.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                grpThuePhong.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                gridControl1.Visible = false;
            }

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
                            DichVuPhongBUS.LuuThongTinDichVuPhong(new DichVuPhongDTO(DichVuPhongBUS.PhatSinhMaDichVuPhong(), thuePhong.MaThuePhong, dichVu_Key, DateTime.Now, chonDichVu.GetSelectedDichVu()[dichVu_Key], DichVuBUS.LayThongTinDichVu(dichVu_Key).DonGia));
                            //DichVuBUS.LayThongTinDichVu(dichVu_Key);
                        }

                        RefreshDataBindingDichVuPhong();
                    }
                    break;
                case "Xóa Dịch Vụ":
                    if (XtraMessageBox.Show("Bạn có chắc muốn xóa dịch vụ '" + dichVuPhong.Rows[gridView1.GetFocusedDataSourceRowIndex()]["TenDV"] + "' ?", "Xác nhận", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        DichVuPhongBUS.XoaDichVuPhong((int)dichVuPhong.Rows[gridView1.GetFocusedDataSourceRowIndex()]["MaDVP"]);


                        RefreshDataBindingDichVuPhong();
                    }
                   
                    break;
                case "Thanh Toán":
                    goToThanhToan();
                    break;
            }
        }

        private void Args_Showing(object sender, XtraMessageShowingArgs e)
        {
            e.Buttons[DialogResult.OK].Text = "Chọn";
            e.Buttons[DialogResult.Cancel].Text = "Hủy bỏ";
        }
        public void UpdateTime()
        {
            if (tabbedControlGroup1.Visible == true)
            {
                txtSoGio.EditValue = ToCustomString((DateTime.Now - thuePhong.GioThuePhong));
            }
        }

        public string ToCustomString(TimeSpan span)
        {
            return string.Format("{0}:{1:D2}:{2:D2}", span.Days * 24 + span.Hours, span.Minutes, span.Seconds);
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gridView1.RowCount == 0)
                wbntQuanlyphong.Buttons[1].Properties.Visible = false;
            else
                wbntQuanlyphong.Buttons[1].Properties.Visible = true;
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
                    DichVuPhongBUS.UpdateDichVuPhong(new DichVuPhongDTO((int)dichVuPhong.Rows[e.ListSourceRowIndex]["MaDVP"], (int)dichVuPhong.Rows[e.ListSourceRowIndex]["MaThuePhong"], (int)dichVuPhong.Rows[e.ListSourceRowIndex]["MaDV"], DateTime.Parse(dichVuPhong.Rows[e.ListSourceRowIndex]["ThoiGian"].ToString()), Convert.ToDouble(e.Value), (double)dichVuPhong.Rows[e.ListSourceRowIndex]["Gia"]));
                    RefreshDataBindingDichVuPhong();
                }

            }
            else if (e.Column.FieldName == "colDonGia")
            {
                if (e.IsGetData)
                {
                    e.Value = Convert.ToInt32(dichVuPhong.Rows[e.ListSourceRowIndex]["Gia"]) ;
                }
                if (e.IsSetData)
                {
                    DichVuPhongBUS.UpdateDichVuPhong(new DichVuPhongDTO((int)dichVuPhong.Rows[e.ListSourceRowIndex]["MaDVP"], (int)dichVuPhong.Rows[e.ListSourceRowIndex]["MaThuePhong"], (int)dichVuPhong.Rows[e.ListSourceRowIndex]["MaDV"], DateTime.Parse(dichVuPhong.Rows[e.ListSourceRowIndex]["ThoiGian"].ToString()), (double)dichVuPhong.Rows[e.ListSourceRowIndex]["SoLuong"], Convert.ToDouble(e.Value)));
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

        Action goToThanhToan;

        
        public void SetActionThanhToanButton(Action action)
        {
            goToThanhToan = action;
           
        }

        private void ThongTinChiTietPhong_Load(object sender, EventArgs e)
        {

        }
    }
}

using BUS;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Customization;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using DTO;
using System;
using System.Collections.Generic;
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

            schedulerControl1.GoToToday();
            
            
        }

  
        void RefreshDataBindingDichVuPhong()
        {
            dichVuPhong = DichVuPhongBUS.LayTatCaDichVuPhong_DichVu(thuePhong);
            gridControl1.DataSource = dichVuPhong;

            if (gridView1.RowCount == 0)
                wbntQuanlyphong.Buttons["Xóa Dịch Vụ"].Properties.Visible = false;
            else
                wbntQuanlyphong.Buttons["Xóa Dịch Vụ"].Properties.Visible = true;
        }
        public void RefreshDataBinding(PhongDTO phongDTO, ThuePhongDTO thuePhongDTO = null)
        {
            phong = phongDTO;

            txtMaPhong.EditValue = phongDTO.MaPhong;
            txtTenPhong.EditValue = phongDTO.TenPhong;
            txtLoaiPhong.EditValue = BUS.LoaiPhongBUS.LayLoaiPhong(phongDTO).TenLoaiPhong;
            txtTang.EditValue = phongDTO.Tang;

            RefreshDataBindingDatPhong();

            //Phòng trống
            if (thuePhongDTO == null)
            {
                DisplayControlForRented(false);
                for(int i = 0; i< wbntQuanlyphong.Buttons.Count; i++)
                {
                    wbntQuanlyphong.Buttons[i].Properties.Visible = false;
                }
            }
            else
            {
                DisplayControlForRented(true);

                if (HoaDonBUS.LayThongTinHoaDon(thuePhongDTO.MaHoaDon).MaDatPhong == -1)
                {
                    wbntQuanlyphong.Buttons[7].Properties.Visible = false;
                    wbntQuanlyphong.Buttons["Thông tin đặt phòng"].Properties.Visible = false;
                }
                    
                else
                    wbntQuanlyphong.Buttons["Thông tin đặt phòng"].Properties.Visible = true;

                thuePhong = thuePhongDTO;
                hoaDon = BUS.HoaDonBUS.LayThongTinHoaDonDangThue(thuePhong.MaHoaDon);
                khachHang = BUS.KhachHangBUS.LayKhachHang(hoaDon.MaKH);

                txtMaKH.EditValue = khachHang.MaKH;
                txtTenKH.EditValue = khachHang.TenKH;
                txtLoaiKH.EditValue = BUS.LoaiKhachHangBUS.LayLoaiKhachHang(khachHang).TenLoaiKH;
                txtSDT.EditValue = khachHang.SDT;
                txtDiemTichLuy.EditValue = khachHang.DiemTichLuy;


                txtNgayGioVao.EditValue = thuePhong.GioThuePhong.ToString("dd-MM-yyyy hh:mm:ss");
                txtGioTraPhong.EditValue = (thuePhong.GioTraPhong == DateTime.MinValue) ? "Chưa có" : thuePhong.GioTraPhong.ToString("dd-MM-yyyy hh:mm:ss");
                txtTienTraTruoc.EditValue = hoaDon.TienTraTruoc;

                txtMaHoaDon.EditValue = hoaDon.MaHoaDon;
                txtGhiChu.EditValue = hoaDon.GhiChu;

                //Phòng đang được thuê
                if (thuePhongDTO.GioTraPhong == DateTime.MinValue)
                {
                    txtSoGio.EditValue = ToCustomString((DateTime.Now - thuePhong.GioThuePhong));
                }
                else //Phòng đã được trả
                {
                    txtSoGio.EditValue = ToCustomString((thuePhong.GioTraPhong - thuePhong.GioThuePhong));
                    wbntQuanlyphong.Buttons["Chuyển Phòng"].Properties.Visible = false;
                    wbntQuanlyphong.Buttons["Trả Phòng"].Properties.Visible = false;
                }


                RefreshDataBindingDichVuPhong();
            }          

            
        }

        private void RefreshDataBindingDatPhong()
        {

            schedulerControl1.Storage.Appointments.Clear();

            List<DatPhongDTO> listDatPhong = DatPhongBUS.LayTatCaCacDatPhong(phong.MaPhong);
            foreach(DatPhongDTO datPhong in listDatPhong)
            {
                
                Appointment apt = schedulerControl1.Storage.CreateAppointment(AppointmentType.Normal);
                apt.Start = datPhong.ThoiGianDatPhong;
                apt.Duration = TimeSpan.FromMinutes(ThamSoBUS.LayKhoangThoiGianToiThieuGiuaHaiLanThue());
                apt.Subject = "Đặt phòng";
                apt.StatusKey = datPhong.MaDatPhong;
                apt.Description = "Khách hàng: " + KhachHangBUS.LayKhachHang(datPhong.MaKH).TenKH + "\nTiền trả trước: "+ datPhong.SoTienDatTruoc.ToString("###,###,##0 VNĐ") + "\nGhi chú: " + datPhong.GhiChu;
                
                if (datPhong.MaTinhTrangDatPhong == 1)
                    apt.LabelId = 3;
                else if (datPhong.MaTinhTrangDatPhong == 2)
                    apt.LabelId = 2;
                else if(datPhong.MaTinhTrangDatPhong == 3)
                    apt.LabelId = 1;
                 
                schedulerControl1.Storage.Appointments.Add(apt);
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
                case "Chuyển Phòng":
                    ChuyenPhong formChuyenPhong = new ChuyenPhong(thuePhong);
                    if (FlyoutDialog.Show(this.FindForm(), formChuyenPhong) == DialogResult.OK)
                    {
                        OnThueThemPhongSuccess();
                    }

                    break;
                case "Xóa Dịch Vụ":
                    if (XtraMessageBox.Show("Bạn có chắc muốn xóa dịch vụ '" + dichVuPhong.Rows[gridView1.GetFocusedDataSourceRowIndex()]["TenDV"] + "' ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        DichVuPhongBUS.XoaDichVuPhong((int)dichVuPhong.Rows[gridView1.GetFocusedDataSourceRowIndex()]["MaDVP"]);


                        RefreshDataBindingDichVuPhong();
                    }

                    break;
                case "Hủy Phòng":

                    //Thông báo xác nhận
                    if (XtraMessageBox.Show("Bạn có chắc hủy thuê phòng này ?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return ;
                    }
            

                    ThuePhongBUS.XoaCacDichVuPhong(thuePhong);
                    ThuePhongBUS.XoaThuePhong(thuePhong);
                    PhongBUS.CapNhatTinhTrangPhong(thuePhong.MaPhong, 0);
                    if (HoaDonBUS.DemSoLuongThuePhong(hoaDon.MaHoaDon) == 0)
                    {
                        HoaDonBUS.XoaHoaDon(hoaDon);
                    }

                    ((ThongTinChiTietNhieuPhong)Parent.Parent.Parent).OnXoaPhong();

                    break;
                case "Trả Phòng":
                    
                    //Đếm số lượng phòng đã trả trong hóa đơn / Nếu hóa đơn còn 1 phòng chuyển qua thanh toán
                    if(HoaDonBUS.DemSoLuongPhongDangConDuocThueHienTai(hoaDon) == 1)
                    {
                        XtraMessageBox.Show("Hóa đơn chỉ còn lại 1 phòng! Vui lòng thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    //Xác nhận trả phòng
                    if (XtraMessageBox.Show("Bạn có chắc trả phòng này ?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                    

                    ThuePhongBUS.CapNhatThongTinThuePhong(new ThuePhongDTO(thuePhong.MaThuePhong,thuePhong.MaPhong,thuePhong.GioThuePhong, DateTime.Now,thuePhong.MaHoaDon,Double.NaN));
                    switch (PhongBUS.LayThongTinPhong(thuePhong.MaPhong).MaTinhTrangPhong)
                    {
                        case 1:
                            if (ThamSoBUS.LayChuyenSangChoDonDepSauKhiThanhToan())
                                PhongBUS.CapNhatTinhTrangPhong(thuePhong.MaPhong, 5);
                            else
                                PhongBUS.CapNhatTinhTrangPhong(thuePhong.MaPhong, 0);
                            break;
                        case 7:
                            if (ThamSoBUS.LayChuyenSangChoDonDepSauKhiThanhToan())
                                PhongBUS.CapNhatTinhTrangPhong(thuePhong.MaPhong, 6);
                            else
                                PhongBUS.CapNhatTinhTrangPhong(thuePhong.MaPhong, 4);
                            break;
                    }

                    //Thông báo thành công
                    XtraMessageBox.Show("Trả phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RefreshDataBinding(phong,ThuePhongBUS.LayThongTinThuePhong(thuePhong.MaThuePhong));

                    break;
                case "Thanh Toán":
                    goToThanhToan(thuePhong);
                    break;
                case "Thông tin đặt phòng":
                    (this.ParentForm as MainForm).HienThiThongTinDatPhong(HoaDonBUS.LayThongTinHoaDon(thuePhong.MaHoaDon).MaDatPhong);
                    break;
                case "Tách Hóa Đơn":
                    if(HoaDonBUS.LayTatCaCacThuePhong(hoaDon.MaHoaDon).Count == 1)
                    {
                        XtraMessageBox.Show("Hóa đơn chỉ có 1 phòng nên không thể tách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    FlyoutDialog.Show(this.FindForm(), new TachHoaDon(hoaDon, OnThueThemPhongSuccess));
                    break;

                case "Thuê Thêm Phòng":
                    FlyoutDialog.Show(this.FindForm(), new ThemPhongVaoHoaDon(hoaDon, OnThueThemPhongSuccess));
                    break;
            }
        }

        void OnThueThemPhongSuccess()
        {
            ((ThongTinChiTietNhieuPhong)Parent.Parent.Parent).OnXoaPhong();
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
                if(thuePhong.GioTraPhong == DateTime.MinValue)
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

        Action<ThuePhongDTO> goToThanhToan;

        
        public void SetActionThanhToanButton(Action<ThuePhongDTO> action)
        {
            goToThanhToan = action;
           
        }



        private void txtGhiChu_EditValueChanged(object sender, EventArgs e)
        {
            HoaDonBUS.CapNhatGhiChu(hoaDon.MaHoaDon,txtGhiChu.Text);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            folderKhachHang.ChonKhachHang chonKhachHang = new folderKhachHang.ChonKhachHang();
            XtraDialogArgs args = new XtraDialogArgs(caption: "Caption", content: chonKhachHang, buttons: new DialogResult[] { DialogResult.OK, DialogResult.Cancel });
            args.Showing += Args_Showing_ChonKH;
            args.Caption = "Default Text";
            args.Buttons = new DialogResult[] { DialogResult.OK, DialogResult.Cancel };


            switch (XtraDialog.Show(args))
            {
                case DialogResult.OK:
                    khachHang = chonKhachHang.LayKhachHangDaChon();


                    txtMaKH.EditValue = khachHang.MaKH;
                    txtTenKH.EditValue = khachHang.TenKH;
                    txtLoaiKH.EditValue = BUS.LoaiKhachHangBUS.LayLoaiKhachHang(khachHang).TenLoaiKH;
                    txtSDT.EditValue = khachHang.SDT;
                    txtDiemTichLuy.EditValue = khachHang.DiemTichLuy;

                    HoaDonBUS.UpdateKhachHang(hoaDon.MaHoaDon, khachHang.MaKH);
                    break;
                case DialogResult.Cancel:


                    break;
                default:
                    break;
            }
        }

        private void Args_Showing_ChonKH(object sender, XtraMessageShowingArgs e)
        {
            e.Form.Text = "Chọn khách hàng";
            e.Buttons[DialogResult.OK].Text = "Chọn";
            e.Buttons[DialogResult.Cancel].Text = "Hủy bỏ";
        }
        public void UpdateOnPageChange()
        {
            this.RefreshDataBinding(phong, thuePhong);
        }

        private void txtTienTraTruoc_TextChanged(object sender, EventArgs e)
        {

            HoaDonBUS.CapNhatTienTraTruoc(hoaDon, Convert.ToDouble(txtTienTraTruoc.EditValue));
 
        }

        private void schedulerControl1_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            
        }

        private void schedulerControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            System.Drawing.Point pos = new System.Drawing.Point(e.X, e.Y);
            DevExpress.XtraScheduler.Drawing.SchedulerViewInfoBase viewInfo = schedulerControl1.ActiveView.ViewInfo;
            DevExpress.XtraScheduler.Drawing.SchedulerHitInfo hitInfo = viewInfo.CalcHitInfo(pos, false);

            if (hitInfo.HitTest == DevExpress.XtraScheduler.Drawing.SchedulerHitTest.AppointmentContent)
            {
                (this.ParentForm as MainForm).HienThiThongTinDatPhong((int)schedulerControl1.SelectedAppointments[0].StatusKey);
            }
        }
    }
}

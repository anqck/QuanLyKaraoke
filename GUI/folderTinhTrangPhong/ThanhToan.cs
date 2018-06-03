using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Threading;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
using BUS;
using DevExpress.XtraBars.Docking2010;

namespace GUI.folderTinhTrangPhong
{
    public partial class ThanhToan : DevExpress.XtraEditors.XtraUserControl
    {

        private KhachHangDTO khachHang;
        private HoaDonDTO hoaDon;
        private ThuePhongDTO thuePhong;

        public Action goBackHome { get; set; }

       

        public ThanhToan()
        {
            InitializeComponent();


        }
        public void RefreshDataBinding(ThuePhongDTO thuePhongDTO)
        {
            this.hoaDon = BUS.HoaDonBUS.LayThongTinHoaDonDangThue(thuePhongDTO.MaHoaDon);
            this.thuePhong = thuePhongDTO;
            this.khachHang = BUS.KhachHangBUS.LayKhachHang(hoaDon.MaKH);

            txtMaHoaDon.Text = hoaDon.MaHoaDon.ToString();
            txtNgayThanhToan.Time = DateTime.Now;
            
            
           

            this.tabbedControlGroup1.Clear();
            foreach (ThuePhongDTO thuePhong in HoaDonBUS.LayTatCaCacThuePhong(hoaDon.MaHoaDon))
            {             

                ChiTietThanhToanPhong chiTietThanhToanPhongThanhToan = new ChiTietThanhToanPhong();
                DevExpress.XtraLayout.LayoutControlGroup layoutGrp = new DevExpress.XtraLayout.LayoutControlGroup();
                DevExpress.XtraLayout.LayoutControlItem layoutItem = new DevExpress.XtraLayout.LayoutControlItem();
                chiTietThanhToanPhongThanhToan.CalcTongTienAction = CalcTongTien_UpdateHoaDon;
                chiTietThanhToanPhongThanhToan.AddButtonXoaDichVu((WindowsUIButton)wbntQuanlyphong.Buttons[1]);


                chiTietThanhToanPhongThanhToan.RefreshDataBinding(thuePhong, khachHang);
                chiTietThanhToanPhongThanhToan.GetTongTienGio();
                //thongTinChiTietPhong.SetActionThanhToanButton(goToThanhToan);
                //DevExpress.XtraTab.XtraTabPage xtraTab = new DevExpress.XtraTab.XtraTabPage();

                // 
                // chiTietThanhToanPhongThanhToan
                // 
                chiTietThanhToanPhongThanhToan.Location = new System.Drawing.Point(37, 187);
                chiTietThanhToanPhongThanhToan.Name = "chiTietThanhToanPhong1";
                chiTietThanhToanPhongThanhToan.Size = new System.Drawing.Size(867, 414);
                chiTietThanhToanPhongThanhToan.TabIndex = 25;
                // 
                // layoutItem
                // 
                layoutItem.Control = chiTietThanhToanPhongThanhToan;
                layoutItem.Location = new System.Drawing.Point(0, 0);
                layoutItem.Name = "layoutControlItem8";
                layoutItem.Size = new System.Drawing.Size(873, 420);
                layoutItem.TextSize = new System.Drawing.Size(0, 0);
                layoutItem.TextVisible = false;
                // 
                // layoutGrp
                // 
                layoutGrp.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutItem });
                layoutGrp.Location = new System.Drawing.Point(0, 0);
                layoutGrp.Name = "layoutControlGroup2";
                layoutGrp.OptionsItemText.TextToControlDistance = 4;
                layoutGrp.Size = new System.Drawing.Size(873, 420);
                layoutGrp.Text = PhongBUS.LayThongTinPhong(thuePhong.MaPhong).TenPhong;
                layoutGrp.Tag = chiTietThanhToanPhongThanhToan;


                this.tabbedControlGroup1.AddTabPage(layoutGrp);

            }
            this.tabbedControlGroup1.SelectedTabPageIndex = 0;

            txtTienTraTruoc.EditValue = hoaDon.TienTraTruoc;
            CalcTongTien_UpdateHoaDon();
        }

        public void RefreshDataBinding_ReadOnly(HoaDonDTO hoaDonDTO)
        {
            this.hoaDon = hoaDonDTO;       
            this.khachHang = BUS.KhachHangBUS.LayKhachHang(hoaDon.MaKH);

            txtMaHoaDon.Text = hoaDon.MaHoaDon.ToString();
            txtNgayThanhToan.Time = DateTime.Now;
            txtTienTraTruoc.EditValue = hoaDon.TienTraTruoc;

            txtTienTraTruoc.ReadOnly = true;
            wbntQuanlyphong.Buttons[0].Properties.Visible = false;
            wbntQuanlyphong.Buttons[1].Properties.Visible = false;
            wbntQuanlyphong.Buttons[2].Properties.Visible = false;
            wbntQuanlyphong.Buttons[4].Properties.Visible = false;

            this.tabbedControlGroup1.Clear();
            foreach (ThuePhongDTO thuePhong in HoaDonBUS.LayTatCaCacThuePhong(hoaDon.MaHoaDon))
            {

                ChiTietThanhToanPhong chiTietThanhToanPhongThanhToan = new ChiTietThanhToanPhong();
                DevExpress.XtraLayout.LayoutControlGroup layoutGrp = new DevExpress.XtraLayout.LayoutControlGroup();
                DevExpress.XtraLayout.LayoutControlItem layoutItem = new DevExpress.XtraLayout.LayoutControlItem();
                chiTietThanhToanPhongThanhToan.CalcTongTienAction = CalcTongTien_UpdateHoaDon;
                chiTietThanhToanPhongThanhToan.AddButtonXoaDichVu((WindowsUIButton)wbntQuanlyphong.Buttons[1]);


                chiTietThanhToanPhongThanhToan.RefreshDataBinding_ReadOnly(thuePhong);
                chiTietThanhToanPhongThanhToan.GetTongTienGio();
                //thongTinChiTietPhong.SetActionThanhToanButton(goToThanhToan);
                //DevExpress.XtraTab.XtraTabPage xtraTab = new DevExpress.XtraTab.XtraTabPage();

                // 
                // chiTietThanhToanPhongThanhToan
                // 
                chiTietThanhToanPhongThanhToan.Location = new System.Drawing.Point(37, 187);
                chiTietThanhToanPhongThanhToan.Name = "chiTietThanhToanPhong1";
                chiTietThanhToanPhongThanhToan.Size = new System.Drawing.Size(867, 414);
                chiTietThanhToanPhongThanhToan.TabIndex = 25;
                // 
                // layoutItem
                // 
                layoutItem.Control = chiTietThanhToanPhongThanhToan;
                layoutItem.Location = new System.Drawing.Point(0, 0);
                layoutItem.Name = "layoutControlItem8";
                layoutItem.Size = new System.Drawing.Size(873, 420);
                layoutItem.TextSize = new System.Drawing.Size(0, 0);
                layoutItem.TextVisible = false;
                // 
                // layoutGrp
                // 
                layoutGrp.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutItem });
                layoutGrp.Location = new System.Drawing.Point(0, 0);
                layoutGrp.Name = "layoutControlGroup2";
                layoutGrp.OptionsItemText.TextToControlDistance = 4;
                layoutGrp.Size = new System.Drawing.Size(873, 420);
                layoutGrp.Text = PhongBUS.LayThongTinPhong(thuePhong.MaPhong).TenPhong;
                layoutGrp.Tag = chiTietThanhToanPhongThanhToan;


                this.tabbedControlGroup1.AddTabPage(layoutGrp);

            }
            this.tabbedControlGroup1.SelectedTabPageIndex = 0;

            CalcTongTien_UpdateHoaDon();
        }

        DataSet dsDichVuPhong;
        public void CalcTongTien_UpdateHoaDon()
        {
            double TongTienGio = 0, TongTienKhuyenMai = 0, TongTienDichVu = 0;
            dsDichVuPhong = new DataSet();

            foreach (DevExpress.XtraLayout.LayoutControlGroup layoutGroup in this.tabbedControlGroup1.TabPages)
            {
                TongTienGio += ((ChiTietThanhToanPhong)layoutGroup.Tag).GetTongTienGio();
                TongTienKhuyenMai+=((ChiTietThanhToanPhong)layoutGroup.Tag).GetTongTienKhuyenMai();
                TongTienDichVu+=((ChiTietThanhToanPhong)layoutGroup.Tag).GetTongTienDichVu();

                dsDichVuPhong.Tables.Add(((ChiTietThanhToanPhong)layoutGroup.Tag).GetDichVuPhong_DataTable());


            }

            DataTable MergedDataTable = new DataTable();
            for (int i =0; i < dsDichVuPhong.Tables.Count;i++)
            {
                MergedDataTable.Merge(dsDichVuPhong.Tables[i]);
            }

            txtTongTienGio.EditValue = TongTienGio;
            txtTongTienKhuyenMai.EditValue = TongTienKhuyenMai;
            txtTongTienDichVu.EditValue = TongTienDichVu;
            txtTongTienThanhToan.EditValue = TongTienGio + TongTienKhuyenMai + TongTienDichVu - Convert.ToDouble(txtTienTraTruoc.EditValue);


        }

       

        private void wbntQuanlyphong_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch(e.Button.Properties.Tag.ToString())
            {
                case "Thêm Dịch Vụ":
                    ((ChiTietThanhToanPhong)tabbedControlGroup1.SelectedTabPage.Tag).ThemDichVu();
                    break;
                case "Xóa Dịch Vụ":
                    ((ChiTietThanhToanPhong)tabbedControlGroup1.SelectedTabPage.Tag).XoaDichVu();
                    break;

                case "Thanh toán":
                    //Nhân viên
                    //BÌNH
                    hoaDon.MaNhanVienThanhToan = 0;
                    hoaDon.TongTienThanhToan = (double)txtTongTienThanhToan.EditValue;
                    hoaDon.NgayThanhToan = txtNgayThanhToan.Time;
                    hoaDon.SoTienKhuyenMai = (double)txtTongTienKhuyenMai.EditValue;
                    //hoaDon.TienGio = (double)txtTongTienGio.EditValue;

                    HoaDonBUS.CapNhatHoaDonDaThanhToan(hoaDon);
                    foreach (DevExpress.XtraLayout.LayoutControlGroup layoutGroup in this.tabbedControlGroup1.TabPages)
                    {
                        ((ChiTietThanhToanPhong)layoutGroup.Tag).LuuKhuyenMai();
                        ((ChiTietThanhToanPhong)layoutGroup.Tag).CapNhatThongTinThuePhong();
                        PhongBUS.CapNhatTinhTrangPhong(((ChiTietThanhToanPhong)layoutGroup.Tag).thuePhong.MaPhong,0);
                    }

                    if(khachHang.MaLoaiKH != 0)
                    {
                        KhachHangBUS.CapNhatDiemTichLuy(khachHang.MaKH, khachHang.DiemTichLuy + ThamSoBUS.QuyDoiDiem((double)txtTongTienThanhToan.EditValue));
                        khachHang.DiemTichLuy = khachHang.DiemTichLuy + ThamSoBUS.QuyDoiDiem((double)txtTongTienThanhToan.EditValue);

                        LoaiKhachHangDTO loaiKhachHangCoThe = KhachHangBUS.LayLoaiKhachHangCoTheDatDuoc(khachHang);
                        if (khachHang.MaLoaiKH != loaiKhachHangCoThe.MaLoaiKH)
                        {
                            KhachHangBUS.CapNhatLoaiKhachHang(khachHang.MaKH, loaiKhachHangCoThe.MaLoaiKH);
                            XtraMessageBox.Show("Khách hàng được cập nhật lên loại '" + loaiKhachHangCoThe.TenLoaiKH + "'! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    

                    goBackHome();

                    break;
            }
        }

        private void windowsUIButtonPanel2_Click(object sender, EventArgs e)
        {
            goBackHome();
        }

        private void txtTienTraTruoc_EditValueChanged(object sender, EventArgs e)
        {
            
            HoaDonBUS.CapNhatTienTraTruoc(hoaDon, Convert.ToDouble(txtTienTraTruoc.EditValue));
            CalcTongTien_UpdateHoaDon();
        }
    }


}

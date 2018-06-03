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
        private PhongDTO phong;
        private KhachHangDTO khachHang;
        private HoaDonDTO hoaDon;
        private ThuePhongDTO thuePhong;

        public Action goBackHome { get; set; }

       

        public ThanhToan()
        {
            InitializeComponent();

            //snapControl.DataSource = PhongBUS.LayTatCaPhong_TinhTrangPhong_LoaiPhong();
            //snapControl.LoadDocument("C:\\Users\\Public\\Documents\\DevExpress Demos 17.1\\Components\\WinForms\\DevExpress.HybridApp.Win\\CS\\DevExpress.HybridApp.Win\\Resources\\MailMerge\\1.snx", DevExpress.Snap.Core.API.SnapDocumentFormat.Snap);
            //snapControl.ReadOnly = true;

            //snapControl.Document.DataSource = ds;
        }
        public void RefreshDataBinding(ThuePhongDTO thuePhongDTO)
        {
            this.hoaDon = BUS.HoaDonBUS.LayThongTinHoaDonDangThue(thuePhongDTO.MaHoaDon);
            this.thuePhong = thuePhongDTO;
            this.khachHang = BUS.KhachHangBUS.LayKhachHang(hoaDon.MaKH);

            txtMaHoaDon.Text = hoaDon.MaHoaDon.ToString();
            txtNgayThanhToan.Time = DateTime.Now;
            txtTienTraTruoc.EditValue = hoaDon.TienTraTruoc;
            
           

            this.tabbedControlGroup1.Clear();
            foreach (ThuePhongDTO thuePhong in HoaDonBUS.LayTatCaCacThuePhong(hoaDon.MaHoaDon))
            {             

                ChiTietThanhToanPhong chiTietThanhToanPhongThanhToan = new ChiTietThanhToanPhong();
                DevExpress.XtraLayout.LayoutControlGroup layoutGrp = new DevExpress.XtraLayout.LayoutControlGroup();
                DevExpress.XtraLayout.LayoutControlItem layoutItem = new DevExpress.XtraLayout.LayoutControlItem();
                chiTietThanhToanPhongThanhToan.CalcTongTienAction = CalcTongTien;
                chiTietThanhToanPhongThanhToan.AddButtonXoaDichVu((WindowsUIButton)wbntQuanlyphong.Buttons[1]);


                chiTietThanhToanPhongThanhToan.RefreshDataBinding(thuePhong);
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

            CalcTongTien();
        }

        public void RefreshDataBinding_ReadOnly(HoaDonDTO hoaDonDTO)
        {
            this.hoaDon = hoaDonDTO;       
            this.khachHang = BUS.KhachHangBUS.LayKhachHang(hoaDon.MaKH);

            txtMaHoaDon.Text = hoaDon.MaHoaDon.ToString();
            txtNgayThanhToan.Time = DateTime.Now;
            txtTienTraTruoc.EditValue = hoaDon.TienTraTruoc;

            this.tabbedControlGroup1.Clear();
            foreach (ThuePhongDTO thuePhong in HoaDonBUS.LayTatCaCacThuePhong(hoaDon.MaHoaDon))
            {

                ChiTietThanhToanPhong chiTietThanhToanPhongThanhToan = new ChiTietThanhToanPhong();
                DevExpress.XtraLayout.LayoutControlGroup layoutGrp = new DevExpress.XtraLayout.LayoutControlGroup();
                DevExpress.XtraLayout.LayoutControlItem layoutItem = new DevExpress.XtraLayout.LayoutControlItem();
                chiTietThanhToanPhongThanhToan.CalcTongTienAction = CalcTongTien;
                chiTietThanhToanPhongThanhToan.AddButtonXoaDichVu((WindowsUIButton)wbntQuanlyphong.Buttons[1]);


                chiTietThanhToanPhongThanhToan.RefreshDataBinding(thuePhong);
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

            CalcTongTien();
        }

        public void CalcTongTien()
        {
            double TongTienGio = 0, TongTienKhuyenMai = 0, TongTienDichVu = 0;
           
            foreach (DevExpress.XtraLayout.LayoutControlGroup layoutGroup in this.tabbedControlGroup1.TabPages)
            {
                TongTienGio += ((ChiTietThanhToanPhong)layoutGroup.Tag).GetTongTienGio();
                TongTienKhuyenMai+=((ChiTietThanhToanPhong)layoutGroup.Tag).GetTongTienKhuyenMai();
                TongTienDichVu+=((ChiTietThanhToanPhong)layoutGroup.Tag).GetTongTienDichVu();
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

                case "Thanh toán":
                    //Nhân viên
                    //BÌNH
                    hoaDon.MaNhanVienThanhToan = 0;
                    hoaDon.TongTienThanhToan = (double)txtTongTienThanhToan.EditValue;
                    hoaDon.NgayThanhToan = txtNgayThanhToan.Time;
                    hoaDon.SoTienKhuyenMai = (double)txtTongTienKhuyenMai.EditValue;

                    HoaDonBUS.CapNhatHoaDonDaThanhToan(hoaDon);
                    foreach (DevExpress.XtraLayout.LayoutControlGroup layoutGroup in this.tabbedControlGroup1.TabPages)
                    {
                        ((ChiTietThanhToanPhong)layoutGroup.Tag).LuuKhuyenMai();
                        PhongBUS.CapNhatTinhTrangPhong(((ChiTietThanhToanPhong)layoutGroup.Tag).thuePhong.MaPhong,0);
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
            CalcTongTien();
        }
    }


}

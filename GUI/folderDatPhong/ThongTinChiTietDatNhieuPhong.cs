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
using DevExpress.XtraTab;
using DevExpress.Office.Utils;

namespace GUI.folderDatPhong
{
    public partial class ThongTinChiTietDatNhieuPhong : XtraUserControl
    {
        public Action goToHome { get; set; }
        DatPhongDTO datPhong;
        KhachHangDTO khachHang;

        List<TinhTrangDatPhongDTO> listTinhTrangDatPhong;
        public ThongTinChiTietDatNhieuPhong()
        {
            InitializeComponent();
        }

        public void RefreshDataBinding(int maDatPhong)
        {
            //Lấy tất cả tinh trang phong vào cmb
            listTinhTrangDatPhong = DatPhongBUS.LayTatCaTinhTrangDatPhong_List();
            //combobox tinh trang phong
            txtTinhTrangDat.Properties.Items.Clear();
           
                foreach (TinhTrangDatPhongDTO tinhtrang in listTinhTrangDatPhong)
                {

                txtTinhTrangDat.Properties.Items.Add(new MyComboBoxItem(tinhtrang.TinhTrangDatPhong, tinhtrang.MaTinhDatTrangPhong));
                 
                }
                

            this.datPhong = DatPhongBUS.LayThongTinDatPhong(maDatPhong);
            txtMaDatPhong.EditValue = maDatPhong;
            txtTienTraTruoc.EditValue = datPhong.SoTienDatTruoc;
            txtThoiGian.EditValue = datPhong.ThoiGianDatPhong;
            txtGhiChu.EditValue =datPhong.GhiChu;
            dateNgayLapPhieu.DateTime = datPhong.NgayLapPhieuDat;
            txtTinhTrangDat.EditValue=   DatPhongBUS.LayTinhTrangPhong(datPhong.MaTinhTrangDatPhong).TinhTrangDatPhong;

            khachHang = KhachHangBUS.LayKhachHang(datPhong.MaKH);
            txtMaKH.EditValue = khachHang.MaKH;
            txtLoaiKH.EditValue = LoaiKhachHangBUS.LayLoaiKhachHang(khachHang.MaLoaiKH).TenLoaiKH;
            txtEmail.EditValue = khachHang.Email;
            txtSDT.EditValue = khachHang.SDT;
            txtTenKH.EditValue = khachHang.TenKH;
            txtDiaChi.EditValue = khachHang.DiaChi;
            txtNgaySinh.EditValue = khachHang.NgaySinh;
            
            txtTenNhanVien.EditValue = NhanVienBUS.LayNhanVien(datPhong.MaNhanVien).TenNhanVien;

            this.TabControl.TabPages.Clear();
            foreach (ChiTietDatPhongDTO chiTiet in DatPhongBUS.LayTatCaCacChiTietDatPhong(datPhong.MaDatPhong))
            {
                ThongTinChiTietDatPhong thongTinChiTietDatPhong = new ThongTinChiTietDatPhong(datPhong);
                thongTinChiTietDatPhong.RefreshDataBinding(chiTiet);
                DevExpress.XtraTab.XtraTabPage xtraTab = new DevExpress.XtraTab.XtraTabPage();

                // 
                // thongTinChiTietPhong1
                // 
                thongTinChiTietDatPhong.Appearance.BackColor = System.Drawing.Color.White;
                thongTinChiTietDatPhong.Appearance.Options.UseBackColor = true;
                thongTinChiTietDatPhong.Dock = System.Windows.Forms.DockStyle.Fill;
                thongTinChiTietDatPhong.Location = new System.Drawing.Point(0, 0);
                thongTinChiTietDatPhong.Name = "thongTinChiTietPhong1";
                thongTinChiTietDatPhong.Size = new System.Drawing.Size(989, 591);
                thongTinChiTietDatPhong.TabIndex = 0;

                // 
                // tab1
                // 
                xtraTab.Controls.Add(thongTinChiTietDatPhong);
                xtraTab.Name = thongTinChiTietDatPhong.phong.MaPhong.ToString();
                xtraTab.Size = new System.Drawing.Size(989, 591);
                xtraTab.Text = thongTinChiTietDatPhong.phong.TenPhong;
                xtraTab.Tag = thongTinChiTietDatPhong;
                // 
                this.TabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTab });
            }

            if(datPhong.MaTinhTrangDatPhong == 3)
            {
                txtTienTraTruoc.ReadOnly = true;
                txtGhiChu.ReadOnly = true;
            }
        }

        private void wbntBackThemKH_Click(object sender, EventArgs e)
        {
            goToHome();
        }

        private void btnThayDoiKhachHang_Click(object sender, EventArgs e)
        {
            folderKhachHang.ChonKhachHang chonKhachHang = new folderKhachHang.ChonKhachHang(false);
            XtraDialogArgs args = new XtraDialogArgs(caption: "Caption", content: chonKhachHang, buttons: new DialogResult[] { DialogResult.OK, DialogResult.Cancel });
            args.Showing += Args_Showing_ChonKH;
            args.Caption = "Default Text";
            args.Buttons = new DialogResult[] { DialogResult.OK, DialogResult.Cancel };


            switch (XtraDialog.Show(args))
            {
                case DialogResult.OK:
                    khachHang = chonKhachHang.LayKhachHangDaChon();

       
                    txtMaKH.EditValue = khachHang.MaKH;
                    txtLoaiKH.EditValue = LoaiKhachHangBUS.LayLoaiKhachHang(khachHang.MaLoaiKH).TenLoaiKH;
                    txtEmail.EditValue = khachHang.Email;
                    txtSDT.EditValue = khachHang.SDT;
                    txtTenKH.EditValue = khachHang.TenKH;
                    txtDiaChi.EditValue = khachHang.DiaChi;
                    txtNgaySinh.EditValue = khachHang.NgaySinh;

                    DatPhongBUS.UpdateKhachHang(datPhong.MaDatPhong, khachHang.MaKH);
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

        internal void RefreshData()
        {
            if (DatPhongBUS.DemSoLuongChiTietDatPhong(datPhong.MaDatPhong) == 0)
            {
                goToHome();
                return;
            }
                

            this.RefreshDataBinding(datPhong.MaDatPhong);

           
        }
        public void NhanPhong()
        {
            foreach (ChiTietDatPhongDTO chiTiet in DatPhongBUS.LayTatCaCacChiTietDatPhong(datPhong.MaDatPhong))
            {
                PhongDTO phongDto =PhongBUS.LayThongTinPhong(chiTiet.MaPhong);
                if (phongDto.MaTinhTrangPhong == 1 || phongDto.MaTinhTrangPhong == 7)
                {
                    XtraMessageBox.Show("Phòng " + phongDto.TenPhong + " đang được sử dụng nên không thể nhận được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                   
                }
                else if (phongDto.MaTinhTrangPhong == 5 || phongDto.MaTinhTrangPhong == 6)
                {
                    XtraMessageBox.Show("Phòng " + phongDto.TenPhong + " đang chờ dọn dẹp! Hãy dọn dẹp trước khi nhận phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
                else if (phongDto.MaTinhTrangPhong == 2)
                {
                    XtraMessageBox.Show("Phòng " + phongDto.TenPhong + " đang sửa chữa! Vui lòng chuyển đặt phòng sang phòng khác hoặc chuyển tình trạng phòng sang bình thường!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
                else if (phongDto.MaTinhTrangPhong == 3)
                {
                    XtraMessageBox.Show("Phòng " + phongDto.TenPhong + " đã bị xóa, không thể nhận phòng! Vui lòng chuyển đặt phòng sang phòng khác! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
            }
           
            //Phát sinh hóa đơn

            HoaDonDTO hoaDon = new HoaDonDTO(HoaDonBUS.PhatSinhMaHoaDon(), (this.ParentForm as MainForm).nhanVien.MaNhanVien, Double.NaN, datPhong.SoTienDatTruoc, DateTime.MinValue, Double.NaN, datPhong.GhiChu, khachHang.MaKH, datPhong.MaDatPhong);
            HoaDonBUS.LuuThongTinHoaDon(hoaDon);

            ThuePhongDTO tp = null;
            

            
            foreach (XtraTabPage xtraTab in this.TabControl.TabPages)
            {
                tp = new ThuePhongDTO(ThuePhongBUS.PhatSinhMaThuePhong(), (xtraTab.Tag as ThongTinChiTietDatPhong).chiTietDatPhong.MaPhong, DateTime.Now, DateTime.MinValue, hoaDon.MaHoaDon, double.NaN);
                ThuePhongBUS.LuuThongTinThuePhong(tp);
                PhongBUS.CapNhatTinhTrangPhong((xtraTab.Tag as ThongTinChiTietDatPhong).chiTietDatPhong.MaPhong, 1);


                (xtraTab.Tag as ThongTinChiTietDatPhong).LuuThongTinDichVuPhong(tp);
            }

            DatPhongBUS.CapNhatTinhTrangDatPhong(2, datPhong.MaDatPhong);
            (this.ParentForm as MainForm).HienThiThongTinPhong(tp);
        }

        private void txtTinhTrangDat_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatPhongBUS.CapNhatTinhTrangDatPhong((int)(txtTinhTrangDat.SelectedItem as MyComboBoxItem).Tag, datPhong.MaDatPhong);
            RefreshData();
        }

        private PhieuDatPhong reportPhieudatphong;
        public void InPhieuDat()
        {
            reportPhieudatphong = new PhieuDatPhong();
            reportPhieudatphong.BindingData(  datPhong,  khachHang);

            XtraDialogArgs phieudatphong = new XtraDialogArgs(caption: "Phiếu đặt phòng", content: new ReportViewer(reportPhieudatphong), buttons: new DialogResult[] { DialogResult.OK });
            XtraDialog.Show(phieudatphong);
        }

        private void txtTienTraTruoc_EditValueChanged(object sender, EventArgs e)
        {
            DatPhongBUS.CapNhatTienTraTruocDatPhong((double)txtTienTraTruoc.Value, datPhong.MaDatPhong);
        }

        private void txtGhiChu_EditValueChanged(object sender, EventArgs e)
        {
            DatPhongBUS.CapNhatGhiChuDatPhong((double)txtTienTraTruoc.Value, datPhong.MaDatPhong);
        }
    }
}

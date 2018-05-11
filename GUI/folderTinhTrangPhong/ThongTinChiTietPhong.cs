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
using DevExpress.XtraScheduler;
using DTO;

namespace GUI.folderTinhTrangPhong
{
    public partial class ThongTinChiTietPhong : DevExpress.XtraEditors.XtraUserControl
    {
        private PhongDTO phong;
        private KhachHangDTO khachHang;
        private ThuePhongDTO thuePhong;

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
        public void RefreshDataBinding(PhongDTO phongDTO)
        {
            txtMaPhong.EditValue = phongDTO.MaPhong;
            txtTenPhong.EditValue = phongDTO.MaPhong;
            txtLoaiPhong.EditValue = BUS.LoaiPhongBUS.LayLoaiPhong(phongDTO).TenLoaiPhong;
            txtTang.EditValue = phongDTO.Tang;

            Dictionary<int, ThuePhongDTO> listPhongDangThue = BUS.ThuePhongBUS.LayThongTinCacPhongDangDuocThue();
            if (listPhongDangThue.ContainsKey(phongDTO.MaPhong))
            {
                DisplayControlForRented(true);

                thuePhong = listPhongDangThue[phongDTO.MaPhong];
                khachHang = BUS.KhachHangBUS.LayKhachHang(thuePhong.MaKH);

                txtMaKH.EditValue = khachHang.MaKH;
                txtTenKH.EditValue = khachHang.TenKH;
                txtLoaiKH.EditValue = BUS.LoaiKhachHangBUS.LayLoaiKhachHang(khachHang).TenKH;
                txtSDT.EditValue = khachHang.SDT;
                txtDiemTichLuy.EditValue = khachHang.DiemTichLuy;
            }
            else
            {
                DisplayControlForRented(false);
            }
        }

        private void DisplayControlForRented(bool dangDuocThue)
        {
            if(dangDuocThue)
                grpKhachHang.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            else
                grpKhachHang.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }
    }
}

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
using DTO;
using BUS;

namespace GUI.folderKhachHang
{
    public partial class SuaKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        public Action actionBack { get; set; }
        KhachHangDTO khachHangDTO;
        List<LoaiKhachHangDTO> listLoaiKH;
        public SuaKhachHang()
        {
            InitializeComponent();
        }
        public void RefreshDataBinding(int maKH)
        {
            try
            {
                khachHangDTO = KhachHangBUS.LayKhachHang(maKH);



                //Lấy tất cả loại phòng vào cmb
                listLoaiKH = LoaiKhachHangBUS.LayTatCaLoaiKhachHang_List();
                //Nếu không có loại phòng, thông báo cần tạo loại phòng trước
                if (listLoaiKH.Count == 0)
                {
                    //BÌNH
                }

                cmbLoaiKH.Properties.Items.Clear();
                foreach (LoaiKhachHangDTO loaiKH in listLoaiKH)
                {
                    cmbLoaiKH.Properties.Items.Add(new MyComboBoxItem(loaiKH.TenKH, loaiKH.MaLoaiKH));
                    if (loaiKH.MaLoaiKH == khachHangDTO.MaLoaiKH)
                        cmbLoaiKH.SelectedIndex = cmbLoaiKH.Properties.Items.Count - 1;
                }


                txtMaKH.EditValue = khachHangDTO.MaKH.ToString();
                txtTenKH.EditValue = khachHangDTO.TenKH;
                txtCMND.EditValue = khachHangDTO.CMND;
                txtDiaChi.EditValue = khachHangDTO.DiaChi;
                txtSDT.EditValue = khachHangDTO.SDT.ToString();
                txtDiemtichluy.EditValue = khachHangDTO.DiemTichLuy;

               // pictureEdit1.Image = khachHangDTO.HinhAnh;


                ValidateChildren();





            }
            catch (Exception x)
            {

            }
        }

        private void wbntSuakhachhang_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Tag.ToString())
            {
                //case "Lưu":
                //    //Kiểm tra thông tin hợp lệ
                //    if (txtTenKH.Text == "")
                //        return;

                //    //Lưu thông tinh
                //    if (DichVuBUS.CapNhatThongTinDichVu(new DichVuDTO(Convert.ToInt32(txtMaDV.Text), txtTenDV.Text, Convert.ToDouble(txtDonGia.EditValue), txtDonVi.Text, (pictureEdit1.Image), listLoaiDichVu[cmbLoaiDV.SelectedIndex].MaLoaiDV)))
                //    {
                //        //Thông báo thành công
                //        //BÌNH


                //        actionBack();
                //    }
                //    else
                //    {
                //        //Thông báo thất bại
                //        //BÌNH
                //    }
                //    break;
                case "Hủy":
                    if (ThongBaoHuyKoLuuDichVu())
                        actionBack();
                    break;
                default:
                    break;
            }
        }
        bool ThongBaoHuyKoLuuDichVu()
        {
            return true;
        }
    }
}

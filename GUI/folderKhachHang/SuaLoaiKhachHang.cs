using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using DevExpress.XtraEditors;

namespace GUI.folderKhachHang
{
    public partial class SuaLoaiKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        LoaiKhachHangDTO loaiKhachHangDTO;

        public Action actionBack { get; set; }

        public SuaLoaiKhachHang()
        {
            InitializeComponent();
        }
        public void RefreshDataBinding(int maLoaiKH)
        {
            this.loaiKhachHangDTO = LoaiKhachHangBUS.LayLoaiKhachHang(maLoaiKH);

            txtMaLoaiKhachHang.EditValue = loaiKhachHangDTO.MaLoaiKH;
            txtTenLoaiKhachHang.Text = loaiKhachHangDTO.TenLoaiKH;
            txtSoDiemDeDatDuoc.EditValue = loaiKhachHangDTO.SoDiemDeDatDuoc;
            txtPhanTramGiamGia.EditValue = loaiKhachHangDTO.PhanTramGiamGia;
            txtSoTienGiamGia_Min.EditValue = loaiKhachHangDTO.SoTienGiamGia_Min;
            txtSoTienGiamGia_Max.EditValue = loaiKhachHangDTO.SoTienGiamGia_Max;
            txtPhanTramGiamGiaSinhNhat.EditValue = loaiKhachHangDTO.PhanTramGiamGiaSinhNhat;
            txtSoTienGiamGiaSinhNhat_Min.EditValue = loaiKhachHangDTO.SoTienGiamGiaSinhNhat_Min;
            txtSoTienGiamGiaSinhNhat_Max.EditValue = loaiKhachHangDTO.SoTienGiamGiaSinhNhat_Max;

            ValidateChildren();
        }

        private void wbntThemloaikhachhang_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Tag.ToString())
            {
                case "Thêm":
                    //Lưu thông tin
                    if (LoaiKhachHangBUS.CapNhatThongTinLoaiKhachHang(new DTO.LoaiKhachHangDTO(loaiKhachHangDTO.MaLoaiKH, txtTenLoaiKhachHang.Text, Convert.ToInt32(txtSoDiemDeDatDuoc.EditValue), Convert.ToDouble(txtPhanTramGiamGia.EditValue), Convert.ToDouble(txtSoTienGiamGia_Min.EditValue), Convert.ToDouble(txtSoTienGiamGia_Max.EditValue), Convert.ToDouble(txtPhanTramGiamGiaSinhNhat.EditValue), Convert.ToDouble(txtSoTienGiamGiaSinhNhat_Min.EditValue), Convert.ToDouble(txtSoTienGiamGiaSinhNhat_Max.EditValue))))
                    {
                        //Thông báo thành công
                        //BÌNH
                        XtraMessageBox.Show("Sửa loại khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        actionBack();
                    }
                    else
                    {
                        //Thông báo thất bại
                        //BÌNH
                        XtraMessageBox.Show("Sửa loại khách hàng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "Hủy":
                    if (ThongBaoHuyKoLuuLoaiKH())
                        actionBack();
                    break;
                default:
                    break;
            }

        }

        private bool ThongBaoHuyKoLuuLoaiKH()
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn thoát khỏi màn hình này (Mọi thông tin không được lưu sẽ bị mất) ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                return true;
            else
                return false;
        }

        private void txtTenLoaiKhachHang_Properties_Validating(object sender, CancelEventArgs e)
        {
            if ((sender as TextEdit).Text == "")
            {
                txtTenLoaiKhachHang.ErrorText = "Tên loại khách hàng không được để trống";
                windowsUIButtonPanel1.Buttons[0].Properties.Visible = false;
            }
            else
            {
                txtTenLoaiKhachHang.ErrorText = "";
                windowsUIButtonPanel1.Buttons[0].Properties.Visible = true;
            }
        }
        private void txtTenLoaiKhachHang_EditValueChanged(object sender, EventArgs e)
        {
            ValidateChildren();
        }

        private void windowsUIButtonPanel4_Click(object sender, EventArgs e)
        {
            if (ThongBaoHuyKoLuuLoaiKH())
                actionBack();
        }
    }
}

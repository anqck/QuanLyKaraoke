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

namespace GUI.folderKhachHang
{
    public partial class ThemLoaiKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        public Action actionBack { get; set; }

        public ThemLoaiKhachHang()
        {
            InitializeComponent();

            
        }

        public void RefreshDataBinding()
        {
            txtMaLoaiKhachHang.EditValue = LoaiKhachHangBUS.PhatSinhLoaiKhachHang();

            txtTenLoaiKhachHang.Text = "";

            ValidateChildren();

        }
        private void wbntThemloaikhachhang_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Tag.ToString())
            {
                case "Thêm":
                    //Lưu thông tin
                    if (LoaiKhachHangBUS.LuuThongTinLoaiKhachHang(new DTO.LoaiKhachHangDTO(LoaiKhachHangBUS.PhatSinhLoaiKhachHang(), txtTenLoaiKhachHang.Text, Convert.ToInt32(txtSoDiemDeDatDuoc.EditValue), Convert.ToDouble(txtPhanTramGiamGia.EditValue), Convert.ToDouble(txtSoTienGiamGia_Min.EditValue), Convert.ToDouble(txtSoTienGiamGia_Max.EditValue), Convert.ToDouble(txtPhanTramGiamGiaSinhNhat.EditValue), Convert.ToDouble(txtSoTienGiamGiaSinhNhat_Min.EditValue), Convert.ToDouble(txtSoTienGiamGiaSinhNhat_Max.EditValue))))
                    {
                        //Thông báo thành công
                    
                        XtraMessageBox.Show("Thêm loại khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        actionBack();
                    }
                    else
                    {
                        //Thông báo thất bại
                      
                        XtraMessageBox.Show("Thêm loại khách hàng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        bool ThongBaoHuyKoLuuLoaiKH()
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

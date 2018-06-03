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
                    XtraMessageBox.Show("Cần thêm loại khách hàng trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                case "Lưu":
                    //Kiểm tra thông tin hợp lệ
                    if (txtTenKH.Text == "")
                        return;

                    //Lưu thông tinh
                    if (KhachHangBUS.CapNhatThongTinKhachHang(new KhachHangDTO(Convert.ToInt32(txtMaKH.Text), txtTenKH.Text, txtCMND.Text, txtSDT.Text, txtDiaChi.Text, listLoaiKH[cmbLoaiKH.SelectedIndex].MaLoaiKH, Convert.ToInt32(txtDiemtichluy.EditValue) )))
                    {
                        //Thông báo thành công
                        XtraMessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        actionBack();
                    }
                    else
                    {
                        //Thông báo thất bại
                        XtraMessageBox.Show("Cập nhật khách hàng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "Hủy":
                    if (ThongBaoHuyCapNhatKhachHang())
                        actionBack();
                    break;
                default:
                    break;
            }
        }
        bool ThongBaoHuyCapNhatKhachHang()
        {
            if (XtraMessageBox.Show("Bạn có chắc hủy cập nhật khách hàng ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                return true;
            }
            return false;
        }

        private void txtTenKH_Validating(object sender, CancelEventArgs e)
        {
            if ((sender as TextEdit).Text == "")
            {
                txtTenKH.ErrorText = "Tên khách hàng không được để trống";
                wbntSuakhachhang.Buttons[0].Properties.Enabled = false;
            }
            else
            {
                txtTenKH.ErrorText = null;
                if (KiemTraHopLeCacGiaTriNhapVao())
                    wbntSuakhachhang.Buttons[0].Properties.Enabled = true;
            }
        }

        private bool KiemTraHopLeCacGiaTriNhapVao()
        {
            if (txtTenKH.Text == "")
            {
                return false;
            }
            //if (txxtSDT.Text == "")
            //{
            //    return false;
            //}

            return true;
        }

        private void txtTenKH_EditValueChanged(object sender, EventArgs e)
        {
            txtTenKH_Validating(sender, new CancelEventArgs());
        }

        private void wbntBackThemKH_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (ThongBaoHuyCapNhatKhachHang())
                actionBack();
        }
    }
}

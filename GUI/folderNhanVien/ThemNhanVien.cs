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

namespace GUI.folderNhanVien
{
    public partial class ThemNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        public Action actionBack { get; set; }
        List<LoaiTaiKhoanDTO> listLoaiTaiKhoan;
        public ThemNhanVien()
        {
            InitializeComponent();

        }
        internal void Initialize()
        {


            //Phát sinh mã loại phòng
            txtMaNhanVien.Text = BUS.NhanVienBUS.PhatSinhMaNhanVien().ToString();


            //Lấy tất cả loại phòng vào cmb
            listLoaiTaiKhoan = NhanVienBUS.LayTatCaLoaiTaiKhoan_List();


            //Nếu không có loại phòng, thông báo cần tạo loại phòng trước
            if (listLoaiTaiKhoan.Count == 0)
            {
                XtraMessageBox.Show("Cần thêm loại tài khoản trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            cmbLoaiTaiKhoan.Properties.Items.Clear();
            foreach (LoaiTaiKhoanDTO loaiTaiKhoang in listLoaiTaiKhoan)
            {
                cmbLoaiTaiKhoan.Properties.Items.Add(new MyComboBoxItem(loaiTaiKhoang.TenLoaiTaiKhoan, loaiTaiKhoang.MaLoaiTaiKhoan));
            }
            cmbLoaiTaiKhoan.SelectedIndex = 0;

            txtTenNhanVien.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            pictureEdit1.Image = (Image)GUI.Properties.Resources.ResourceManager.GetObject("No_Image_Available");
            ValidateChildren();
        }

        private void wbntThemdichvu_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Tag.ToString())
            {
                case "Thêm":
                    //Kiểm tra thông tin hợp lệ
                    if (txtTenNhanVien.Text == "")
                        return;

                    if (txtTenDangNhap.Text == "")
                        return;
                    if (txtMatKhau.Text == "")
                        return;


                    //Lưu thông tinh
                    if (NhanVienBUS.LuuThongTinNhanVien(new NhanVienDTO(Convert.ToInt32(txtMaNhanVien.Text), txtTenNhanVien.Text,txtDiaChi.Text, txtSDT.Text,txtTenDangNhap.Text,txtMatKhau.Text, listLoaiTaiKhoan[cmbLoaiTaiKhoan.SelectedIndex].MaLoaiTaiKhoan, resizeImage(pictureEdit1.Image))))
                    {
                        //Thông báo thành công
                        //BÌNH
                        XtraMessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        actionBack();
                    }
                    else
                    {
                        //Thông báo thất bại
                        //BÌNH
                        XtraMessageBox.Show("Thêm nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "Hủy":
                    if (ThongBaoHuyKoLuuDichVu())
                        actionBack();
                    break;
                default:
                    break;
            }
        }
        private bool ThongBaoHuyKoLuuDichVu()
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn thoát khỏi màn hình này (Mọi thông tin không được lưu sẽ bị mất) ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                return true;
            else
                return false;
        }
        public Image resizeImage(Image img, int width = 500, int height = 500)
        {
            Bitmap b = new Bitmap(width, height);
            Graphics g = Graphics.FromImage((Image)b);

            g.DrawImage(img, 0, 0, width, height);
            g.Dispose();

            return (Image)b;
        }
        bool KiemTraHopLeCacGiaTriNhapVao()
        {
            if (txtTenDangNhap.Text == "")
            {
                return false;
            }
            if (txtTenNhanVien.Text == "")
            {
                return false;
            }
            if (txtMatKhau.Text == "")
            {
                return false;
            }
            return true;
        }

        private void txtTenNhanVien_Validating(object sender, CancelEventArgs e)
        {
            if ((sender as TextEdit).Text == "")
            {
                txtTenNhanVien.ErrorText = "Tên nhân viên không được để trống";
                wbntThemnhanvien.Buttons[0].Properties.Enabled = false;
            }
            else
            {
                if (KiemTraHopLeCacGiaTriNhapVao())
                    wbntThemnhanvien.Buttons[0].Properties.Enabled = true;
            }
        }

        private void txtTenDangNhap_Validating(object sender, CancelEventArgs e)
        {
            if ((sender as TextEdit).Text == "")
            {
                txtTenDangNhap.ErrorText = "Tên đăng nhập không được để trống";
                wbntThemnhanvien.Buttons[0].Properties.Enabled = false;
            }
            else
            {
                if (KiemTraHopLeCacGiaTriNhapVao())
                    wbntThemnhanvien.Buttons[0].Properties.Enabled = true;
            }
        }

        private void txtMatKhau_Validating(object sender, CancelEventArgs e)
        {
            if ((sender as TextEdit).Text == "")
            {
                txtMatKhau.ErrorText = "Mật khẩu không được để trống";
                wbntThemnhanvien.Buttons[0].Properties.Enabled = false;
            }
            else
            {
                if (KiemTraHopLeCacGiaTriNhapVao())
                    wbntThemnhanvien.Buttons[0].Properties.Enabled = true;
            }
        }

        private void pictureEdit1_Properties_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                pictureEdit1.LoadImage();
        }

        private void txtTenNhanVien_EditValueChanged(object sender, EventArgs e)
        {
            ValidateChildren();
        }

        private void txtTenDangNhap_EditValueChanged(object sender, EventArgs e)
        {
            ValidateChildren();
        }

        private void txtMatKhau_EditValueChanged(object sender, EventArgs e)
        {
            ValidateChildren();
        }

        private void wbntBack_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (ThongBaoHuyKoLuuDichVu())
                actionBack();
         
        }
    }
}

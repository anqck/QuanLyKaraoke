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

namespace GUI.folderQuanLyPhong
{
    public partial class SuaPhong : DevExpress.XtraEditors.XtraUserControl
    {
        public Action actionBack { get; set; }
        PhongDTO phongDTO;
        List<LoaiPhongDTO> listLoaiPhong;
        List<TinhTrangPhongDTO> listTinhTrangPhong;
        public SuaPhong()
        {
            InitializeComponent();

        }
        internal void RefreshDataBinding(int maPhong)
        {
            //lay phong truyen vao
            phongDTO = BUS.PhongBUS.LayThongTinPhong(maPhong);
            

            //Lấy tất cả loại phòng vào cmb
            listLoaiPhong = LoaiPhongBUS.LayTatCaLoaiPhong_List();
            //Nếu không có loại phòng, thông báo cần tạo loại phòng trước

            if (listLoaiPhong.Count == 0)
            {
                //BÌNH
                XtraMessageBox.Show("Cần thêm loại phòng trước!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            cmbLoaiPhong.Properties.Items.Clear();
            foreach (LoaiPhongDTO loaiPhong in listLoaiPhong)
            {

                cmbLoaiPhong.Properties.Items.Add(new MyComboBoxItem(loaiPhong.TenLoaiPhong, loaiPhong.MaLoaiPhong));
                if (loaiPhong.MaLoaiPhong == phongDTO.MaLoaiPhong)
                    cmbLoaiPhong.SelectedIndex = cmbLoaiPhong.Properties.Items.Count - 1;
            }

            
                

           

            //Lấy tất cả tinh trang phong vào cmb
            listTinhTrangPhong = PhongBUS.LayTatCaTinhTrangPhong_List();
            //combobox tinh trang phong
            cmbTinhTrangPhong.Properties.Items.Clear();
            if (phongDTO.MaTinhTrangPhong == 1 || phongDTO.MaTinhTrangPhong == 4)
            {
                cmbTinhTrangPhong.Enabled = false;
                foreach (TinhTrangPhongDTO tinhtrang in listTinhTrangPhong)
                {

                    cmbTinhTrangPhong.Properties.Items.Add(new MyComboBoxItem(tinhtrang.TinhTrangPhong, tinhtrang.MaTinhTrangPhong));
                    if (tinhtrang.MaTinhTrangPhong == phongDTO.MaTinhTrangPhong)
                        cmbTinhTrangPhong.SelectedIndex = cmbTinhTrangPhong.Properties.Items.Count - 1;
                }

            }
            else
            {
                cmbTinhTrangPhong.Enabled = true;
                foreach (TinhTrangPhongDTO tinhtrang in listTinhTrangPhong)
                {
                    if (tinhtrang.MaTinhTrangPhong == 1|| tinhtrang.MaTinhTrangPhong == 4)
                        continue;
                    cmbTinhTrangPhong.Properties.Items.Add(new MyComboBoxItem(tinhtrang.TinhTrangPhong, tinhtrang.MaTinhTrangPhong));
                    if (tinhtrang.MaTinhTrangPhong == phongDTO.MaTinhTrangPhong)
                        cmbTinhTrangPhong.SelectedIndex = cmbTinhTrangPhong.Properties.Items.Count - 1;
                }
            }

            
           

            //Lấy tất cả các tầng
            cmbTang.Properties.Items.Clear();
            List<string> listTang = PhongBUS.LayCacTangCoSan();
            //Nếu không có loại phòng, thông báo cần tạo loại phòng trước
            if (listLoaiPhong.Count == 0)
            {
                //BÌNH
                XtraMessageBox.Show("Cần thêm các tầng trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            foreach (string tang in listTang)
            {
                cmbTang.Properties.Items.Add(tang);
                if (tang == phongDTO.Tang)
                    cmbTang.SelectedIndex = cmbTang.Properties.Items.Count - 1;
            }
           



            txtMaPhong.Text = phongDTO.MaPhong.ToString();
            txtTenPhong.Text = phongDTO.TenPhong.ToString();

        }

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (ThongBaoHuySuaPhong())
                actionBack();
        }
        private bool ThongBaoHuySuaPhong()
        {
            //Bình
            if (XtraMessageBox.Show("Bạn có chắc hủy cập nhật khách hàng ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                return true;
            }
            return false;
        }

        private void wbntSuaphong_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Tag.ToString())
            {
                case "Lưu":
                    //Kiểm tra thông tin hợp lệ
                    if (txtTenPhong.Text == "")
                        return;

                    //Lưu thông tinh
                    if (PhongBUS.CapNhatThongTinPhong(new PhongDTO(int.Parse(txtMaPhong.Text), txtTenPhong.Text, (int)((GUI.MyComboBoxItem)cmbLoaiPhong.SelectedItem).Tag, cmbTang.Text, txtGhiChu.Text, (int)((GUI.MyComboBoxItem)cmbTinhTrangPhong.SelectedItem).Tag)))
                    {
                        //Thông báo thành công
                        //BÌNH
                        XtraMessageBox.Show("Cập nhật phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        actionBack();

                    }
                    else
                    {
                        //Thông báo thất bại
                        //BÌNH
                        XtraMessageBox.Show("Cập nhật phòng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    break;

                case "Hủy":
                    if (ThongBaoHuySuaPhong())
                        actionBack();
                    break;
                default:
                    break;
            }
        }
        private bool KiemTraHopLeCacGiaTriNhapVao()
        {
            if (txtTenPhong.Text == "")
            {
                return false;
            }
            //if (txxtSDT.Text == "")
            //{
            //    return false;
            //}

            return true;
        }

        private void txtTenPhong_EditValueChanged(object sender, EventArgs e)
        {
            txtTenPhong_Validating(sender, new CancelEventArgs());
        }

        private void txtTenPhong_Validating(object sender, CancelEventArgs e)
        {
            if ((sender as TextEdit).Text == "")
            {
                txtTenPhong.ErrorText = "Tên phòng không được để trống";
                wbntSuaphong.Buttons[0].Properties.Enabled = false;
            }
            else
            {
                txtTenPhong.ErrorText = null;
                if (KiemTraHopLeCacGiaTriNhapVao())
                    wbntSuaphong.Buttons[0].Properties.Enabled = true;
            }
        }
    }
}

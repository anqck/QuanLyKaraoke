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

namespace GUI.folderKhachHang
{
    public partial class ThemKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        public Action actionBack { get; set; }
        List<LoaiKhachHangDTO> listLoaiKH;
        public ThemKhachHang()
        {
            InitializeComponent();
        }
        internal void Initialize()
        {


           // Phát sinh mã loại phòng
            txxtMaKh.Text = BUS.KhachHangBUS.PhatSinhMaKH().ToString();


            //Lấy tất cả loại phòng vào cmb
            listLoaiKH = BUS.LoaiKhachHangBUS.LayTatCaLoaiKhachHang_List();


            if (listLoaiKH.Count == 0)
            {
                //BÌNH
                XtraMessageBox.Show("Cần thêm loại khách hàng trước!", "Thông báo", MessageBoxButtons.OK);
            }

            comboBoxloaiKH.Properties.Items.Clear();
            foreach (LoaiKhachHangDTO loaiKH in listLoaiKH)
            {
                comboBoxloaiKH.Properties.Items.Add(new MyComboBoxItem(loaiKH.TenKH, loaiKH.MaLoaiKH));
            }
            comboBoxloaiKH.SelectedIndex = 0;

            txxtTenKh.Text = "";
            txxtCMND.Text = "";
            txxtSDT.Text = "";
            txxtDiaChi.Text = "";
            spinEdit1.EditValue = 0;
            ValidateChildren();
        }

        private void wbntThemkhachhang_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Tag.ToString())
            {
                case "Thêm":
                    //Kiểm tra thông tin hợp lệ
                    if (txxtTenKh.Text == "")
                        return;

                    if (comboBoxloaiKH.Text == "")
                        return;

                    //Lưu thông tinh
                    if (BUS.KhachHangBUS.LuuThongTinKH(new KhachHangDTO(Convert.ToInt32(txxtMaKh.Text), txxtTenKh.Text, txxtCMND.Text, txxtSDT.Text, txxtDiaChi.Text, listLoaiKH[comboBoxloaiKH.SelectedIndex].MaLoaiKH, Convert.ToInt32(spinEdit1.EditValue) )))
                    {
                        //Thông báo thành công
                        //BÌNH
                        XtraMessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK);
                        actionBack();

                    }
                    else
                    {
                        //Thông báo thất bại
                        //BÌNH
                        XtraMessageBox.Show("Thêm khách hàng thất bại!", "Thông báo", MessageBoxButtons.OK);
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
            //Bình
            if (XtraMessageBox.Show("Bạn có chắc hủy thêm khách hàng ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                return true;
            }
            return false;
        }

        private void txxtTenKh_Validating(object sender, CancelEventArgs e)
        {
            if ((sender as TextEdit).Text == "")
            {
                txxtTenKh.ErrorText = "Tên khách hàng không được để trống";
                wbntThemkhachhang.Buttons[0].Properties.Enabled = false;
            }
            else
            {
                if (KiemTraHopLeCacGiaTriNhapVao())
                    wbntThemkhachhang.Buttons[0].Properties.Enabled = true;
            }
        }

        private bool KiemTraHopLeCacGiaTriNhapVao()
        {
            if (txxtTenKh.Text == "")
            {
                return false;
            }
            //if (txxtSDT.Text == "")
            //{
            //    return false;
            //}
       
            return true;
        }
    }
}

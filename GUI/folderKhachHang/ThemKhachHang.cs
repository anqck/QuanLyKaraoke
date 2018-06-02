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


            ////Nếu không có loại phòng, thông báo cần tạo loại phòng trước
            //if (listLoaiDichVu.Count == 0)
            //{
            //    //BÌNH
            //}

            comboBoxloaiKH.Properties.Items.Clear();
            foreach (LoaiKhachHangDTO loaiKH in listLoaiKH)
            {
                comboBoxloaiKH.Properties.Items.Add(new MyComboBoxItem(loaiKH.TenKH, loaiKH.MaLoaiKH));
            }
            comboBoxloaiKH.SelectedIndex = 0;

            //txtTenDichVu.Text = "";
            //txtDonVi.Text = "";
            //txtDonGia.Text = "0";
            //pictureEdit1.Image = (Image)Resources.ResourceManager.GetObject("No_Image_Available");
            //ValidateChildren();
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
                    if (BUS.KhachHangBUS.LuuThongTinKH(new KhachHangDTO(Convert.ToInt32(txxtMaKh.Text), txxtTenKh.Text, txxtCMND.Text, txxtSDT.Text, txxtDiaChi.Text, listLoaiKH[comboBoxloaiKH.SelectedIndex].MaLoaiKH, 5)))
                    {
                        //Thông báo thành công
                        //BÌNH
                        actionBack();

                    }
                    else
                    {
                        //Thông báo thất bại
                        //BÌNH
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
            return true;
        }
    }
}

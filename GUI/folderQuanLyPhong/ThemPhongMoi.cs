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
    public partial class ThemPhongMoi : DevExpress.XtraEditors.XtraUserControl
    {

        List<LoaiPhongDTO> listLoaiPhong;

        public ThemPhongMoi()
        {
            InitializeComponent();
        }

        private void wbntThemphong_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch(e.Button.Properties.Tag.ToString())
            {
                case "btnSave":
                    LuuThongTinPhong();
                    break;
                case "btnCancel":
                    //Thông báo mất save??, trở về màn hình chính
                    //BÌNH
                    break;
            }
            return;
        }

        private void LuuThongTinPhong()
        {
            //Kiểm tra thông tin nhập vào hợp lệ
            //BÌNH

            //Lưu
            PhongDTO phongDTO = new PhongDTO(int.Parse(txtMaPhong.Text),txtTenPhong.Text, listLoaiPhong[cmbLoaiPhong.SelectedIndex].MaLoaiPhong,cmbTang.Text,txtGhiChu.Text,0);
            if(ThemPhongBUS.LuuThongTinPhong(phongDTO))
            {
                //Thông báo thành công
                //BÌNH
            }
            else
            {
                //Thông báo thất bại
                //BÌNH
            }
        }

        internal void Initialize()
        {


            //Phát sinh mã loại phòng
            txtMaPhong.Text = BUS.ThemPhongBUS.PhatSinhMaPhong().ToString();

           
            //Lấy tất cả loại phòng vào cmb
            listLoaiPhong =  LoaiPhongBUS.LayTatCaLoaiPhong();
            //Nếu không có loại phòng, thông báo cần tạo loại phòng trước
            if(listLoaiPhong.Count == 0)
            {
                //BÌNH
            }

            cmbLoaiPhong.Properties.Items.Clear();
            foreach (LoaiPhongDTO loaiPhong in listLoaiPhong)
            {
                cmbLoaiPhong.Properties.Items.Add(new MyComboBoxItem(loaiPhong.TenLoaiPhong, loaiPhong.MaLoaiPhong));
            }
            cmbLoaiPhong.SelectedIndex = 0;

            //Lấy tất cả các tầng
            cmbTang.Properties.Items.Clear();
            List<string> listTang = ThemPhongBUS.LayCacTangCoSan();
            foreach (string tang in listTang)
            {
                cmbTang.Properties.Items.Add(tang);
            }
            cmbTang.SelectedIndex = 0;
        }
    }
}

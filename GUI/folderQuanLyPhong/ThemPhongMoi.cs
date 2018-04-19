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
            
        }

        internal void Initialize()
        {


            //Phát sinh mã loại phòng
            txtMaPhong.Text = BUS.ThemPhongBUS.PhatSinhMaPhong().ToString();

           
            //Lấy tất cả loại phòng vào cmb
            listLoaiPhong =  LoaiPhongBUS.LayTatCaLoaiPhong();
            //Nếu không có loại phòng
            //TODO

            foreach(LoaiPhongDTO loaiPhong in listLoaiPhong)
            {
                cmbLoaiPhong.Properties.Items.Add(new MyComboBoxItem(loaiPhong.TenLoaiPhong, loaiPhong.MaLoaiPhong));
            }
            cmbLoaiPhong.SelectedIndex = 0;

            //Lấy tất cả các tầng
            List<string> listTang = ThemPhongBUS.LayCacTangCoSan();
            foreach (string tang in listTang)
            {
                cmbTang.Properties.Items.Add(tang);
            }
            cmbTang.SelectedIndex = 0;
        }
    }
}

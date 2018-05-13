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

namespace GUI.folderDichVu
{
    public partial class ThemDichVu : DevExpress.XtraEditors.XtraUserControl
    {
        public ThemDichVu()
        {
            InitializeComponent();

            //pictureEdit1.Image = Image.FromStream(ms);

        }

        internal void Initialize()
        {


            //Phát sinh mã loại phòng
            txtMaPhong.Text = BUS.PhongBUS.PhatSinhMaPhong().ToString();


            //Lấy tất cả loại phòng vào cmb
            listLoaiPhong = LoaiPhongBUS.LayTatCaLoaiPhong_List();
            //Nếu không có loại phòng, thông báo cần tạo loại phòng trước
            if (listLoaiPhong.Count == 0)
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
            List<string> listTang = PhongBUS.LayCacTangCoSan();
            foreach (string tang in listTang)
            {
                cmbTang.Properties.Items.Add(tang);
            }
            cmbTang.SelectedIndex = 0;
        }
    }
}

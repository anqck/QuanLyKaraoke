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
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraBars.Docking2010.Customization;

namespace GUI.folderQuanLyPhong
{
    public partial class ThemPhongMoi : DevExpress.XtraEditors.XtraUserControl
    {
        public Action actionBack { get; set; }
        List<LoaiPhongDTO> listLoaiPhong;

        public ThemPhongMoi()
        {
            InitializeComponent();
        }

        private void wbntThemphong_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch(e.Button.Properties.Tag.ToString())
            {
                case "Thêm":
                    //Kiểm tra thông tin hợp lệ
                    if (txtTenPhong.Text == "")
                        return;

                    //Lưu thông tinh
                    if (PhongBUS.LuuThongTinPhong(new PhongDTO(int.Parse(txtMaPhong.Text), txtTenPhong.Text, listLoaiPhong[cmbLoaiPhong.SelectedIndex].MaLoaiPhong, cmbTang.Text, txtGhiChu.Text, 0,Convert.ToInt32(txtSucChua.Value))) )
                    {
                        //Thông báo thành công
                        
                        XtraMessageBox.Show("Thêm phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        actionBack();

                    }
                    else
                    {
                        //Thông báo thất bại
                       
                        XtraMessageBox.Show("Thêm phòng thất bại!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }

                    break;

                case "Hủy":
                    if (ThongBaoHuyThemPhong())
                        actionBack();
                    break;
                default:
                    break;
            }
           
        }

        private bool ThongBaoHuyThemPhong()
        {
        
            if (XtraMessageBox.Show("Bạn có chắc hủy thêm phòng ?", "Xác nhận", MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.OK)
            {
                return true;
            }
            return false;
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

        internal void Initialize()
        {


            //Phát sinh mã loại phòng
            txtMaPhong.Text = BUS.PhongBUS.PhatSinhMaPhong().ToString();

           
            //Lấy tất cả loại phòng vào cmb
            listLoaiPhong =  LoaiPhongBUS.LayTatCaLoaiPhong_List();
            //Nếu không có loại phòng, thông báo cần tạo loại phòng trước
            if(listLoaiPhong.Count == 0)
            {
                XtraMessageBox.Show("Cần phải thêm loại phòng trước!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                actionBack();
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
            txtTenPhong.Text = "";

        }

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (ThongBaoHuyThemPhong())
                actionBack();
        }

        private void txtTenPhong_Validating(object sender, CancelEventArgs e)
        {
            if ((sender as TextEdit).Text == "")
            {
                txtTenPhong.ErrorText = "Tên phòng không được để trống";
                wbntThemphong.Buttons[0].Properties.Enabled = false;
            }
            else
            {
                txtTenPhong.ErrorText = null;
                if (KiemTraHopLeCacGiaTriNhapVao())
                    wbntThemphong.Buttons[0].Properties.Enabled = true;
            }
        }

        private void txtTenPhong_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            txtTenPhong_Validating(sender, new CancelEventArgs());
        }
    }
}

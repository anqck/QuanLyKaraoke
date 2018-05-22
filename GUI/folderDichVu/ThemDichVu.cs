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
using DTO;

namespace GUI.folderDichVu
{
    public partial class ThemDichVu : DevExpress.XtraEditors.XtraUserControl
    {
        public Action actionBack { get; set; }
        List<LoaiDichVuDTO> listLoaiDichVu;
        public ThemDichVu()
        {
            InitializeComponent();

            //pictureEdit1.Image = Image.FromStream(ms);

        }

        

        internal void Initialize()
        {


            //Phát sinh mã loại phòng
            txtMaDV.Text = BUS.DichVuBUS.PhatSinhMaDichVu().ToString();


            //Lấy tất cả loại phòng vào cmb
            listLoaiDichVu = LoaiDichVuBUS.LayTatCaLoaiDichVu_List();


            //Nếu không có loại phòng, thông báo cần tạo loại phòng trước
            if (listLoaiDichVu.Count == 0)
            {
                //BÌNH
            }

            cmbLoaiDV.Properties.Items.Clear();
            foreach (LoaiDichVuDTO loaiDV in listLoaiDichVu)
            {
                cmbLoaiDV.Properties.Items.Add(new MyComboBoxItem(loaiDV.TenDV, loaiDV.MaLoaiDV));
            }
            cmbLoaiDV.SelectedIndex = 0;

            txtTenDichVu.Text = "";
            txtDonVi.Text = "";
            ValidateChildren();
        }

        private void wbntThemdichvu_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch(e.Button.Properties.Tag.ToString())
            {
                case "Thêm":
                    //Kiểm tra thông tin hợp lệ
                    if (txtTenDichVu.Text == "")
                        return;

                    if (txtDonVi.Text == "")
                        return;


                    //Lưu thông tinh
                    if(DichVuBUS.LuuThongTinDichVu(new DichVuDTO(Convert.ToInt32(txtMaDV.Text),txtTenDichVu.Text, Convert.ToDouble(txtDonGia.EditValue), txtDonVi.Text, pictureEdit1.Image, listLoaiDichVu[cmbLoaiDV.SelectedIndex].MaLoaiDV)))
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
                    actionBack();
                    break;
                default:
                    break;
            }
        }

        private void wbntBackThemKH_Click(object sender, EventArgs e)
        {
            actionBack();
        }

        private void txtTenDichVu_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            
        }

        private void txtTenDichVu_Properties_Validating(object sender, CancelEventArgs e)
        {
            if ((sender as TextEdit).Text == "")
                txtTenDichVu.ErrorText = "Tên dịch vụ không được để trống";
        }

        private void txtDonVi_Properties_Validating(object sender, CancelEventArgs e)
        {
            if ((sender as TextEdit).Text == "")
                txtDonVi.ErrorText = "Đơn vị tính không được để trống";
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void pictureEdit1_Properties_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
                pictureEdit1.LoadImage();
        }
    }
}

﻿using System;
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
using GUI.Properties;

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
                XtraMessageBox.Show("Cần thêm loại dịch vụ trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            cmbLoaiDV.Properties.Items.Clear();
            foreach (LoaiDichVuDTO loaiDV in listLoaiDichVu)
            {
                cmbLoaiDV.Properties.Items.Add(new MyComboBoxItem(loaiDV.TenDV, loaiDV.MaLoaiDV));
            }
            cmbLoaiDV.SelectedIndex = 0;

            txtTenDichVu.Text = "";
            txtDonVi.Text = "";
            txtDonGia.Text = "0";
            pictureEdit1.Image = (Image)Resources.ResourceManager.GetObject("No_Image_Available");
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
                    if(DichVuBUS.LuuThongTinDichVu(new DichVuDTO(Convert.ToInt32(txtMaDV.Text),txtTenDichVu.Text, Convert.ToDouble(txtDonGia.EditValue), txtDonVi.Text, resizeImage(pictureEdit1.Image), listLoaiDichVu[cmbLoaiDV.SelectedIndex].MaLoaiDV)))
                    {
                        //Thông báo thành công
                 
                        XtraMessageBox.Show("Thêm dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        actionBack();
                    }
                    else
                    {
                        //Thông báo thất bại
                    
                        XtraMessageBox.Show("Thêm dịch vụ thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "Hủy":
                    if(ThongBaoHuyKoLuuDichVu())
                        actionBack();
                    break;
                default:
                    break;
            }
        }

        public Image resizeImage(Image img, int width = 300, int height = 300)
        {
            Bitmap b = new Bitmap(width, height);
            Graphics g = Graphics.FromImage((Image)b);

            g.DrawImage(img, 0, 0, width, height);
            g.Dispose();

            return (Image)b;
        }

        private void wbntBackThemDV_Click(object sender, EventArgs e)
        {
            if(ThongBaoHuyKoLuuDichVu())
                actionBack();
        }
        private bool ThongBaoHuyKoLuuDichVu()
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn thoát khỏi màn hình này (Mọi thông tin không được lưu sẽ bị mất) ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                return true;
            else
                return false;
        }



        bool KiemTraHopLeCacGiaTriNhapVao()
        {
            if (txtTenDichVu.Text == "")
            {
                return false;
            }
            else if (txtDonVi.Text == "")
            {
                return false;
            }
            return true;
        }
        private void txtTenDichVu_Properties_Validating(object sender, CancelEventArgs e)
        {
            if ((sender as TextEdit).Text == "")
            {
                txtTenDichVu.ErrorText = "Tên dịch vụ không được để trống";
                wbntThemdichvu.Buttons[0].Properties.Enabled = false;
            }
            else
            {
                if(KiemTraHopLeCacGiaTriNhapVao())
                    wbntThemdichvu.Buttons[0].Properties.Enabled = true;
            }
                
        }

        private void txtDonVi_Properties_Validating(object sender, CancelEventArgs e)
        {
            if ((sender as TextEdit).Text == "")
            {
                txtDonVi.ErrorText = "Đơn vị tính không được để trống";
                wbntThemdichvu.Buttons[0].Properties.Enabled = false;
            }
            else
            {
                if (KiemTraHopLeCacGiaTriNhapVao())
                    wbntThemdichvu.Buttons[0].Properties.Enabled = true;
            }

        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void pictureEdit1_Properties_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
                pictureEdit1.LoadImage();
        }

        private void pictureEdit1_Properties_ImageChanged(object sender, EventArgs e)
        {

        }

        private void txtTenDichVu_EditValueChanged(object sender, EventArgs e)
        {
            ValidateChildren();
        }
    }
}

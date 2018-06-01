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

namespace GUI.folderDichVu
{
    public partial class SuaDichVu : DevExpress.XtraEditors.XtraUserControl
    {
        public Action actionBack { get; set; }
        DichVuDTO dichVuDTO;
        List<LoaiDichVuDTO> listLoaiDichVu;
        public SuaDichVu()
        {
            InitializeComponent();
        }

        public void RefreshDataBinding(int maDV)
        {
            try
            {
                dichVuDTO = DichVuBUS.LayThongTinDichVu(maDV);



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
                    if (loaiDV.MaLoaiDV == dichVuDTO.MaLoaiDV)
                        cmbLoaiDV.SelectedIndex = cmbLoaiDV.Properties.Items.Count - 1;
                }


                txtMaDV.EditValue = dichVuDTO.MaDV.ToString();
                txtTenDV.EditValue = dichVuDTO.TenDV;
                txtDonVi.EditValue = dichVuDTO.DonVi;
                txtDonGia.EditValue = dichVuDTO.DonGia.ToString();

                pictureEdit1.Image = dichVuDTO.HinhAnh;


                ValidateChildren();





            }
            catch (Exception x)
            {

            }
        }

        private void pictureEdit1_Properties_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                pictureEdit1.LoadImage();
         
        }

        bool ThongBaoHuyKoLuuDichVu()
        {
            return true;
        }
        private void wbntSuadichvu_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Tag.ToString())
            {
                case "Lưu":
                    //Kiểm tra thông tin hợp lệ
                    if (txtTenDV.Text == "")
                        return;

                    if (txtDonVi.Text == "")
                        return;


                    //Lưu thông tinh
                    if (DichVuBUS.CapNhatThongTinDichVu(new DichVuDTO(Convert.ToInt32(txtMaDV.Text), txtTenDV.Text, Convert.ToDouble(txtDonGia.EditValue), txtDonVi.Text, (pictureEdit1.Image), listLoaiDichVu[cmbLoaiDV.SelectedIndex].MaLoaiDV)))
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

        private void txtTenDV_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            //ValidateChildren();
        }

        private void txtDonVi_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            //();
        }

        bool KiemTraHopLeCacGiaTriNhapVao()
        {
            if (txtTenDV.Text == "")
            {
                return false;
            }
            else if (txtDonVi.Text == "")
            {
                return false;
            }
            return true;
        }
        private void txtTenDV_Properties_Validating(object sender, CancelEventArgs e)
        {
            if ((sender as TextEdit).Text == "")
            {
                txtTenDV.ErrorText = "Tên dịch vụ không được để trống";
                wbntSuadichvu.Buttons[0].Properties.Enabled = false;
            }
            else
            {
                if (KiemTraHopLeCacGiaTriNhapVao())
                    wbntSuadichvu.Buttons[0].Properties.Enabled = true;
            }
        }

        private void txtDonVi_Properties_Validating(object sender, CancelEventArgs e)
        {
            if ((sender as TextEdit).Text == "")
            {
                txtDonVi.ErrorText = "Đơn vị tính không được để trống";
                wbntSuadichvu.Buttons[0].Properties.Enabled = false;
            }
            else
            {
                if (KiemTraHopLeCacGiaTriNhapVao())
                    wbntSuadichvu.Buttons[0].Properties.Enabled = true;
            }
        }

        public Image resizeImage(Image img, int width = 320, int height = 300)
        {
            Bitmap b = new Bitmap(width, height);
            Graphics g = Graphics.FromImage((Image)b);

            g.DrawImage(img, 0, 0, width, height);
            g.Dispose();

            return (Image)b;
        }
    }
}

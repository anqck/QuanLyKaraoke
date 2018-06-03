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

namespace GUI.folderDichVu
{
    public partial class ThemLoaiDichVu : DevExpress.XtraEditors.XtraUserControl
    {
        public Action actionBack { get; set; }
        public ThemLoaiDichVu()
        {
            InitializeComponent();
        }
        public void Initialize()
        {
            //Phát sinh mã loại phòng
            txtMaLoaiDV.Text = BUS.LoaiDichVuBUS.PhatSinhMaDichVu().ToString();         


     
            txtTenLoaiDV.Text = "";
  
            ValidateChildren();
        }

        private void txtTenLoaiDV_Properties_Validating(object sender, CancelEventArgs e)
        {
            if ((sender as TextEdit).Text == "")
            {
                txtTenLoaiDV.ErrorText = "Tên loại dịch vụ không được để trống";
                wbntSuadichvu.Buttons[0].Properties.Enabled = false;
            }
            else
            {                
                    wbntSuadichvu.Buttons[0].Properties.Enabled = true;
            }
        }

        private void wbntSuadichvu_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Tag.ToString())
            {
                case "Thêm":
                    //Kiểm tra thông tin hợp lệ
                    if (txtTenLoaiDV.Text == "")
                        return;

                    //Lưu thông tinh
                    if (BUS.LoaiDichVuBUS.LuuThongTinLoaiDichVu(new LoaiDichVuDTO(int.Parse(txtMaLoaiDV.Text),txtTenLoaiDV.Text)))
                    {
                        //Thông báo thành công
                        XtraMessageBox.Show("Thêm loại dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);



                            actionBack();
                    }
                    else
                    {
                        //Thông báo thất bại
                        XtraMessageBox.Show("Thêm loại dịch vụ thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        bool ThongBaoHuyKoLuuDichVu()
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn thoát khỏi màn hình này (Mọi thông tin không được lưu sẽ bị mất) ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                return true;
            else
                return false;
        }

        private void layoutControlItem1_Click(object sender, EventArgs e)
        {
            ValidateChildren();
        }

        private void txtTenLoaiDV_EditValueChanged(object sender, EventArgs e)
        {
            ValidateChildren();
        }

        private void wbntBack_Click(object sender, EventArgs e)
        {

            if (ThongBaoHuyKoLuuDichVu())
                actionBack();
        }
    }
}

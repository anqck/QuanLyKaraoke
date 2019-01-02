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
using DevExpress.XtraBars.Docking2010.Customization;
using DTO;
using BUS;

namespace GUI.folderTinhTrangPhong
{
    public partial class ChuyenPhong : DevExpress.XtraEditors.XtraUserControl
    {
        //private Action<ThuePhongDTO> onThuePhongSuccess;
        ThuePhongDTO phongCu, phongMoi;
        DataTable dtPhong;
         ChiTietDatPhongDTO chiTietDatPhong;

        public ChuyenPhong()
        {
            InitializeComponent();

            chiTietDatPhong = null;
        }
        public ChuyenPhong(ThuePhongDTO phongCu) : this()
        {
            this.phongCu = phongCu;

           // this.onThuePhongSuccess = onThuePhongSuccess;      

            RefreshDataBinding_ChuyenPhong();


            ValidateChildren();


        }

        public ChuyenPhong(ChiTietDatPhongDTO chiTietDatPhong) :this()
        {
            this.chiTietDatPhong = chiTietDatPhong;

            RefreshDataBinding_ChuyenDatPhong();


            ValidateChildren();
        }

        private void RefreshDataBinding_ChuyenPhong()
        {
            PhongDTO phongDto =PhongBUS.LayThongTinPhong(phongCu.MaPhong);

            txtLoaiPhong_Old.EditValue = LoaiPhongBUS.LayLoaiPhong(phongDto).TenLoaiPhong;
            txtMaPhong_Old.EditValue = phongDto.MaPhong;
            txtTang_Old.EditValue = phongDto.Tang;
            txtTenPhong_Old.EditValue = phongDto.TenPhong;
            txtGhiChu_Old.EditValue = phongDto.GhiChu;

            txtPhong.Properties.DataSource = dtPhong = PhongBUS.LayTatCaPhong_TinhTrangPhong_LoaiPhong_CoSan();
            txtPhong.Properties.DisplayMember = "TenPhong";
            txtPhong.Properties.ValueMember = "MaPhong";

        }
        void RefreshDataBinding_ChuyenDatPhong()
        {
            PhongDTO phongDto = PhongBUS.LayThongTinPhong(chiTietDatPhong.MaPhong);

            txtLoaiPhong_Old.EditValue = LoaiPhongBUS.LayLoaiPhong(phongDto).TenLoaiPhong;
            txtMaPhong_Old.EditValue = phongDto.MaPhong;
            txtTang_Old.EditValue = phongDto.Tang;
            txtTenPhong_Old.EditValue = phongDto.TenPhong;
            txtGhiChu_Old.EditValue = phongDto.GhiChu;

            txtPhong.Properties.DataSource = dtPhong = DatPhongBUS.LayCacPhongConTrongTrongThoiGian(DatPhongBUS.LayThongTinDatPhong(chiTietDatPhong.MaDatPhong).ThoiGianDatPhong, ThamSoBUS.LayKhoangThoiGianToiThieuGiuaHaiLanThue()); 
            txtPhong.Properties.DisplayMember = "TenPhong";
            txtPhong.Properties.ValueMember = "MaPhong";
        }


        private void txtPhong_Properties_Validating(object sender, CancelEventArgs e)
        {
            if(gridView1.GetSelectedRows().Count()==0)
            {
                txtPhong.ErrorText = "Không có phòng nào được chọn";
                windowsUIButtonPanel1.Buttons[0].Properties.Visible = false;
                txtGhiChu.ReadOnly = true;
            }
            else
            {
                txtPhong.ErrorText = "";
                windowsUIButtonPanel1.Buttons[0].Properties.Visible = true;
                txtGhiChu.ReadOnly = false;
            }
        }

        private void txtPhong_EditValueChanged(object sender, EventArgs e)
        {
            ValidateChildren();

            if (gridView1.GetSelectedRows().Count() != 0)
            {
                int sourceIdx = gridView1.GetDataSourceRowIndex(gridView1.GetSelectedRows().ElementAt(0));
                txtMaPhong.EditValue = dtPhong.Rows[sourceIdx]["MaPhong"];
                txtLoaiPhong.EditValue = dtPhong.Rows[sourceIdx]["TenLoaiPhong"];
                txtTang.EditValue = dtPhong.Rows[sourceIdx]["Tang"];
                txtGhiChu.EditValue = dtPhong.Rows[sourceIdx]["GhiChu"];

            }
        }

        private void txtGhiChu_EditValueChanged(object sender, EventArgs e)
        {
            PhongBUS.CapNhatGhiChu((int)txtMaPhong.EditValue, txtGhiChu.EditValue.ToString());
        }

        private void txtGhiChu_Old_EditValueChanged(object sender, EventArgs e)
        {
            PhongBUS.CapNhatGhiChu((int)txtMaPhong_Old.EditValue, txtGhiChu_Old.EditValue.ToString());
        }

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            
            switch (e.Button.Properties.Tag.ToString())
            {
                case "Hủy":
                    ((FlyoutDialog)this.Parent).DialogResult = DialogResult.Cancel;
                    ((FlyoutDialog)this.Parent).Hide();
                    break;
                case "Chuyển":
                    if(chiTietDatPhong == null)
                    {
                        ThuePhongBUS.CapNhatThongTinThuePhong(new ThuePhongDTO(phongCu.MaThuePhong, phongCu.MaPhong, phongCu.GioThuePhong, DateTime.Now, phongCu.MaHoaDon, Double.NaN));
                        PhongBUS.CapNhatTinhTrangPhong(phongCu.MaPhong, 0);

                        phongMoi = new ThuePhongDTO(ThuePhongBUS.PhatSinhMaThuePhong(), (int)txtMaPhong.EditValue, DateTime.Now, DateTime.MinValue, phongCu.MaHoaDon, Double.NaN);
                        ThuePhongBUS.LuuThongTinThuePhong(phongMoi);
                        PhongBUS.CapNhatTinhTrangPhong(phongMoi.MaPhong, 1);

                        
                    }
                    else
                    {
                        if (PhongBUS.LayThongTinPhong(chiTietDatPhong.MaPhong).MaTinhTrangPhong == 4)
                        {
                            PhongBUS.CapNhatTinhTrangPhong(chiTietDatPhong.MaPhong, 0);
                        }
                        ChiTietDatPhongBUS.CapNhatThongTinDatPhong(new ChiTietDatPhongDTO(chiTietDatPhong.MaChiTietDatPhong, (int)txtMaPhong.EditValue,chiTietDatPhong.MaDatPhong));
                       
                    }

                    ((FlyoutDialog)this.Parent).DialogResult = DialogResult.OK;
                    ((FlyoutDialog)this.Parent).Hide();
                    break;
                default:
                    break;
            }
        }

        public ThuePhongDTO GetThuePhongMoi()
        {
            return phongMoi;
        }
    }
}

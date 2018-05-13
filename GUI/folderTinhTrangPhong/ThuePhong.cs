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
using DevExpress.XtraBars.Docking2010.Customization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BUS;
using DevExpress.Utils;

namespace GUI.folderTinhTrangPhong
{
    public partial class ThuePhong : DevExpress.XtraEditors.XtraUserControl
    {
        private KhachHangDTO khachHang;
        private PhongDTO phong;

        private DataTable dataSource_KhachHang;
        private Action onThuePhongSuccess;

        public ThuePhong()
        {
            InitializeComponent();

            khachHang = null;

          
            
            
        }

        public ThuePhong(PhongDTO phong,Action onThuePhongSuccess) : this()
        {
            this.phong = phong;

            this.onThuePhongSuccess = onThuePhongSuccess;

            txtMaPhong.Text = phong.MaPhong.ToString();
            txtTenPhong.Text = phong.TenPhong;
            txtLoaiPhong.Text = LoaiPhongBUS.LayLoaiPhong(phong).TenLoaiPhong;

            RefreshDataBinding();
            txtKhachHang.Properties.DisplayMember = "TenKH";
            txtKhachHang.Properties.ValueMember = "MaKH";


            txtNgayVao.EditValue = DateTime.Now;

            khachHang = KhachHangBUS.LayTatCaKhachHang()[0];
        }

        public void RefreshDataBinding()
        {
            dataSource_KhachHang = KhachHangBUS.LayTatCaKhachHang_LoaiKhachHang();
            txtKhachHang.Properties.DataSource = dataSource_KhachHang;

            txtKhachHang.EditValue = 0;           
            
        }


        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch(e.Button.Properties.Tag.ToString())
            {
                case "Hủy":
                    ((FlyoutDialog)this.Parent).Hide();
                    break;
                case "Thuê":
                    //Kiểm tra khách hàng
                    if (khachHang == null)
                    {
                        XtraMessageBox.Show("Không có khách hàng nào được chọn!", "Lỗi", MessageBoxButtons.OK);
                        return;
                    }


                    if(ThuePhongBUS.LuuThongTinThuePhong(new ThuePhongDTO(ThuePhongBUS.PhatSinhMaThuePhong(), phong.MaPhong,khachHang.MaKH,(DateTime)txtNgayVao.EditValue,Convert.ToDouble(txtTienTraTruoc.EditValue),1))&&PhongBUS.CapNhatTinhTrangPhong(phong,1))
                    {
                        //Thông báo thành công
                        onThuePhongSuccess();

                        ((FlyoutDialog)this.Parent).Hide();
                    }
                    else
                    {
                        //Thông báo thất bại
                    }

                    break;
                default:
                    break;
            }
        }

        private void bntChonKH_Click(object sender, EventArgs e)
        {

            folderKhachHang.ChonKhachHang chonKhachHang = new folderKhachHang.ChonKhachHang();
            XtraDialogArgs args = new XtraDialogArgs(caption: "Caption", content: chonKhachHang, buttons: new DialogResult[] { DialogResult.OK, DialogResult.Cancel });
            args.Showing += Args_Showing;
            args.Caption = "Default Text";
            args.Buttons = new DialogResult[] { DialogResult.OK, DialogResult.Cancel };


            switch (XtraDialog.Show(args))
            {
                case DialogResult.OK:
                    khachHang = chonKhachHang.LayKhachHangDaChon();
                    txtKhachHang.EditValue = khachHang.MaKH;


                    break;
                case DialogResult.Cancel:


                    break;
                default:
                    break;
            }
           


            //FlyoutDialog.Show(this.FindForm(), new folderKhachHang.ChonKhachHang());
        }

        private void Args_Showing(object sender, XtraMessageShowingArgs e)
        {
            e.Form.Text = "Chọn khách hàng";
            e.Buttons[DialogResult.OK].Text = "Chọn";
            e.Buttons[DialogResult.Cancel].Text = "Hủy bỏ";
        }

        private void txtKhachHang_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view =

            txtKhachHang.Properties.View as DevExpress.XtraGrid.Views.Grid.GridView;

           
            //khachHang = new KhachHangDTO((int)dataSource_KhachHang.Rows[idxSelected]["MaKH"], dataSource_KhachHang.Rows[idxSelected]["TenKH"].ToString(), dataSource_KhachHang.Rows[idxSelected]["CMND"].ToString(), dataSource_KhachHang.Rows[idxSelected]["SDT"].ToString(), dataSource_KhachHang.Rows[idxSelected]["DiaChi"].ToString(), (int)dataSource_KhachHang.Rows[idxSelected]["MaLoaiKH"], (int)dataSource_KhachHang.Rows[idxSelected]["DiemTichLuy"]);
           
            
        }

        private void gridLookUpEdit1View_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int idxSelected = gridLookUpEdit1View.GetFocusedDataSourceRowIndex();
            khachHang = new KhachHangDTO((int)dataSource_KhachHang.Rows[idxSelected]["MaKH"], dataSource_KhachHang.Rows[idxSelected]["TenKH"].ToString(), dataSource_KhachHang.Rows[idxSelected]["CMND"].ToString(), dataSource_KhachHang.Rows[idxSelected]["SDT"].ToString(), dataSource_KhachHang.Rows[idxSelected]["DiaChi"].ToString(), (int)dataSource_KhachHang.Rows[idxSelected]["MaLoaiKH"], (int)dataSource_KhachHang.Rows[idxSelected]["DiemTichLuy"]);


        }
               
    }
}



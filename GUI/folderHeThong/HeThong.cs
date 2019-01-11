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

namespace GUI.folderHeThong
{
    public partial class HeThong : DevExpress.XtraEditors.XtraUserControl
    {
        List<NgayLeDTO> listNgayLe;
        public HeThong()
        {
            InitializeComponent();

            ngayLe1.actionBack = GoToHomePage;
        }
        public void RefreshDataBinding()
        {
            //Lấy tất cả ngày lễ
            listNgayLe = NgayLeBUS.LayTatCaNgayLe_List();           

            txtNgayLe.Properties.Items.Clear();
            foreach (NgayLeDTO ngayLe in listNgayLe)
            {

                txtNgayLe.Properties.Items.Add(new MyComboBoxItem(ngayLe.NgayLe.ToString("dd/MM/yyyy"), ngayLe.MaNgayLe));
             
            }

            spinEdit1.EditValue = ThamSoBUS.LayKhoangThoiGianChoDatPhong();
            txtNgayVao.EditValue = ThamSoBUS.LayKhoangThoiGianToiThieuGiuaHaiLanThue();
            txtTienTraTruoc.EditValue = ThamSoBUS.QuyDoiDiem(1);

            if (ThamSoBUS.LayChuyenSangChoDonDepSauKhiThanhToan())
                cbChoDonDep.SelectedIndex = 0;
            else
                cbChoDonDep.SelectedIndex = 1;
        }

        internal void GoToPage_WithoutAnimation(int v)
        {
            navigationFrame1.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            navigationFrame1.SelectedPageIndex = v;
            navigationFrame1.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.True;
        }

        internal void GoToHomePage()
        {
            navigationFrame1.SelectedPageIndex = 0;
           
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ngayLe1.RefeshDataBinding();
            navigationFrame1.SelectedPageIndex = 1;
        }

        private void txtNgayLe_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            txtNgayLe.Text = "Danh sách ngày lễ";
        }

        private void txtNgayVao_Properties_EditValueChanged(object sender, EventArgs e)
        {
            ThamSoBUS.SetKhoangThoiGianToiThieuGiuaHaiLanThue(Convert.ToInt32(txtNgayVao.EditValue));
            spinEdit1.Properties.MaxValue = Convert.ToDecimal(txtNgayVao.EditValue);
        }

        private void txtTienTraTruoc_EditValueChanged(object sender, EventArgs e)
        {
            ThamSoBUS.SetTyLeQuyDoiDiemTien(Convert.ToDouble(txtTienTraTruoc.EditValue));
        }

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch(e.Button.Properties.Tag.ToString())
            {
                case "Mặc định":
                    txtNgayVao.EditValue = 240;
                    txtTienTraTruoc.EditValue = 100;
                break;
            }
        }

        private void spinEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {
            ThamSoBUS.SetKhoangThoiGianChoDatPhong(Convert.ToInt32(spinEdit1.EditValue));
        }

        private void cbChoDonDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChoDonDep.SelectedIndex == 0)
                ThamSoBUS.SetKChuyenSangChoDonDepSauKhiThanhToan(true);
            else if (cbChoDonDep.SelectedIndex == 1)
                ThamSoBUS.SetKChuyenSangChoDonDepSauKhiThanhToan(false);
        }
    }
}

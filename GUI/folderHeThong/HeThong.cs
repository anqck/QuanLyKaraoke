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
    }
}

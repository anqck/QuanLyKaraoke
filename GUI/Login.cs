using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
using DTO;

namespace GUI
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public static Login loginFrm = new Login();


        public NhanVienDTO nhanVien { get; set; }
        public Login()
        {
            InitializeComponent();

            txtTenDangNhap.EditValue = null;
            txtMatKhau.EditValue = null;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.EditValue == null || txtMatKhau.EditValue == null)
                return;

             nhanVien = NhanVienBUS.XacThucNhanVien(txtTenDangNhap.EditValue.ToString(), txtMatKhau.EditValue.ToString());
            if (nhanVien == null)
                XtraMessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
                this.Close();


        }

        private void navButton1_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.Close();
        }

        private void navButtonMinimize_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
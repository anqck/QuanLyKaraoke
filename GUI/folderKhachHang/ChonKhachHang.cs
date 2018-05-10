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

namespace GUI.folderKhachHang
{
    public partial class ChonKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        public ChonKhachHang()
        {
            InitializeComponent();

            gridControl1.DataSource = BUS.KhachHangBUS.LayTatCaKhachHang_LoaiKhachHang();
        }


    }
}

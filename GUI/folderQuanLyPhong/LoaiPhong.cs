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

namespace GUI.folderQuanLyPhong
{
    public partial class LoaiPhong : DevExpress.XtraEditors.XtraUserControl
    {
        public LoaiPhong()
        {
            InitializeComponent();
        }

        private void wbntBack_themloaiphong_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            LoaiPhongPagecontrol.SelectedPage = PageLoaiphong;
        }

        private void wbntBack_sualoaiphong_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            LoaiPhongPagecontrol.SelectedPage = PageLoaiphong;
        }

        private void wbntLoaiphong_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Caption.ToString())
            {
                case "Thêm Loại Phòng":
                    LoaiPhongPagecontrol.SelectedPage = PageThemloaiphong;
                    break;
                case "Sửa Loại Phòng":
                    LoaiPhongPagecontrol.SelectedPage = PageSualoaiphong;
                    break;
                case "Xóa Loại Phòng":
                    break;
            }
        }
    }
}

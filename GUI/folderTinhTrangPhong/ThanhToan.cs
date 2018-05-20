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

namespace GUI.folderTinhTrangPhong
{
    public partial class ThanhToan : DevExpress.XtraEditors.XtraUserControl
    {
        public ThanhToan()
        {
            InitializeComponent();

            //snapControl.Document.DataSource = ds;
        }
        public void RefreshDataBinding(PhongDTO phongDTO)
        {
            //doc.Document.DataSource = BUS.PhongBUS.LayTatCaPhong_TinhTrangPhong_LoaiPhong();
        }

        private void wbntQuanlyphong_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch(e.Button.Properties.Tag.ToString())
            {
                case "Thanh toán":

                    break;
            }
        }
    }
}

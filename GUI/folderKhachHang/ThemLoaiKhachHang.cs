﻿using System;
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
    public partial class ThemLoaiKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        public ThemLoaiKhachHang()
        {
            InitializeComponent();
        }

        private void wbntLoaikhachhang_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            //if (e.Button.Equals(wbntLoaikhachhang.Buttons[0]))
            //{
            //    this.LoaikhachhangPagecontrol.SelectedPage = PageThemLoaikhachang;
            //}
        }

        private void wbntThemloaikhachhang_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            //this.LoaikhachhangPagecontrol.SelectedPage = PageLoaikhachhang;
        }
    }
}
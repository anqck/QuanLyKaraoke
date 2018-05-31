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
using DTO;

namespace GUI.folderDichVu
{
    public partial class SuaLoaiDichVu : DevExpress.XtraEditors.XtraUserControl
    {
        LoaiDichVuDTO loaiDichVuDTO;

        public Action actionBack { get; set; }

        public SuaLoaiDichVu()
        {
            InitializeComponent();
        }

        public void RefreshDataBinding(LoaiDichVuDTO loaiDichVu)
        {
            try
            {
                loaiDichVuDTO = loaiDichVu;
                txtMaLDV.Text = loaiDichVu.MaLoaiDV.ToString();
                txtTenLDV.Text = loaiDichVu.TenDV.ToString();

                     

           

            }
            catch (Exception x)
            {

            }
        }

        private void txtTenLoaiDV_Properties_Validating(object sender, CancelEventArgs e)
        {
            if ((sender as TextEdit).Text == "")
            {
                txtTenLDV.ErrorText = "Tên loại dịch vụ không được để trống";
                wbntSualoaidichvu.Buttons[0].Properties.Enabled = false;
            }
            else
            {
                wbntSualoaidichvu.Buttons[0].Properties.Enabled = true;
            }
        }

        private void txtTenLDV_EditValueChanged(object sender, EventArgs e)
        {
            ValidateChildren();
        }

        private void wbntSualoaidichvu_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Tag.ToString())
            {
                case "Lưu":
                    //Kiểm tra thông tin hợp lệ
                    if (txtTenLDV.Text == "")
                        return;

                    //Lưu thông tinh
                    if (BUS.LoaiDichVuBUS.SuaThongTinLoaiDichVu(new LoaiDichVuDTO(int.Parse(txtMaLDV.Text), txtTenLDV.Text)))
                    {
                        //Thông báo thành công
                        //BÌNH

                        if (ThongBaoHuyKoLuuDichVu()) 
                            actionBack();
                    }
                    else
                    {
                        //Thông báo thất bại
                        //BÌNH
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

        private bool ThongBaoHuyKoLuuDichVu()
        {
            return true;
        }

        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {
            if (ThongBaoHuyKoLuuDichVu()) 
            actionBack();
        }
    }
}

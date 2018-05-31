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

namespace GUI.folderDichVu
{
    public partial class SuaDichVu : DevExpress.XtraEditors.XtraUserControl
    {
        DichVuDTO dichVuDTO;

        List<LoaiDichVuDTO> listLoaiDichVu;
        public SuaDichVu()
        {
            InitializeComponent();
        }

        public void RefreshDataBinding(DichVuDTO dichVu)
        {
            try
            {
                dichVuDTO = dichVu;



                //Lấy tất cả loại phòng vào cmb
                listLoaiDichVu = LoaiDichVuBUS.LayTatCaLoaiDichVu_List();
                //Nếu không có loại phòng, thông báo cần tạo loại phòng trước
                if (listLoaiDichVu.Count == 0)
                {
                    //BÌNH
                }

                cmbLoaiDV.Properties.Items.Clear();
                foreach (LoaiDichVuDTO loaiDV in listLoaiDichVu)
                {
                    cmbLoaiDV.Properties.Items.Add(new MyComboBoxItem(loaiDV.TenDV, loaiDV.MaLoaiDV));
                }

                cmbLoaiDV.SelectedText = dichVu.TenDV;

                ValidateChildren();





            }
            catch (Exception x)
            {

            }
        }

        private void pictureEdit1_Properties_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                pictureEdit1.LoadImage();
        }
    }
}

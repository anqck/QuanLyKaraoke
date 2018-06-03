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

namespace GUI.folderKhachHang
{
    public partial class ChonKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        DataTable gridDataSource; 
        public ChonKhachHang()
        {
            InitializeComponent();

            gridDataSource = BUS.KhachHangBUS.LayTatCaKhachHang_LoaiKhachHang();
            gridControl1.DataSource = gridDataSource;

     
            searchControl1.Client = gridControl1;
        }

        internal KhachHangDTO LayKhachHangDaChon()
        {
            int idxSelectedRow = gridView1.GetFocusedDataSourceRowIndex();
            return new KhachHangDTO((int)gridDataSource.Rows[idxSelectedRow]["MaKH"], gridDataSource.Rows[idxSelectedRow]["TenKH"].ToString(), gridDataSource.Rows[idxSelectedRow]["CMND"].ToString(), gridDataSource.Rows[idxSelectedRow]["SDT"].ToString(), gridDataSource.Rows[idxSelectedRow]["DiaChi"].ToString(), (int)gridDataSource.Rows[idxSelectedRow]["MaLoaiKH"], (double)gridDataSource.Rows[idxSelectedRow]["DiemTichLuy"], (gridDataSource.Rows[idxSelectedRow]["NgaySinh"].ToString() == "") ? (DateTime.MinValue) : ((DateTime)gridDataSource.Rows[idxSelectedRow]["NgaySinh"]));
        }

   
    }
}

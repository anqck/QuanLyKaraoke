using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        public NhanVienDTO()
        {
            MaNhanVien        = -1;
            TenNhanVien       = "";
            SDT               = "";
            DiaChi            = "";
            MaLoaiTaiKhoan    = -1;
            TenDangNhap       = "";
            MatKhau = "";
        }
        public NhanVienDTO(int maNhanVien, string tenNhanVien, string diaChi, string sdt, string tenDangNhap, string matKhau, int maLoaiTaiKhoan,Image hinhAnh )
        {
            MaNhanVien = maNhanVien;
            TenNhanVien = tenNhanVien;
            SDT = sdt;
            DiaChi = diaChi;
            MaLoaiTaiKhoan = maLoaiTaiKhoan;
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            HinhAnh = hinhAnh;
        }
        public NhanVienDTO(int maNhanVien, string tenNhanVien, string diaChi, string sdt, string tenDangNhap, string matKhau, int maLoaiTaiKhoan, byte[] byteArrayIn)
        {
            MaNhanVien = maNhanVien;
            TenNhanVien = tenNhanVien;
            SDT = sdt;
            DiaChi = diaChi;
            MaLoaiTaiKhoan = maLoaiTaiKhoan;
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            SetHinhAnh(byteArrayIn);
        }
        public void SetHinhAnh(byte[] byteArrayIn)
        {
            Image returnImage = null;
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                returnImage = Image.FromStream(ms);
            }
            HinhAnh = returnImage;
        }
        public int MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
      
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public int MaLoaiTaiKhoan { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public Image HinhAnh { get; set; }

    }
}

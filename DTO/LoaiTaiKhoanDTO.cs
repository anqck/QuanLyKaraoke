using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiTaiKhoanDTO
    {

        public int MaLoaiTaiKhoan { get; set; }
        public string TenLoaiTaiKhoan { get; set; }

        public LoaiTaiKhoanDTO(int maLoaiTaiKhoan, string tenLoaiTaiKhoan)
        {
            MaLoaiTaiKhoan = maLoaiTaiKhoan;
            TenLoaiTaiKhoan = tenLoaiTaiKhoan;
        }
    }
}

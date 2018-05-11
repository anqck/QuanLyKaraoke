using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiKhachHangDTO
    {
        public int MaLoaiKH { get; set; }
        public string TenKH { get; set; }

        public LoaiKhachHangDTO(int maLoaiKH, string tenLoaiKH)
        {
            MaLoaiKH = maLoaiKH;
            TenKH = tenLoaiKH;
        }
    }
}

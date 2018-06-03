using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TinhTrangPhongDTO
    {

        public int MaTinhTrangPhong { get; set; }
        public string TinhTrangPhong { get; set; }

        public TinhTrangPhongDTO(int maTinhTrangPhong, string tinhTrangPhong)
        {
            MaTinhTrangPhong = maTinhTrangPhong;
            TinhTrangPhong = tinhTrangPhong;
        }
    }
}

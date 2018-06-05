using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TinhTrangDatPhongDTO
    {
        public int MaTinhDatTrangPhong { get; set; }
        public string TinhTrangDatPhong { get; set; }

        public TinhTrangDatPhongDTO(int maTinhTrangPhong, string tinhTrangPhong)
        {
            MaTinhDatTrangPhong = maTinhTrangPhong;
            TinhTrangDatPhong = tinhTrangPhong;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiDichVuDTO
    {
        public int MaLoaiDV { get; set; }
        public string TenDV { get; set; }

        public LoaiDichVuDTO(int maLoaiDV, string tenLoaiDV)
        {
            MaLoaiDV = maLoaiDV;
            TenDV = tenLoaiDV;
        }
    }
}

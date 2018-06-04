using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NgayLeDTO
    {
        public int MaNgayLe { get; set; }
        public DateTime NgayLe { get; set; }

        public NgayLeDTO(int maNgayLe, DateTime ngayLe)
        {
            MaNgayLe = maNgayLe;
            NgayLe = ngayLe;
        }
    }
}

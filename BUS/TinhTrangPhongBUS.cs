using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TinhTrangPhongBUS
    {
        public static string GetFilterString_LoaiPhong(List<String> listLoaiPhong)
        {
            String res = "[TenLoaiPhong] = '" + listLoaiPhong[0] + "'" ;
            for(int i = 1; i< listLoaiPhong.Count; i++)
            {
                res += "or [TenLoaiPhong] = '" + listLoaiPhong[i] + "'";
            }

            return res;
        }
    }
}

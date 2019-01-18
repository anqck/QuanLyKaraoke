using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TienGio_ThuePhongBUS
    {
        public static int PhatSinhMaTienGio_ThuePhong()
        {
            return DAL.TienGio_ThuePhongDAL.PhatSinhMaTienGio_ThuePhong();
        }

        public static DataTable LayTienGio_ThuePhong_DataTable(int maThuePhong)
        {

            return DAL.TienGio_ThuePhongDAL.LayTienGio_ThuePhong_DataTable(maThuePhong);

        }

        public static bool LuuTienGio_ThuePhong(TienGio_ThuePhongDTO tienThuePhongDTO)
        {

            return DAL.TienGio_ThuePhongDAL.LuuTienGio_ThuePhong(tienThuePhongDTO);
        }
    }
}

using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NgayLeBUS
    {
        public static int PhatSinhMaNgayLe()
        {

            return DAL.NgayLeDAL.PhatSinhMaNgayLe();
        }

        public static DataTable LayTatCaNgayLe_DataTable()
        {
            return DAL.NgayLeDAL.LayTatCaNgayLe_DataTable();
        }

        public static List<NgayLeDTO> LayTatCaNgayLe_List()
        {
            return DAL.NgayLeDAL.LayTatCaNgayLe_List();
        }

        public static bool ThemNgayLe(NgayLeDTO ngayLe)
        {
            return DAL.NgayLeDAL.ThemNgayLe(ngayLe);
        }
        public static bool SuaNgayLe(NgayLeDTO ngayLe)
        {
            return DAL.NgayLeDAL.SuaNgayLe(ngayLe);
        }
        public static bool XoaNgayLe(int maNgayLe)
        {
            return DAL.NgayLeDAL.XoaNgayLe(maNgayLe);
        }
    }
}

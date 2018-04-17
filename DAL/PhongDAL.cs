﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhongDAL
    {

        public static Dictionary<string, PhongDTO> LayTatCaPhong()
        {

            DataTable dt = DataProvider.ExecuseQuery("Select * FROM phong");

            Dictionary<string, PhongDTO> res = new Dictionary<string, PhongDTO>();

            for (int i = 0; i < dt.Rows.Count - 1; i++)
            {
                DTO.PhongDTO temp = new PhongDTO();
                temp.MaPhong = dt.Rows[i]["MaPhong"].ToString();

                res.Add(temp.MaPhong, temp);
            }

            return res;
        }

        public static DataTable LayTatCaPhong_TinhTrangPhong_LoaiPhong()
        {
            return DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.phong, quanlykaraoke.tinhtrangphong,quanlykaraoke.loaiphong where quanlykaraoke.phong.MaTinhTrangPhong = quanlykaraoke.tinhtrangphong.MaTinhTrangPhong and quanlykaraoke.phong.MaLoaiPhong = quanlykaraoke.loaiphong.MaLP ;");
        }

        public static DataTable LayTatCaPhong_TinhTrangPhong()
        {
            return DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.phong, quanlykaraoke.tinhtrangphong where quanlykaraoke.phong.MaTinhTrangPhong = quanlykaraoke.tinhtrangphong.MaTinhTrangPhong;");
        }

        public static List<String> LayCacTangCoSan()
        {
            List<String> res = new List<string>();

            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT quanlykaraoke.phong.tang FROM quanlykaraoke.phong group by quanlykaraoke.phong.tang;");
            foreach (DataRow row in dt.Rows)
            {
                res.Add(row[0].ToString());
            }

            return res;
        }
    }
}

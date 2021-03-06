﻿using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DichVuDAL
    {
        public static int PhatSinhMaDichVu()
        {
            DataTable dt = DataProvider.ExecuseQuery("SELECT quanlykaraoke.dichvu.MaDV FROM quanlykaraoke.dichvu ORDER BY quanlykaraoke.dichvu.MaDV DESC LIMIT 1;");
            if (dt.Rows.Count == 0)
                return 1;
            else
                return Convert.ToInt32(dt.Rows[0][0]) + 1;
        }

        public static bool LuuThongTinDichVu(DichVuDTO dichVuDTO)
        {
            //try
            //{
                StringBuilder strSQL = new StringBuilder("INSERT INTO quanlykaraoke.dichvu(MaDV, TenDV, DonGia, DonVi, MaLDV,HinhAnhDV) VALUES (@0,@1,@2,@3,@4,@5)");
                //strSQL.Replace("@0", dichVuDTO.MaDV.ToString());
                //strSQL.Replace("@1", dichVuDTO.TenDV.ToString());
                //strSQL.Replace("@2", dichVuDTO.DonGia.ToString());
                //strSQL.Replace("@3", dichVuDTO.DonVi.ToString());
                //strSQL.Replace("@4", dichVuDTO.MaLoaiDV.ToString());

                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(dichVuDTO.HinhAnh, typeof(byte[]));

                //strSQL.Replace("@5", arr.ToString());



                MySqlTransaction transaction = null; //wherever you get the transaction obj from.

                var maDV = new MySqlParameter("@0", MySqlDbType.Int32)
                {
                    Direction = ParameterDirection.Input,
                    Value = dichVuDTO.MaDV
                };
                var tenDV = new MySqlParameter("@1", MySqlDbType.VarChar)
                {
                    Direction = ParameterDirection.Input,
                    Value = dichVuDTO.TenDV
                };
                var donGia = new MySqlParameter("@2", MySqlDbType.Double)
                {
                    Direction = ParameterDirection.Input,
                    Value = dichVuDTO.DonGia
                };
                var donVi = new MySqlParameter("@3", MySqlDbType.VarChar)
                {
                    Direction = ParameterDirection.Input,
                    Value = dichVuDTO.DonVi
                };
                var maLoaiDV = new MySqlParameter("@4", MySqlDbType.Int32)
                {
                    Direction = ParameterDirection.Input,
                    Value = dichVuDTO.MaLoaiDV
                };

                var byteParam = new MySqlParameter("@5", MySqlDbType.VarBinary)
                {
                    Direction = ParameterDirection.Input,
                    Size = arr.Length,
                    Value = arr
                }; //change the data type to whatever data type you are expecting

                DAL.DataProvider.getConnection().Open();
                MySqlHelper.ExecuteNonQuery(DAL.DataProvider.getConnection(), strSQL.ToString(), maDV, tenDV, donGia, donVi, maLoaiDV, byteParam);
                DAL.DataProvider.getConnection().Close();
                //DAL.DataProvider.ExecuseNonQuery(strSQL.ToString());

                return true;
            //}
            //catch (Exception e)
            //{
            //    return false;
            //}
        }

        public static DataTable LayTatCaDichVu_LoaiDichVu()
        {
            return DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.dichvu, quanlykaraoke.loaidichvu where quanlykaraoke.dichvu.MaLDV = quanlykaraoke.loaidichvu.MaLDV ;");
        }

        public static DataTable LayTatCaDichVu_LoaiDichVu_ExceptHuyVaKM()
        {
            return DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.dichvu, quanlykaraoke.loaidichvu where quanlykaraoke.dichvu.MaLDV = quanlykaraoke.loaidichvu.MaLDV AND loaidichvu.MaLDV NOT IN ( SELECT loaidichvu.MaLDV FROM quanlykaraoke.loaidichvu  WHERE  loaidichvu.MaLDV = '3' OR loaidichvu.MaLDV = '2' );");
        }

        public static Dictionary<int, DichVuDTO> LayTatCaDichVu_Dictionary()
        {
            try
            {
                Dictionary<int, DichVuDTO> res = new Dictionary<int, DichVuDTO>();

                DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.dichvu;");
                foreach (DataRow row in dt.Rows)
                {
                    DichVuDTO dichVuDTO = new DichVuDTO((int)row["MaDV"], row["TenDV"].ToString(), (double)row["donGia"], row["DonVi"].ToString(), (byte[])row["HinhAnh"], (int)row["MaLDV"]);
                    res.Add(dichVuDTO.MaDV, dichVuDTO);
                }

                return res;

            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static DataTable LayTatCaDichVu_DataTable()
        {
            return DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.dichvu;");
        }

        public static List<DichVuDTO> LayTatCaDichVu_List()
        {
            List<DichVuDTO> res = new List<DichVuDTO>();

            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.dichvu;");
            foreach (DataRow row in dt.Rows)
            {
                DichVuDTO dichVuDTO = new DichVuDTO((int)row["MaDV"], row["TenDV"].ToString(), (double)row["donGia"], row["DonVi"].ToString(), (byte[])row["HinhAnh"], (int)row["MaLDV"]);
                res.Add( dichVuDTO);
            }

            return res;
        }
        public static int DemSoLuongDichVu(int maLoaiDV)
        {
            return Convert.ToInt32(DataProvider.ExecuseQuery("SELECT Count(*) FROM quanlykaraoke.dichvu WHERE quanlykaraoke.dichvu.MaLDV = '"+maLoaiDV.ToString()+"';").Rows[0][0]);
        }
        public static DichVuDTO LayThongTinDichVu(int maDichVu)
        {
            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.dichvu WHERE quanlykaraoke.dichvu.MaDV = '"+maDichVu.ToString()+"';");

            return new DichVuDTO((int)dt.Rows[0]["MaDV"], dt.Rows[0]["TenDV"].ToString(), (double)dt.Rows[0]["DonGia"], dt.Rows[0]["DonVi"].ToString(), (byte[])dt.Rows[0]["HinhAnhDV"], (int)dt.Rows[0]["MaLDV"]);
        }
        public static bool CapNhatThongTinDichVu(DichVuDTO dichVuDTO)
        {
            StringBuilder strSQL = new StringBuilder("UPDATE quanlykaraoke.dichvu SET  TenDV = @1,DonGia = @2, DonVi = @3,MaLDV = @4, HinhAnhDV = @5   WHERE MaDV = @0");
            //strSQL.Replace("@0", dichVuDTO.MaDV.ToString());
            //strSQL.Replace("@1", dichVuDTO.TenDV.ToString());
            //strSQL.Replace("@2", dichVuDTO.DonGia.ToString());
            //strSQL.Replace("@3", dichVuDTO.DonVi.ToString());
            //strSQL.Replace("@4", dichVuDTO.MaLoaiDV.ToString())

            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(dichVuDTO.HinhAnh, typeof(byte[]));

            //strSQL.Replace("@5", arr.ToString());



            MySqlTransaction transaction = null; //wherever you get the transaction obj from.

            var maDV = new MySqlParameter("@0", MySqlDbType.Int32)
            {
                Direction = ParameterDirection.Input,
                Value = dichVuDTO.MaDV
            };
            var tenDV = new MySqlParameter("@1", MySqlDbType.VarChar)
            {
                Direction = ParameterDirection.Input,
                Value = dichVuDTO.TenDV
            };
            var donGia = new MySqlParameter("@2", MySqlDbType.Double)
            {
                Direction = ParameterDirection.Input,
                Value = dichVuDTO.DonGia
            };
            var donVi = new MySqlParameter("@3", MySqlDbType.VarChar)
            {
                Direction = ParameterDirection.Input,
                Value = dichVuDTO.DonVi
            };
            var maLoaiDV = new MySqlParameter("@4", MySqlDbType.Int32)
            {
                Direction = ParameterDirection.Input,
                Value = dichVuDTO.MaLoaiDV
            };

            var byteParam = new MySqlParameter("@5", MySqlDbType.VarBinary)
            {
                Direction = ParameterDirection.Input,
                Size = arr.Length,
                Value = arr
            }; //change the data type to whatever data type you are expecting

            DAL.DataProvider.getConnection().Open();
            MySqlHelper.ExecuteNonQuery(DAL.DataProvider.getConnection(), strSQL.ToString(), maDV, tenDV, donGia, donVi, maLoaiDV, byteParam);
            DAL.DataProvider.getConnection().Close();
            //DAL.DataProvider.ExecuseNonQuery(strSQL.ToString());

            return true;
        }
        public static DataTable LayTatCaDichVu_LoaiDichVu_KM()
        {
            return DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.dichvu, quanlykaraoke.loaidichvu where quanlykaraoke.dichvu.MaLDV = quanlykaraoke.loaidichvu.MaLDV  ;");

        }
    }
}

using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class ChiTietHoaDonDBContext : DBConnection
    {
        DbSet<ChiTietHoaDon> ChiTietHoaDon { get; set; }
        DbSet<Thuoc> Thuoc { get; set; }
        public ChiTietHoaDonDBContext() { }
        

        /// <summary>
        ///  join ChiTietHoaDon and Thuoc to get the details of the Bill
        /// </summary>
        /// <param name="HD_ID"></param>
        /// <returns> list of bills </returns>
        public static BindingList<hoadonHT> getHoaDon(int HD_ID)
        {
            try
            {
                using(var dbContext = new ChiTietHoaDonDBContext())
                {
                    var query = (from cthd in dbContext.ChiTietHoaDon
                                join thuoc in dbContext.Thuoc on cthd.TH_ID equals thuoc.TH_ID
                                where cthd.HD_ID == HD_ID
                                select new hoadonHT
                                {
                                    hd_id = cthd.HD_ID,
                                    th_id = thuoc.TH_ID,
                                    th_name = thuoc.TenThuoc,
                                    soluong = cthd.SoLuong,
                                    dongia = cthd.DonGia
                                }).ToList();
                    return new BindingList<hoadonHT>(query);
                }
            }
            catch 
            {
                return new BindingList<hoadonHT>();
            }

        }

        public static BindingList<HoaDonTonKho> getHoaDonTonkho(int HD_ID)
        {
            try
            {
                using (var dbContext = new ChiTietHoaDonDBContext())
                {
                    var query = (from cthd in dbContext.ChiTietHoaDon
                                 join thuoc in dbContext.Thuoc on cthd.TH_ID equals thuoc.TH_ID
                                 where cthd.HD_ID == HD_ID
                                 select new HoaDonTonKho
                                 {
                                     hd_id = cthd.HD_ID,
                                     th_id = thuoc.TH_ID,
                                     th_name = thuoc.TenThuoc,
                                     soluong = cthd.SoLuong,
                                     dongia = cthd.DonGia,
                                     TonKho = thuoc.SoLuong,
                                 }).ToList();
                    return new BindingList<HoaDonTonKho>(query);


                }
            }
            catch
            {
                return new BindingList<HoaDonTonKho>();
            }

        }

    }
}

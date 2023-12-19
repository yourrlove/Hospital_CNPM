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
        public DbSet<ChiTietHoaDon> ChiTietHoaDon { get; set; }
        public DbSet<Thuoc> Thuoc { get; set; }
        public ChiTietHoaDonDBContext() { }
        /// <summary>
        /// add the details of the medicine
        /// </summary>
        /// <param name="HD_ID"></param>
        /// <param name="TH_ID"></param>
        /// <param name="SoLuong"></param>
        /// <param name="DonGia"></param>
        public static void addChiTietHoaDon (int HD_ID, int TH_ID, int SoLuong, double DonGia)
        {
            var dbContext = new ChiTietHoaDonDBContext();
            try
            {
                dbContext.ChiTietHoaDon.Add(new ChiTietHoaDon
                {
                    HD_ID = HD_ID,
                    TH_ID = TH_ID,
                    SoLuong = SoLuong,
                    DonGia = DonGia

                });

                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }


        public static BindingList<ThuocHoaDon> loadHoaDon(int HD_ID)
        {
            try
            {
                using (var dbContext = new ChiTietHoaDonDBContext())
                {
                    var query = (from cthd in dbContext.ChiTietHoaDon
                                join th in dbContext.Thuoc on cthd.TH_ID equals th.TH_ID
                                where cthd.HD_ID == HD_ID
                                select new ThuocHoaDon
                                {
                                    th_id = th.TH_ID,
                                    tenthuoc = th.TenThuoc,
                                    soluong = cthd.SoLuong,
                                    giaban = th.GiaBan,
                                    dongia = cthd.DonGia
                                }).ToList();
                    return new BindingList<ThuocHoaDon>(query);
                }
            }
            catch 
            {
                return null;   
            }

        }

        public static bool CheckHD(int HD_ID)
        {
            try
            {
                using (var dbContext = new ChiTietHoaDonDBContext())
                {
                    var existingRecord = dbContext.ChiTietHoaDon.FirstOrDefault(record => record.HD_ID == HD_ID);
                    return existingRecord != null;

                }
            }
            catch (Exception ex)
            {
               
                return false;
            }
        }

    }
}

using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class ChiTietHoaDonDBContext : DBConnection
    {
        public DbSet<ChiTietHoaDon> ChiTietHoaDon { get; set; }
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
    }
}

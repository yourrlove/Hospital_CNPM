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
    public class HoaDonDBContext : DBConnection
    {
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<BenhNhan> BenhNhan { get; set; }
        public DbSet<BenhAn> BenhAn { get; set; }
        public HoaDonDBContext() { }
        /// <summary>
        /// Create a bill
        /// </summary>
        /// <param name="NgayLap"></param>
        /// <param name="TongTien"></param>
        /// <param name="TN_ID"></param>
        /// <param name="BN_ID"></param>
        public static void addHoaDon( DateTime NgayLap, double TongTien, int TN_ID, int BN_ID, string thanhtoan)
        {
            var dbContext = new HoaDonDBContext();
            try
            {
                dbContext.HoaDon.Add(new HoaDon
                {
                    NgayLap = NgayLap,
                    TongTien = TongTien,
                    TN_ID = TN_ID,
                    BN_ID = BN_ID,
                    ThanhToan = thanhtoan
                });
                    
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }


        /// <summary>
        /// get the last id of bill in database
        /// </summary>
        /// <returns>the last id of bills </returns>
        public static int getLastHD_ID()
        {
            int lastHD_ID = 0;

            using (var dbContext = new HoaDonDBContext())
            {
                var lastHoaDon = dbContext.HoaDon
                    .OrderByDescending(hd => hd.HD_ID)
                    .FirstOrDefault();

                if (lastHoaDon != null)
                {
                    lastHD_ID = lastHoaDon.HD_ID;
                }
            }
            return lastHD_ID;
        }

        

        public static BindingList<HoaDonBenhNhan> GetHoaDonBenhNhan(int BN_ID)
        {
            try
            {
                using (var dbContext = new BenhNhanDBContext())
                {
                    var query = (from hd in dbContext.HoaDon
                                 join ba in dbContext.BenhAn on hd.HD_ID equals ba.BA_ID
                                 where hd.BN_ID == BN_ID
                                 select new HoaDonBenhNhan
                                 {
                                     hd_id = hd.HD_ID,
                                     tenhoadon = ba.TenBenhAn,
                                     ngayxuat = hd.NgayLap,
                                     tongtien = hd.TongTien,
                                     thanhtoan = hd.ThanhToan
                                 }).ToList();
                    var distinctResults = query.Distinct().ToList();
                    return new BindingList<HoaDonBenhNhan>(distinctResults);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class CTDTDBContext : DBConnection
    {
        public DbSet<ChiTietDonThuoc> ChiTietDonThuoc { get; set; }
        public DbSet<Thuoc> Thuoc { get; set; }
        public CTDTDBContext() { }

        public static bool AddChiTietDT(IList<ChiTietDonThuoc> newList)
        {
            try
            {
                var dbContext = new CTDTDBContext();
                dbContext.ChiTietDonThuoc.AddRange(newList);
                dbContext.SaveChanges();
                return true;
            }
            catch { return false; }
        }
        
        public static bool DeleteCTDT(int DT_ID)
        {
            try
            {
                var dbContext = new CTDTDBContext();
                var list = dbContext.ChiTietDonThuoc.Where(p => p.DT_ID == DT_ID);
                foreach(var item in list)
                {
                    dbContext.ChiTietDonThuoc.Remove(item);
                }
                dbContext.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        public static List<ThuocDOC> GetMedicines(int DT_ID)
        {
            try
            {
                var dbContext = new CTDTDBContext();
                var item =
                    (
                        from detail in dbContext.ChiTietDonThuoc
                        join medicine in dbContext.Thuoc on detail.TH_ID equals medicine.TH_ID
                        where detail.DT_ID == DT_ID
                        select new ThuocDOC
                        {
                            TH_ID = medicine.TH_ID,
                            Name = medicine.TenThuoc,
                            Quantity = detail.SoLuong,
                            Buoi = detail.LieuDung
                        });

                return item.ToList();
            
            }
            catch { return null; }
        }
    }
}

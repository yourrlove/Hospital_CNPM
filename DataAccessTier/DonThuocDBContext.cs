using DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class DonThuocDBContext : DBConnection
    {
        public DbSet<DonThuoc> DonThuoc { get; set; }
        public DbSet<ChiTietDonThuoc> ChiTietDonThuoc { get; set; }
        public DbSet<Thuoc> Thuoc { get; set; }
        public DonThuocDBContext() { }

        public static bool AddDonThuoc(DateTime createDate, int BS_ID, string prescriptionName)
        {
            try
            {
                var dbContext = new DonThuocDBContext();
                dbContext.DonThuoc.Add(new DonThuoc { NgayKeDon = createDate, BS_ID = BS_ID, TenDonThuoc = prescriptionName });
                dbContext.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        public static int GetDT_IDLatest()
        {
            try
            {
                var dbContext = new DonThuocDBContext();
                return dbContext.DonThuoc.OrderByDescending(d => d.DT_ID).FirstOrDefault().DT_ID;
            }
            catch { return -1; }
        }

        public static bool UpdateDonThuoc(int DT_ID, DateTime createDate, string prescriptionName)
        {
            try
            {
                var dbContext = new DonThuocDBContext();
                var data = dbContext.DonThuoc.Find(DT_ID);
                if (data != null)
                {
                    data.TenDonThuoc = prescriptionName;
                    data.NgayKeDon = createDate;
                }
                dbContext.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        public static DonThuocDetail GetDonThuocDetail(int DT_ID)
        {
            try
            {
                var dbContext = new DonThuocDBContext();
                var item = (
                    from prescript in dbContext.DonThuoc
                    join detail in dbContext.ChiTietDonThuoc on prescript.DT_ID equals detail.DT_ID
                    where prescript.DT_ID == DT_ID
                    select new DonThuocDetail
                    {
                        TenDonThuoc = prescript.TenDonThuoc ?? "",
                        NgayKeDon = prescript.NgayKeDon.ToString() ?? "",
                        Lists = CTDTDBContext.GetMedicines(DT_ID)
                    });
                return item.FirstOrDefault();
            }
            catch { return null; }
        }
}
}

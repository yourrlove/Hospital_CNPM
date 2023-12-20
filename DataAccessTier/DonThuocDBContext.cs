using DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public DbSet<ChiTietBenhAn> ChiTietBenhAn { get; set; }
        public DbSet<BenhAn> BenhAn { get; set; }
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


        /// <summary>
        /// Get the prescription of specific patient
        /// </summary>
        /// <param name="BN_ID"></param>
        /// <returns></returns>
        public static BindingList<DonThuoc>? GetDonThuocBenhNhan(int BN_ID)
        {
            try
            {
                using (var dbContext = new DonThuocDBContext())
                {
                    var query = (
                        from donthuoc in dbContext.DonThuoc
                        join chitietBA in dbContext.ChiTietBenhAn on donthuoc.DT_ID equals chitietBA.DT_ID
                        join benhan in dbContext.BenhAn on chitietBA.BA_ID equals benhan.BA_ID
                        where benhan.BN_ID == BN_ID
                        select new DonThuoc
                        {
                            DT_ID = donthuoc.DT_ID,
                            NgayKeDon = donthuoc.NgayKeDon,
                            BS_ID = donthuoc.BS_ID,
                            TenDonThuoc = donthuoc.TenDonThuoc
                        }).ToList();

                    return new BindingList<DonThuoc>(query);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");

                return new BindingList<DonThuoc>();
            }
        }
    }

}

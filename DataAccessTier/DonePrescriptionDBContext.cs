using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccessTier.HoaDonDuocSiDBContext;

namespace DataAccessTier
{
    public class DonePrescriptionDBContext : DBConnection
    {
        //public DbSet<HoaDonDuocSi> DonePrescription { get; set; }
        public DbSet<HoaDonDuocSi> DonePrescription { get; set; }
        public DbSet<BenhNhan> BenhNhan { get; set; }
        public DbSet<listHTcho> listHTcho { get; set; }
        public DonePrescriptionDBContext() { }

        public static void addPrescription(int BN_ID, int HD_ID)
        {
            try
            {
                using(var dbContext = new DonePrescriptionDBContext())
                {
                    dbContext.DonePrescription.Add(new HoaDonDuocSi
                    {
                        HD_ID = HD_ID,
                        BN_ID = BN_ID
                    });
                    dbContext.SaveChanges();
                }
            }
            catch(Exception ex) { }
        }

        public static BindingList<listHTcho> ListHoaDon()
        {
            try
            {
                using (var dbContext = new DonePrescriptionDBContext())
                {
                    var query = (from hdds in dbContext.DonePrescription
                                 join bn in dbContext.BenhNhan on hdds.BN_ID equals bn.BN_ID
                                 select new listHTcho
                                 {
                                     HD_ID = hdds.HD_ID,
                                     BN_ID = bn.BN_ID,
                                     sodienthoai = bn.SoDienThoai,
                                     tenbenhnhan = bn.HoTen
                                 }).ToList();
                    return new BindingList<listHTcho>(query);
                }
            }
            catch (Exception ex)
            {
                return new BindingList<listHTcho>();
            }
        }

        public static void deleteRecord(int BN_ID, int HD_ID)
        {
            try
            {
                using (var dbContext = new DonePrescriptionDBContext())
                {
                    var deleted = dbContext.DonePrescription.Where(t => t.HD_ID == HD_ID && t.BN_ID == BN_ID).First();
                    dbContext.DonePrescription.Remove(deleted);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }
        }


        public static BindingList<listHTcho> SearchCompletedPrescription(string s)
        {
            BindingList<listHTcho> resultList = null;

            if (!string.IsNullOrEmpty(s))
            {
                using (var dbContext = new DonePrescriptionDBContext())
                {
                    var query = (from hdds in dbContext.DonePrescription
                                 join bn in dbContext.BenhNhan on hdds.BN_ID equals bn.BN_ID
                                 where bn.HoTen.Contains(s) || bn.SoDienThoai.Contains(s)
                                 select new listHTcho
                                 {
                                     HD_ID = hdds.HD_ID,
                                     BN_ID = bn.BN_ID,
                                     sodienthoai = bn.SoDienThoai,
                                     tenbenhnhan = bn.HoTen
                                 }).ToList();

                    resultList = new BindingList<listHTcho>(query);
                }
            }

            return resultList;
        }


    }
}

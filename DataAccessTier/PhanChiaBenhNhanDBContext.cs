using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class PhanChiaBenhNhanDBContext : DBConnection
    {
        DbSet<PhanChiaBenhNhan> PhanChiaBenhNhan { get; set; }
        public PhanChiaBenhNhanDBContext() { }

        public static void AssignPatient(int BN_ID, int PH_ID)
        {
            try
            {
                using (var dbContext = new PhanChiaBenhNhanDBContext())
                {
                    dbContext.PhanChiaBenhNhan.Add(new PhanChiaBenhNhan
                    {
                        BN_ID = BN_ID,
                        PH_ID = PH_ID
                    });
                    dbContext.SaveChanges();
                }

            }
            catch
            { }
        }

        public static void deleteRecord(int BN_ID, int PH_ID)
        {
            try
            {
                using (var dbContext = new PhanChiaBenhNhanDBContext())
                {
                    var deleted = dbContext.PhanChiaBenhNhan.FirstOrDefault(t => t.BN_ID == BN_ID && t.PH_ID == PH_ID);

                    if (deleted != null)
                    {
                        dbContext.PhanChiaBenhNhan.Remove(deleted);
                        dbContext.SaveChanges();
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception ex)
            {
            }
        }


    }
}

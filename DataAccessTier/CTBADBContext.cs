using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class CTBADBContext : DBConnection
    {
        public DbSet<ChiTietBenhAn> ChiTietBenhAn { get; set; }
        public CTBADBContext() { }

        public static bool AddChiTietBA(int BA_ID, int DT_ID, string medicalHistory)
        {
            try
            {
                var dbContext = new CTBADBContext();
                dbContext.ChiTietBenhAn.Add(new ChiTietBenhAn { BA_ID = BA_ID, DT_ID = DT_ID, TSBenhLi = medicalHistory});
                dbContext.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        public static bool IsCTBAExist(int BA_ID)
        {
            try
            {
                var dbContext = new CTBADBContext();
                return dbContext.ChiTietBenhAn.Any(p => p.BA_ID == BA_ID);
            }
            catch { return false; }
        }

        public static int GetDTID_BA(int BA_ID)
        {
            try
            {
                var dbContext = new CTBADBContext();
                return dbContext.ChiTietBenhAn.Single(p => p.BA_ID == BA_ID).DT_ID;
            }
            catch { return -1; }
        }

        public static bool UpdateCTBA(int BA_ID, string medicalHistory)
        {
            try
            {
                var dbContext = new CTBADBContext();
                var data = dbContext.ChiTietBenhAn.Single(p => p.BA_ID == BA_ID);
                if (data != null)
                {
                    data.TSBenhLi = medicalHistory;
                }
                dbContext.SaveChanges();
                return true;
            }
            catch { return false; }
        }
    }
}

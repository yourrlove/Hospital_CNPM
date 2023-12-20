using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class DuocSiDBContext : DBConnection
    {
        public DbSet<DuocSi> DuocSi { get; set; }
        public DuocSiDBContext() { }

        public static int GetID(string UserID)
        {
            try
            {
                var dbContext = new DuocSiDBContext();
                return dbContext.DuocSi.Where(p => p.User_ID == UserID).FirstOrDefault().DS_ID;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }


        public static int CountDuocSi()
        {
            try
            {
                var dbContext = new DuocSiDBContext();
                return dbContext.DuocSi.Count();
            }
            catch (Exception ex) { }
            return 0;
        }

        public static List<DuocSi> GetListDuocSi()
        {
            try
            {
                var dbContext = new DuocSiDBContext();
                return dbContext.DuocSi.ToList();
            }
            catch (Exception ex) { }
            return null;
        }

        public static bool DeleteDuocSi(int DS_ID)
        {
            try
            {
                var dbContext = new DuocSiDBContext();
                var account = dbContext.DuocSi.Find(DS_ID);
                if (account != null)
                {
                    dbContext.DuocSi.Remove(account);
                }
                dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

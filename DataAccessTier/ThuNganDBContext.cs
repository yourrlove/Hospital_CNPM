using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class ThuNganDBContext : DBConnection
    {
        public DbSet<ThuNgan> ThuNgan { get; set; }
        public ThuNganDBContext() { }

        public static int GetID(string UserID)
        {
            try
            {
                var dbContext = new ThuNganDBContext();
                return dbContext.ThuNgan.Where(p => p.User_ID == UserID).FirstOrDefault().TN_ID;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }
        public static int CountThuNgan()
        {
            try
            {
                var dbContext = new ThuNganDBContext();
                return dbContext.ThuNgan.Count();
            }
            catch (Exception ex) { }
            return 0;
        }

        public static List<ThuNgan> GetListThuNgan()
        {
            try
            {
                var dbContext = new ThuNganDBContext();
                return dbContext.ThuNgan.ToList();
            }
            catch (Exception ex) { }
            return null;
        }

        public static bool DeleteThuNgan(int TN_ID)
        {
            try
            {
                var dbContext = new ThuNganDBContext();
                var account = dbContext.ThuNgan.Find(TN_ID);
                if (account != null)
                {
                    dbContext.ThuNgan.Remove(account);
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

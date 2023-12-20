using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class TiepTanDBContext : DBConnection
    {
        public DbSet<TiepTan> TiepTan { get; set; }
        public TiepTanDBContext() { }

        public static int GetID(string UserID)
        {
            try
            {
                var dbContext = new TiepTanDBContext();
                return dbContext.TiepTan.Where(p => p.User_ID == UserID).FirstOrDefault().TT_ID;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }
        public static int CountTiepTan()
        {
            try
            {
                var dbContext = new TiepTanDBContext();
                return dbContext.TiepTan.Count();
            }
            catch (Exception ex) { }
            return 0;
        }

        public static List<TiepTan> GetListTiepTan()
        {
            try
            {
                var dbContext = new TiepTanDBContext();
                return dbContext.TiepTan.ToList();
            }
            catch (Exception ex) { }
            return null;
        }

        public static bool DeleteTiepTan(int TT_ID)
        {
            try
            {
                var dbContext = new TiepTanDBContext();
                var account = dbContext.TiepTan.Find(TT_ID);
                if (account != null)
                {
                    dbContext.TiepTan.Remove(account);
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

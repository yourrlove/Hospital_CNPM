using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class QuanLiBenhAnBSDBContext : DBConnection
    {
        public DbSet<BS_BA> QuanLiBenhAnBS { get; set; }
        public QuanLiBenhAnBSDBContext() { }

        public static bool AddBS_BA(int BS_ID, int BA_ID)
        {
            try
            {
                var dbContext = new QuanLiBenhAnBSDBContext();
                dbContext.QuanLiBenhAnBS.Add(new BS_BA{ BS_ID = BS_ID, BA_ID = BA_ID });
                dbContext.SaveChanges();
                return true;
            }
            catch { return false; }
        }
    }
}

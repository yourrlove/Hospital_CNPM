using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class QuanLiBenhAnDBContext : DBConnection
    {
        public DbSet<QuanLiBenhAn> QuanLiBenhAn { get; set; }
        public QuanLiBenhAnDBContext() { }

        public static bool AddQuanLiBenhAn(int KH_ID, int BA_ID)
        {
            try
            {
                var dbContext = new QuanLiBenhAnDBContext();
                dbContext.QuanLiBenhAn.Add(new QuanLiBenhAn { KH_ID = KH_ID, BA_ID = BA_ID});
                dbContext.SaveChanges();
                return true;
            }
            catch { return false; }
        }
    }
}

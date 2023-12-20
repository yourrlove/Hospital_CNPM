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
    }
}

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
    }
}

using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class PhanCongBSDBContext : DBConnection
    {
        public DbSet<PhanCongBS> PhanCongBS { get; set; }
        public PhanCongBSDBContext() { }

        public static Dictionary<int, int>? GetListPhanCongBS()
        {
            try
            {
                var dbContext = new PhanCongBSDBContext();
                return dbContext.PhanCongBS.ToDictionary(p => p.PH_ID, p => p.BS_ID);
            }
            catch (Exception ex) { }
            return null;
        }

        public static int? GetPCBS_ID(int PH_ID)
        {
            try
            {
                var dbContext = new PhanCongBSDBContext();
                return dbContext.PhanCongBS.SingleOrDefault(p => p.PH_ID == PH_ID).BS_ID;
            }
            catch (Exception ex) { }
            return null;
        }
    }
}

﻿using DTO;
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
            catch (Exception ex) 
            {
                return new Dictionary<int, int>();
            }
            
        }

        public static int? GetPCBS_ID(int PH_ID)
        {
            try
            {
                var dbContext = new PhanCongBSDBContext();
                return dbContext.PhanCongBS.SingleOrDefault(p => p.PH_ID == PH_ID).BS_ID;
            }
            catch (Exception ex) 
            {
                return 0;
            }
            
        }


        public static bool DeletePCBS(int BS_ID)
        {
            try
            {
                var dbContext = new PhanCongBSDBContext();
                var account = dbContext.PhanCongBS.Where(p => p.BS_ID == BS_ID).FirstOrDefault();
                if (account != null)
                {
                    dbContext.PhanCongBS.Remove(account);
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

﻿using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class BacSiDBContext : DBConnection
    {
        public DbSet<BacSi> BacSi { get; set; }
        public BacSiDBContext() { }

        public static BacSi? FindById(int BS_ID)
        {
            try
            {
                var dbContext = new BacSiDBContext();
                return dbContext.BacSi.Find(BS_ID);
            }
            catch (Exception ex) { }
            return null;
        }

        public static int? FindKH_ID(int BS_ID)
        {
            try
            {
                var dbContext = new BacSiDBContext();
                return dbContext.BacSi.Find(BS_ID).KH_ID;
            }
            catch (Exception ex) { }
            return 0;
        }

        public static string? GetDoctorName(int BS_ID)
        {
            try
            {
                var dbContext = new BacSiDBContext();
                return dbContext.BacSi.Find(BS_ID).HoTen;
            }
            catch (Exception ex) { }
            return null;
        }
    }
}
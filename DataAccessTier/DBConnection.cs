﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataAccessTier
{
    public partial class DBConnection : DbContext
    {
        protected DBConnection()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=THUPHA-ACERAPPL\\SQLEXPRESS03;Database=hospital_121;Database=hospital_121;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
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
                "Server=LAPTOP-ECTV8EAG\\SQLEXPRESS;Database=hospital_007;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
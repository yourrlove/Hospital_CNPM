using Microsoft.EntityFrameworkCore;
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
                "Server=THUPHA-ACERAPPL\\SQLEXPRESS03;Database=hospital_121;Trusted_Connection=True;TrustServerCertificate=True;Min Pool Size=5;Max Pool Size=100;",
                 options => options.EnableRetryOnFailure());
        }
    }
}
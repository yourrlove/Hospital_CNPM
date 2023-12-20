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
                "Server=LAPTOP-ECTV8EAG\\SQLEXPRESS;Database=hospital_007;Trusted_Connection=True;TrustServerCertificate=True;Min Pool Size=5;Max Pool Size=100;Connection Timeout=30;",

            options => options.EnableRetryOnFailure());
        }
    }
}

//"Server=LAPTOP-ECTV8EAG\\SQLEXPRESS;Database=hospital_007;Trusted_Connection=True;TrustServerCertificate=True;Min Pool Size=5;Max Pool Size=100;Connection Timeout=30;",
//"Server=hospitaldatabase.database.windows.net;Database=hospital;User Id=thanhdat;Password=dangdat@123;Trusted_connection=False;Encrypt=True;",
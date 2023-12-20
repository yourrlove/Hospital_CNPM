﻿using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class AccountDBContext : DBConnection
    {
        public DbSet<Account> account { get; set; }
        public DbSet<TiepTan> TiepTan { get; set; }
        public DbSet<ThuNgan> ThuNgan { get; set; }
        public DbSet<DuocSi> DuocSi { get; set; }

        public DbSet<BacSi> BacSi { get; set; }
        public AccountDBContext() { }

        public static List<Account>? GetListAccount()
        {
            try
            {
                var dbContext = new AccountDBContext();
       
                return dbContext.account.ToList();

            }
            catch (Exception e)
            {

            }
            return null;
        }

        public static bool Authenticate(string name, string pass)
        {
            var dbContext = new AccountDBContext();
            return dbContext.account.Any(account => account.username == name && account.password == pass);
        }

        public static string GetUserID(string userName, string password)
        {
            var dbContext = new AccountDBContext();
            var v = dbContext.account.Where(account => account.username == userName).Select(account => account.User_ID).ToList();
            return v.FirstOrDefault();
        }


    }
}

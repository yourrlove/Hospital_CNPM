using DTO;
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
            try
            {
                var dbContext = new AccountDBContext();
                return dbContext.account.Any(account => account.username == name && account.password == pass);
            } catch
            (Exception e)
            {
                return false;
            }

        }

        public static string GetUserID(string userName, string password)
        {
            try
            {
                var dbContext = new AccountDBContext();
                var v = dbContext.account.Where(account => account.username == userName).Select(account => account.User_ID).ToList();
                return v.FirstOrDefault();
            } catch
            {
                return "";
            }

        }

        public static string GetDisplayName(string userID)
        {
            try
            {
                var dbContext = new AccountDBContext();
                var v = dbContext.account.Where(account => account.User_ID == userID).Select(account => account.displayName).ToList();
                return v.FirstOrDefault();
            }
            catch
            {
                return "";
            }
        }

        public static Account? GetAccount(string User_ID)
        {
            try
            {
                var dbContext = new AccountDBContext();
                return dbContext.account.Find(User_ID);
            }
            catch
            {
                return null;
            }
        }

        public static bool UpdateAccount(string User_ID, string userName, string password)
        {
            try
            {
                var dbContext = new AccountDBContext();
                var account = dbContext.account.Find(User_ID);
                if (account != null)
                {
                    account.username = userName;
                    account.password = password;
                }
                dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteAccount(string User_ID)
        {
            try
            {
                var dbContext = new AccountDBContext();
                var account = dbContext.account.Find(User_ID);
                if (account != null)
                {
                    dbContext.account.Remove(account);
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

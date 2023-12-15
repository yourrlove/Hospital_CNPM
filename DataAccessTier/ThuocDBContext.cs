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
    public class ThuocDBContext : DBConnection
    {
        public DbSet<Thuoc> Thuoc { get; set; }
        public ThuocDBContext() { }

        public static List<Thuoc> GetAllThuoc()
        {
            var dbContext = new ThuocDBContext();
            return dbContext.Thuoc.ToList();
        }

        public static List<Thuoc> FindByPattern(string pattern)
        {
            var dbContext = new ThuocDBContext();
            return dbContext.Thuoc.Where(m => m.TenThuoc.ToLower().Contains(pattern.ToLower())).ToList();
        }
    }
}

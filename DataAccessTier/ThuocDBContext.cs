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

        public static List<ThuocDOC> GetAllThuoc()
        {
            var dbContext = new ThuocDBContext();
            return dbContext.Thuoc.Select(p => new ThuocDOC { TH_ID = p.TH_ID, Name = p.TenThuoc, Quantity = p.SoLuong }).ToList();
        }

        public static List<Thuoc> FindByPattern(string pattern)
        {
            var dbContext = new ThuocDBContext();
            return dbContext.Thuoc.Where(m => m.TenThuoc.ToLower().Contains(pattern.ToLower())).ToList();
        }

        public static Thuoc? GetThuocDetail(int TH_ID)
        {
            try
            {
                var dbContext = new ThuocDBContext();
                return dbContext.Thuoc.Find(TH_ID);
            } catch { return null; }
        }
    }
}

using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class KhoaDBContext : DBConnection
    {
        public DbSet<Khoa> Khoa { get; set; }
        public KhoaDBContext() { }

        public static Dictionary<int, string> GetKhoa()
        {
            var dbContext = new KhoaDBContext();
            return dbContext.Khoa.ToDictionary(k => k.KH_ID, k => k.TenKhoa);
        }

        public static string GetKhoaName(int KH_ID)
        {
            var dbContext = new KhoaDBContext();
            return dbContext.Khoa.Find(KH_ID).TenKhoa;
        }
    }
}

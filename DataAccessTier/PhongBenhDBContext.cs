using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class PhongBenhDBContext : DBConnection
    {
        public DbSet<PhongBenh> PhongBenh { get; set; }
        public PhongBenhDBContext() { }

        public static Dictionary<string, int> GetRooms()
        {
                var dbContext = new PhongBenhDBContext();

                return dbContext.PhongBenh.ToDictionary(room => room.TenPhong, room => room.SucChua);
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Microsoft.EntityFrameworkCore;

namespace DataAccessTier
{
    public class BenhNhanDBContext : DBConnection
    {
        public DbSet<BenhNhan> BenhNhan { get; set; }
        public BenhNhanDBContext() { }

        public static BindingList<BenhNhan>? GetListPatient()
        {
            try
            {
                var dbContext = new BenhNhanDBContext();
                dbContext.BenhNhan.Load();
                return  dbContext.BenhNhan.Local.ToBindingList();

            } catch (Exception e)
            {

            }
            return null;
        }

    }
}

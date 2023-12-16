using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class ThuNganDBContext : DBConnection
    {
        public DbSet<ThuNgan> ThuNgan { get; set; }
        public ThuNganDBContext() { }
    }
}

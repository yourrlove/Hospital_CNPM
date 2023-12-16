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
    public class ChiTietBenhAnDBContext : DBConnection
    {
        public DbSet<ChiTietBenhAn> ChiTietBenhAns { get; set; }
        public ChiTietBenhAnDBContext() { }


    }
}

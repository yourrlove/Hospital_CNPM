using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [PrimaryKey(nameof(BA_ID), nameof(DT_ID))]
    public class ChiTietBenhAn
    {
        public int BA_ID { get; set; }
        public int DT_ID { get; set; }
        [StringLength(50)]
        public string? TSBenhLi { get; set; } // Tien su benh ly
    }
}




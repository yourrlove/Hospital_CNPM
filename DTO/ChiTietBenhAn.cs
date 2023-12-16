using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DTO
{
    [PrimaryKey(nameof(BA_ID), nameof(DT_ID))]
    public class ChiTietBenhAn
    {
        public int BA_ID { get; set; }
        public int DT_ID { get; set; }
        [StringLength(50)]
        public string? TSBenhLi { get; set; } 
        [ForeignKey("BA_ID")]
        public BenhAn BenhAn { get; set; }
        [ForeignKey("DT_ID")]
        public DonThuoc DonThuoc { get; set; }
    }
}

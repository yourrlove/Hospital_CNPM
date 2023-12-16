using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace DTO
{

    public class BenhAn
    {
        [Key]
        public int BA_ID { get; set; }
        [AllowNull, StringLength(50)]
        public string? TenBenhAn { get; set; }
        [AllowNull, StringLength(50)]
        public string? TrieuChung { get; set; }
        public int BN_ID { get; set; }
        public DateTime Ngay { get; set; }
    }
}

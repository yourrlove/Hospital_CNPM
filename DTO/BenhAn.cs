using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Diagnostics.CodeAnalysis;

namespace DTO
{
    public class BenhAn
    {
        [Key, Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BA_ID { get; set; }
        [Required]
        [AllowNull, StringLength(50)]
        public string TenBenhAn { get; set; }
        [AllowNull, StringLength(50)]
        public string? TrieuChung { get; set; }
        public int BN_ID { get; set; }
        public DateTime Ngay { get; set; }
        //[ForeignKey("BN_ID")]
        //public BenhNhan BenhNhan { get; set; }

        //List<QuanLiBenhAn> QuanLiBenhAns { get; set; }
        //List<ChiTietBenhAn> ChiTietBenhAns { get; set; }
        //List<BS_BA> BS_BA { get; set; }

        //List<PhanChiaDonThuoc> PhanChiaDonThuocs { get; set; }
    }
}

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
        [StringLength(50)]
        [Required]
        public string TenBenhAn { get; set; }
        [StringLength(50)]
        public string? TrieuChung { get; set; }
        public int BN_ID { get; set; }
        [Required(ErrorMessage = "Date created is required!")]
        public DateTime Ngay { get; set; }
    }
}

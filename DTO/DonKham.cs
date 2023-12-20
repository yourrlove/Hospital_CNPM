using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonKham
    {
        [Key]
        public int BN_ID { get; set; }
        [Required]
        public int TT_ID { get; set; }
        [Required]
        public int PH_ID { get; set; }
        [Required]
        public int KH_ID { get; set; }
        [Required]
        public string TenBenhAn {  get; set; }
        [Required]
        public DateTime Ngay {  get; set; }
        public string? TrieuChung { get; set; }
    }
}

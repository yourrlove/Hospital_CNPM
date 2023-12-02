using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Phieu
    {
        [Key, Required]
        [StringLength(50)]
        public string PH_ID { set; get; }
        [Required]
        [StringLength(50)]
        public string BN_ID { set; get; }
        [StringLength(50)]
        public string HoTen { set; get; }
        public DateTime Ngay { set; get; }
        public int STT { set; get; }

        [ForeignKey("BN_ID")]
        public BenhNhan BenhNhan { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BenhAn
    {
        [Key, Required]
        [StringLength(50)]
        public string BA_ID { get; set; }
        [Required]
        [StringLength(50)]
        public string TenBenhAnh { get; set; }
        [StringLength(50)]

        public string TT_ID { get; set; }
        [StringLength(50)]

        public string KH_ID { get; set; }
        [StringLength(50)]

        public string BS_ID { get; set; }
        [StringLength(50)]

        public string BN_ID { get; set; }

        public DateTime Ngay { get; set; }
        [StringLength(50)]

        public string ChiTiet { get; set; }

        [ForeignKey("BN_ID")]
        public BenhNhan BenhNhan { get; set; }
    }
}

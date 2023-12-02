using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhanChiaBenhNhan
    {
        [Key, Required]
        [StringLength(50)]
        public string PCBN_ID { set; get; }
        [Required]
        [StringLength(50)]
        public string BN_ID { get; set; }
        [StringLength(50)]
        public string PH_ID { set; get; }
    }
}

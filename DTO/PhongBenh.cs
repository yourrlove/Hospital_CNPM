using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongBenh
    {
        [Key]
        public int PH_ID { get; set; }
        [Required]
        [StringLength(50)]
        public string TenPhong { set; get; }
        public int SucChua { set; get; }
        public int KH_ID { set; get; }
    }
}

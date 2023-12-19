using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Khoa
    {
        [Key]
        public int KH_ID { get; set; }
        [Required]
        [StringLength(50)]
        public string TenKhoa { get; set; }
        public double GiaKham { get; set; }
    }
}

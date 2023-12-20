using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Khoa
    {
        [Key, Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KH_ID { get; set; }
        [Required]
        [StringLength(50)]
        public string TenKhoa { get; set; }
        public double GiaKham { get; set; }
    }

}

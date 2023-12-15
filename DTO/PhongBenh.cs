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
        [Key, Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PH_ID { get; set; }
        [Required]
        [StringLength(50)]
        public string TenPhong { set; get; }
        public int SucChua { set; get; }

        [StringLength(50)]
        public int KH_ID { get; set; }
    }
}

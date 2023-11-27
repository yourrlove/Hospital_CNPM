using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongBenh
    {
        [Key, Required]
        [StringLength(50)]
        public string PH_ID { get; set; }
        [Required]
        [StringLength(50)]
        public string TenPhong { set; get; }
        public int SucChua { set; get; }
        //List<PhanChiaBenhNhan> PhanChiaBenhNhans { get; set; }
    }
}

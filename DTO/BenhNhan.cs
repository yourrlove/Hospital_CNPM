using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BenhNhan
    {
        [Key, Required]
        [StringLength(50)]
        public string BN_ID { set; get; }
        [Required]
        [StringLength(50)]
        public string HoTen { set; get; }
        [StringLength(50)]
        public string GioiTinh { get; set; }
        public DateTime Tuoi { set; get; }
        [StringLength(50)]
        public string DiaChi { get; set; }
        [StringLength(50)]
        public string NgheNGhiep { get; set; }


        // List<BenhAn> BenhAns { get; set; }
        // List<Phieu> Phieus { get; set; }
    }
}

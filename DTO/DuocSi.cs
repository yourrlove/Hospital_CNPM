using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DuocSi
    {
        [Key, Required]
        public int DS_ID { set; get; }
        [Required]
        [StringLength(50)]
        public string User_ID { set; get; }
        [StringLength(50)]
        public string HoTen { set; get; }
        public DateTime NgaySinh { set; get; }
        [StringLength(50)]
        public string GioiTinh { get; set; }
        [StringLength(50)]
        public string SoDienThoai { set; get; }
    }
}

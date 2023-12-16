using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BenhNhan
    {
        [Key, Required]
        public int BN_ID { set; get; }
        [Required]
        [StringLength(50)]
        public string HoTen { set; get; }
        [StringLength(50)]
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { set; get; }
        [StringLength(50)]
        public string DiaChi { get; set; }
        [StringLength(50)]
        public string SoDienThoai { get; set; }
        [StringLength(50)]
        public string? NhomMau { get; set; }
        public double? CanNang { get; set; }
        public double? ChieuCao { get; set; }
    }
}

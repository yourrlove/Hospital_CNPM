using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Thuoc
    {
        [Key, Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TH_ID { get; set; }
        [Required]
        [StringLength(50)]
        public string TenThuoc { get; set; }
        [StringLength(50)]
        public double GiaBan { get; set; }
        public int SoLuong { get; set; }
        //List<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        //List<ChiTietDonThuoc> ChiTietDonThuocs { get; set; }
    }
}

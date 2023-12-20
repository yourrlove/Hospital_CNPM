using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonThuoc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DT_ID { get; set; }
        [Required(ErrorMessage = "Date created is required!")]
        public DateTime NgayKeDon { get; set; }
        public int BS_ID { get; set; }
        [Required(ErrorMessage = "Prescription name is required!")]
        [StringLength(50)]
        public string TenDonThuoc { get; set; }
    }
}

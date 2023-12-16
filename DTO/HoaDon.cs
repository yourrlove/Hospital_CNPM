using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HD_ID { get; set; }
        [Required]
        public DateTime NgayLap { get; set; }
        public double TongTien { get; set; }
        public int TN_ID { get; set; }
        public int BN_ID { get; set; }

    }

}

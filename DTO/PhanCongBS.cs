using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [PrimaryKey(nameof(BS_ID), nameof(PH_ID))]
    public class PhanCongBS
    {
        [Required]
        public int BS_ID { get; set; }
        [StringLength(50)]
        public int PH_ID { get; set; }

        [ForeignKey("BS_ID")]
        public BacSi BacSi { get; set; }

        [ForeignKey("PH_ID")]
        public PhongBenh PhongBenh { get; set; }


    }
}

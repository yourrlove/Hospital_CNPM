using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DTO
{
    [PrimaryKey(nameof(BN_ID), nameof(PH_ID))]
    public class PhanChiaBenhNhan
    {

        [Required]
        public int BN_ID { get; set; }
        [Required]
        public int PH_ID { set; get; }    
    }
}

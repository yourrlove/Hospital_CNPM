using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [PrimaryKey(nameof(BN_ID), nameof(PH_ID))]
    public class PhanChiaBenhNhan
    {
        public int BN_ID { get; set; }
        public int PH_ID { set; get; }
    }
}

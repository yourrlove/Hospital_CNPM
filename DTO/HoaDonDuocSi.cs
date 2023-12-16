using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [PrimaryKey(nameof(HD_ID), nameof(BN_ID))]
    public class HoaDonDuocSi
    {
        public int HD_ID { get; set; }

        public int BN_ID { get; set; }
    }
}

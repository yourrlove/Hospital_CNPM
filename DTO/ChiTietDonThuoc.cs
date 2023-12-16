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

    [PrimaryKey(nameof(DT_ID), nameof(TH_ID))]
    public class ChiTietDonThuoc
    {
        public int DT_ID { get; set; }
        public int TH_ID { get; set; }
        public int SoLuong { get; set; }
        [StringLength(50)]
        public string LieuDung { get; set; }
    }

}

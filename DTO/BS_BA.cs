using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{

    [PrimaryKey(nameof(BS_ID), nameof(BA_ID))]
    public class BS_BA
    {
        public int BS_ID { get; set; }
        public int BA_ID { get; set; }

        //[ForeignKey("BS_ID")]
        //public BacSi BacSi { get; set; }

        //[ForeignKey("BA_ID")]
        //public BenhAn benhAn { get; set; }
    }

}

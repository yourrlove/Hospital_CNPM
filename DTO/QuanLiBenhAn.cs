using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [PrimaryKey(nameof(KH_ID), nameof(BA_ID))]
    public class QuanLiBenhAn
    {
        public int KH_ID { get; set; }
        public int BA_ID { get; set; }
    }

}

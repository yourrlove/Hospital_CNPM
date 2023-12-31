﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DTO
{
    [PrimaryKey(nameof(HD_ID), nameof(TH_ID))]
    public class ChiTietHoaDon
    {
        public int HD_ID { get; set; }
        public int TH_ID { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }
    }
}

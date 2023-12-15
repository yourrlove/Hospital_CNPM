using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietBenhAnh
    {
        [Key]
        [StringLength(50)]
        public int CTBA_ID { get; set; }
        [Required]
        [StringLength(50)]
        public int BA_ID { get; set; }
        [StringLength(50)]
        public int DT_ID { get; set; }
        [StringLength(50)]
        public string HoTen { get; set; }
        [Range(0, float.MaxValue, ErrorMessage = "Please enter valid float Number")]
        public double? Height { get; set; } //chieu cao
        [Range(0, float.MaxValue, ErrorMessage = "Please enter valid float Number")]
        public double? Weight { get; set; } // can nang
        [StringLength(4)]
        public string? BloodType { get; set; } //nhom mau
        [StringLength(50)]
        public string? HealthInsurance { get; set; }
        [StringLength(50)]
        public string? Symptom { get; set; } //trieu chung
        [StringLength(50)]
        public string? MedicalHistory { get; set; } // Tien su benh ly
    }
}

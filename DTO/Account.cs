using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        [Key]
        [Required]
        [StringLength(50)]
        public string User_ID { set; get; }
        [Required]
        [StringLength(50)]
        public string username { set; get; }
        [StringLength(50)]
        public string password { set; get; }
        [StringLength(50)]
        public string displayName { set; get; }
    }
}

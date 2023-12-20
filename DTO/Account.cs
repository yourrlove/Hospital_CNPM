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
        public string User_ID { get; set; }
        [Required(ErrorMessage = "Username is required.")]
        public string username { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        public string password { get; set; }
        [StringLength(50)]
        public string displayName { get; set; }
    }
}

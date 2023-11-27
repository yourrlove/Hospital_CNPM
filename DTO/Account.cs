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
        public string username { get; set; }
        public string password { get; set; }
        public string displayName { get; set; }
    }
}

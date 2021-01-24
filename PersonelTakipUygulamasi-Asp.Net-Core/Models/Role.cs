using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelTakipUygulamasi_Asp.Net_Core.Models
{
    public class Role
    {
        [Key]
        [Required]
        public int RoleId { get; set; }
        [Required]
        public int RoleName { get; set; }
        public Employee Employee { get; set; }
    }
}

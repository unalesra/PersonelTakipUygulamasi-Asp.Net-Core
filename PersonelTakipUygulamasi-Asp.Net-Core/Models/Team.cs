using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelTakipUygulamasi_Asp.Net_Core.Models
{
    public class Team
    {

        [Key]
        public int TeamId { get; set; }
      
        [Required]
        [StringLength(20)]
        public String TeamName { get; set; }
        
        [Required]
        public int TeamLeaderId { get; set; }


    }
}

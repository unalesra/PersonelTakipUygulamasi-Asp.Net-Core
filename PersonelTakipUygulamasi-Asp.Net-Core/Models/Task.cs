using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelTakipUygulamasi_Asp.Net_Core.Models
{
    public class Task
    {
        [Key]
        public int TaskId { get; set; }

        [Required]
        [StringLength(50)]
        public String TaskName { get; set; }

        [Required]
        [StringLength(500)]
        public String TaskContent { get; set; }

        [Required]
        public bool Status { get; set; }  

        [Required]
        public bool Approval { get; set; } //approved by the admin as Done

        [Required]
        public bool Done { get; set; } // marked by teamleader as Done


        public int? teamId { get; set; }

        public Team Team { get; set; }
    }
}

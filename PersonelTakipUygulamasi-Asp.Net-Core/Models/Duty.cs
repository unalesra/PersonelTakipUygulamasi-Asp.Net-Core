using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelTakipUygulamasi_Asp.Net_Core.Models
{
    public class Duty
    {
        [Key]
        public int DutyId { get; set; }

        [Required]
        [StringLength(50)]
        public String DutyName { get; set; }

        [Required]
        [StringLength(500)]
        public String DutyContent { get; set; }

        [Required]
        public float ChangePerUnit { get; set; }

        [Required]
        public bool Status { get; set; }

        [Required]
        public bool Approval { get; set; } //approved by the teamleader as done

        [Required]
        public bool Done { get; set; } // marked by employee as done

        public int TaskId { get; set; }
        public Task Tasks { get; set; } 
    }
}

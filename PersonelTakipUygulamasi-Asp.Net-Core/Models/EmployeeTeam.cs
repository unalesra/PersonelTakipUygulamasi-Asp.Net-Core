using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelTakipUygulamasi_Asp.Net_Core.Models
{
    public class EmployeeTeam
    {

        [Key]
        public int EmployeeTeamId { get; set; }
        public Employee Employee { get; set; }
        public int? EmployeeId { get; set; }
        public Team Team { get; set; }
        public int? TeamId { get; set; }
    }
}

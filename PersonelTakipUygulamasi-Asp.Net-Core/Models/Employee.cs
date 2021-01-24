using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelTakipUygulamasi_Asp.Net_Core.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        public String EmployeeName { get; set; }

        [Required]
        public String EmployeeLastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public String EmployeeEmail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public String EmployeePassword { get; set; }
        
        [Required]
        public bool Status { get; set; }

        public Role Role { get; set; }

        public int RoleId { get; set; }

        public Genre Genre { get; set; }

    }
}

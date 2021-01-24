using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelTakipUygulamasi_Asp.Net_Core.Models
{
    public class EmployeeTasks
    {
        [Key]
        public int EmployeeTasksId { get; set; }
        public Employee Employee { get; set; }
        public int? EmployeeId { get; set; }
        public Task Task { get; set; }
        public int? TaskId { get; set; }

    }
}

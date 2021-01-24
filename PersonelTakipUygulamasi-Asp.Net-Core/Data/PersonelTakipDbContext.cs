using Microsoft.EntityFrameworkCore;
using PersonelTakipUygulamasi_Asp.Net_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task = PersonelTakipUygulamasi_Asp.Net_Core.Models.Task;

namespace PersonelTakipUygulamasi_Asp.Net_Core.Data
{
        public class PersonelTakipDbContext : DbContext
        {
            public PersonelTakipDbContext(DbContextOptions<PersonelTakipDbContext> options) : base(options)
            {

            }

            public DbSet<Employee> Employees { get; set; }
            public DbSet<Role> Roles { get; set; }
            public DbSet<EmployeeTasks> EmployeeTasks { get; set; }
            public DbSet<Task> Tasks { get; set; }
            public DbSet<Duty> Duties { get; set; }
            public DbSet<Team> Teams { get; set; }
            public DbSet<EmployeeTeam> EmployeeTeams { get; set; }



    }

}

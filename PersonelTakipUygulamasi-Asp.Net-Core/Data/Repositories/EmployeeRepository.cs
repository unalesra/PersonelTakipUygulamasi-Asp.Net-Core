using Microsoft.EntityFrameworkCore;
using PersonelTakipUygulamasi_Asp.Net_Core.Core.Repositories;
using PersonelTakipUygulamasi_Asp.Net_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelTakipUygulamasi_Asp.Net_Core.Data.Repositories
{
    public class EmployeeRepository: Repository<Employee>, IEmployeeRepository
    {
        private readonly PersonelTakipDbContext _personelTakipDbContext;
        public EmployeeRepository(PersonelTakipDbContext personelTakipDbContext): base(personelTakipDbContext) { }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await _personelTakipDbContext.Employees.ToListAsync();
        }
    }
}

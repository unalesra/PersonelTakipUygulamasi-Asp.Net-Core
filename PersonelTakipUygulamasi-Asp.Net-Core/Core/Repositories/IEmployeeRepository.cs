using PersonelTakipUygulamasi_Asp.Net_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelTakipUygulamasi_Asp.Net_Core.Core.Repositories
{
    public interface IEmployeeRepository: IRepository<Employee>
    {
        Task<IEnumerable<Employee>> GetEmployees();
    }
}

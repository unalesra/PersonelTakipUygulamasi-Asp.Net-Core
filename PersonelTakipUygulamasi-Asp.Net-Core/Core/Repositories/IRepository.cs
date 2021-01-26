using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakipUygulamasi_Asp.Net_Core.Core.Repositories
{
    public interface IRepository<TEntity> where TEntity: class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}

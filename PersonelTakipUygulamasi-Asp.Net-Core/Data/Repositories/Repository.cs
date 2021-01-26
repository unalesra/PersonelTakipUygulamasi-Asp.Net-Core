using Microsoft.EntityFrameworkCore;
using PersonelTakipUygulamasi_Asp.Net_Core.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelTakipUygulamasi_Asp.Net_Core.Data.Repositories
{
    public class Repository<TEntity>: IRepository<TEntity> where TEntity: class
    {
        protected readonly PersonelTakipDbContext personelTakipDbContext;

        public Repository(PersonelTakipDbContext _personelTakipDbContext)
        {
            this.personelTakipDbContext = _personelTakipDbContext;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await personelTakipDbContext.Set<TEntity>().ToListAsync();
        }
    }
}

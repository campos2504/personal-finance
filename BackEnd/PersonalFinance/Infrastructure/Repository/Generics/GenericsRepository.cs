using Domain.Interfaces.Generics;
using Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Generics
{
    public class GenericsRepository<T> : IGenerics<T> where T : class
    {
        private readonly DbContextOptions<BaseContext> _OptionsBuider;
        public GenericsRepository()
        {
            _OptionsBuider = new DbContextOptions<BaseContext>();
        }
        public async Task Add(T Object)
        {
            using (var data = new BaseContext(_OptionsBuider))
            {
                await data.Set<T>().AddAsync(Object);
                await data.SaveChangesAsync();
            }
        }

        public async Task<List<T>> All()
        {
            using (var data = new BaseContext(_OptionsBuider))
            {
                return await data.Set<T>().ToListAsync();
            }
        }

        public async Task Delete(T Object)
        {
            using (var data = new BaseContext(_OptionsBuider))
            {
                data.Set<T>().Remove(Object);
                await data.SaveChangesAsync();
            }
        }

        public async Task<T> GetEntityByID(int id)
        {
            using (var data = new BaseContext(_OptionsBuider))
            {
                return await data.Set<T>().FindAsync(id);
            }
        }

        public async Task Update(T Object)
        {
            using (var data = new BaseContext(_OptionsBuider))
            {
                data.Set<T>().Update(Object);
                await data.SaveChangesAsync();
            }
        }
    }
   
}

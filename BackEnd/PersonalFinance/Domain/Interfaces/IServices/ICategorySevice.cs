using Entities.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.IServices
{
    public interface ICategorySevice
    {
        Task AddCategiory(Category category);

        Task UpdateCategiory(Category category);
    }
}

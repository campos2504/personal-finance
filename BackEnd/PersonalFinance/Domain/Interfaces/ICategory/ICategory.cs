﻿using Domain.Interfaces.Generics;
using Entities.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.ICategory
{
    public interface ICategory : IGenerics<Category>
    {
        Task<IList<Category>> UserCategoriesList(string email);

    }
}

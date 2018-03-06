﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DShop.Services.Storage.Models.Products;

namespace DShop.Services.Storage.Repositories
{
    public interface IProductsRepository
    {
        Task<Product> GetAsync(Guid id);
        Task<IEnumerable<Product>> FindAsync(Expression<Func<Product, bool>> predicate);
        Task CreateAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(Guid id);
    }
}

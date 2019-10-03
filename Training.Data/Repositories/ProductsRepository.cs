﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Training.API.Contracts;
using Training.Data.Extensions;

namespace Training.Data.Repositories
{
    class ProductsRepository : IProductsRepository
    {
        private readonly StoreContext _StoreContext;
        public ProductsRepository(StoreContext storeContext)
        {
            _StoreContext = storeContext;
        }
        public async Task<List<DTO.Product>> GetAll()
        {
            var products = await _StoreContext.Products.ToListAsync();
            return products.Select(s => s.toDTO()).ToList();
        }
    }
}

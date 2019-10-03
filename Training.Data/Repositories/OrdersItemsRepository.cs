using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.API.Contracts;
using Training.Data.Extensions;
using Training.DTO;

namespace Training.Data.Repositories
{
    class OrdersItemsRepository : IOrdersItemsRepository
    {
        private readonly StoreContext _StoreContext;
        public OrdersItemsRepository(StoreContext storeContext)
        {
            _StoreContext = storeContext;
        }
        public async Task<List<DTO.Order_Item>> GetAll()
        {
            var orderProduct = await _StoreContext.OrdersItems.ToListAsync();
            return orderProduct.Select(s => s.ToDTO()).ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Training.API.Contracts;

namespace Training.API.Operations
{
    public class GetOrdersItems
    {
        private readonly IOrdersItemsRepository _OrdersItemsRepository;

        public GetOrdersItems(IOrdersItemsRepository orderItemRepository)
        {
            _OrdersItemsRepository = orderItemRepository;
        }

        public async Task<List<DTO.Order_Item>> Execute()
        {
            return await _OrdersItemsRepository.GetAll();
        }
    }
}

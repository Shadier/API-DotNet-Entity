using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Training.API.Operations;

namespace Training.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersItemsController : ControllerBase
    {
        private readonly IServiceProvider _IoC;

        public OrdersItemsController(IServiceProvider service)
        {
            _IoC = service;
        }
        [HttpGet]
        public async Task<List<DTO.Order_Item>> GetProducts()
        {
            return await _IoC.GetService<GetOrdersItems>().Execute();
        }
    }
}
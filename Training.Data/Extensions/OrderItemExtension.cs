using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Data.Extensions
{
    public static class OrderProductExtension
    {
        public static DTO.Order_Item ToDTO(this Models.OrderItem oi)
        {
            DTO.Product product = new DTO.Product();
            return new DTO.Order_Item
            {
                id = oi.Id,
                product = oi.ProductId,
                quantity = oi.Quantity,

            };
        }

        public static Models.OrderItem ToDatabaseModel(this DTO.Order_Item oi)
        {
            return new Models.OrderItem
            {
                Id = oi.id,
                ProductId = oi.product,
                Quantity = oi.quantity,

            };

        }
    }
}

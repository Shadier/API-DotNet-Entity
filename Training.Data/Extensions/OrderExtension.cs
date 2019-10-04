using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Data.Extensions
{
    public static class OrderExtension
    {
        public static DTO.Order ToDTO(this Models.Order order)
        {
            return new DTO.Order
            {
                Id = order.Id,
                user = order.UserId,
                status = order.Status,
                created_at = order.Created_at
            };
        }

        public static Models.Order ToDatabaseModel(this DTO.Order order)
        {
            return new Models.Order
            {
                Id = order.Id,
                UserId = order.user,
                Status = order.status,
                Created_at = order.created_at
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Data.Extensions
{
    public static class ProductExtension
    {
        public static DTO.Product toDTO(this Models.Product product)
        {
            return new DTO.Product
            {
                Id = product.Id,
                name = product.Name,
                price = product.Price,
                merchant_id = product.Merchant_id,
                status = product.Status,
                created_at = product.Created_at,
            };
        }

        public static Models.Product ToDatabaseModel(this DTO.Product product)
        {
            return new Models.Product
            {
                Id = product.Id,
                Name = product.name,
                Price = product.price,
                Merchant_id = product.merchant_id,
                Status = product.status,
                Created_at = product.created_at,
            };
        }

    }
}


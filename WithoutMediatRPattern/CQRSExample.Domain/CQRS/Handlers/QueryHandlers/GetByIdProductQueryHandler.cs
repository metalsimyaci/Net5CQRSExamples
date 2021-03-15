using System;
using System.Linq;
using CQRSExample.Domain.CQRS.Queries.Request;
using CQRSExample.Domain.CQRS.Queries.Response;

namespace CQRSExample.Domain.CQRS.Handlers.QueryHandlers
{
    public class GetByIdProductQueryHandler
    {
        public GetByIdProductQueryResponse GetByIdProduct(GetByIdProductQueryRequest getByIdProductQueryRequest)
        {
            var product = ApplicationDbContext.ProductList.FirstOrDefault(s => s.Id == getByIdProductQueryRequest.Id);
            if (product == null)
                throw new ArgumentNullException("Product Not Found");
            
            return new GetByIdProductQueryResponse
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity,
                CreateTime = product.CreateTime
            };
        }
    }
}
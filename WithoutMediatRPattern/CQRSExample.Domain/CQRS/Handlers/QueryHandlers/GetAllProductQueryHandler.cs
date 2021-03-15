using System.Collections.Generic;
using System.Linq;
using CQRSExample.Domain.CQRS.Queries.Request;
using CQRSExample.Domain.CQRS.Queries.Response;

namespace CQRSExample.Domain.CQRS.Handlers.QueryHandlers
{
    public class GetAllProductQueryHandler
    {
        public List<GetAllProductQueryResponse> GetAllProduct(GetAllProductQueryRequest getAllProductQueryRequest)
        {
            return ApplicationDbContext.ProductList.Select(product => new GetAllProductQueryResponse
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity,
                CreateTime = product.CreateTime
            }).ToList();
        }
    }
}
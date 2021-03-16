using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CQRSExample.Domain.Abstraction;
using CQRSExample.Domain.CQRS.Queries.Request;
using CQRSExample.Domain.CQRS.Queries.Response;

namespace CQRSExample.Domain.CQRS.Handlers.QueryHandlers
{
    public class GetAllProductQueryHandler:IRequestHandle<GetAllProductQueryRequest,List<GetAllProductQueryResponse>>
    {
        public async Task<List<GetAllProductQueryResponse>> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
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
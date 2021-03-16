using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CQRSExample.Domain.Abstraction;
using CQRSExample.Domain.CQRS.Queries.Request;
using CQRSExample.Domain.CQRS.Queries.Response;

namespace CQRSExample.Domain.CQRS.Handlers.QueryHandlers
{
    public class GetByIdProductQueryHandler:IRequestHandle<GetByIdProductQueryRequest,GetByIdProductQueryResponse>
    {
        public async Task<GetByIdProductQueryResponse> Handle(GetByIdProductQueryRequest request, CancellationToken cancellationToken)
        {
            var product = ApplicationDbContext.ProductList.FirstOrDefault(s => s.Id == request.Id);
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
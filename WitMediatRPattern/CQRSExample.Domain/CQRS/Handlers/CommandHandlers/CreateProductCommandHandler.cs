using System;
using System.Threading;
using System.Threading.Tasks;
using CQRSExample.Domain.CQRS.Commands.Request;
using CQRSExample.Domain.CQRS.Commands.Response;
using CQRSExample.Domain.Entities;
using MediatR;

namespace CQRSExample.Domain.CQRS.Handlers.CommandHandlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {
        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest createProductCommandRequest,CancellationToken cancellationToken)
        {
            var id = Guid.NewGuid();
            ApplicationDbContext.ProductList.Add(new Product
            {
                Id = id,
                Name = createProductCommandRequest.Name,    
                Price = createProductCommandRequest.Price,
                Quantity = createProductCommandRequest.Quantity,
                CreateTime = DateTime.Now
            });
            return new CreateProductCommandResponse
            {
                IsSuccess = true,
                ProductId = id
            };
        }
    }
}
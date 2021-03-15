using System;
using CQRSExample.Domain.CQRS.Commands.Request;
using CQRSExample.Domain.CQRS.Commands.Response;
using CQRSExample.Domain.Entities;

namespace CQRSExample.Domain.CQRS.Handlers.CommandHandlers
{
    public class CreateProductCommandHandler
    {
        public CreateProductCommandResponse CreateProduct(CreateProductCommandRequest createProductCommandRequest)
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
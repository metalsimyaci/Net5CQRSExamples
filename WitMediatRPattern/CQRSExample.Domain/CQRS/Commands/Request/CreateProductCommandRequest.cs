using CQRSExample.Domain.Abstraction;
using CQRSExample.Domain.CQRS.Commands.Response;

namespace CQRSExample.Domain.CQRS.Commands.Request
{
    public class CreateProductCommandRequest:IRequest<CreateProductCommandResponse>
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
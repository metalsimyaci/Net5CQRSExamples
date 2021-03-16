using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CQRSExample.Domain.CQRS.Commands.Request;
using CQRSExample.Domain.CQRS.Commands.Response;
using MediatR;

namespace CQRSExample.Domain.CQRS.Handlers.CommandHandlers
{
    public class DeleteProductCommandHandler:IRequestHandler<DeleteProductCommandRequest,DeleteProductCommandResponse>
    {
        public async Task<DeleteProductCommandResponse> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            var deleteProduct =
                ApplicationDbContext.ProductList.FirstOrDefault(x => x.Id == deleteProductCommandRequest.Id);
            ApplicationDbContext.ProductList.Remove(deleteProduct);
            return new DeleteProductCommandResponse
            {
                IsSuccess = true
            };
        }
    }
}
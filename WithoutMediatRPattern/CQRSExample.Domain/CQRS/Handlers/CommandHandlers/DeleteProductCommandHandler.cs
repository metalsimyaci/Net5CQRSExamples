using System.Linq;
using CQRSExample.Domain.CQRS.Commands.Request;
using CQRSExample.Domain.CQRS.Commands.Response;

namespace CQRSExample.Domain.CQRS.Handlers.CommandHandlers
{
    public class DeleteProductCommandHandler
    {
        public DeleteProductCommandResponse DeleteProduct(DeleteProductCommandRequest deleteProductCommandRequest)
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
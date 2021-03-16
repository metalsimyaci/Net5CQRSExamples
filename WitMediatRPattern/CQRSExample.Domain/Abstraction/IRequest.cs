using MediatR;

namespace CQRSExample.Domain.Abstraction
{
    public interface IRequest<out TResponse>:IBaseRequest
    {
        
    }
}
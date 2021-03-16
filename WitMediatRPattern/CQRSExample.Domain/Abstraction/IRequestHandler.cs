using System.Threading;
using System.Threading.Tasks;

namespace CQRSExample.Domain.Abstraction
{
    public interface IRequestHandle<in TRequest, TResponse> where TRequest:IRequest<TResponse>
    {
        Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
    }
}
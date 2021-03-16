using System;
using CQRSExample.Domain.Abstraction;
using CQRSExample.Domain.CQRS.Commands.Response;

namespace CQRSExample.Domain.CQRS.Commands.Request
{
    public class DeleteProductCommandRequest:IRequest<DeleteProductCommandResponse>
    {
        public Guid Id { get; set; }    
    }
}
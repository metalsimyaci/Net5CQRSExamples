using System;

namespace CQRSExample.Domain.CQRS.Commands.Request
{
    public class DeleteProductCommandRequest
    {
        public Guid Id { get; set; }    
    }
}
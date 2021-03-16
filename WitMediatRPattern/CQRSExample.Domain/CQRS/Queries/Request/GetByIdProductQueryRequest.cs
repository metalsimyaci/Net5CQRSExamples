using System;
using CQRSExample.Domain.Abstraction;
using CQRSExample.Domain.CQRS.Queries.Response;

namespace CQRSExample.Domain.CQRS.Queries.Request
{
    public class GetByIdProductQueryRequest:IRequest<GetByIdProductQueryResponse>
    {
        public Guid Id { get; set; }
    }
}
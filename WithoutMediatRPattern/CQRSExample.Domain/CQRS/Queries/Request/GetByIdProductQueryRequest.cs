using System;

namespace CQRSExample.Domain.CQRS.Queries.Request
{
    public class GetByIdProductQueryRequest
    {
        public Guid Id { get; set; }
    }
}
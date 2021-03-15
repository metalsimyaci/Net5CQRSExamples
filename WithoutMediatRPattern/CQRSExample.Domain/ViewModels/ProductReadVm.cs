using System;

namespace CQRSExample.Domain.ViewModels
{
    public class ProductReadVm
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
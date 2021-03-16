using System;
using System.Collections.Generic;
using CQRSExample.Domain.Entities;

namespace CQRSExample.Domain
{
    public static class ApplicationDbContext
    {
        private static List<Product> _productList = new List<Product>
        {
            new Product
            {
                Id = Guid.NewGuid(), Name = "Product 1", Price = 100, Quantity = 10, CreateTime = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(), Name = "Product 1", Price = 200, Quantity = 20, CreateTime = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(), Name = "Product 1", Price = 300, Quantity = 30, CreateTime = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(), Name = "Product 1", Price = 400, Quantity = 40, CreateTime = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(), Name = "Product 1", Price = 500, Quantity = 50, CreateTime = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(), Name = "Product 1", Price = 600, Quantity = 60, CreateTime = DateTime.Now
            },
        };

        public static List<Product> ProductList => _productList;
    }
}
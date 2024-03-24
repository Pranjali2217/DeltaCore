// ProductsService.cs
using System.Collections.Generic;

namespace DeltaCore.Models
{
    public class ProductsService
    {
        public IEnumerable<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { ProductId = 1001, Name = "Tools Gears", Description = "Gear tools production specification" },
                new Product { ProductId = 2001, Name = "Panels", Description = "Switch Gear Panels" },
                new Product { ProductId = 2008, Name = "DocTonar", Description = "Document Solar Objects" }
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductCatalog.API.Domain;

namespace ProductCatalog.API.Data
{
    public class ProductCatalogContext : DbContext
    {
        public ProductCatalogContext (DbContextOptions<ProductCatalogContext> options)
            : base(options)
        {
        }

        public DbSet<ProductCatalog.API.Domain.CatalogType> CatalogTypes { get; set; }

        public DbSet<ProductCatalog.API.Domain.CatalogBrand> CatalogBrands { get; set; }

        public DbSet<ProductCatalog.API.Domain.CatalogItem> CatalogItems { get; set; }
    }
}

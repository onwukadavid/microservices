using ProductCatalog.API.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalog.API.Data
{
    public class ProductCatalogSeed
    {
        public static async Task SeedAsync(ProductCatalogContext context)
        {
            if (!context.CatalogBrands.Any())
            {
                context.CatalogBrands.AddRange(GetPreconfiguredCatalogBrands());
                    await context.SaveChangesAsync();
            }
            if (!context.CatalogTypes.Any())
            {
                context.CatalogTypes.AddRange(GetPreconfiguredCatalogTypes());
                    await context.SaveChangesAsync();
            }
            if (!context.CatalogItems.Any())
            {
                context.CatalogItems.AddRange(GetPreconfiguredCatalogItems());
                    await context.SaveChangesAsync();
            }

        }
        static IEnumerable<CatalogBrand> GetPreconfiguredCatalogBrands()
        {
            return new List<CatalogBrand>()
        {
                new CatalogBrand() { Brand = "Addidas"},
                new CatalogBrand() { Brand = "Puma"},
                new CatalogBrand() { Brand = "Nike"}
        };
        }

        static IEnumerable<CatalogType> GetPreconfiguredCatalogTypes()
        {
            return new List<CatalogType>()
        {
                new CatalogType() { Type = "Running"},
                new CatalogType() { Type = "Basketball"},
                new CatalogType() { Type = "Tennis"}
        };
        }

        static IEnumerable<CatalogItem> GetPreconfiguredCatalogItems()
        {
            return new List<CatalogItem>()
        {
                    new CatalogItem() {CatalogTypeId=2,CatalogBrandId=3,Description="Shoes for next century",Name="World Star",Price=199.5M,PictureUrl=""},
                    new CatalogItem() {CatalogTypeId=1,CatalogBrandId=2,Description="Will Make You World Champion",Name="White Line",Price=88.5M,PictureUrl=""},
                    new CatalogItem() {CatalogTypeId=2,CatalogBrandId=3,Description="You have already won god medal",Name="Prism White Shoes",Price=129,PictureUrl=""},
                    new CatalogItem() {CatalogTypeId=2,CatalogBrandId=2,Description="Olympic runner",Name="Foundation Hitech",Price=12,PictureUrl=""},
                    new CatalogItem() {CatalogTypeId=2,CatalogBrandId=1,Description="Rosyln Red Sheet",Name="Roslyn White",Price=188.5M,PictureUrl=""},
                    new CatalogItem() {CatalogTypeId=2,CatalogBrandId=2,Description="Lala Land",Name="Blue Star",Price=112,PictureUrl=""},
                    new CatalogItem() {CatalogTypeId=2,CatalogBrandId=1,Description="High in the sky",Name="Roslyn Green",Price=212,PictureUrl=""},
                    new CatalogItem() {CatalogTypeId=1,CatalogBrandId=1,Description="Light as carbon",Name="Deep Purple",Price=238.5M,PictureUrl=""},
                    new CatalogItem() {CatalogTypeId=1,CatalogBrandId=2,Description="High jumper",Name="Addidas<White>Running",Price=129,PictureUrl=""},
                    new CatalogItem() {CatalogTypeId=2,CatalogBrandId=3,Description="Dunker",Name="Elequent",Price=12,PictureUrl=""},
                    new CatalogItem() {CatalogTypeId=1,CatalogBrandId=2,Description="All round",Name="Incredible",Price=248.5M,PictureUrl=""},
                    new CatalogItem() {CatalogTypeId=2,CatalogBrandId=1,Description="Priceless",Name="London Sky",Price=412,PictureUrl=""},
                    new CatalogItem() {CatalogTypeId=3,CatalogBrandId=3,Description="Tennis Star",Name="Elequent",Price=123,PictureUrl=""},
                    new CatalogItem() {CatalogTypeId=3,CatalogBrandId=2,Description="Wimbeldon",Name="London Star",Price=218.5M,PictureUrl=""},
                    new CatalogItem() {CatalogTypeId=3,CatalogBrandId=1,Description="Roland Garros",Name="Paris Blue",Price=312,PictureUrl=""}
        };
        }
    }
}

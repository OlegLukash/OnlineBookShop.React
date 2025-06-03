using Microsoft.EntityFrameworkCore;
using OnlineBookShop.Infrastructure.Persistance.Contexts;

namespace OnlineBookShop.Infrastructure.Persistance.DataSeed
{
    public class SeedFacade
    {
        public static async Task SeedData(OnlineBookShopDbContext onlineBookShopDbContext)
        {
            onlineBookShopDbContext.Database.Migrate();

            await PublishersSeed.Seed(onlineBookShopDbContext);
            await BooksSeed.Seed(onlineBookShopDbContext);
        }
    }
}

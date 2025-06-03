using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnlineBookShop.Application.Common.Interfaces;
using OnlineBookShop.Application.Common.Interfaces.Repositories;
using OnlineBookShop.Infrastructure.Persistance.Contexts;
using OnlineBookShop.Infrastructure.Persistance.Repositories;

namespace OnlineBookShop.Infrastructure.Persistance.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<OnlineBookShopDbContext>(optionBuilder =>
            {
                optionBuilder.UseSqlServer(configuration.GetConnectionString("OnlineBookShopConnection"));
            });

            services.AddScoped<IUnitOfWork>(serviceProvider => serviceProvider.GetRequiredService<OnlineBookShopDbContext>());
            services.AddScoped<IRepository, EFCoreRepository>();
            services.AddScoped<IBookRepository, BookRepository>();

            return services;
        }
    }
    
}

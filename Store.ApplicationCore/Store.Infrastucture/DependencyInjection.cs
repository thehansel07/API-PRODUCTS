using Microsoft.Extensions.DependencyInjection;
using Store.ApplicationCore.Interfaces;
using Store.Infrastucture.Persistence.Contexts;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Infrastucture.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Store.Infrastucture
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var defaultConnectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<StoreContext>(options =>
               options.UseSqlServer(defaultConnectionString));

            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }
    }
}

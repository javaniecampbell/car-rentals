using Microsoft.Extensions.DependencyInjection;
using shopping_cart.Repositories;
using shopping_cart.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopping_cart
{
    public static class ServiceCollectionExtentions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            // One line
            services.AddTransient<ICartsRepository, CartsRepository>();
            //services.AddTransient<ICartsRepository, MongoDBCartsRespository>();
            return services;
        }

        public static IServiceCollection AddAppServices(this IServiceCollection services)
        {
            services.AddTransient<ICartsService, CartsService>();
            return services;
        }
    }
}

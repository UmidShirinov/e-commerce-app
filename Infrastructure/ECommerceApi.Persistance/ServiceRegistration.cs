using ECommerceApi.Application.Repositories;
using ECommerceApi.Persistance.Contexts;
using ECommerceApi.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Persistance
{
    public static class ServiceRegistration
    {

        public static void AddPersistanceService(this IServiceCollection services)
        {

            services.AddDbContext<ECommerceAPIDbContext>(options => options.UseNpgsql(Configurations.ConnectionString ),ServiceLifetime.Singleton);

            services.AddSingleton<ICustomerReadRepository, CustomerReadRepository>();
            services.AddSingleton<ICustomerWriteRepository, CustomerWriteRepository>(); 
            services.AddSingleton<IOrdersWriteRepository, OrderWriteRepository>();

        }

    }
}

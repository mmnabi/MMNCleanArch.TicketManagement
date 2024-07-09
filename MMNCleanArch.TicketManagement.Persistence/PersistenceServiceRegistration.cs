using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MMNCleanArch.TicketManagement.Application.Contracts.Persistence;
using MMNCleanArch.TicketManagement.Persistence.Repositories;

namespace MMNCleanArch.TicketManagement.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FirstRowTicketsDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("FirstRowTicketsTicketManagementConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();

            return services;
        }
    }
}

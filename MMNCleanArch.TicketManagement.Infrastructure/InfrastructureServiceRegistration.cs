using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MMNCleanArch.TicketManagement.Application.Contracts.Infrastructure;
using MMNCleanArch.TicketManagement.Application.Models.Mail;
using MMNCleanArch.TicketManagement.Infrastructure.Mail;

namespace MMNCleanArch.TicketManagement.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));

            services.AddTransient<IEmailService, EmailService>();

            return services;
        }
    }
}

using Application.Contracts.Infrastructure;
using Application.Models;
using Infrastructure.FileExport;
using Infrastructure.Identity;
using Infrastructure.Mail;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace Infrastructure;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));

        // services.AddTransient<ICsvExporter, CsvExporter>();
        services.Configure<JWT>(configuration.GetSection("JWT"));
        services.AddTransient<IEmailService, EmailService>();

        return services;
    }
}

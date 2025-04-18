using Domain.Repository;
using Infrastructure.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IHostApplicationBuilder AddInfrastructureServices(this IHostApplicationBuilder builder, IConfiguration configuration)
    {
        builder.Services.AddScoped<IHomeRepository, HomeRepository>();
        return builder;
    }
}

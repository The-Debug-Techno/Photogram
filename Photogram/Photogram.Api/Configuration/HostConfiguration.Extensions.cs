using Microsoft.EntityFrameworkCore;
using Photogram.Persistence.DataContext;
using Photogram.Persistence.Repositories.UserRepository;

namespace Photogram.Api.Configuration;

public static partial class HostConfiguration
{
    private static WebApplicationBuilder AddSettingConfigurations(this WebApplicationBuilder builder)
    {
        //  add settings configurations

        builder.Services.AddDbContext<AppDbContext>(option =>
        option.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

        return builder;
    }

    private static WebApplicationBuilder AddInfrastructures(this WebApplicationBuilder builder)
    {
        // add service

        builder.Services
            .AddScoped<IUserRepository, UserRepository>();

        return builder;
    } 
}

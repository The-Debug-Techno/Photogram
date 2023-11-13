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
    private static WebApplicationBuilder AddDevTools(this WebApplicationBuilder builder)
    {
        builder.Services.AddSwaggerGen();
        builder.Services.AddEndpointsApiExplorer();

        /*
         ADD THIS TO YOUR API USER SECRETS 
         
         "ConnectionStrings": {
       "DefaultConnection":
        "Host=localhost;Port=5432;Database=Photogram;Username=[YOUR USERNAME];Password=[YOUR PASSWORD]"
        }
         
         
         */

        return builder;
    }
    private static WebApplicationBuilder AddInfrastructures(this WebApplicationBuilder builder)
    {
        // add service

        builder.Services
            .AddScoped<IUserRepository, UserRepository>();

        builder.Services.AddControllers();

        return builder;
    } 
    private static WebApplication UseDevtools(this WebApplication app)
    {
        app.UseSwagger();
        app.UseSwaggerUI();

        return app;
    }
    private static WebApplication UseControllers(this WebApplication app)
    {
        app.MapControllers();

        return app;
    }

}

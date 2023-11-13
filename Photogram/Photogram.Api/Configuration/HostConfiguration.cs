using System.Runtime.CompilerServices;

namespace Photogram.Api.Configuration;

public static partial class HostConfiguration
{
    public static ValueTask<WebApplicationBuilder> ConfigureAsync(this WebApplicationBuilder builder)
    {
        builder
            .AddSettingConfigurations()
            .AddInfrastructures()
            .AddDevTools();

        return new(builder);
    }
    public static ValueTask<WebApplication> ConfigureAsync(this WebApplication app)
    {
        app
            .UseDevtools()
            .UseControllers();

        return new(app);
    }
}

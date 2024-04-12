using Microsoft.EntityFrameworkCore;
using PlatformService.Data;

namespace PlatformService.Extensions;

public static class ServicesExtensions
{
    public static void ConfigureInMemoryDb(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseInMemoryDatabase("InMem"));
    }
}
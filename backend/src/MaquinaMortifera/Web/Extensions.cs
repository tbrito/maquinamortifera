using MaquinaMortifera.Infra.Database;
using MaquinaMortifera.Infra.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Web
{
    public static class Extensions
    {
        public static void AddContext(this IServiceCollection services)
        {
            var configuration = services.BuildServiceProvider().GetRequiredService<IConfiguration>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContextMigrate<MaquinaMortiferaContext>(options => options.UseSqlServer(connectionString));
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Scrutor;
using System;
using System.Linq;
using System.Reflection;

namespace MaquinaMortifera.Infra.Services
{
    public static class ServiceCollectionExtensions
    {
        public static void AddClassesMatchingInterfaces(
            this IServiceCollection services, 
            params Assembly[] assemblies)
        {
            services.Scan(scan => scan
                .FromAssemblies(assemblies)
                .AddClasses()
                .UsingRegistrationStrategy(RegistrationStrategy.Skip)
                .AsMatchingInterface()
                .WithScopedLifetime());
        }

        public static void ApplyConfigurationsFromAssembly(this ModelBuilder modelBuilder)
        {
            static bool Expression(Type type) => type.IsGenericType && 
                type.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>);

            var types = Assembly.GetCallingAssembly().GetTypes().
                Where(type => type.GetInterfaces().Any(Expression)).ToList();

            foreach (var configuration in types.Select(Activator.CreateInstance))
            {
                modelBuilder.ApplyConfiguration((dynamic)configuration);
            }
        }

        public static void AddDbContextMigrate<T>(
            this IServiceCollection services, 
            Action<DbContextOptionsBuilder> options) where T : DbContext
        {
            services.AddDbContextPool<T>(options);
            services.BuildServiceProvider().GetRequiredService<T>().Database.Migrate();
        }
    }
}

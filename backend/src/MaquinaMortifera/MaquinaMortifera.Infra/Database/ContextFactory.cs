using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace MaquinaMortifera.Infra.Database
{
    public sealed class ContextFactory : IDesignTimeDbContextFactory<MaquinaMortiferaContext>
    {
        public MaquinaMortiferaContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            var builder = new DbContextOptionsBuilder<MaquinaMortiferaContext>();

            builder.UseSqlServer(connectionString);

            return new MaquinaMortiferaContext(builder.Options);
        }
    }
}

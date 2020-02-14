using MaquinaMortifera.Infra.Services;
using Microsoft.EntityFrameworkCore;

namespace MaquinaMortifera.Infra.Database
{
    public sealed class MaquinaMortiferaContext : DbContext
    {
        public MaquinaMortiferaContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly();
        }
    }
}

using MaquinaMoritifera.Model.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MaquinaMortifera.Infra.Mappings
{
    public sealed class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuario");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();
            
            builder.Property(x => x.Login)
                .HasColumnName("login");

            builder.Property(x => x.Senha)
                .HasColumnName("senha");

            builder.Property(x => x.Nome)
                .HasColumnName("nome");
        }
    }
}

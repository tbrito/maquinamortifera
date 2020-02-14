using MaquinaMoritifera.Model.Entidades;
using MaquinaMoritifera.Model.Repositorios;
using MaquinaMortifera.Infra.Database;

namespace MaquinaMortifera.Infra.Repositorios
{
    public sealed class UsuarioRepositorio : EntityFrameworkCoreRepository<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(MaquinaMortiferaContext context) : base(context)
        {
        }
    }
}

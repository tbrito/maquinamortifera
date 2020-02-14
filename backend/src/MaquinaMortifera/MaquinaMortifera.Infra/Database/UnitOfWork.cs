using System.Threading.Tasks;

namespace MaquinaMortifera.Infra.Database
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly MaquinaMortiferaContext _context;

        public UnitOfWork(MaquinaMortiferaContext context)
        {
            _context = context;
        }

        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}

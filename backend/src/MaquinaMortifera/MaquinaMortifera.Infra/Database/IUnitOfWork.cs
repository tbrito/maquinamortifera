using System.Threading.Tasks;

namespace MaquinaMortifera.Infra.Database
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();
    }
}

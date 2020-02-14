using System.Collections.Generic;
using System.Linq;
using MaquinaMoritifera.Model.Repositorios;
using Microsoft.EntityFrameworkCore;

namespace MaquinaMortifera.Infra.Database
{
    public class EntityFrameworkCoreQueryRepository<T> : IQueryRepository<T> where T : class
    {
        private readonly DbContext _context;

        public EntityFrameworkCoreQueryRepository(DbContext context)
        {
            _context = context;
        }

        public IQueryable<T> Queryable => _context.Set<T>().AsNoTracking();

        public IList<T> ObterTodos()
        {
            return Queryable.ToList();
        }
    }
}

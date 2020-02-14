using MaquinaMoritifera.Model.Repositorios;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace MaquinaMortifera.Infra.Database
{
    public class EntityFrameworkCoreRepository<T> : IRepository<T> where T : class
    {
        private readonly EntityFrameworkCoreQueryRepository<T> _entityFrameworkCoreQueryRepository;

        public EntityFrameworkCoreRepository(DbContext context)
        {
            _entityFrameworkCoreQueryRepository = new EntityFrameworkCoreQueryRepository<T>(context);
        }

        public IQueryable<T> Queryable => _entityFrameworkCoreQueryRepository.Queryable;

        public IList<T> ObterTodos()
        {
            return _entityFrameworkCoreQueryRepository.ObterTodos();
        }
    }
}

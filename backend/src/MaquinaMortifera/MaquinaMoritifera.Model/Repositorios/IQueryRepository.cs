using System.Collections.Generic;
using System.Linq;

namespace MaquinaMoritifera.Model.Repositorios
{
    public interface IQueryRepository<T> where T : class
    {
        IQueryable<T> Queryable { get; }

        IList<T> ObterTodos();
    }
}

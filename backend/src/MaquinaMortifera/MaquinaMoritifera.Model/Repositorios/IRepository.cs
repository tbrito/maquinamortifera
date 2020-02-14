namespace MaquinaMoritifera.Model.Repositorios
{
    public interface IRepository<T> : IQueryRepository<T> where T : class 
    { 
    }
}

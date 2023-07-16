using DesafioSoft.Core.Entities;

namespace DesafioSoft.Core.Interfaces.Services
{
    public interface IGenericService<T> where T : BaseEntity
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        string Add(T entity);
        string Update(T entity);
        string Delete(T entity);
    }
}

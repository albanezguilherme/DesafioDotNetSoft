using DesafioSoft.Core.Entities;
using DesafioSoft.Core.Interfaces.Repositories;
using DesafioSoft.Core.Interfaces.Services;

namespace DesafioSoft.Core.Services
{
    public class GenericService<T> : IGenericService<T> where T : BaseEntity
    {
        private readonly IGenericRepository<T> _genericRepository;

        public GenericService(IGenericRepository<T> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public string Add(T entity)
        {
            return _genericRepository.Add(entity);
        }

        public string Delete(T entity)
        {
            return _genericRepository.Delete(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _genericRepository.GetAll();
        }

        public T GetById(int id)
        {
            return _genericRepository.GetById(id);
        }

        public string Update(T entity)
        {
            return _genericRepository.Update(entity);
        }
    }
}

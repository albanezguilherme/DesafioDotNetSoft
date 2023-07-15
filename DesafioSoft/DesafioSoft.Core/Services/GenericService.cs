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

        public void Add(T entity)
        {
            _genericRepository.Add(entity);
        }

        public void Delete(int id)
        {
            _genericRepository.Delete(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _genericRepository.GetAll();
        }

        public T GetById(int id)
        {
            return _genericRepository.GetById(id);
        }

        public void Update(T entity)
        {
            _genericRepository.Update(entity);
        }
    }
}

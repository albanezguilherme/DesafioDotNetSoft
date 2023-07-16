using DesafioSoft.Core.Entities;
using DesafioSoft.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DesafioSoft.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly DbSet<T> _entities;
        private readonly DesafioSoftContext _context;

        public GenericRepository(DesafioSoftContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }

        public string Add(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
            return "Book added successfully";
        }

        public string Delete(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();

            return "Book removed successfully";
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.ToList();
        }

        public T GetById(int id)
        {
            return _entities.FirstOrDefault(e => e.Id == id);
        }

        public string Update(T entity)
        {
            _entities.Update(entity);
            _context.SaveChanges();

            return "Book updated successfully";
        }
    }
}

using DesafioSoft.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

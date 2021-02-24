using Pr1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pr1.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(Guid id);
        IEnumerable<T> GetAll();
        T Add(T entity);
    }
}

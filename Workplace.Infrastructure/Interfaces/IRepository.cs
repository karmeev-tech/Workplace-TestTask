using System.Collections.Generic;
using Workplace.Domain.User;

namespace Workplace.Infrastructure.Interfaces
{
    public interface IRepository<T>
    {
        T Get(string email);
        List<T> GetAll();
        T Create(User person);
        void Delete(string email);
        void Update(T entity);
    }
}

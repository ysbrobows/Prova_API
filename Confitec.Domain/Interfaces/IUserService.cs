using Confitec.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Confitec.Domain.Interfaces
{
    public interface IUserService
    {
        void Add(Usuario entity);
        void Update(Usuario entity);
        void Delete(int id);
        Task<List<Usuario>> GetUsers();
        Task<Usuario> GetUser(int id);
        Task<bool> SaveChangesAsync();
    }
}

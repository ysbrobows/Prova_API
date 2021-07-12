using Confitec.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Confitec.Domain.Interfaces
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();
        Task<Usuario[]> GetUsers();
        Task<Usuario> GetUser(int UsuarioId);
    }
}

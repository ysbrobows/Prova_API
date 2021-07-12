
//using Confitec.Domain.Entities;
//using Confitec.Domain.Interfaces;
//using System;
//using System.Threading.Tasks;

//namespace Confitec.Service.Services
//{
//    public class UserService : IRepository
//    {
//        private readonly IRepository _repo;

//        public UserService(IRepository repo)
//        {
//            _repo = repo;
//        }
//        void IRepository.Add<T>(T entity)
//        {
//            _repo.Add(entity);
//        }

//        void IRepository.Delete<T>(T entity)
//        {
//            _repo.Delete(entity);
//        }

//        async Task<Usuario> IRepository.GetUser(int UsuarioId)
//        {
//            return await _repo.GetUser(UsuarioId);
//        }

//        async Task<Usuario[]> IRepository.GetUsers()
//        {
//            return await _repo.GetUsers();
//        }

//        async Task<bool> IRepository.SaveChangesAsync()
//        {
//            return await _repo.SaveChangesAsync();
//        }

//        void IRepository.Update<T>(T entity)
//        {
//            _repo.Update(entity);
//        }
//    }
//}

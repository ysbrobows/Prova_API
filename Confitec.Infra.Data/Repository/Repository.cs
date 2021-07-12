using Confitec.Domain.Entities;
using Confitec.Domain.Interfaces;
using Confitec.Service.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confitec.Infra.Data.Repository
{
    public class Repository : IRepository
    {
        private readonly DataContext _context;
        public Repository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }
        public Task<bool> SaveChangesASync()
        {
            throw new System.NotImplementedException();
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
        public async Task<Usuario[]> GetUsers()
        {
            IQueryable<Usuario> query = _context.Usuarios;

            query = query.AsNoTracking()
                         .OrderBy(c => c.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Usuario> GetUser(int id)
        {
            IQueryable<Usuario> query = _context.Usuarios;

            return await query.AsNoTracking()
                .Where(x => x.Id == id)
                        .FirstOrDefaultAsync();
        } 
    }
}

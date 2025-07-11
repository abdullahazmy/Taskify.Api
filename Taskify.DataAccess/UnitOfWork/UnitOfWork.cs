using System.Collections;
using Taskify.DataAccess.Contexts;
using Taskify.DataAccess.IRepository;
using Taskify.DataAccess.IUnitOfWorks;
using Taskify.DataAccess.Models;
using Taskify.DataAccess.Repsitory;

namespace Taskify.DataAccess.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbcontext;

        public IApplicationUserRepository ApplicationUserRepository { get; private set; }

        private Hashtable _repositories;
        public UnitOfWork(ApplicationDbContext dbcontext)
        {
            this._dbcontext = dbcontext;
            _repositories = new Hashtable();
            ApplicationUserRepository = new ApplicationUserRepository(_dbcontext);
        }
        public IRepository<T> Repository<T>() where T : ModelBase
        {
            var type = typeof(T).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repoInstance = new Repository<T>(_dbcontext);
                _repositories.Add(type, repoInstance);
            }

            return (IRepository<T>)_repositories[type];
        }



        public async Task<int> SaveAsync()
        {
            return await _dbcontext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbcontext.Dispose();
        }


    }
}

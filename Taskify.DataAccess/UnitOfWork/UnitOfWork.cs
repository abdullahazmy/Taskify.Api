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

        private Hashtable _repsitories;
        public UnitOfWork(ApplicationDbContext dbcontext)
        {
            this._dbcontext = dbcontext;
            _repsitories = new Hashtable();
            ApplicationUserRepository = new ApplicationUserRepository(_dbcontext);
        }
        public Repository<T> Repository<T>() where T : ModelBase
        {
            var Key = typeof(T).Name;
            if (!_repsitories.ContainsKey(Key))
            {
                var repo = new Repository<T>(_dbcontext);
                _repsitories.Add(Key, repo);
            }
            return _repsitories[Key] as Repository<T>;
        }



        public async Task<int> Complete()
        {
            return await _dbcontext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbcontext.Dispose();
        }


    }
}

using Taskify.DataAccess.IRepository;
using Taskify.DataAccess.Models;


namespace Taskify.DataAccess.IUnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> Repository<T>() where T : ModelBase;

        Task<int> SaveAsync();


        IApplicationUserRepository ApplicationUserRepository { get; }

    }
}

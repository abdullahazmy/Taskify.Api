using Taskify.DataAccess.IRepository;
using Taskify.DataAccess.Models;
using Taskify.DataAccess.Repsitory;


namespace Taskify.DataAccess.IUnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        Repository<T> Repository<T>() where T : ModelBase;

        Task<int> Complete();


        IApplicationUserRepository ApplicationUserRepository { get; }
    }
}

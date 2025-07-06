using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Taskify.DataAccess.Contexts;
using Taskify.DataAccess.IRepository;
using Taskify.DataAccess.IUnitOfWorks;
using Taskify.DataAccess.Repsitory;
using Taskify.DataAccess.UnitOfWorks;

namespace Taskify.DataAccess
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration config)
        {

            //For Entity FrameWork
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("Cs")),
            ServiceLifetime.Scoped);

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IApplicationUserRepository, ApplicationUserRepository>();

            return services;
        }
    }
}

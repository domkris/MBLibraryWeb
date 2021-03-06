using MBLibraryWeb.DB.Repositories;
using MBLibraryWeb.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace MBLibraryWeb.DB.DataAccess
{
    public static class RepositoryServices
    {
        public static void AddRepositoryServices(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork.UnitOfWork>();
        }
    }
}

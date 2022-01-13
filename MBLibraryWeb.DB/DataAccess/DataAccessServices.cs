using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MBLibraryWeb.DB.DataAccess
{
    public static class DataAccessServices
    {
        public static void AddDataAccessServices(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<MBLibraryDbContext>(options =>
              options.UseSqlServer(connectionString));
        }
    }
}

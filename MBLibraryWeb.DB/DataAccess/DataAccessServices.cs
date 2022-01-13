using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

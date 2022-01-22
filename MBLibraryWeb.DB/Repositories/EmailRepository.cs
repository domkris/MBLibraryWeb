using MBLibraryWeb.Domain.Entities;
using MBLibraryWeb.Domain.Interfaces;

namespace MBLibraryWeb.DB.Repositories
{
    public class EmailRepository : GenericRepository<Email>, IEmailRepository
    {
        public EmailRepository(MBLibraryDbContext context) : base(context)
        {
        }
    }
}

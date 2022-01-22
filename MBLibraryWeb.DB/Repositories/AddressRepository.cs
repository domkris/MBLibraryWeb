using MBLibraryWeb.Domain.Entities;
using MBLibraryWeb.Domain.Interfaces;

namespace MBLibraryWeb.DB.Repositories
{
    public class AddressRepository: GenericRepository<Address>, IAddressRepository
    {
        public AddressRepository(MBLibraryDbContext context) : base(context)
        {
        }
    }
}

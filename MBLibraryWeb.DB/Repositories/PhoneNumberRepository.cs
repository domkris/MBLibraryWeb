using MBLibraryWeb.Domain.Entities;
using MBLibraryWeb.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBLibraryWeb.DB.Repositories
{
    public class PhoneNumberRepository : GenericRepository<PhoneNumber>, IPhoneNumberRepository
    {
        public PhoneNumberRepository(MBLibraryDbContext context) : base(context)
        {
        }
    }
}

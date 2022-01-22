using MBLibraryWeb.DB.Repositories;
using MBLibraryWeb.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBLibraryWeb.DB.UnitOfWork
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly MBLibraryDbContext context;
        public UnitOfWork(MBLibraryDbContext context)
        {
            this.context = context;
            Users = new UserRepository(context);
            Books = new BookRepository(context);
            Emails = new EmailRepository(context);
            Addresses = new AddressRepository(context);
            PhoneNumbers = new EmailRepository(context);


        }

        public IUserRepository Users { get; private set; }

        public IBookRepository Books { get; private set; }
        public IEmailRepository Emails { get; private set; }
        public IAddressRepository Addresses { get; private set; }
        public IPhoneNumberRepository PhoneNumbers { get; private set; }


        public int Save()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}

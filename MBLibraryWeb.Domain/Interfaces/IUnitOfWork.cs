using System;

namespace MBLibraryWeb.Domain.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        IUserRepository Users { get; }
        IBookRepository Books { get; }
        IEmailRepository Emails { get; }
        IAddressRepository Addresses { get; }
        IPhoneNumberRepository PhoneNumbers { get; }
        int Save();
    }
}

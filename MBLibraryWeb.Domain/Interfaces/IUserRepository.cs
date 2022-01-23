using MBLibraryWeb.Domain.Entities;
using System.Collections.Generic;

namespace MBLibraryWeb.Domain.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        void AddToUserRentHistory(IEnumerable<UserBookBorrowHistory> entitie);
        void EditUserRentHistory(int id);
        List<UserBookBorrowHistory> GetUserRentHistory(int id);
        List<User> GetUsersByOverDueTime();
        User GetUserDetails(int id);

    }
}
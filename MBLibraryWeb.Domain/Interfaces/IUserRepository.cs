using MBLibraryWeb.Domain.Entities;
using System.Collections.Generic;

namespace MBLibraryWeb.Domain.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        void BorrowBooks(int id, IEnumerable<Book> entities);
        void AddToUserRentHistory(IEnumerable<UserBookBorrowHistory> entitie);
        void ReturnBook(int id);
        List<UserBookBorrowHistory> GetUserRentHistory(int id);
        List<User> GetTopUsersByOverDueTime(int numberOfUsers);
        User GetUserDetails(int id);

    }
}
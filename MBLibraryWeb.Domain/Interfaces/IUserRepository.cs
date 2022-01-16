using MBLibraryWeb.Domain.Models;
using MBLibraryWeb.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBLibraryWeb.Domain.Interfaces
{
    public interface IUserRepository : IGenericRepository<UserUIDetails>
    {
        void BorrowBooks(int id, IEnumerable<BookUI> entities);
        void ReturnBook(int id);
        List<UserBookBorrowHistory> GetUserRentHistory(int id);
        List<UserUI> GetTopUsersByOverDueTime(int numberOfUsers);
        User GetUserDetails(int id);

    }
}
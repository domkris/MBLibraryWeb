using MBLibraryWeb.Domain.Models;
using MBLibraryWeb.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBLibraryWeb.Domain.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        void BorrowBooks(int id, IEnumerable<BookUI> entities);
        void ReturnBooks(int id, IEnumerable<BookUI> entities);
        List<UserBookBorrowHistoryUI> GetUserRentHistory(int id);
        List<UserUI> GetTopUsersByOverDueTime(int numberOfUsers);
        List<UserUI> GetSimpleList();

    }
}
using MBLibraryWeb.Domain.Models;
using MBLibraryWeb.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBLibraryWeb.Domain.Interfaces
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        List<UserBookBorrowHistoryUI> GetBookRentHistory(int id);
        List<BookUI> GetSimpleList();
    }
}

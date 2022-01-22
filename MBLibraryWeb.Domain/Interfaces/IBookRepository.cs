using MBLibraryWeb.Domain.Entities;
using System.Collections.Generic;

namespace MBLibraryWeb.Domain.Interfaces
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        List<UserBookBorrowHistory> GetBookRentHistory(int id);
    }
}

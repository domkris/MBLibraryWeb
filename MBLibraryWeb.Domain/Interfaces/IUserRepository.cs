using MBLibraryWeb.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBLibraryWeb.Domain.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        void BorrowBooks(int id, IEnumerable<Book> entities);
        void ReturnBooks(int id, IEnumerable<Book> entities);

    }
}
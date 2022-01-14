using MBLibraryWeb.Domain.Interfaces;
using MBLibraryWeb.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBLibraryWeb.DB.Repositories
{
    public class UserRepository: GenericRepository<User>, IUserRepository
    {
        public UserRepository(MBLibraryDbContext context): base(context)
        {
        }

        public void BorrowBooks(int userId, IEnumerable<Book> entities)
        {
            List<UserBookBorrowHistory> newBookBorrowHistoryList = new();
            foreach (var book in entities)
            {
                newBookBorrowHistoryList.Add( new UserBookBorrowHistory 
                {
                    UserId = userId,
                    BookId = book.Id,
                    BorrowedAt = DateTime.UtcNow,
                    DueAt = DateTime.UtcNow.AddDays(30)
                });
            }
            context.UsersBooksBorrowHistory.AddRange(newBookBorrowHistoryList);
        }

        public void ReturnBooks(int userId, IEnumerable<Book> entities)
        {
            List<UserBookBorrowHistory> bookBorrowHistoryList;
            List<int> booksToReturnIdsList = entities.Select(_ => _.Id).ToList();

            bookBorrowHistoryList = context.UsersBooksBorrowHistory
                .Where(_ => _.UserId == userId && booksToReturnIdsList.Contains(_.BookId) && _.ReturnedAt == null).ToList();
            
            foreach (var bookBorrowHistory in bookBorrowHistoryList)
            {
                bookBorrowHistory.ReturnedAt = DateTime.UtcNow;
            }
        }
    }
}

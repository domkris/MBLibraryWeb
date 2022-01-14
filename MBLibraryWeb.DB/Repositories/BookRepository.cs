using MBLibraryWeb.Domain.Interfaces;
using MBLibraryWeb.Domain.Models;
using MBLibraryWeb.UI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBLibraryWeb.DB.Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(MBLibraryDbContext context) : base(context)
        {
        }
        public List<UserBookBorrowHistoryUI> GetBookRentHistory(int id)
        {
            List<UserBookBorrowHistoryUI> bookRentHistoryUIList = new();
            var bookRentHistoryDbList = context.UsersBooksBorrowHistory.AsNoTracking()
                .Where(_ => _.BookId == id).Include(_ => _.User)
                .Select(_ => new UserBookBorrowHistory
                {
                    Id = _.Id,
                    UserId = _.UserId,
                    User = _.User,
                    BorrowedAt = _.BorrowedAt,
                    DueAt = _.DueAt,
                    ReturnedAt = _.ReturnedAt
                })
                .ToList();
            
            foreach (var item in bookRentHistoryDbList)
            {
                bookRentHistoryUIList.Add(new UserBookBorrowHistoryUI
                {
                    Id = item.Id,
                    User = new UserUI { FirstName = item.User.FirstName, LastName = item.User.LastName, DOB = item.User.DOB},
                    BorrowedAt = item.BorrowedAt,
                    DueAt = item.DueAt,
                    ReturnedAt = item.ReturnedAt,
                    OverdueTimeInDays = item.GetOverdueTimeInDays
                    
                });
            }

            return bookRentHistoryUIList;
        }

        public List<BookUI> GetSimpleList()
        {
            List<BookUI> booksUI = new();
            var booksDb = context.Books.AsNoTracking().Select(_ => new Book
            {
                Id = _.Id,
                Author = _.Author,
                Title = _.Title,
                Genre = _.Genre

            }).ToList();

            foreach (var item in booksDb)
            {
                booksUI.Add(new BookUI
                {
                    Id = item.Id,
                    Author = item.Author,
                    Title = item.Title,
                    Genre = Enum.GetName(item.Genre)
                });
            }
            return booksUI;
        }
    }
}

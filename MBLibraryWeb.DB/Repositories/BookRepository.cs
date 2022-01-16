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
    public class BookRepository : GenericRepository<Book, BookUIDetails>, IBookRepository
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
                    User = new UserUI { FirstName = item.User.FirstName, LastName = item.User.LastName, DateOfBirth = item.User.DateOfBirth },
                    BorrowedAt = item.BorrowedAt,
                    DueAt = item.DueAt,
                    ReturnedAt = item.ReturnedAt,
                    OverdueTimeInDays = item.GetOverdueTimeInDays
                    
                });
            }

            return bookRentHistoryUIList;
        }
      
        protected override Book ToDbModel(BookUIDetails modelUI)
        {
           
            throw new NotImplementedException();
        }

        protected override IEnumerable<Book> ToDbModelList(IEnumerable<BookUIDetails> modelUIList)
        {
            throw new NotImplementedException();
        }

        protected override BookUIDetails ToUIModel(Book modelDb)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<BookUIDetails> ToUIModelList(IEnumerable<Book> modelDbList)
        {
            List<BookUIDetails> booksUI = new();
            foreach (var item in modelDbList)
            {
                booksUI.Add(new BookUIDetails
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

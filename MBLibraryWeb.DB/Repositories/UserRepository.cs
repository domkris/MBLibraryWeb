using MBLibraryWeb.Domain.Interfaces;
using MBLibraryWeb.Domain.Models;
using MBLibraryWeb.UI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MBLibraryWeb.DB.Repositories
{
    public class UserRepository: GenericRepository<User>, IUserRepository
    {
        public UserRepository(MBLibraryDbContext context): base(context)
        {
        }
        public List<UserBookBorrowHistoryUI> GetUserRentHistory(int id)
        {
            List<UserBookBorrowHistoryUI> bookRentHistoryUIList = new();
            var bookRentHistoryDbList = context.UsersBooksBorrowHistory.AsNoTracking()
                .Where(_ => _.UserId == id)
                .Include(_ => _.Book)
                .Select(_ => new UserBookBorrowHistory
                {
                    Id = _.Id,
                    BookId = _.BookId,
                    Book = _.Book,
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
                    Book = new BookUI { Author = item.Book.Author, Title = item.Book.Title, Genre = Enum.GetName(item.Book.Genre)},
                    BorrowedAt = item.BorrowedAt,
                    DueAt = item.DueAt,
                    ReturnedAt = item.ReturnedAt,
                    OverdueTimeInDays = item.GetOverdueTimeInDays

                });
            }

            return bookRentHistoryUIList;
        }

        public List<UserUI> GetSimpleList()
        {
            List<UserUI> usersUI = new();
            var usersDb = context.Users.AsNoTracking().Select(_ => new User 
            {
               Id = _.Id,
               FirstName = _.FirstName,
               LastName = _.LastName,
               DOB = _.DOB

            }).ToList();

            foreach (var item in usersDb)
            {
                usersUI.Add(new UserUI 
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    DOB = item.DOB
                });
            }
            return usersUI;
        }
        public void BorrowBooks(int userId, IEnumerable<BookUI> entities)
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

        public void ReturnBooks(int userId, IEnumerable<BookUI> entities)
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

        public List<UserUI> GetTopUsersByOverDueTime(int numberOfUsers) 
        {
            List<UserUI> usersUI = new();
            
            var booksBorrowHistoryNotReturned = context.UsersBooksBorrowHistory.AsNoTracking()
                .Where(_ => (_.ReturnedAt != null && _.DueAt < _.ReturnedAt) || (_.ReturnedAt == null && _.DueAt < DateTime.UtcNow))
                .Include(_ => _.User)
                .ToList();

            var usersOverDueGrouped = booksBorrowHistoryNotReturned
                .GroupBy(_ => _.UserId);

            var usersOverDue = usersOverDueGrouped
                .Select(_ => new UserUI
                {
                    Id = _.Key,
                    FirstName = _.Select(_ => _.User.FirstName).FirstOrDefault(),
                    LastName = _.Select(_ => _.User.LastName).FirstOrDefault(),
                    DOB = _.Select(_ => _.User.DOB).FirstOrDefault(),
                    OverDueInDays = (int)Math.Floor(_.Sum(_ => _.GetOverdueTimeInDays))
                }).ToList();

            return usersOverDue;
        }
    }
}

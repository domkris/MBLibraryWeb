using MBLibraryWeb.Domain.Entities;
using MBLibraryWeb.Domain.Interfaces;
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
        public List<UserBookBorrowHistory> GetUserRentHistory(int id)
        {
            List<UserBookBorrowHistory> bookRentHistoryDbList = context.UsersBooksBorrowHistory.AsNoTracking()
                .Where(_ => _.UserId == id)
                .Include(_ => _.Book)
                .Select(_ => new UserBookBorrowHistory
                {
                    Id = _.Id,
                    BookId = _.BookId,
                    Book = new Book
                    {
                        Id = _.Book.Id,
                        Title = _.Book.Title,
                        Author = _.Book.Author
                    },
                    BorrowedAt = _.BorrowedAt,
                    DueAt = _.DueAt,
                    ReturnedAt = _.ReturnedAt
                })
                .OrderBy(_ => _.ReturnedAt)
                .ToList();

            return bookRentHistoryDbList;
        }

        public void AddToUserRentHistory(IEnumerable<UserBookBorrowHistory> userBookBorrowHistoryList) 
        {
            context.UsersBooksBorrowHistory.AddRange(userBookBorrowHistoryList);
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
        
        public void ReturnBook(int userBookBorrowHistoryItemId)
        {
            UserBookBorrowHistory userBookBorrowHistoryItem = context.UsersBooksBorrowHistory.Where(_ => _.Id == userBookBorrowHistoryItemId).FirstOrDefault();
            userBookBorrowHistoryItem.ReturnedAt = DateTime.UtcNow;


        }

        public List<User> GetTopUsersByOverDueTime(int numberOfUsers) 
        {
            var booksBorrowHistoryNotReturned = context.UsersBooksBorrowHistory.AsNoTracking()
                .Where(_ => (_.ReturnedAt != null && _.DueAt < _.ReturnedAt) || (_.ReturnedAt == null && _.DueAt < DateTime.UtcNow))
                .Include(_ => _.User)
                .ToList();

            var usersOverDueGrouped = booksBorrowHistoryNotReturned
                .GroupBy(_ => _.UserId);

            var usersOverDue = usersOverDueGrouped
                .Select(_ => new User
                {
                    Id = _.Key,
                    FirstName = _.Select(_ => _.User.FirstName).FirstOrDefault(),
                    LastName = _.Select(_ => _.User.LastName).FirstOrDefault(),
                    DateOfBirth = _.Select(_ => _.User.DateOfBirth).FirstOrDefault(),
                    OverDueInDays = (int)Math.Floor(_.Sum(_ => _.OverdueTimeInDays))
                }).ToList();

            return usersOverDue;
        }

        public User GetUserDetails(int id)
        {
            User userDb = context.Users.AsNoTracking()
                .Where(_ => _.Id == id)
                .Include(_ => _.Addresses)
                .Include(_ => _.Emails)
                .Include(_ => _.PhoneNumbers)
                .Select(_ => new User 
                {
                    Id = _.Id,
                    FirstName = _.FirstName,
                    LastName = _.LastName,
                    DateOfBirth = _.DateOfBirth,
                    PhoneNumbers = _.PhoneNumbers.Select(_ => new PhoneNumber 
                    {
                        Id = _.Id,
                        Number = _.Number,
                        UserId = _.UserId
                    }).ToList(),
                    Emails = _.Emails.Select(_ => new Email 
                    { 
                        Id = _.Id,
                        EmailAddress = _.EmailAddress,
                        UserId = _.UserId
                    }).ToList(),
                    Addresses = _.Addresses.Select(_ => new Address 
                    {
                        Id = _.Id,
                        Country = _.Country,
                        City = _.City,
                        Street = _.Street,
                        PostalCode = _.PostalCode,
                        UserId = _.UserId
                    }).ToList()
                })
                .FirstOrDefault();
            return userDb;
        }
    }
}

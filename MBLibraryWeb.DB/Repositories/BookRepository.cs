using MBLibraryWeb.Domain.Entities;
using MBLibraryWeb.Domain.Interfaces;
using MBLibraryWeb.UI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MBLibraryWeb.DB.Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(MBLibraryDbContext context) : base(context)
        {
        }
        public List<UserBookBorrowHistory> GetBookRentHistory(int id)
        {
            var bookRentHistoryDbList = context.UsersBooksBorrowHistory.AsNoTracking()
                .Where(_ => _.BookId == id).Include(_ => _.User)
                .Select(_ => new UserBookBorrowHistory
                {
                    Id = _.Id,
                    UserId = _.UserId,
                    User = new User 
                    {
                        Id = _.User.Id,
                        FirstName = _.User.FirstName,
                        LastName = _.User.LastName,
                        DateOfBirth = _.User.DateOfBirth
                    },
                    BorrowedAt = _.BorrowedAt,
                    DueAt = _.DueAt,
                    ReturnedAt = _.ReturnedAt
                })
                .OrderBy(_ => _.ReturnedAt)
                .ToList();
            return bookRentHistoryDbList;
        }   
    }
}

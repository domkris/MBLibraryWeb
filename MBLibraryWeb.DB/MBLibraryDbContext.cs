using MBLibraryWeb.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MBLibraryWeb.DB
{
    public class MBLibraryDbContext: DbContext
    {
        public MBLibraryDbContext(DbContextOptions options): base(options)
        {
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserBookBorrowHistory> UsersBooksBorrowHistory { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.SeedTestBookData();
        }

    }
}

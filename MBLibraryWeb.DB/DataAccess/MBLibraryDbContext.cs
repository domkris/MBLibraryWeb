using MBLibraryWeb.DB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBLibraryWeb.DB.DataAccess
{
    public class MBLibraryDbContext: DbContext
    {
        public MBLibraryDbContext(DbContextOptions options): base(options)
        {
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<User> Users { get; set; }



    }
}

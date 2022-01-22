using MBLibraryWeb.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace MBLibraryWeb.DB
{
    public static class MBLibraryModelBuilderSeeder
    {
        public static void SeedTestBookData(this ModelBuilder modelBuilder) 
        {
            //assign year, month, day, hour, min, seconds
            DateTime createdAt = new (2022, 1, 13, 10, 10, 20);

            string createdBy = "initialSeedTest";
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Genre = Domain.Models.Enumerations.Genre.Adventure, Title = "Treasure Island", Author = "Robert Louis Stevenson", CreatedAt = createdAt, CreatedBy = createdBy },
                new Book { Id = 2, Genre = Domain.Models.Enumerations.Genre.Comedy, Title = "Born Standing Up", Author = "Steve Martin", CreatedAt = createdAt, CreatedBy = createdBy },
                new Book { Id = 3, Genre = Domain.Models.Enumerations.Genre.Fantasy, Title = "Harry Potter and the Philosopher's Stone", Author = "J. K. Rowling", CreatedAt = createdAt, CreatedBy = createdBy },
                new Book { Id = 4, Genre = Domain.Models.Enumerations.Genre.Fantasy, Title = "Harry Potter and the Chamber of Secrets", Author = "J. K. Rowling", CreatedAt = createdAt, CreatedBy = createdBy },
                new Book { Id = 5, Genre = Domain.Models.Enumerations.Genre.Fantasy, Title = "Harry Potter and the Prisoner of Azkaban", Author = "J. K. Rowling", CreatedAt = createdAt, CreatedBy = createdBy },
                new Book { Id = 6, Genre = Domain.Models.Enumerations.Genre.Fantasy, Title = "Harry Potter and the Goblet of Fire", Author = "J. K. Rowling", CreatedAt = createdAt, CreatedBy = createdBy },
                new Book { Id = 7, Genre = Domain.Models.Enumerations.Genre.Fantasy, Title = "Harry Potter and the Order of the Phoenix", Author = "J. K. Rowling", CreatedAt = createdAt, CreatedBy = createdBy },
                new Book { Id = 8, Genre = Domain.Models.Enumerations.Genre.Fantasy, Title = "Harry Potter and the Half-Blood Prince", Author = "J. K. Rowling", CreatedAt = createdAt, CreatedBy = createdBy },
                new Book { Id = 9, Genre = Domain.Models.Enumerations.Genre.Fantasy, Title = "Harry Potter and the Deathly Hallows", Author = "J. K. Rowling", CreatedAt = createdAt, CreatedBy = createdBy },
                new Book { Id = 10, Genre = Domain.Models.Enumerations.Genre.ScienceFiction, Title = "Leviathan Wakes", Author = "James S. A. Corey", CreatedAt = createdAt, CreatedBy = createdBy },
                new Book { Id = 11, Genre = Domain.Models.Enumerations.Genre.ScienceFiction, Title = "Caliban's War", Author = "James S. A. Corey", CreatedAt = createdAt, CreatedBy = createdBy },
                new Book { Id = 12, Genre = Domain.Models.Enumerations.Genre.ScienceFiction, Title = "Abaddon's Gate", Author = "James S. A. Corey", CreatedAt = createdAt, CreatedBy = createdBy },
                new Book { Id = 13, Genre = Domain.Models.Enumerations.Genre.ScienceFiction, Title = "Cibola Burn", Author = "James S. A. Corey", CreatedAt = createdAt, CreatedBy = createdBy },
                new Book { Id = 14, Genre = Domain.Models.Enumerations.Genre.ScienceFiction, Title = "Nemesis Games", Author = "James S. A. Corey", CreatedAt = createdAt, CreatedBy = createdBy },
                new Book { Id = 15, Genre = Domain.Models.Enumerations.Genre.ScienceFiction, Title = "Babylon's Ashes", Author = "James S. A. Corey", CreatedAt = createdAt, CreatedBy = createdBy },
                new Book { Id = 16, Genre = Domain.Models.Enumerations.Genre.ScienceFiction, Title = "Persepolis Rising", Author = "James S. A. Corey", CreatedAt = createdAt, CreatedBy = createdBy },
                new Book { Id = 17, Genre = Domain.Models.Enumerations.Genre.ScienceFiction, Title = "Tiamat's Wrath", Author = "James S. A. Corey", CreatedAt = createdAt, CreatedBy = createdBy },
                new Book { Id = 18, Genre = Domain.Models.Enumerations.Genre.ScienceFiction, Title = "Leviathan Falls", Author = "James S. A. Corey", CreatedAt = createdAt, CreatedBy = createdBy }
                );
        }
    }
}

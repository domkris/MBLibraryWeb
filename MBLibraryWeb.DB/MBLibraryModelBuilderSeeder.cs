using MBLibraryWeb.DB.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace MBLibraryWeb.DB
{
    public static class MBLibraryModelBuilderSeeder
    {
        public static void SeedTestBookData(this ModelBuilder modelBuilder) 
        {
            string createdBy = "initialSeedTest";
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Genre = Models.Enumerations.Genre.Adventure, Title = "Treasure Island", Author = "Robert Louis Stevenson", CreatedAt = DateTime.Now, CreatedBy = createdBy },
                new Book { Id = 2, Genre = Models.Enumerations.Genre.Comedy, Title = "Born Standing Up", Author = "Steve Martin", CreatedAt = DateTime.Now, CreatedBy = createdBy },
                new Book { Id = 3, Genre = Models.Enumerations.Genre.Fantasy, Title = "Harry Potter and the Philosopher's Stone", Author = "J. K. Rowling", CreatedAt = DateTime.Now, CreatedBy = createdBy },
                new Book { Id = 4, Genre = Models.Enumerations.Genre.Fantasy, Title = "Harry Potter and the Chamber of Secrets", Author = "J. K. Rowling", CreatedAt = DateTime.Now, CreatedBy = createdBy },
                new Book { Id = 5, Genre = Models.Enumerations.Genre.Fantasy, Title = "Harry Potter and the Prisoner of Azkaban", Author = "J. K. Rowling", CreatedAt = DateTime.Now, CreatedBy = createdBy },
                new Book { Id = 6, Genre = Models.Enumerations.Genre.Fantasy, Title = "Harry Potter and the Goblet of Fire", Author = "J. K. Rowling", CreatedAt = DateTime.Now, CreatedBy = createdBy },
                new Book { Id = 7, Genre = Models.Enumerations.Genre.Fantasy, Title = "Harry Potter and the Order of the Phoenix", Author = "J. K. Rowling", CreatedAt = DateTime.Now, CreatedBy = createdBy },
                new Book { Id = 8, Genre = Models.Enumerations.Genre.Fantasy, Title = "Harry Potter and the Half-Blood Prince", Author = "J. K. Rowling", CreatedAt = DateTime.Now, CreatedBy = createdBy },
                new Book { Id = 9, Genre = Models.Enumerations.Genre.Fantasy, Title = "Harry Potter and the Deathly Hallows", Author = "J. K. Rowling", CreatedAt = DateTime.Now, CreatedBy = createdBy },
                new Book { Id = 10, Genre = Models.Enumerations.Genre.ScienceFiction, Title = "Leviathan Wakes", Author = "James S. A. Corey", CreatedAt = DateTime.Now, CreatedBy = createdBy },
                new Book { Id = 11, Genre = Models.Enumerations.Genre.ScienceFiction, Title = "Caliban's War", Author = "James S. A. Corey", CreatedAt = DateTime.Now, CreatedBy = createdBy },
                new Book { Id = 12, Genre = Models.Enumerations.Genre.ScienceFiction, Title = "Abaddon's Gate", Author = "James S. A. Corey", CreatedAt = DateTime.Now, CreatedBy = createdBy },
                new Book { Id = 13, Genre = Models.Enumerations.Genre.ScienceFiction, Title = "Cibola Burn", Author = "James S. A. Corey", CreatedAt = DateTime.Now, CreatedBy = createdBy },
                new Book { Id = 14, Genre = Models.Enumerations.Genre.ScienceFiction, Title = "Nemesis Games", Author = "James S. A. Corey", CreatedAt = DateTime.Now, CreatedBy = createdBy },
                new Book { Id = 15, Genre = Models.Enumerations.Genre.ScienceFiction, Title = "Babylon's Ashes", Author = "James S. A. Corey", CreatedAt = DateTime.Now, CreatedBy = createdBy },
                new Book { Id = 16, Genre = Models.Enumerations.Genre.ScienceFiction, Title = "Persepolis Rising", Author = "James S. A. Corey", CreatedAt = DateTime.Now, CreatedBy = createdBy },
                new Book { Id = 17, Genre = Models.Enumerations.Genre.ScienceFiction, Title = "Tiamat's Wrath", Author = "James S. A. Corey", CreatedAt = DateTime.Now, CreatedBy = createdBy },
                new Book { Id = 18, Genre = Models.Enumerations.Genre.ScienceFiction, Title = "Leviathan Falls", Author = "James S. A. Corey", CreatedAt = DateTime.Now, CreatedBy = createdBy }
                );
        }
    }
}

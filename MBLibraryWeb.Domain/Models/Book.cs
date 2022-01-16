using MBLibraryWeb.Domain.Models.Base;
using MBLibraryWeb.Domain.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBLibraryWeb.Domain.Models
{
    public class Book: BaseOb
    {
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        public Genre Genre { get; set; }
        [Required]
        [MaxLength(200)]
        public string Author { get; set; }
        public List<UserBookBorrowHistory> UserBookBorrowHistoryList { get; set; } = new();

        [NotMapped]
        public string GetGenreString
        {
            get
            {
                return Enum.GetName(Genre);
            }
        }
    }
}

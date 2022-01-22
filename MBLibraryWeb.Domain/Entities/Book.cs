using MBLibraryWeb.Domain.Entities.Base;
using MBLibraryWeb.Domain.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBLibraryWeb.Domain.Entities
{
    public class Book: BaseOb
    {
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        [Required]
        public Genre Genre { get; set; }

        [Required]
        [MaxLength(200)]
        public string Author { get; set; }
        public List<UserBookBorrowHistory> UserBookBorrowHistoryList { get; set; } = new();

        [NotMapped]
        public string GenreName
        {
            get
            {
                return Enum.GetName(Genre);
            }
        }
    }
}

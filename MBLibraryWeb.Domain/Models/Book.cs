using MBLibraryWeb.Domain.Models.Base;
using MBLibraryWeb.Domain.Models.Enumerations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        public List<UserBookBorrowHistory> UserBookBorrowHistoryList { get; set; }
    }
}

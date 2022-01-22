using MBLibraryWeb.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBLibraryWeb.Domain.Entities
{
    public class User : BaseOb
    {
        [Required]
        [MaxLength(200)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(200)]
        public string LastName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        public List<Address> Addresses { get; set; } = new();
        public List<Email> Emails { get; set; } = new();
        public List<PhoneNumber> PhoneNumbers { get; set; } = new();
        public List<UserBookBorrowHistory> UserBookBorrowHistoryList { get; set; } = new();

        [NotMapped]
        public int OverDueInDays { get; set; }
    }
}

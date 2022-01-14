using MBLibraryWeb.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MBLibraryWeb.Domain.Models
{
    public class User: BaseOb
    {
        [Required]
        [MaxLength(200)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(200)]
        public string LastName { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        public List<Address> Addresses { get; set; } = new();
        public List<Email> Emails { get; set; } = new();
        public List<PhoneNumber> PhoneNumbers { get; set; } = new();
        public List<UserBookBorrowHistory> UserBookBorrowHistoryList { get; set; } = new();
    }
}

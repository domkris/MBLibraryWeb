using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBLibraryWeb.UI.Models
{
    public class UserUIDetails: UserUI
    {
        public List<AddressUI> Addresses { get; set; } 
        public List<EmailUI> Emails { get; set; } 
        public List<PhoneNumberUI> PhoneNumbers { get; set; }
        public List<UserBookBorrowHistoryUI> UserBookBorrowHistoryList { get; set; }
    }
}


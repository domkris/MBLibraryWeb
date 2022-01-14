using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBLibraryWeb.UI.Models
{
    public class BookUIDetails: BookUI
    {
        public List<UserBookBorrowHistoryUI> UserBookBorrowHistoryList { get; set; } = new();
    }
}

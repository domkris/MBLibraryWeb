using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBLibraryWeb.UI.Models
{
    public class UserBookBorrowHistoryUI
    {
        public int Id { get; set; }
        public BookUI Book { get; set; }
        public UserUI User { get; set; }

        public DateTime BorrowedAt { get; set; }
        public DateTime DueAt { get; set; }
        public DateTime? ReturnedAt { get; set; }
        public double OverdueTimeInDays { get; set; }
    }
}

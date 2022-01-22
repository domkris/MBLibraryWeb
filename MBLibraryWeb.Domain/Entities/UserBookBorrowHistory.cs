using MBLibraryWeb.Domain.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBLibraryWeb.Domain.Entities
{
    public class UserBookBorrowHistory : BaseOb
    {
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public DateTime BorrowedAt { get; set; }
        public DateTime DueAt { get; set; }
        public DateTime? ReturnedAt { get; set; }

        [NotMapped]
        public double OverdueTimeInDays
        {
            get
            {
                if (ReturnedAt != null)
                {
                    if (DueAt.CompareTo(ReturnedAt) < 0)
                    {
                        TimeSpan ts = (TimeSpan)(ReturnedAt - DueAt);
                        return Math.Floor(ts.TotalDays);
                    }
                }
                else 
                {
                    if (DueAt.CompareTo(DateTime.Now) < 0)
                    {
                        TimeSpan ts = DateTime.UtcNow.ToUniversalTime() - DueAt;
                        return Math.Floor(ts.TotalDays);
                    }
                }
                return 0;
            }
        }
    }
}

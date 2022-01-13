using MBLibraryWeb.Domain.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace MBLibraryWeb.Domain.Models
{
    public class PhoneNumber: BaseOb
    {
        [Required]
        [MaxLength(100)]
        public string Number { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}

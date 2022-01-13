using MBLibraryWeb.DB.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace MBLibraryWeb.DB.Models
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

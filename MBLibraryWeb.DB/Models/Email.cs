using MBLibraryWeb.DB.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace MBLibraryWeb.DB.Models
{
    public class Email: BaseOb
    {
        [Required]
        [MaxLength(200)]
        public string EmailAddress { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}

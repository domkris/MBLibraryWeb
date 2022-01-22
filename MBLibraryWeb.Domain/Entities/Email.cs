using MBLibraryWeb.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace MBLibraryWeb.Domain.Entities
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

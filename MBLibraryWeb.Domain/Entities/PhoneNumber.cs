using MBLibraryWeb.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace MBLibraryWeb.Domain.Entities
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

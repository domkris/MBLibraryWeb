using MBLibraryWeb.DB.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBLibraryWeb.DB.Models
{
    public class Address: BaseOb
    {
        [Required]
        [MaxLength(200)]
        public string Country { get; set; }
        
        [Required]
        [MaxLength(200)]
        public string City { get; set; }
        
        [Required]
        [MaxLength(200)]
        public string Street { get; set; }
        
        [Required]
        [MaxLength(50)]
        [Column(TypeName ="varchar(50)")]
        public string PostalCode { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}

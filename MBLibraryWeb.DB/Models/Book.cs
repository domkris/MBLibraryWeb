using MBLibraryWeb.DB.Models.Base;
using MBLibraryWeb.DB.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBLibraryWeb.DB.Models
{
    public class Book: BaseOb
    {
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        public Genre Genre { get; set; }
        [Required]
        [MaxLength(200)]
        public string Author { get; set; }
    }
}

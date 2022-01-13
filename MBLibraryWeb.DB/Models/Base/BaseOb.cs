using System;
using System.ComponentModel.DataAnnotations;

namespace MBLibraryWeb.DB.Models.Base
{
    public class BaseOb
    {
        public int Id { get; set; }       
        public DateTime? CreatedAt { get; set; }     
        public DateTime? UpdatedAt { get; set; }

        [MaxLength(100)]
        public string CreatedBy { get; set; }

        [MaxLength(100)]
        public string UpdatedBy { get; set; }
    }
}

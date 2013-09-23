using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Domain.Model
{
    public class SiteImages
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int SiteId { get; set; }
        public string ImageName { get; set; }
        public string FolderName { get; set; }
    }
}

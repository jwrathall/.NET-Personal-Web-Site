using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Domain.Model
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int SiteId { get; set; }
        public string Title { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Domain.Model
{
    public class TopicHighlight
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int TopicId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
    }
}

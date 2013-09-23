using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Domain.Model
{
    public class Topic
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int SubjectId { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public virtual ICollection<TopicHighlight> TopicHighlights { get; set; } 

    }
}

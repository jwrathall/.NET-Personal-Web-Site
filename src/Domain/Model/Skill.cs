using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Domain.Model
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string SkillName { get; set; }
        public string SkillAbbreviation { get; set; }
        public virtual ICollection<Site> Sites { get; set; }
    }
}

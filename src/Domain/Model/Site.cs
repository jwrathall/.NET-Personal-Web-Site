using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Domain.Model
{
    public class Site
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Client { get; set; }
        public string Thumbnail { get; set; }
        public string Url { get; set; }
        public string Summary { get; set; }
        public string Detail { get; set; }
        public string Orderby { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<SiteImages> Images { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }

        public string VanityUrl()
        {
            return
                string.Format("{0} {1}", Client, Title);
        }

        //http://mytechworld.officeacuity.com/index.php/2010/02/serializing-entity-framework-objects-into-json-using-asp-net-mvc/

    }
}

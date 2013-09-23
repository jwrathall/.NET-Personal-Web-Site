using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Domain.Model
{
    public class ContactInfo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Firstname is required")]
        public string Firstname { get; set; }
        [Required(ErrorMessage = "Lastname is required")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email address is invalid")]
        public string Email { get; set; }

        public string Message { get; set; }

        public string Subject
        {
            get { return "Inquiry from jeffwrathall.com"; }
        }

        public string FullName
        {
            get
            {
                var sb = new StringBuilder(string.Format("{0} {1}",this.Firstname,this.Lastname));
                return sb.ToString();
            }

        }

        public string Response
        {
            get { return "Thanks for your inquiry. I'll get back to you as soon as I can"; }
        }

        public DateTime CreateDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain.Data.Respositories;
using Domain.Model;

namespace Web.ViewModels
{
    public class SiteViewModel
    {
       
    }

    public class FooterViewModel
    {
        private readonly ISocialRepository _social;
        public FooterViewModel(ISocialRepository socialRepository)
        {
            _social = socialRepository;
        }

        public ICollection<Social> socialLinks
        {
            get { return _social.GetSocialLinks().ToList(); }
        }
    }
}
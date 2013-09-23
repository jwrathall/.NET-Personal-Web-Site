using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Data.EF5.Repositories;
using Domain.Data.Respositories;
using Domain.Model;

namespace Web.ViewModels
{
    public class PastSites
    {
        private readonly IPastWorkRepository _pastWork;
        public ICollection<Site> Sites { get; set; }
        public PastSites(IPastWorkRepository pastWork)
        {
            _pastWork = pastWork;
            Sites = _pastWork.GetAllSites().ToList();
        }
    }

    public class PastSiteDetail
    {
        private readonly IPastWorkRepository _pastWork;
        public Object site { get; set; }
        public PastSiteDetail(IPastWorkRepository pastWork, string id)
        {
            _pastWork = pastWork;
            var pastSite = pastWork.GetSiteById(Convert.ToInt32(id));
            var obj = pastSite.Select(p => new
                                        {
                                            id = p.Id,
                                            title = p.Title,
                                            client = p.Client,
                                            summary = p.Summary,
                                            url = p.Url,
                                            skills = p.Skills
                                            .Select(s => new
                                                         {
                                                             title = s.SkillName
                                                         }),
                                            roles = p.Roles.OrderBy(o=>o.Title)
                                            .Select(r => new
                                                         {
                                                             title = r.Title
                                                         }),
                                            images = p.Images
                                            .Select(i => new
                                                         {
                                                             image = i.ImageName
                                                         })

                                        }).Single();
            site = obj;
        }
    }
}
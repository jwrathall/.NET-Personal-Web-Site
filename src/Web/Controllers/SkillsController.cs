using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data.EF5.Repositories;
using Domain.Data.Respositories;
using Domain.Model;
using Domain.Services;
using Web.ViewModels;

namespace Web.Controllers
{
    public class SkillsController : Controller
    {
        private readonly ITopicRepository _topicRepository;
        private readonly IContactInfoRespository _contactInfoRespository;
        public SkillsController()
        {
            _contactInfoRespository = new ContactInfoRepository();
            _topicRepository = new TopicRepository();
        }

        public ActionResult FrontEnd()
        {
            return View(new TopicViewModel(_topicRepository, "5"));
        }

        public ActionResult WebApplications(string id)
        {
            return View(new TopicViewModel(_topicRepository, "6"));
        }

        //[HttpGet]
        //public ActionResult About()
        //{
        //    var model = new ContactViewModel
        //                    {
        //                        UserRequest = new ContactInfo()
        //                    };
        //    return View(model); 
        //}

        //[HttpPost]
        //public ActionResult About(ContactInfo model, FormCollection form)
        //{
        //    if (ModelState.IsValid && model != null)
        //    {
        //        _contactInfoRespository.Add(model);
        //        _contactInfoRespository.SaveChanges();
        //        return PartialView("Partial/UserContact");
        //    }
        //    return View(new ContactViewModel{UserRequest = model});
        //}
    }
}

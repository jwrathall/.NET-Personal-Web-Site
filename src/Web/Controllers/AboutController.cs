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
    public class AboutController : Controller
    {
        private readonly IContactInfoRespository _contactInfoRespository;
        public AboutController()
        {
            _contactInfoRespository = new ContactInfoRepository();
        }
        [HttpGet]
        public ActionResult Index()
        {
            var model = new ContactViewModel
            {
                UserRequest = new ContactInfo()
            };
            return View(model); 
        }
        [HttpPost]
        public ActionResult Index(ContactInfo model, FormCollection form)
        {
            if (ModelState.IsValid && model != null)
            {
                model.CreateDate = DateTime.Now;
                _contactInfoRespository.Add(model);
                _contactInfoRespository.SaveChanges();
                var emailService = new NotificationService();
               if(! emailService.Send(new Notification{contactInfo = model}))
               {
                   //log some error 
               }
                return PartialView("Partial/UserContact");
            }
            return View(new ContactViewModel { UserRequest = model });
        }

    }
}

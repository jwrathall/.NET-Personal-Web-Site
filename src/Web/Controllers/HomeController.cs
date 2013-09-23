using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data.EF5.Repositories;
using Domain.Data.Respositories;
using Domain.Model;
using Web.ViewModels;


namespace Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        private readonly ISubjectRepository _subject;
        public HomeController()
        {
            _subject = new SubjectRepository();
        }

        public ActionResult Index()
        {
            
            return View(new HomeViewModel(_subject));
        }
    }
}

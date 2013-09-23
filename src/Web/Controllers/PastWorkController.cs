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
    public class PastWorkController : Controller
    {
        //
        // GET: /PastWork/
        private readonly IPastWorkRepository _pastWorkRepository;
        public PastWorkController()
        {
            _pastWorkRepository = new PastWorkRepository();
        }

        public ActionResult Index()
        {
            return View(new PastSites(_pastWorkRepository));
        }
        [HttpPost]
        public JsonResult Index(string id)
        {
            return Json(new PastSiteDetail(_pastWorkRepository, id));
        }
    }
}

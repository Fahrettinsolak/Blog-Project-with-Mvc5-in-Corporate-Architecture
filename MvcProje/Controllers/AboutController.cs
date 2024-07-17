﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace MvcProje.Controllers
{
    [AllowAnonymous]
    public class AboutController : Controller
    {
        // GET: About
        AboutManager abm = new AboutManager(new EfAboutDal());

        public ActionResult Index()
        {
            var aboutcontent = abm.GetList();
            return View(aboutcontent);
        }
        public PartialViewResult Footer()
        {
            var aboutcontentlist = abm.GetList();
            return PartialView(aboutcontentlist);
        }
        public PartialViewResult MeetTheTeam()
        {
            AuthorManager autman = new AuthorManager(new EfAuthorDal());
            var authorlist = autman.GetList();
            return PartialView(authorlist);
        }
        [HttpGet]
        public ActionResult UpdateAboutList()
        {
            var aboutlist = abm.GetList();
            return View(aboutlist);
        }
        [HttpPost]
        public ActionResult UpdateAbout(About p)
        {
            abm.TUpdate(p);
            return RedirectToAction("UpdateAboutList");
        }
    }
}
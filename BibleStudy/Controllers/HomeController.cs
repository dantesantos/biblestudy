using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BibleStudy.Models;

namespace BibleStudy.Controllers
{
    public class HomeController : Controller
    {
        DbBible db = new DbBible();
        public ActionResult Index()
        {
            List<object> myModel = new List<object>();
            myModel.Add(db.ChapterQties.ToList());
            myModel.Add(db.VerseContents.ToList());
            return View(myModel);
        }

        //public ActionResult Authors()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        public ActionResult Study()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
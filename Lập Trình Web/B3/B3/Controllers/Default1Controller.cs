using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using B3.Models;
namespace B3.Controllers
{
    public class Default1Controller : Controller
    {
        //
        // GET: /Default1/
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Information info)
        {
            Session["info"] = new Information
            {
                FullName = info.FullName,
                IdStudent = info.IdStudent,
                FileImage = info.FileImage,
                Note = info.Note,
                Check1 = info.Check1,
                Check2 = info.Check2,
                Check3 = info.Check3,
                ChooseWorkTime = info.ChooseWorkTime,
                SelectCourse = info.SelectCourse
            };
            return RedirectToAction("MHXacNhan", "Default1");

        }
        public ActionResult MHXacNhan()
        {
            return View();
        }

	}
}
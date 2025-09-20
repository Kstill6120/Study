using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using B3.Models;
namespace B3.Controllers
{
    public class SachController : Controller
    {
        //
        // GET: /Sach/
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Sach sx)
        {
            if (ModelState.IsValid)
            {
                Session["sx"] = new Sach
                {
                    MaSach=sx.MaSach,
                    TenSach=sx.TenSach,
                    GiaSach=sx.GiaSach
                };
                return RedirectToAction("ViewSach", "Sach");
            }
            else
                return View();
        }
	}
}
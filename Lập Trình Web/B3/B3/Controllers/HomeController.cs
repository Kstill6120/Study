using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using B3.Models;
namespace B3.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Search()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Search(string productName)
        {
            Session["sp"] = productName;
            return RedirectToAction("SearchB","Home");
        }
        //[HttpPost]
        //public ActionResult SearchA(string productName)
        //{
        //    ViewBag.Message = "Ten sp: " + productName;
        //    return View();
        //}
        public ActionResult SearchB()
        {
            return View();
        }
        //
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginA(FormCollection fc)
        {
            string name = fc["Username"];
            string pass = fc["Pass"];
            ViewBag.Message = "tai khoan: " + name + " pass: " + pass;
            return View();
        }
        public ActionResult Add(){
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Productmodels p){
            ViewBag.Message = "Ten: " + p.Name + "Gia: " + p.Tien;
            return View();
        }
	}
}
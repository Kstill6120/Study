using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using B3.Models;
namespace B3.Controllers
{
    public class DangNhapController : Controller
    {
        //
        // GET: /DangNhap/
        public ActionResult Index()
        {
            return View();
        }

        // POST: DangNhap
        [HttpPost]
        public ActionResult Index(User model)
        {
            if (ModelState.IsValid)
            {
                // Giả sử login thành công khi Username = "admin" và Password = "123456"
                if (model.FullName == "admin" && model.Password == "123456")
                {
                    ViewBag.Message = "Đăng nhập thành công!";
                    return RedirectToAction("Welcome","DangNhap");
                }
                else
                {
                    ModelState.AddModelError("", "Sai tài khoản hoặc mật khẩu");
                }
            }

            return View(model);
        }

        public ActionResult Welcome()
        {
            return Content("Chào mừng bạn đã đăng nhập thành công!");
        }
    }
	}

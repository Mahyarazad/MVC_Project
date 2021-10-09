using System;
using Microsoft.AspNetCore.Mvc;
using MVC_Project.Models;
using System.Diagnostics;

namespace MVC_Project.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Contact()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Contact(Contact form)
        {
            Console.Write(form.ToString());
            return Json(Ok());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace MVC_Project.Controllers
{
    public class TestController : Controller
    {
        public FileResult DownloadFile()
        {
            var fileByte = System.IO.File.ReadAllBytes("wwwroot/images/me.jpeg");
            const string fileName = "hossein.jpg";
            return File(fileByte, MediaTypeNames.Image.Jpeg, fileName);
        }
        public IActionResult Customized()
        {
            return Content("alert(\'Something New!\')", contentType: "application/javascript");
        }
    }
}

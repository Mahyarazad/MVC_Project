using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Project.Models;

namespace MVC_Project.ViewComponent
{
    public class ArticleViewComponent : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(1, "Snapp Taxi", "Public transportation service", "project-1.jpg"),
                new Article(2, "Snapp Taxi", "Public transportation service", "project-2.jpg"),
                new Article(3, "Snapp Taxi", "Public transportation service", "project-3.jpg"),
                new Article(4, "Snapp Taxi", "Public transportation service", "project-4.jpg"),
            };
            return View("_Article", articles);
        }

    }
}

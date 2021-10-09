using System.Collections.Generic;
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
                new Article(1, "Snapp Taxi", "Public transportation service", "blog-post-thumb-1.jpg"),
                new Article(2, "Snapp Taxi", "Public transportation service", "blog-post-thumb-2.jpg"),
                new Article(3, "Snapp Taxi", "Public transportation service", "blog-post-thumb-3.jpg"),
                new Article(4, "New Article", "Article Number 4", "blog-post-thumb-4.jpg"),
            };
            return View("_Article", articles);
        }

    }
}
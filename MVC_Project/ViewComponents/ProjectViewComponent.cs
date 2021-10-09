using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MVC_Project.Models;

namespace MVC_Project.ViewComponent
{
    public class ProjectViewComponent : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project(1, "Snapp Taxi", "Public transportation service", "project-1.jpg"),
                new Project(2, "Snapp Taxi", "Public transportation service", "project-2.jpg"),
                new Project(3, "Snapp Taxi", "Public transportation service", "project-3.jpg"),
                new Project(4, "Snapp Taxi", "Public transportation service", "project-4.jpg"),
            };
            return View("_Project", projects);
        }

    }
}

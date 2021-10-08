﻿using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MVC_Project.Models
{

    public class Article
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }

        public Article(long id, string title, string description, string imageName)
        {
            Id = id;
            Title = title;
            Description = description;
            ImageName = imageName;
        }
    }
}
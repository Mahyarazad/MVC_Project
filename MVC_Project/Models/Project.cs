

namespace MVC_Project.Models
{
    public class Project
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }

        public Project(long id, string title, string description, string imageName)
        {
            Id = id;
            Title = title;
            Description = description;
            ImageName = imageName;

        }
    }
}

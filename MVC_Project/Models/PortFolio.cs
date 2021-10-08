using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MVC_Project.Models
{
    public class PortFolio
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
    }
}

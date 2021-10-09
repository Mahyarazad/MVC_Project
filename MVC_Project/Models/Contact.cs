using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Project.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "وارد کردن نام الزامی میباشد")]
        [MinLength(2)]
        [MaxLength(10)]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "وارد کردن ایمیل الزامی میباشد")]
        [Required(ErrorMessage = "این قسمت اجباری است")]
        public string Email { get; set; }
        public string Message { get; set; }
        public string Services { get; set; }
    }
}


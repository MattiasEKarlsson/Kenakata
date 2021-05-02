using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kenakata.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Field is required")]
        public string LoginName { get; set; }
       
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

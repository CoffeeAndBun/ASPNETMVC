using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoApp.Models
{
    public class UserRegisterModel
    {
        [DisplayName("User Name")]
        [Required(ErrorMessage = "Name cannot be blank")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Password cannot be blank")]
        [StringLength(6, ErrorMessage = "Password should be equal or less than 6 character")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Email cannot be blank")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email is not Valid")]
        public string Email { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace InventorySystemExample.ViewModels
{
    public class LoginViewModels
    {
        [Required(ErrorMessage = "EmployeeId can't be blank")]
        public string EmployeeId { get; set; }

        [Required(ErrorMessage = "Password can't be blank")]
        public string Password { get; set; }
    }
}
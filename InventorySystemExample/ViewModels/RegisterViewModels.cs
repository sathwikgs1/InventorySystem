using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace InventorySystemExample.ViewModels
{
    public class RegisterViewModels
    {
        [Required(ErrorMessage = "EmployeeId can't be blank")]
        public string EmployeeId { get; set; }

        [Required(ErrorMessage = "Password can't be blank")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password can't be blank")]
        [Compare("Password", ErrorMessage = "Password and confirm password do not match")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Email can't be blank")]
        [EmailAddress(ErrorMessage = "Invalid email")]
        public string Email { get; set; }

        public string Mobile { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Country { get; set; }
    }
}
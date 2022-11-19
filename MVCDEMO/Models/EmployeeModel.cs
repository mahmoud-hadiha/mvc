using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCDEMO.Models
{
    public class EmployeeModel
    {
        [Display(Name = "Employee Id")]
        [Range(100000, 999999, ErrorMessage = "You need to enter a valid employee id.")]
        public int EmployeeId { get; set; }


        [Display(Name = "first Name ")]
        [Required(ErrorMessage = "You need to give  us  your first name.")]
        public string Firstname { get; set; }



        [Display(Name = "Last Name ")]
        [Required(ErrorMessage = "You need to give  us  your lastname.")]
        public string Lastname { get; set; }


        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "You need to give  us  your email address.")]
        public string Emailaddress { get; set; }


        [Display(Name = "confirm Email")]
        [Compare("Emailaddress", ErrorMessage = "The  email and confirm email must match.")]
        public string ConfirmEmail { get; set; }


        [Display(Name = "Password")]
        [Required(ErrorMessage = "You must have a password.")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "You need to provide a long enough password.")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Compare("password", ErrorMessage = "Your password and confirm password do not match.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }


    }
}
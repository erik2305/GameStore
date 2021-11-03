//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GameStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class UserRegistration
    {
        public int UserID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First name is required",AllowEmptyStrings = false)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last name is required")]
        public string LastName { get; set; }

        [Display(Name = "Contact")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Phone number required")]
        [DataType(DataType.PhoneNumber)]
        public string Contact { get; set; }

        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Display(Name = "Address")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage ="Please provide username",AllowEmptyStrings =false)]
        public string UserName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Minimum 6 characters are required, please try again")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "password does not march, please try again")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string confirmPassword { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please select your Email address")]
        public string Email { get; set; }
    }
}

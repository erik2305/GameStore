using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GameStore.Models
{
   
    [MetadataType(typeof(SignupMetadata))]
    public partial class Signup
    {
        public string ComfirmPassword { get; set; }
    }
    public class SignupMetadata
    {
        [Display(Name = "First Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "First name is required")]
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

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Minimum 6 characters are required, please try again")]
        public string Password { get; set; }

        [Display(Name = "confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "password does not march, please try again")]

        public string ComfirmPassword { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please select your Email address")]
        public string Email { get; set; }
        





    

    }

}
namespace GameStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public static class MetaPerson
    {
        public static int Id { get; set; }
        public static string Surname { get; set; }
        [DisplayName("First Name")]
        public static string GivenName { get; set; }
        public static string Street; 
        public static string City { get; set; }
        public static string ProvinceCode { get; set; }
        public static string CountryCode { get; set; }
        public static string PostalCode { get; set; }
        public static string LandLine { get; set; }
        public static string Extension { get; set; }
        public static string Mobile { get; set; }
        public static string Fax { get; set; }
        [Required(ErrorMessage = "Input Email", AllowEmptyStrings = false)]
        public static string Email { get; set; }
        [Required(ErrorMessage = "Input User name", AllowEmptyStrings = false)]
        [DisplayName("User Name")]
        public static string UserName { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Input Password", AllowEmptyStrings = false)]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "Password must be at least 8 characters long")]
        public static string Password { get; set; }
        [Compare("Password", ErrorMessage = "Passwords doesn't match")]
        [DataType(DataType.Password)]
        [DisplayName("Confirm Password")]
        public static string ConfirmPassword { get; set; }
        public static string LoginErrorMessage { get; set; }

        //public virtual Country Country { get; set; }
        //public static virtual Employee Employee { get; set; }
        //public static virtual Province Province { get; set; }
    }
}